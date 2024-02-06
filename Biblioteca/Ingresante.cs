using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        // Atributos o campos
        private string[] _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        // Propiedad para acceder a _cursos
        public string[] Cursos
        {
            get { return _cursos; }
        }

        // Propiedad para acceder a _direccion
        public string Direccion
        {
            get { return _direccion; }
        }

        // Propiedad para acceder a _edad
        public int Edad
        {
            get { return _edad; }
        }

        // Propiedad para acceder a _genero
        public string Genero
        {
            get { return _genero; }
        }

        // Propiedad para acceder a _nombre
        public string Nombre
        {
            get { return _nombre; }
        }

        // Propiedad para acceder a _pais
        public string Pais
        {
            get { return _pais; }
        }

        // Constructor
        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            _cursos = cursos;
            _direccion = direccion;
            _edad = edad;
            _genero = genero;
            _nombre = nombre;
            _pais = pais;
        }

        // Método que formatea y muestra los valores de los atributos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dirección: {Direccion}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Género: {Genero}");
            sb.AppendLine($"País: {Pais}");
            sb.AppendLine($"Curso/s: {Cursos}");
            return sb.ToString();
        }
    }
}
