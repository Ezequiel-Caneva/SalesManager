﻿using App.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class UsuarioRepositorio
    {
        private readonly Context _context;
       
        public UsuarioRepositorio(Context context)
        {
            _context = context;      
        }

        // Inicio de registro
        public void CrearUsuario(int dni, string username, string password, string email, int rol)
        {
            // Genera un salt único para el usuario
            byte[] salt = GenerateSalt();

            // Calcula el hash de la contraseña con el salt
            byte[] passwordHash = GeneratePasswordHash(password, salt);

            string passwordHashString = BitConverter.ToString(passwordHash).Replace("-", "");
            string saltString = BitConverter.ToString(salt).Replace("-", "");
            // Crea una nueva instancia de la entidad Usuario y asigna los valores
            var newUser = new Usuario
            {
                dni = dni,
                usuario = username,
                contraseniahash = passwordHashString,
                contraseniasalt = saltString,
                email = email,
                rol = rol
            };
            // Agrega el nuevo usuario al contexto y guarda los cambios en la base de datos
            _context.Usuario.Add(newUser);
            _context.SaveChanges();
        }
        public byte[] GenerateSalt()
        {
            byte[] salt = new byte[32]; // Tamaño del salt (ajusta según tus necesidades)
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        public byte[] GeneratePasswordHash(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32); // Tamaño del hash (ajusta según tus necesidades)
            }
        }
        // Fin de registro


        //Inicio de logeo 
        private Usuario? ObtenerUsuario(string usuario)
        {
            return _context.Usuario.FirstOrDefault(u => u.usuario.ToLower().Equals(usuario.ToLower()));
        }
        public Usuario LogeoUsuario(LoginRequest loginRequest)
        {
            var passwordHasher = new PasswordHasher<Usuario>();
            var usuario = ObtenerUsuario(loginRequest.usuario);
            if (usuario != null)
            {
                byte[] salt = HexToByteArray(usuario.contraseniasalt); // Obtener el salto del usuario a logear
                var passwordHash = GeneratePasswordHash(loginRequest.contrasenia, salt);
                string passwordHashString = BitConverter.ToString(passwordHash).Replace("-", "");

                var result = passwordHasher.VerifyHashedPassword(usuario, usuario.contraseniahash, loginRequest.contrasenia);
                if (passwordHashString == usuario.contraseniahash)
                {
                    return usuario; // Devuelve el objeto de usuario completo
                }
            }
            return null; // Devuelve null si el inicio de sesión falla
        }
        public byte[] HexToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
        //Fin de logeo 

    }
}