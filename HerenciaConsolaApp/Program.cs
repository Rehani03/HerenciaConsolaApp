using HerenciaConsolaApp.Entidades;
using System;

namespace HerenciaConsolaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamamos el constructor y lo cargamos con los datos.
            //Se puede hacer asi o de forma directa, llamando cada variable o metodo
            Carro c = new Carro(2014,"B142536", "Nuevo", 4, 20452, "Terrestre", "Blanco");

            Console.WriteLine("Mostrando lo que se puede hacer con la herencia");
            Console.WriteLine("Año:" + c.year);
            Console.WriteLine("Placa:" + c.placa);
            Console.WriteLine("Condición:" + c.condicion);
            Console.WriteLine("Ruedas:" + c.GetRuedas());
            Console.WriteLine("Kilometraje:" + c.GetKilometraje());
            Console.WriteLine("Tipo:" + c.GetTipo());
            Console.WriteLine("Color:" + c.GetColor());

            
        }
    }
}
