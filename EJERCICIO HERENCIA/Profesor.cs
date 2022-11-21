
    public class Profesor : Empleado
    {
        private string Departamento;

        public Profesor(string Departamento, int AnioIncorporacion, string NumeroDespacho, 
                        string Nombre, string Apellidos, string EstadoCivil, string Identificacion) : 
                        base(AnioIncorporacion, NumeroDespacho, Nombre, Apellidos, EstadoCivil, Identificacion)
        {
            this.Departamento = Departamento;
        }

        public void CambiarDepartamento(string Departamento)
        {
            this.Departamento = Departamento;
        }

        public void imprimir()
        {
            base.imprimir();    
            Console.WriteLine("Departamento: " + this.Departamento + "\n");
        }
    }
