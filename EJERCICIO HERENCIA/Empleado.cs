    public class Empleado : Persona {
        private int AnioIncorporacion;
        private string NumeroDespacho;

        public Empleado(int AnioIncorporacion, string NumeroDespacho, string Nombre, string Apellidos,
                        string EstadoCivil, string Identificacion) : base(Nombre, Apellidos, EstadoCivil,
                                                                          Identificacion)
        {
            this.AnioIncorporacion = AnioIncorporacion;
            this.NumeroDespacho = NumeroDespacho;
        }

        protected void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Fecha Incorporacion: " + this.AnioIncorporacion);
            Console.WriteLine("Numero de Despacho: " + this.NumeroDespacho);
        }

        public void cambiarDespacho(string numeroDespacho)
        {
            this.NumeroDespacho = numeroDespacho;
        }
    }