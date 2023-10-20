using App.Business;
using App.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Autenticacion con Jwt
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Ket"]))
    };
});

app.UseAuthentication();
*/
builder.Services.AddDbContext<Context>();

//Negocio

builder.Services.AddTransient<UsuarioNegocio>();
builder.Services.AddTransient<PermisoNegocio>();
builder.Services.AddTransient<StockNegocio>();
builder.Services.AddTransient<ProveedorNegocio>();

//Repositorio

builder.Services.AddTransient<UsuarioRepositorio>();
builder.Services.AddTransient<PermisoRepositorio>();
builder.Services.AddTransient<StockRepositorio>();
builder.Services.AddTransient<ProveedorRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
