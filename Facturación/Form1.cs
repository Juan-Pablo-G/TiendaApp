using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación
{
    public partial class frmlogin : Form
    {
        private int intentos = 0;
        public frmlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(Usuario) || string.IsNullOrWhiteSpace(Contraseña))
            {
                MessageBox.Show("Por favor ingrese los campos necesarios para ingresar", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection("Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario=@NombreUsuario AND Contraseña=@Contraseña", connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", Usuario);
                    command.Parameters.AddWithValue("@Contraseña", Contraseña);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount > 0)
                    {
                        frmMenu frmMenu = new frmMenu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        intentos++;

                        if (intentos >= 3)
                        {
                            MessageBox.Show("Ha pasado el número de intentos, por favor hagálo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos + "/3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtUsuario.Text = "";
                        txtContraseña.Text = "";
                    }
                }
            }
        }

        private void ckbOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOcultar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
