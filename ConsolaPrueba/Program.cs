// See https://aka.ms/new-console-template for more information


using App.Business;
using App.Entities;


var prueba = new Business();
var datos = new Search()
{
    PageIndex = 1,
    PageSize = 10,
    TextToSearch = "hola"
};

var response = prueba.GetVentas(datos); // Usar una variable diferente para almacenar la respuesta


    foreach (var venta in response.Items)
    {
        // Realizar operaciones con cada venta
        Console.WriteLine($"Venta ID: {venta.IdVenta}, Nombre: {venta.Nombre}, Monto: {venta.Precio}");

        // Puedes realizar otras operaciones aquí, como cálculos, filtrado, etc.
    }





