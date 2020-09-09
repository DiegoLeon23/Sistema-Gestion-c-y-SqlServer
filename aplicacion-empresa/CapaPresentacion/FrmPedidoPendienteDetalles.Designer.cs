namespace CapaPresentacion
{
    partial class FrmPedidoPendienteDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCentral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelTransporte = new System.Windows.Forms.Label();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.labelFechaOrdenado = new System.Windows.Forms.Label();
            this.labelFechaRequerido = new System.Windows.Forms.Label();
            this.labelCostoEnvio = new System.Windows.Forms.Label();
            this.textBoxFechaOrdenado = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCostoEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFechaRequerido = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxTransporte = new System.Windows.Forms.TextBox();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelNumeroPedido = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEditarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelCentral.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 2;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.56531F));
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.43469F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelCentral, 1, 0);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 1;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(934, 661);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36641F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.63359F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(76, 655);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.pedidos;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 74);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanelCentral
            // 
            this.tableLayoutPanelCentral.ColumnCount = 1;
            this.tableLayoutPanelCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCentral.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelCentral.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCentral.Location = new System.Drawing.Point(82, 0);
            this.tableLayoutPanelCentral.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelCentral.Name = "tableLayoutPanelCentral";
            this.tableLayoutPanelCentral.RowCount = 2;
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.62006F));
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.37994F));
            this.tableLayoutPanelCentral.Size = new System.Drawing.Size(849, 658);
            this.tableLayoutPanelCentral.TabIndex = 1;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 4;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37589F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63357F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80378F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95036F));
            this.tableLayoutPanelTop.Controls.Add(this.labelCliente, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelTransporte, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelResponsable, 0, 3);
            this.tableLayoutPanelTop.Controls.Add(this.labelFechaOrdenado, 2, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelFechaRequerido, 2, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelCostoEnvio, 2, 3);
            this.tableLayoutPanelTop.Controls.Add(this.textBoxFechaOrdenado, 3, 1);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel7, 3, 3);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel8, 3, 2);
            this.tableLayoutPanelTop.Controls.Add(this.textBoxCliente, 1, 1);
            this.tableLayoutPanelTop.Controls.Add(this.textBoxTransporte, 1, 2);
            this.tableLayoutPanelTop.Controls.Add(this.textBoxEmpleado, 1, 3);
            this.tableLayoutPanelTop.Controls.Add(this.labelPedido, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelNumeroPedido, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 4;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97727F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86364F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2236F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.60248F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(846, 161);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(6, 52);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(81, 26);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelTransporte
            // 
            this.labelTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransporte.AutoSize = true;
            this.labelTransporte.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransporte.Location = new System.Drawing.Point(6, 90);
            this.labelTransporte.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelTransporte.Name = "labelTransporte";
            this.labelTransporte.Size = new System.Drawing.Size(117, 26);
            this.labelTransporte.TabIndex = 2;
            this.labelTransporte.Text = "Transporte:";
            // 
            // labelResponsable
            // 
            this.labelResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.Location = new System.Drawing.Point(6, 128);
            this.labelResponsable.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(133, 26);
            this.labelResponsable.TabIndex = 3;
            this.labelResponsable.Text = "Responsable:";
            // 
            // labelFechaOrdenado
            // 
            this.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaOrdenado.AutoSize = true;
            this.labelFechaOrdenado.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaOrdenado.Location = new System.Drawing.Point(443, 52);
            this.labelFechaOrdenado.Name = "labelFechaOrdenado";
            this.labelFechaOrdenado.Size = new System.Drawing.Size(166, 26);
            this.labelFechaOrdenado.TabIndex = 7;
            this.labelFechaOrdenado.Text = "Fecha Ordenado:";
            // 
            // labelFechaRequerido
            // 
            this.labelFechaRequerido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaRequerido.AutoSize = true;
            this.labelFechaRequerido.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRequerido.Location = new System.Drawing.Point(443, 90);
            this.labelFechaRequerido.Name = "labelFechaRequerido";
            this.labelFechaRequerido.Size = new System.Drawing.Size(169, 26);
            this.labelFechaRequerido.TabIndex = 8;
            this.labelFechaRequerido.Text = "Fecha Requerido:";
            // 
            // labelCostoEnvio
            // 
            this.labelCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCostoEnvio.AutoSize = true;
            this.labelCostoEnvio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoEnvio.Location = new System.Drawing.Point(443, 128);
            this.labelCostoEnvio.Name = "labelCostoEnvio";
            this.labelCostoEnvio.Size = new System.Drawing.Size(153, 26);
            this.labelCostoEnvio.TabIndex = 9;
            this.labelCostoEnvio.Text = "Costo de Envío:";
            // 
            // textBoxFechaOrdenado
            // 
            this.textBoxFechaOrdenado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaOrdenado.Enabled = false;
            this.textBoxFechaOrdenado.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaOrdenado.Location = new System.Drawing.Point(619, 49);
            this.textBoxFechaOrdenado.Name = "textBoxFechaOrdenado";
            this.textBoxFechaOrdenado.ReadOnly = true;
            this.textBoxFechaOrdenado.Size = new System.Drawing.Size(224, 33);
            this.textBoxFechaOrdenado.TabIndex = 11;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27642F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72358F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxCostoEnvio, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(616, 122);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(230, 39);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // textBoxCostoEnvio
            // 
            this.textBoxCostoEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCostoEnvio.Enabled = false;
            this.textBoxCostoEnvio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostoEnvio.Location = new System.Drawing.Point(3, 3);
            this.textBoxCostoEnvio.MaxLength = 10;
            this.textBoxCostoEnvio.Name = "textBoxCostoEnvio";
            this.textBoxCostoEnvio.ReadOnly = true;
            this.textBoxCostoEnvio.Size = new System.Drawing.Size(91, 33);
            this.textBoxCostoEnvio.TabIndex = 12;
            this.textBoxCostoEnvio.Text = "0";
            this.textBoxCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.66116F));
            this.tableLayoutPanel8.Controls.Add(this.textBoxFechaRequerido, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(616, 84);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(230, 38);
            this.tableLayoutPanel8.TabIndex = 14;
            // 
            // textBoxFechaRequerido
            // 
            this.textBoxFechaRequerido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaRequerido.Enabled = false;
            this.textBoxFechaRequerido.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaRequerido.Location = new System.Drawing.Point(3, 3);
            this.textBoxFechaRequerido.Name = "textBoxFechaRequerido";
            this.textBoxFechaRequerido.ReadOnly = true;
            this.textBoxFechaRequerido.Size = new System.Drawing.Size(224, 33);
            this.textBoxFechaRequerido.TabIndex = 0;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(150, 49);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(287, 33);
            this.textBoxCliente.TabIndex = 15;
            // 
            // textBoxTransporte
            // 
            this.textBoxTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransporte.Enabled = false;
            this.textBoxTransporte.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransporte.Location = new System.Drawing.Point(150, 87);
            this.textBoxTransporte.Name = "textBoxTransporte";
            this.textBoxTransporte.ReadOnly = true;
            this.textBoxTransporte.Size = new System.Drawing.Size(287, 33);
            this.textBoxTransporte.TabIndex = 16;
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpleado.Location = new System.Drawing.Point(150, 125);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.ReadOnly = true;
            this.textBoxEmpleado.Size = new System.Drawing.Size(287, 33);
            this.textBoxEmpleado.TabIndex = 17;
            // 
            // labelPedido
            // 
            this.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelPedido.Location = new System.Drawing.Point(3, 2);
            this.labelPedido.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(144, 42);
            this.labelPedido.TabIndex = 18;
            this.labelPedido.Text = "PEDIDO:";
            // 
            // labelNumeroPedido
            // 
            this.labelNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumeroPedido.AutoSize = true;
            this.labelNumeroPedido.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedido.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelNumeroPedido.Location = new System.Drawing.Point(147, 2);
            this.labelNumeroPedido.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNumeroPedido.Name = "labelNumeroPedido";
            this.labelNumeroPedido.Size = new System.Drawing.Size(87, 42);
            this.labelNumeroPedido.TabIndex = 19;
            this.labelNumeroPedido.Text = "NNN";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewProductos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 161);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.619433F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.906882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 494);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.buttonSalir, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(315, 452);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(215, 42);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalir.BackColor = System.Drawing.Color.Orange;
            this.buttonSalir.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(5, 0);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(210, 42);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "Volver";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.ColumnHeadersHeight = 35;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowTemplate.ReadOnly = true;
            this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ShowCellErrors = false;
            this.dataGridViewProductos.ShowCellToolTips = false;
            this.dataGridViewProductos.ShowEditingIcon = false;
            this.dataGridViewProductos.ShowRowErrors = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(831, 435);
            this.dataGridViewProductos.TabIndex = 3;
            this.dataGridViewProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewProductos_RowPrePaint);
            // 
            // numero
            // 
            this.numero.HeaderText = "";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 17;
            // 
            // FrmPedidoPendienteDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "FrmPedidoPendienteDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles del Pedido";
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelCentral.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTipAgregarProducto;
        private System.Windows.Forms.ToolTip toolTipEliminarProducto;
        private System.Windows.Forms.ToolTip toolTipEditarProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelTransporte;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.Label labelFechaOrdenado;
        private System.Windows.Forms.Label labelFechaRequerido;
        private System.Windows.Forms.Label labelCostoEnvio;
        private System.Windows.Forms.TextBox textBoxFechaOrdenado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBoxCostoEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBoxFechaRequerido;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxTransporte;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Label labelNumeroPedido;
        private System.Windows.Forms.Label labelPedido;


    }
}