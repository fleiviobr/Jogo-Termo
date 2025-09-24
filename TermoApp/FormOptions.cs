using static System.Windows.Forms.LinkLabel;

namespace TermoApp
{
    public partial class FormOptions : Form
    {
        public TemaForm tema;
        private FormTermo formTermo;
        public FormOptions(string result, FormTermo formTermo)
        {
            InitializeComponent();
            tema = formTermo.tema;
            this.formTermo = formTermo;

            InicializaTema();
            barProgress();

            if (result == "placar")
            {
                exibePlacar();
            }
            if (result == "win")
            {
                resultWin();
            }
            if(result == "lose")
            {
                resultLose();
            }
        }

        private void exibePlacar()
        {
            Label lblWin = new Label();
            lblWin.Text = "Progresso";
            lblWin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWin.ForeColor = tema.formFontColor;
            lblWin.Width = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Width;
            lblWin.Height = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Height;
            lblWin.Location = new Point(((this.ClientSize.Width - lblWin.Width) / 2), 40);
            this.Controls.Add(lblWin);

            Button btnPlayAgain = new Button();
            btnPlayAgain.Text = "Fechar";
            btnPlayAgain.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = tema.formFontColor;
            btnPlayAgain.BackColor = tema.tecladoV;
            btnPlayAgain.Width = 500;
            btnPlayAgain.Height = 50;
            btnPlayAgain.Location = new Point(((this.ClientSize.Width - btnPlayAgain.Width) / 2), barBox.Bottom + 30);
            btnPlayAgain.Click += ClosePlacar;
            this.Controls.Add(btnPlayAgain);
        }

        private void InicializaTema()
        {
            this.BackColor = tema.formEndBackground;
            lblPercentual.ForeColor = tema.formFontColor;
            lblTotalJogos.ForeColor = tema.formFontColor;
            lblSub.ForeColor = tema.formFontColor;
            lblPr1.ForeColor = tema.formFontColor;
            lblPr2.ForeColor = tema.formFontColor;
            lblPr3.ForeColor = tema.formFontColor;
            lblPr4.ForeColor = tema.formFontColor;
            lblPr5.ForeColor = tema.formFontColor;
            lblPr6.ForeColor = tema.formFontColor;
        }

        private void barProgress()
        {
            int valorTotal = 0;
            int value = 0;

            for (int i = 0; i < 7; i++)
            {
                valorTotal += formTermo.placar[i];
            }
            for (int i = 1; i <= 7; i++)
            {
                ProgressBar bar = (ProgressBar)Controls.Find($"Bar{i}", true)[0];
                bar.Maximum = valorTotal;
                bar.Value = value + formTermo.placar[i - 1];
            }

            lblTotalJogos.Text = valorTotal.ToString() + "\n Total de jogos";

            if (valorTotal == 0)
            {
                lblPercentual.Text = "0%";
            }
            else
            {
                double percentual = ((double)(valorTotal - formTermo.placar[6]) / valorTotal) * 100;
                lblPercentual.Text = $"{Math.Round(percentual, 2)}%";
            }
            lblPercentual.Text += "\n Percentual de vitórias";
        }

        public void resultWin()
        {
            Label lblWin = new Label();
            lblWin.Text = "Parabéns! Você venceu!";
            lblWin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWin.ForeColor = tema.formFontColor;
            lblWin.Width = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Width;
            lblWin.Height = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Height;
            lblWin.Location = new Point(((this.ClientSize.Width - lblWin.Width) / 2), 40);
            this.Controls.Add(lblWin);

            Button btnPlayAgain = new Button();
            btnPlayAgain.Text = "Jogar Novamente";
            btnPlayAgain.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = tema.formFontColor;
            btnPlayAgain.BackColor = tema.tecladoV;
            btnPlayAgain.Width = 500;
            btnPlayAgain.Height = 50;
            btnPlayAgain.Location = new Point(((this.ClientSize.Width - btnPlayAgain.Width) / 2), barBox.Bottom + 30);
            btnPlayAgain.Click += PlayAgain;
            this.Controls.Add(btnPlayAgain);
        }

        public void resultLose()
        {
            Label lblWin = new Label();
            lblWin.Text = "Que tristeza! Você errou!";
            lblWin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWin.ForeColor = tema.formFontColor;
            lblWin.Width = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Width;
            lblWin.Height = TextRenderer.MeasureText(lblWin.Text, lblWin.Font).Height;
            lblWin.Location = new Point(((this.ClientSize.Width - lblWin.Width) / 2), 40);
            this.Controls.Add(lblWin);

            Label lblPalavra = new Label();
            lblPalavra.Text = $"A palavra era {formTermo.termo.palavraSorteada}";
            lblPalavra.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPalavra.ForeColor = tema.tecladoV;
            lblPalavra.Width = TextRenderer.MeasureText(lblPalavra.Text, lblPalavra.Font).Width;
            lblPalavra.Height = TextRenderer.MeasureText(lblPalavra.Text, lblPalavra.Font).Height;
            lblPalavra.Location = new Point(((this.ClientSize.Width - lblPalavra.Width) / 2), 100);
            this.Controls.Add(lblPalavra);

            Button btnPlayAgain = new Button();
            btnPlayAgain.Text = "Jogar Novamente";
            btnPlayAgain.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = tema.formFontColor;
            btnPlayAgain.BackColor = tema.tecladoV;
            btnPlayAgain.Width = 500;
            btnPlayAgain.Height = 50;
            btnPlayAgain.Location = new Point(((this.ClientSize.Width - btnPlayAgain.Width) / 2), barBox.Bottom + 30);
            btnPlayAgain.Click += PlayAgain;
            this.Controls.Add(btnPlayAgain);
        }

        public void PlayAgain(object sender, EventArgs e)
        {
            formTermo.btnResetClick(sender, e);
            this.Close();
        }
        public void ClosePlacar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
