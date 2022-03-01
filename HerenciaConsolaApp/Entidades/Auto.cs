using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaConsolaApp.Entidades
{
    public class Auto
    {
        //Declaramos las variables de la entidad
        private int _ruedas;
        private decimal _kilometraje;
        private string _tipo;
        private string _color;

        //Los get y set se utilizan para acceder a las variables desde otras clases.
        public int GetRuedas()
        {
            return _ruedas;
        }

        public void SetRuedas(int ruedas)
        {
            this._ruedas = ruedas;
        }

        public decimal GetKilometraje()
        {
            return _kilometraje;
        }

        public void SetKilometraje(decimal kilometraje)
        {
            this._kilometraje = kilometraje;
        }

        public string GetTipo()
        {
            return _tipo;
        }

        public void SetTipo(string tipo)
        {
            this._tipo = tipo;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            this._color = color;
        }

        //Fijate que las variables las pongo dentro del constructor, esto es para inicializarlas
        public Auto()
        {
            _ruedas = 0;
            _kilometraje = 0;
            _tipo = string.Empty;
            _color = string.Empty;
        }

        //Con este constructor podemos cargarlo en la herencia
        public Auto(int ruedas, decimal kilometraje, string tipo, string color)
        {
            this._ruedas = ruedas;
            this._kilometraje = kilometraje;
            this._tipo = tipo;
            this._color = color;
        }
    }
}
