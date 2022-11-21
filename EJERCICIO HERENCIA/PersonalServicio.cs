    public class PersonalServicio : Empleado
    {
        private string Seccion;

        public PersonalServicio(string Seccion, int AnioIncorporacion, string NumeroDespacho,
                                string Nombre, string Apellidos, string EstadoCivil, string Identificacion) :
                                 base(AnioIncorporacion, NumeroDespacho, Nombre, Apellidos, EstadoCivil,
                                  Identificacion)
        {
            this.Seccion = Seccion;
        }

        public void TrasladoPersonal(string Seccion)
        {
            this.Seccion = Seccion;
        }

        public void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Seccion: " + this.Seccion + "\n");
        }
    }

