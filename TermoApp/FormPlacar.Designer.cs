namespace TermoApp
{
    partial class FormPlacar
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
            lblPlacar = new Label();
            lblVitorias = new Label();
            lblDerrotas = new Label();
            label1 = new Label();
            lblLinha = new Label();
            SuspendLayout();
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacar.ForeColor = Color.Beige;
            lblPlacar.Location = new Point(281, 36);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(378, 81);
            lblPlacar.TabIndex = 35;
            lblPlacar.Text = "< PLACAR >";
            // 
            // lblVitorias
            // 
            lblVitorias.AutoSize = true;
            lblVitorias.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVitorias.ForeColor = Color.Lime;
            lblVitorias.Location = new Point(139, 123);
            lblVitorias.Name = "lblVitorias";
            lblVitorias.Size = new Size(264, 62);
            lblVitorias.TabIndex = 36;
            lblVitorias.Text = "-> Vitórias:";
            // 
            // lblDerrotas
            // 
            lblDerrotas.AutoSize = true;
            lblDerrotas.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDerrotas.ForeColor = Color.Red;
            lblDerrotas.Location = new Point(139, 188);
            lblDerrotas.Name = "lblDerrotas";
            lblDerrotas.Size = new Size(278, 62);
            lblDerrotas.TabIndex = 37;
            lblDerrotas.Text = "-> Derrotas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(139, 253);
            label1.Name = "label1";
            label1.Size = new Size(316, 62);
            label1.TabIndex = 38;
            label1.Text = "-> Tentativas:";
            // 
            // lblLinha
            // 
            lblLinha.AutoSize = true;
            lblLinha.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLinha.ForeColor = Color.Transparent;
            lblLinha.Location = new Point(103, 377);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(369, 62);
            lblLinha.TabIndex = 39;
            lblLinha.Text = "-------------------";
            // 
            // FormPlacar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(914, 600);
            Controls.Add(lblLinha);
            Controls.Add(label1);
            Controls.Add(lblDerrotas);
            Controls.Add(lblVitorias);
            Controls.Add(lblPlacar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPlacar";
            Text = "Form1";
            Load += FormPlacar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlacar;
        private Label lblVitorias;
        private Label lblDerrotas;
        private Label label1;
        private Label lblLinha;
    }
}