using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Facturación
{
    public partial class frmVentas : Form
    {

        private SqlConnection connection;
        private string nombreCliente;
        private string apellidoCliente;
        public frmVentas()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadComboBoxProducto();
            InitializeDataGridView();

        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
        }

        private void LoadComboBoxProducto()
        {
            try
            {
                connection.Open();
                string query = "SELECT Idpro, Nombre, Precio FROM Articulo";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "Idpro";
                cmbProducto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void InitializeDataGridView()
        {
            dgvFactura.Columns.Add("Cedula", "Cédula");
            dgvFactura.Columns.Add("Nombre", "Nombre");
            dgvFactura.Columns.Add("Producto", "Producto");
            dgvFactura.Columns.Add("Cantidad", "Cantidad");
            dgvFactura.Columns.Add("Precio", "Precio Total");
        }




        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Clientes", connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    // Obtener el ID de la fila seleccionada
                    int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

                    string connectionString = "Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;";
                    string query = "DELETE FROM Clientes WHERE Id = @Id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Eliminar la fila del DataGridView
                                dgvClientes.Rows.RemoveAt(dgvClientes.SelectedRows[0].Index);
                                MessageBox.Show("Los datos se eliminaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al eliminar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=EIDER\\SQLEXPRESS;Database=negocio;Trusted_Connection=True;";
            string query = "INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Cedula, Direccion) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Cedula, @Direccion)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Los datos se guardaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCliente = string.Empty;
            string apellidoCliente = string.Empty;

            if (cmbProducto.SelectedValue != null && !string.IsNullOrEmpty(txtCantidad.Text))
            {
                if (!string.IsNullOrEmpty(txtCedula1.Text))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Nombre, Apellido FROM Clientes WHERE Cedula = @cedula";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@cedula", txtCedula1.Text);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            nombreCliente = reader["Nombre"].ToString();
                            apellidoCliente = reader["Apellido"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                            connection.Close();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar cliente: " + ex.Message);
                        connection.Close();
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                string producto = cmbProducto.Text;
                int cantidad;
                if (int.TryParse(txtCantidad.Text, out cantidad))
                {
                    int productoId = Convert.ToInt32(cmbProducto.SelectedValue);
                    DataRowView selectedProduct = (DataRowView)cmbProducto.SelectedItem;
                    decimal precioUnitario = Convert.ToDecimal(selectedProduct["Precio"]);
                    decimal precioTotal = precioUnitario * cantidad;

                    dgvFactura.Rows.Add(txtCedula1.Text, $"{nombreCliente} {apellidoCliente}", producto, cantidad, precioTotal);
                    dgvFactura.Refresh(); // Refrescar el DataGridView
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto y una cantidad.");
            }
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroFactura.Text))
            {
                MessageBox.Show("Por favor, ingrese el número de factura.");
                return;
            }

            StringBuilder factura = new StringBuilder();
            factura.AppendLine($"Número de Factura: {txtNumeroFactura.Text}");
            factura.AppendLine($"Cédula: {txtCedula1.Text}");
            factura.AppendLine($"Cliente: {nombreCliente} {apellidoCliente}");
            factura.AppendLine("Detalles de la compra:");
            factura.AppendLine("---------------------------------------------------------");

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.IsNewRow) continue;
                factura.AppendLine($"Producto: {row.Cells["Producto"].Value}, Cantidad: {row.Cells["Cantidad"].Value}, Precio Total: {row.Cells["Precio"].Value}");
            }

            factura.AppendLine("---------------------------------------------------------");
            factura.AppendLine("Su compra fue realizada con éxito.");

            MessageBox.Show(factura.ToString(), "Factura");
        }
    }

}
