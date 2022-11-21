using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana_Lucas
{
    public class Program
    {
        
        static void Main(String []args)
        {
            Profesor profesor = new Profesor("INGNIERIA DE REQUISITOS", 2000, "11405", "JOSSELYNE", "BASURTO", "SOLTERA", "54202");
            PersonalServicio personalServicio = new PersonalServicio("BIBLIOTECA", 2021, "72762", "MERCEDES", "CASQUETE", "CASADA", "86562");
            Estudiante estudiante = new Estudiante("PROGRAMACION ORIENTADA A OBJETOS", "JORMAN", "VINCES", "SOLTERO", "89786");

            personalServicio.cambiarEstadoCivil("SOLTERO");
            profesor.cambiarDespacho("2222");
            estudiante.Matricular(" ECUACION DIFERENCIAL ");
            profesor.cambiarDespacho("90");
            personalServicio.TrasladoPersonal("50");

            profesor.imprimir();
            personalServicio.imprimir();
            estudiante.imprimir();
        }

    }
}
