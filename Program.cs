using System;

namespace Ejercicio_Sesion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente miCliente = new Cliente
            {
                NombreCompleto = "Jose Antonio",
                Telefono = "665376263",
                Direccion = "Calle 123, Madrid",
                Email = "jose.antonio@example.com",
                EsNuevoCliente = true
            };

            Console.WriteLine(miCliente.ToString());
        }
    }
}
public struct Cliente
{
    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool EsNuevoCliente { get; set; }

    public override string ToString()
    {
        return $"Nombre completo: {NombreCompleto}\nTeléfono: {Telefono}\nDirección: {Direccion}\nEmail: {Email}\n¿Es nuevo cliente?: {EsNuevoCliente}";
    }
}
