using System.Text.RegularExpressions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace NivelEstudiosSql
{
    public partial class Form1 : Form
    {
        public DateTimePicker fecha;
        private SqlConnection conexion;
        public Empleado empleado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSql();

            if (!validarDatos())
            {
                conexion.Close();
                return;
            }

            string insert = "insert into NivelEstudios(Empleado_idEmpleado, Grado, Titulado, Fecha_Egreso, NombreEscuela, Especialidad)" +
                            "values (@Empleado_idEmpleado, @Grado, @Titulado, @Fecha_Egreso, @NombreEscuela, @Especialidad)";

            using (SqlCommand comando = new SqlCommand(insert, conexion))
            {
                comando.Parameters.AddWithValue("@Empleado_idEmpleado", this.empleado.Id);
                comando.Parameters.AddWithValue("@Grado", this.empleado.Grado);
                comando.Parameters.AddWithValue("@Titulado", this.empleado.Titulado);
                comando.Parameters.AddWithValue("@Fecha_Egreso", this.empleado.Fecha_egreso);
                comando.Parameters.AddWithValue("@NombreEscuela", this.empleado.Escuela);
                comando.Parameters.AddWithValue("@Especialidad", this.empleado.Especialidad);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");
            }

            conexion.Close();
        }

        private void ConexionSql()
        {
            conexion = new SqlConnection("server=LAPTOPRTX; database=Coppel ; integrated security = true");
            conexion.Open();
        }
        private bool EmpleadoIdExistente(int empleadoId)
        {
            string consultaExistencia = "SELECT COUNT(*) FROM NivelEstudios WHERE Empleado_idEmpleado = @Empleado_idEmpleado";

            using (SqlCommand comandoExistencia = new SqlCommand(consultaExistencia, conexion))
            {
                comandoExistencia.Parameters.AddWithValue("@Empleado_idEmpleado", empleadoId);

                int registrosExistentes = (int)comandoExistencia.ExecuteScalar();
                return registrosExistentes > 0;
            }
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            ConexionSql();
            string consulta = "select * from NivelEstudios";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                using (SqlDataReader NivelEstudios = comando.ExecuteReader())
                {
                    DG.Rows.Clear();
                    while (NivelEstudios.Read())
                    {
                        DG.Rows.Add(
                            NivelEstudios["Empleado_idEmpleado"].ToString(),
                            NivelEstudios["Grado"].ToString(),
                            NivelEstudios["Titulado"].ToString(),
                            NivelEstudios["Fecha_Egreso"].ToString(),
                            NivelEstudios["NombreEscuela"].ToString(),
                            NivelEstudios["Especialidad"].ToString()
                        );
                    }
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ConexionSql();
            if (DG.SelectedCells.Count == 0)
            {
                MessageBox.Show("No hay un empleado seleccionado.");
                return;
            }

            DataGridViewRow selectedRow = DG.Rows[this.DG.SelectedCells[0].RowIndex];
            int idEmpleado;

            if (!int.TryParse(selectedRow.Cells["Empleado_idEmpleado"].Value?.ToString(), out idEmpleado))
            {
                MessageBox.Show("El id del empleado no es valido.");
                return;
            }

            string delete = "DELETE FROM NivelEstudios WHERE Empleado_idEmpleado = @idEmpleado";

            using (SqlCommand comando = new SqlCommand(delete, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                int filasAfectadas = comando.ExecuteNonQuery();
                MessageBox.Show(filasAfectadas > 0 ? "Datos eliminados correctamente" : "No se encontraron datos para eliminar.");
            }
            conexion.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ConexionSql();

            if (!validarDatos(true))
            {
                conexion.Close();
                return;
            }

            string update = "UPDATE NivelEstudios SET Grado = @Grado, Titulado = @Titulado, Fecha_Egreso = @Fecha_Egreso, NombreEscuela = @NombreEscuela, Especialidad = @Especialidad WHERE Empleado_idEmpleado = @Empleado_idEmpleado";

            using (SqlCommand comando = new SqlCommand(update, conexion))
            {
                comando.Parameters.AddWithValue("@Empleado_idEmpleado", this.empleado.Id);
                comando.Parameters.AddWithValue("@Grado", this.empleado.Grado);
                comando.Parameters.AddWithValue("@Titulado", this.empleado.Titulado);
                comando.Parameters.AddWithValue("@Fecha_Egreso", this.empleado.Fecha_egreso);
                comando.Parameters.AddWithValue("@NombreEscuela", this.empleado.Escuela);
                comando.Parameters.AddWithValue("@Especialidad", this.empleado.Especialidad);
                int filasActualizadas = comando.ExecuteNonQuery();
                MessageBox.Show(filasActualizadas != 0 ? "Datos actualizados correctamente" : "No se encontraron datos para actualizar.");
            }
            conexion.Close();
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3){
                this.fecha = new DateTimePicker();
                this.DG.Controls.Add(this.fecha);
                this.fecha.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
                this.fecha.Format = DateTimePickerFormat.Custom;
                Rectangle rectangle = this.DG.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.fecha.Size = new Size(rectangle.Width, rectangle.Height);
                this.fecha.Location = new Point(rectangle.X, rectangle.Y);
                this.fecha.CloseUp += new EventHandler(this.fecha_closeup);
                this.fecha.TextChanged += new EventHandler(this.fecha_ontextchange);
                this.fecha.Visible = true;
            } else
            {
                if (this.fecha != null && this.fecha.Visible == true)
                {
                    this.fecha.Visible = false;
                }
            }
        }

        private void fecha_ontextchange(object sender, EventArgs e)
        {
            this.DG.CurrentRow.Cells[3].Value = this.fecha.Text.ToString();
        }

        private void fecha_closeup(object sender, EventArgs e)
        {
            this.fecha.Visible = false;
        }

        private bool validarDatos(bool actualiza = false)
        {

            if (this.DG.SelectedCells.Count == 0)
            {
                MessageBox.Show("No hay un empleado seleccionado.");
                return false;
            }

            DataGridViewRow selectedRow = this.DG.Rows[this.DG.SelectedCells[0].RowIndex];

            int empleadoId;
            if (!int.TryParse(selectedRow.Cells["Empleado_idEmpleado"].Value?.ToString(), out empleadoId))
            {
                MessageBox.Show($"El id empleado ({selectedRow.Cells["Empleado_idEmpleado"].Value}) no tiene un identificador valido.");
                return false;
            }

            if (empleadoId > 5 || empleadoId <= 0)
            {
                MessageBox.Show("El id empleado debe ser un valor numerico menor o igual a 5 y mayor a 0");
                return false;
            }

            if (selectedRow.Cells["Empleado_idEmpleado"].Value == null &&
                selectedRow.Cells["Grado"].Value == null &&
                selectedRow.Cells["Titulado"].Value == null &&
                selectedRow.Cells["Fecha_Egreso"].Value == null &&
                selectedRow.Cells["NombreEscuela"].Value == null &&
                selectedRow.Cells["Especialidad"].Value == null)
            {
                MessageBox.Show("Todos los campos son requeridos.");
                return false;
            }

            this.empleado = new Empleado();
            this.empleado.Id = empleadoId;
            this.empleado.Grado = selectedRow.Cells[1].Value.ToString();
            this.empleado.Titulado = selectedRow.Cells[2].Value.ToString();
            this.empleado.Fecha_egreso = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            this.empleado.Escuela = selectedRow.Cells[4].Value.ToString();
            this.empleado.Especialidad = selectedRow.Cells[5].Value.ToString();

            if (!validarCampo(this.empleado.Grado, "Grado", 100) || !validarCampo(this.empleado.Titulado, "Titulado", 2) ||
                !validarCampo(this.empleado.Escuela, "NombreEscuela", 100) || !validarCampo(this.empleado.Especialidad, "Especialidad", 100))
            {
                return false;
            }
            
            if (!actualiza)
            {
                if (EmpleadoIdExistente(empleadoId))
                {
                    MessageBox.Show($"Ya existe un empleado con el id {empleadoId}.");
                    return false;
                }
            }
            return true;
        }

        private bool validarCampo(string texto, string campo, int longitud = 0)
        {
            if (!new Regex("^[a-zA-Z\\s]+$").IsMatch(texto))
            {
                MessageBox.Show($"El campo '{campo}' solo debe contener caracteres alfabéticos.");
                return false;
            }
            if (texto.Length > longitud)
            {
                MessageBox.Show($"El campo {campo} debe contener menos de {longitud} caracteres");
                return false;
            }
            return true;
        }
    }

    public class Empleado
    {
        private int id;
        private string grado;
        private string titulado;
        private DateTime fecha_egreso;
        private string escuela;
        private string especialidad;

        public int Id { get => id; set => id = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Titulado { get => titulado; set => titulado = value; }
        public DateTime Fecha_egreso { get => fecha_egreso; set => fecha_egreso = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}