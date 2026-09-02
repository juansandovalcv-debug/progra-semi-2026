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

        #region 

        private void InitializeComponent()
        {
            txtMonto = new TextBox();
            label1 = new Label();
            lblRespuesta = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "monto de actividad economica:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(260, 37);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 27);
            txtMonto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(30, 90);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 40);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRespuesta.Location = new Point(30, 160);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(160, 25);
            lblRespuesta.TabIndex = 3;
            lblRespuesta.Text = "valor a pagar: ??";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 230);
            Controls.Add(lblRespuesta);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impuesto a Actividades Económicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private Label label1;
        private Label lblRespuesta;
        private Button btnCalcular;
    }
}
