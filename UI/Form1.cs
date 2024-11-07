using BE;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private PartidoBusiness partidoBusiness = new PartidoBusiness();
        private DeporteBusiness deporteBusiness = new DeporteBusiness();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDeportesEnComboBox();
            ActualizarDgvPartidos();
        }

        private void CargarDeportesEnComboBox()
        {
            try
            {
                cmbDeporte.DataSource = deporteBusiness.ObtenerDeportes();
                cmbDeporte.DisplayMember = "Descripcion";
                cmbDeporte.ValueMember = "IdDeporte";
                cmbDeporte.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar deportes: {ex.Message}");
            }
        }

        private void ActualizarDgvPartidos()
        {
            try
            {
                dgvPartidos.DataSource = null;
                dgvPartidos.DataSource = partidoBusiness.ObtenerPartidos();

                // Personalizo los encabezados de las columnas
                dgvPartidos.Columns["IdPartido"].HeaderText = "ID Partido";
                dgvPartidos.Columns["Deporte"].HeaderText = "Deporte";
                dgvPartidos.Columns["EquipoLocal"].HeaderText = "Equipo Local";
                dgvPartidos.Columns["EquipoVisitante"].HeaderText = "Equipo Visitante";
                dgvPartidos.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                dgvPartidos.Columns["FechaPartido"].HeaderText = "Fecha Partido";
                dgvPartidos.Columns["MarcadorLocal"].HeaderText = "Marcador Local";
                dgvPartidos.Columns["MarcadorVisitante"].HeaderText = "Marcador Visitante";

                // Oculto la columna Deporte.IdDeporte ya que no es necesaria
                dgvPartidos.Columns["Deporte"].Visible = false;

                // Ajusto el tamaño de las columnas al contenido
                dgvPartidos.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar partidos: {ex.Message}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de negocio y creación de nuevo partido con el Deporte seleccionado
                var deporteSeleccionado = (Deporte)cmbDeporte.SelectedItem;
                if (deporteSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un deporte.");
                    return;
                }

                Partido nuevoPartido = new Partido
                {
                    Deporte = deporteSeleccionado,
                    EquipoLocal = txtEquipoLocal.Text,
                    EquipoVisitante = txtEquipoVisitante.Text,
                    FechaPartido = dateFechaPartido.Value
                };

                partidoBusiness.GuardarPartido(nuevoPartido);
                MessageBox.Show("Partido guardado correctamente.");
                ActualizarDgvPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el partido: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPartido = Convert.ToInt32(txtIdPartidoEliminar.Text);
                partidoBusiness.EliminarPartido(idPartido);
                MessageBox.Show("Partido eliminado correctamente.");
                ActualizarDgvPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el partido: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPartido = Convert.ToInt32(txtIdPartidoModificar.Text);
                int marcadorLocal = Convert.ToInt32(txtMarcadorLocal.Text);
                int marcadorVisitante = Convert.ToInt32(txtMarcadorVisitante.Text);

                partidoBusiness.ActualizarMarcador(idPartido, marcadorLocal, marcadorVisitante);
                MessageBox.Show("Marcador actualizado correctamente.");
                ActualizarDgvPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el marcador: {ex.Message}");
            }
        }

        private void btnAgregarAlBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                var deporteSeleccionado = (Deporte)cmbDeporte.SelectedItem;
                if (deporteSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un deporte.");
                    return;
                }

                Partido partidoBorrador = new Partido
                {
                    Deporte = deporteSeleccionado,
                    EquipoLocal = txtEquipoLocal.Text,
                    EquipoVisitante = txtEquipoVisitante.Text,
                    FechaPartido = dateFechaPartido.Value
                };

                partidoBusiness.AgregarPartidoAlBorrador(partidoBorrador);
                MessageBox.Show("Partido agregado al borrador.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar al borrador: {ex.Message}");
            }
        }

        private void btnGuardarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                partidoBusiness.GuardarBorrador();
                MessageBox.Show("Borrador guardado exitosamente en la base de datos.");
                ActualizarDgvPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el borrador: {ex.Message}");
            }
        }

        private void btnLimpiarBorrador_Click(object sender, EventArgs e)
        {
            partidoBusiness.LimpiarBorrador();
            MessageBox.Show("Borrador limpiado.");
        }
    }
}
