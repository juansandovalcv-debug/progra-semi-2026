namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            lblDe = new Label();
            lblA = new Label();
            txtCantidad = new Label();
            textBox3 = new TextBox();
            lblRespuesta = new Label();
            cboDe = new ComboBox();
            cboA = new ComboBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(285, 307);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(177, 73);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDe.Location = new Point(96, 69);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(32, 20);
            lblDe.TabIndex = 1;
            lblDe.Text = "de:";
            lblDe.Click += label1_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(396, 69);
            lblA.Name = "lblA";
            lblA.Size = new Size(23, 20);
            lblA.TabIndex = 3;
            lblA.Text = "a:";
            // 
            // txtCantidad
            // 
            txtCantidad.AutoSize = true;
            txtCantidad.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(96, 195);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(81, 20);
            txtCantidad.TabIndex = 5;
            txtCantidad.Text = "cantidad:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(396, 195);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(100, 20);
            lblRespuesta.TabIndex = 7;
            lblRespuesta.Text = "respuesta: ?";
            // 
            // cboDe
            // 
            cboDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDe.FormattingEnabled = true;
            cboDe.Items.AddRange(new object[] { "Metros", "Cm ", "Pulgadas ", "Pies", "Varas", "Yardas", "Km", "Millas " });
            cboDe.Location = new Point(133, 66);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(151, 28);
            cboDe.TabIndex = 8;
            // 
            // cboA
            // 
            cboA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboA.FormattingEnabled = true;
            cboA.Items.AddRange(new object[] { "Metros", "Cm ", "Pulgadas ", "Pies", "Varas", "Yardas", "Km", "Millas " });
            cboA.Location = new Point(425, 66);
            cboA.Name = "cboA";
            cboA.Size = new Size(151, 28);
            cboA.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboA);
            Controls.Add(cboDe);
            Controls.Add(lblRespuesta);
            Controls.Add(textBox3);
            Controls.Add(txtCantidad);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblDe;
        private Label lblA;
        private Label txtCantidad;
        private TextBox textBox3;
        private Label lblRespuesta;
        private ComboBox cboDe;
        private ComboBox cboA;
    }
}
