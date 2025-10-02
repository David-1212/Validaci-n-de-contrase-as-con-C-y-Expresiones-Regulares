// Importa la librería que permite trabajar con expresiones regulares (Regex).
using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Constructor de la clase Form1: inicializa los componentes del formulario (botones, etiquetas, cajas de texto, etc.).
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón "btnvalidar".
        private void btnvalidar_Click(object sender, EventArgs e)
        {
            /*
               Requisitos de la contraseña que se validarán:
               - Al menos una letra mayúscula
               - Al menos una letra minúscula
               - Al menos un símbolo
               - Al menos un número
           */


            // Obtiene el texto que el usuario escribió en el primer TextBox (txtcontrasena1).
            string contrasena1 = txtcontrasena1.Text;

            // Obtiene el texto del segundo TextBox (txtcontrasena2) para verificar que coincidan.
            string contrasena2 = txtcontrasena2.Text;


            // Define el patrón de expresión regular que valida:
            // (?=.*[a-z]) → al menos una letra minúscula
            // (?=.*[A-Z]) → al menos una letra mayúscula
            // (?=.*\d)   → al menos un dígito numérico
            // (?=.*[\W_]) → al menos un símbolo o carácter no alfanumérico
            // ^ y $ → delimitan el inicio y fin de la cadena
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";


            // Aplica el patrón Regex a la primera contraseña para verificar si cumple con los requisitos.
            bool valido = Regex.IsMatch(contrasena1, patron);


            // Muestra mensajes según el resultado de la validación.
            if (!valido)
            {   // Si la contraseña no es válida, muestra un mensaje de error.
                MessageBox.Show("La contraseña no contiene los caracteres esperados...");
                return;
            }
            // Verifica si las dos contraseñas ingresadas coinciden entre sí.
            if (!contrasena1.Equals(contrasena2))
            {   // Si no coinciden, muestra un mensaje de error.
                MessageBox.Show("Las contraseñas no coinciden entre si...");
                return;
            }
            // Si la contraseña es válida y ambas coinciden, muestra un mensaje de éxito.
            MessageBox.Show("La contraseña es valida");

        }
    }
}
