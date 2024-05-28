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
using System.Windows.Input;

namespace Facturación
{
    public partial class frmIventario : Form
    {
        public frmIventario()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Articulo", connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvTabla.DataSource = dt;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;";
            string querySelect = "SELECT COUNT(*) FROM Articulo WHERE Nombre = @Nombre AND Categoria = @Categoria";
            string queryUpdate = "UPDATE Articulo SET Cantidad = Cantidad + @Cantidad WHERE Nombre = @Nombre AND Categoria = @Categoria";
            string queryInsert = "INSERT INTO Articulo (Nombre, Categoria, Decripcion, Cantidad, Precio) VALUES (@Nombre, @Categoria, @Decripcion, @Cantidad, @Precio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand commandSelect = new SqlCommand(querySelect, connection))
                    {
                        commandSelect.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        commandSelect.Parameters.AddWithValue("@Categoria", txtCategoria.Text);

                        int count = (int)commandSelect.ExecuteScalar();

                        if (count > 0)
                        {
                            // Si el producto existe, actualiza la cantidad
                            using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                            {
                                commandUpdate.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                                commandUpdate.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                                commandUpdate.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));

                                commandUpdate.ExecuteNonQuery();
                                MessageBox.Show("La cantidad del producto se actualizó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // Si el producto no existe, inserta un nuevo producto
                            using (SqlCommand commandInsert = new SqlCommand(queryInsert, connection))
                            {
                                commandInsert.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                                commandInsert.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                                commandInsert.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));

                                commandInsert.ExecuteNonQuery();
                                MessageBox.Show("Producto agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
