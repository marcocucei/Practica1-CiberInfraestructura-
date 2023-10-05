using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+$]).*$");

            if (string.IsNullOrEmpty(txtContrasenaUno.Text) &&
                string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }

            //Valida
            //
            //
            if (!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))

            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }

            if (validacion.IsMatch(txtContrasenaUno.Text))
            {
                MessageBox.Show("La contrase�a es VALIDA");
            }
            else
            {
                MessageBox.Show("La contrase�a NO ES VALIDA");
            }
        }


    }
}