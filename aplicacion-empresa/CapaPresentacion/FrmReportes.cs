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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        int esCliente = 1;
        int esEmpleado = 0;
        int esProducto = 0;

        public FrmReportes()
        {
            InitializeComponent();
            this.dateTimePickerDesde.Value = DateTime.Now.AddDays(-365);
            this.dateTimePickerHasta.Value = DateTime.Now;
        }

        public void CargarComboBox()
        {
            if (esCliente == 1)
            {
                this.comboBox.DataSource = NClientes.ListaClientes();
            }

            else if (esEmpleado == 1)
            {
                this.comboBox.DataSource = NEmpleados.ListaEmpleados();
            }

            else if (esProducto == 1)
            {
                this.comboBox.DataSource = NProductos.ListaProductos();
            }

            this.comboBox.ValueMember = "ID";
            this.comboBox.DisplayMember = "NOMBRE";
        }

        public void CargarGraficos()
        {
            foreach (var series in chartTorta.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chartHistorial.Series)
            {
                series.Points.Clear();
            }

            if (esCliente == 1)
            {
                this.labelR.Text = "LOS 10 MEJORES CLIENTES";
                this.chartHistorial.DataSource = NReportes.MostrarHistorialCliente(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"),
                this.comboBox.Text);

                this.chartHistorial.Series["MONTO"].YValueMembers = "MONTO";
                this.chartHistorial.Series["MONTO"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                this.chartHistorial.ChartAreas["ChartArea1"].AxisY.Title = "SALDO $";

                this.dataGridView.DataSource = NReportes.MostrarTop10Clientes(
                    this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                    this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));

                this.dataGridView.Columns[2].DefaultCellStyle.Format = "0.00#### $";

                this.chartTorta.Series["Series1"].XValueMember = "CLIENTE";
                this.chartTorta.Series["Series1"].YValueMembers = "SALDO";

                this.chartTorta.DataSource = NReportes.MostrarTop10Clientes(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));
            }

            else if (esEmpleado == 1)
            {
                this.labelR.Text = "LOS 10 MEJORES EMPLEADOS";
                this.chartHistorial.DataSource = NReportes.MostrarHistorialEmpleado(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"),
                this.comboBox.Text);

                this.chartHistorial.Series["MONTO"].YValueMembers = "MONTO";
                this.chartHistorial.Series["MONTO"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                this.chartHistorial.ChartAreas["ChartArea1"].AxisY.Title = "SALDO $";

                this.dataGridView.DataSource = NReportes.MostrarTop10Empleados(
                    this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                    this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));

                this.dataGridView.Columns[2].DefaultCellStyle.Format = "0.00#### $";

                this.chartTorta.Series["Series1"].XValueMember = "EMPLEADO";
                this.chartTorta.Series["Series1"].YValueMembers = "SALDO";

                this.chartTorta.DataSource = NReportes.MostrarTop10Empleados(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));
            }

            else if (esProducto == 1)
            {
                this.labelR.Text = "LOS 10 MEJORES PRODUCTOS";
                this.chartHistorial.DataSource = NReportes.MostrarHistorialProducto(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"),
                this.comboBox.Text);

                this.chartHistorial.Series["MONTO"].YValueMembers = "CANTIDAD";
                this.chartHistorial.Series["MONTO"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                this.chartHistorial.ChartAreas["ChartArea1"].AxisY.Title = "CANTIDAD";

                this.dataGridView.DataSource = NReportes.MostrarTop10Productos(
                    this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                    this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));

                this.chartTorta.Series["Series1"].XValueMember = "PRODUCTO";
                this.chartTorta.Series["Series1"].YValueMembers = "CANTIDAD";

                this.chartTorta.DataSource = NReportes.MostrarTop10Productos(
                this.dateTimePickerDesde.Value.ToString("yyyyMMdd"),
                this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));
            }

            this.dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            chartTorta.Series[0]["PieLabelStyle"] = "Outside";
            chartTorta.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartTorta.ChartAreas[0].Area3DStyle.Inclination = 0;
            chartTorta.ChartAreas[0].Area3DStyle.Rotation = 0;
            this.chartTorta.Series[0].LegendText = "#PERCENT{P2}";
        }

        private void buttonGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGraficos();
            }
            catch(Exception ex) 
            {
                MensajeError(ex.Message);
            }
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboBox();
                CargarGraficos();
            }
            catch(Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();  
        }

        private void buttonRClientes_Click(object sender, EventArgs e)
        {
            esCliente = 1;
            esEmpleado = 0;
            esProducto = 0;

            try
            {
                CargarComboBox();
                CargarGraficos();
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void buttonREmpleados_Click(object sender, EventArgs e)
        {
            esEmpleado = 1;
            esCliente = 0;
            esProducto = 0;

            try
            {
                CargarComboBox();
                CargarGraficos();
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void buttonRProductos_Click(object sender, EventArgs e)
        {
            esProducto = 1;
            esEmpleado = 0;
            esCliente = 0;

            try
            {
                CargarComboBox();
                CargarGraficos();
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

    }
}
