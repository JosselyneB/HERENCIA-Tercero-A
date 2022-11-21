        public class Estudiante : Persona{
    
        private string Curso;

        public Estudiante(string Curso, string Nombre, string Apellidos, string EstadoCivil, 
                          string Identificacion) : base(Nombre, Apellidos, EstadoCivil, Identificacion) 
        {
            this.Curso = Curso;
        }

        public void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Curso: " + this.Curso + "\n");
        }

        public void Matricular(string Curso)
        {
            this.Curso = Curso;
        }
    }
    