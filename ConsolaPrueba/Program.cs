using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using App.Business;
using App.Data;
using App.Entities;






Console.Write("Crear usuario(1)");
Console.Write("Logear (2)");
int opcion = Convert.ToInt32(Console.ReadLine());





switch (opcion)
{

    case 1:
        // Configura el contexto de base de datos (debes implementar esto)
        var context = new Context(); // Reemplaza "Context" con tu clase de contexto

        var usuarioRepository = new UsuarioRepositorio(context);
        var usuarioBusiness = new UsuarioNegocio(usuarioRepository);

        Console.Write("Ingrese dni: ");
        string numerodni = Console.ReadLine();
        int dni = int.Parse(numerodni);

        Console.Write("Ingrese el nombre de usuario: ");
        string username = Console.ReadLine();

        Console.Write("Ingrese la contraseña: ");
        string password = Console.ReadLine();

        Console.Write("Ingrese email: ");
        string email = Console.ReadLine();

        Console.Write("Ingrese rol: ");
        string numerorol = Console.ReadLine();
        int rol = int.Parse(numerorol);


        Usuario usuario = new Usuario();

        usuario.dni = dni;
        usuario.usuario = username;
        usuario.rol = rol;
        usuario.email = email;
        usuario.contraseniahash = password;

        usuarioBusiness.CrearUsuario(usuario);


        Console.WriteLine("Cuenta de usuario creada con éxito.");
        break;
        case 2:

        var loginrequest = new LoginRequest();

        Console.Write("Ingrese el nombre de usuario: ");
        loginrequest.usuario = Console.ReadLine();

        Console.Write("Ingrese la contraseña: ");
        loginrequest.contrasenia = Console.ReadLine();

        
        break;
}



