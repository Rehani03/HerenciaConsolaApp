using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaConsolaApp.Entidades
{
    public class Carro : Auto
    {
       //Esta es una forma mas sencilla de hacer los get y set
        public int year { get; set; }
        public string placa { get; set; }
        public string condicion { get; set; }

       
        //A esto se le llama Constructor; se utiliza para poder inicializar la clase o los metodos que estan en ella

        public Carro()
        {
            //Inicializamos las variables, para que esten en 0 cuando sean llamadas
            year = 0; 
            placa = string.Empty;
            condicion = string.Empty;
        }


        public Carro(int _year, string _placa, string _condicion, int ruedas, decimal kilometraje, string tipo, string color) 
            : base(ruedas,kilometraje,tipo,color)
        {
            this.year = _year;
            this.placa = _placa;
            this.condicion = _condicion;
        }
    }
}
