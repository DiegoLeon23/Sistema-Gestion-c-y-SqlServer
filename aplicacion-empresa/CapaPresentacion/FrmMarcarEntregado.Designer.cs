namespace CapaPresentacion
{
    partial class FrmMarcarEntregado
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonHoy = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHoy = new System.Windows.Forms.TextBox();
            this.dateTimePickerMarcarFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59136F));
            this.tableLayoutPanel2.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(80, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(403, 75);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(5, 24);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(395, 26);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NNN";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHoy
            // 
            this.buttonHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHoy.BackColor = System.Drawing.Color.Orange;
            this.buttonHoy.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoy.Location = new System.Drawing.Point(188, 38);
            this.buttonHoy.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoy.Name = "buttonHoy";
            this.buttonHoy.Size = new System.Drawing.Size(215, 37);
            this.buttonHoy.TabIndex = 3;
            this.buttonHoy.Text = "Hoy";
            this.buttonHoy.UseVisualStyleBackColor = false;
            this.buttonHoy.Click += new System.EventHandler(this.buttonHoy_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFecha.BackColor = System.Drawing.Color.Orange;
            this.buttonFecha.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecha.Location = new System.Drawing.Point(188, 0);
            this.buttonFecha.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(215, 38);
            this.buttonFecha.TabIndex = 1;
            this.buttonFecha.Text = "Fecha";
            this.buttonFecha.UseVisualStyleBackColor = false;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonHoy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHoy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerMarcarFecha, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 75);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxHoy
            // 
            this.textBoxHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHoy.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoy.Location = new System.Drawing.Point(3, 41);
            this.textBoxHoy.Name = "textBoxHoy";
            this.textBoxHoy.ReadOnly = true;
            this.textBoxHoy.Size = new System.Drawing.Size(182, 32);
            this.textBoxHoy.TabIndex = 2;
            // 
            // dateTimePickerMarcarFecha
            // 
            this.dateTimePickerMarcarFecha.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMarcarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMarcarFecha.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerMarcarFecha.Name = "dateTimePickerMarcarFecha";
            this.dateTimePickerMarcarFecha.Size = new System.Drawing.Size(182, 32);
            this.dateTimePickerMarcarFecha.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.entregado;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 75);
            this.panel1.TabIndex = 1;
            // 
            // FrmMarcarEntregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 194);
            this.Name = "FrmMarcarEntregado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marcar Pedido Pendiente como Entregado";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.Button buttonHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxHoy;
        private System.Windows.Forms.DateTimePicker dateTimePickerMarcarFecha;

    }
}