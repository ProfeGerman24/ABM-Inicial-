namespace Clases
{
    public class Alumno
    {
        int legajo;
        string nombre;
        string apellido;
        float nota;

        public Alumno(int legajo, string nombre, string apellido, float nota)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nota = nota;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public float Nota { get => nota; set => nota = value; }

        public override string ToString()
        {
            string datos;
            datos = $"{Legajo} - {Apellido} - {Nombre} - {Nota}";

            return datos;
        }
    }
}
