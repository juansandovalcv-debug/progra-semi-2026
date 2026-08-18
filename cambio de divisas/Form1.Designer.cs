namespace cambio_de_divisas
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
            lblOrigen = new Label();
            lblConvertir = new Label();
            lblCantidad = new Label();
            cbOrigen = new ComboBox();
            cbConvertida = new ComboBox();
            tbCantidad = new TextBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(54, 84);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(105, 20);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "divisa original:";
            // 
            // lblConvertir
            // 
            lblConvertir.AutoSize = true;
            lblConvertir.Location = new Point(479, 84);
            lblConvertir.Name = "lblConvertir";
            lblConvertir.Size = new Size(124, 20);
            lblConvertir.TabIndex = 1;
            lblConvertir.Text = "divisa a convertir:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(119, 293);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "cantidad:";
            // 
            // cbOrigen
            // 
            cbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Items.AddRange(new object[] { "DOLAR EEUU ", "EUROS", "LIBRAS ESTERLINAS", "PESOS MEXICANOS ", "PESOS ARGENTINOS", "PESOS COLOMBIANOS", "YEN JAPONES", "YUAN CHINO " });
            cbOrigen.Location = new Point(165, 81);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(151, 28);
            cbOrigen.TabIndex = 3;
            // 
            // cbConvertida
            // 
            cbConvertida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConvertida.FormattingEnabled = true;
            cbConvertida.Items.AddRange(new object[] { "DOLAR EEUU ", "EUROS", "LIBRAS ESTERLINAS", "PESOS MEXICANOS ", "PESOS ARGENTINOS", "PESOS COLOMBIANOS", "YEN JAPONES", "YUAN CHINO " });
            cbConvertida.Location = new Point(609, 81);
            cbConvertida.Name = "cbConvertida";
            cbConvertida.Size = new Size(151, 28);
            cbConvertida.TabIndex = 4;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(195, 290);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(125, 27);
            tbCantidad.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(574, 293);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "resultado: ??";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(340, 380);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(175, 48);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 493);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(tbCantidad);
            Controls.Add(cbConvertida);
            Controls.Add(cbOrigen);
            Controls.Add(lblCantidad);
            Controls.Add(lblConvertir);
            Controls.Add(lblOrigen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private Label lblConvertir;
        private Label lblCantidad;
        private ComboBox cbOrigen;
        private ComboBox cbConvertida;
        private TextBox tbCantidad;
        private Label lblResultado;
        private Button btnCalcular;
    }
}
