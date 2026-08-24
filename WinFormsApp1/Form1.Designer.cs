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
            lblSerie = new Label();
            txtSerie = new TextBox();
            ltsValores = new ListBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(62, 57);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(43, 20);
            lblSerie.TabIndex = 0;
            lblSerie.Text = "serie:";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(128, 54);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(125, 27);
            txtSerie.TabIndex = 1;
            // 
            // ltsValores
            // 
            ltsValores.FormattingEnabled = true;
            ltsValores.Location = new Point(93, 211);
            ltsValores.Name = "ltsValores";
            ltsValores.Size = new Size(150, 104);
            ltsValores.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(457, 211);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(198, 104);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcesar);
            Controls.Add(ltsValores);
            Controls.Add(txtSerie);
            Controls.Add(lblSerie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSerie;
        private TextBox txtSerie;
        private ListBox ltsValores;
        private Button btnProcesar;
    }
}
