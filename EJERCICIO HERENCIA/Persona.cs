using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Persona
    {
        private string Nombre, Apellidos, EstadoCivil, Identificacion;

        public Persona(string Nombre, string Apellidos, string EstadoCivil, string Identificacion)
        {
            this.Nombre = Nombre;   
            this.Apellidos = Apellidos; 
            this.EstadoCivil = EstadoCivil;
            this.Identificacion = Identificacion;
        }

        public void cambiarEstadoCivil(string estadoCivil)
        {
            this.EstadoCivil = estadoCivil;
        }

        protected void imprimir()
        {
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Apellidos: " + this.Apellidos);
            Console.WriteLine("Estado Civil: " + this.EstadoCivil);
            Console.WriteLine("No. Idetificacion: " + this.Identificacion);
        }
    }