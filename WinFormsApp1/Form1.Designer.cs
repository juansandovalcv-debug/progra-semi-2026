namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabMonto = new TabPage();
            label1 = new Label();
            txtMonto = new TextBox();
            btnCalcular = new Button();
            lblRespuesta = new Label();
            tabArea = new TabPage();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            cboDe = new ComboBox();
            label4 = new Label();
            cboA = new ComboBox();
            btnConvertir = new Button();
            lblResultadoArea = new Label();
            tabControl1.SuspendLayout();
            tabMonto.SuspendLayout();
            tabArea.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMonto);
            tabControl1.Controls.Add(tabArea);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(520, 270);
            tabControl1.TabIndex = 0;
            // 
            // tabMonto
            // 
            tabMonto.Controls.Add(label1);
            tabMonto.Controls.Add(txtMonto);
            tabMonto.Controls.Add(btnCalcular);
            tabMonto.Controls.Add(lblRespuesta);
            tabMonto.Location = new Point(4, 29);
            tabMonto.Name = "tabMonto";
            tabMonto.Padding = new Padding(3);
            tabMonto.Size = new Size(512, 237);
            tabMonto.TabIndex = 0;
            tabMonto.Text = "monto economico";
            tabMonto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "monto de actividad economica:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(245, 27);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 27);
            txtMonto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(20, 80);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 38);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblRespuesta.Location = new Point(20, 145);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(150, 25);
            lblRespuesta.TabIndex = 3;
            lblRespuesta.Text = "valor a pagar: ??";
            // 
            // tabArea
            // 
            tabArea.Controls.Add(label2);
            tabArea.Controls.Add(txtCantidad);
            tabArea.Controls.Add(label3);
            tabArea.Controls.Add(cboDe);
            tabArea.Controls.Add(label4);
            tabArea.Controls.Add(cboA);
            tabArea.Controls.Add(btnConvertir);
            tabArea.Controls.Add(lblResultadoArea);
            tabArea.Location = new Point(4, 29);
            tabArea.Name = "tabArea";
            tabArea.Padding = new Padding(3);
            tabArea.Size = new Size(512, 237);
            tabArea.TabIndex = 1;
            tabArea.Text = "conversor de Area";
            tabArea.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 25);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(98, 22);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(130, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 2;
            label3.Text = "De:";
            // 
            // cboDe
            // 
            cboDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDe.FormattingEnabled = true;
            cboDe.Items.AddRange(new object[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" });
            cboDe.Location = new Point(58, 67);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(170, 28);
            cboDe.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 70);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 4;
            label4.Text = "A:";
            // 
            // cboA
            // 
            cboA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboA.FormattingEnabled = true;
            cboA.Items.AddRange(new object[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" });
            cboA.Location = new Point(285, 67);
            cboA.Name = "cboA";
            cboA.Size = new Size(170, 28);
            cboA.TabIndex = 5;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(20, 118);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(120, 38);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoArea
            // 
            lblResultadoArea.AutoSize = true;
            lblResultadoArea.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblResultadoArea.Location = new Point(20, 175);
            lblResultadoArea.Name = "lblResultadoArea";
            lblResultadoArea.Size = new Size(130, 25);
            lblResultadoArea.TabIndex = 7;
            lblResultadoArea.Text = "Resultado: ??";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 270);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impuesto a Actividades Económicas";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabMonto.ResumeLayout(false);
            tabMonto.PerformLayout();
            tabArea.ResumeLayout(false);
            tabArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMonto;
        private TabPage tabArea;
        private TextBox txtMonto;
        private Label label1;
        private Label lblRespuesta;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private ComboBox cboDe;
        private Label label4;
        private ComboBox cboA;
        private Button btnConvertir;
        private Label lblResultadoArea;
    }
}
