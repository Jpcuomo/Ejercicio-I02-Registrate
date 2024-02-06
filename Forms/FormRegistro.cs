using Biblioteca;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Forms
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private string[] GetCursos()
        {
            int indice = 0;
            string[] cursos = new string[3];
            if (cBoxC.Checked)
            {
                cursos[indice++] = cBoxC.Text;
            }
            if (cBoxCmas.Checked)
            {
                cursos[indice++] = cBoxCmas.Text;
            }
            if (cBoxJavaScript.Checked)
            {
                cursos[indice++] = cBoxJavaScript.Text;
            }
            return cursos;
        }

        private string GetGenero()
        {
            if (rBtnMasculino.Checked)
            {
                return rBtnMasculino.Text;
            }
            else if(rBtnFemenino.Checked)
            {
                return rBtnFemenino.Text;
            }
            else 
            { 
                return rBtnNoBinario.Text;
            }
        }

        private bool ValidarEntradas()
        {
            // Verificar si todos los campos obligatorios están completos y válidos
            if (!string.IsNullOrEmpty(txtDireccion.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(lBoxPaises.Text) &&
                !string.IsNullOrEmpty(GetGenero()) &&
                GetCursos() != null)
            {
                return true; // Todas las entradas son válidas
            }
            return false; // Al menos un campo obligatorio está vacío o inválido
        }

        private bool ValidaEdad(out int edadNum)
        {
            if (int.TryParse(numEdad.Text, out edadNum))
            {
                if (edadNum >= 0 && edadNum <= 110)
                {
                    return true;
                }
            }
            return false; 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int edadNum;
            if (ValidarEntradas() && ValidaEdad(out edadNum))
            {
                Ingresante ingresante = new Ingresante(GetCursos(), txtDireccion.Text, edadNum, GetGenero(), txtNombre.Text, lBoxPaises.Text);
                string mensaje = ingresante.Mostrar();
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
