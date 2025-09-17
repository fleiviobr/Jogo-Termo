using TermoLib;
namespace TermoApp
{
    public partial class Form1 : Form
    {
        public Termo termo;
        int coluna = 1;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Paint += (s, e) => e.Graphics.Clear(groupBox1.BackColor);
            groupBox2.Paint += (s, e) => e.Graphics.Clear(groupBox2.BackColor);
            termo = new Termo();
            this.KeyPreview = true;
        }

        public void btnTecladoClick(object sender, EventArgs e)
        {
            if (coluna > 5) return;
            var button = (Button)sender;
            if (button.BackColor == ColorTranslator.FromHtml("#504a4b")) return;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;

            coluna++;
        }

        public void btnEnterClick(object sender, EventArgs e)
        {
            string palavra = "";

            for (int i = 1; i <= 5; i++)
            {
                var button = retornButton(termo.palavraAtual, i);
                palavra += button.Text;
            }

            if (palavra.Length < 5)
            {
                MostrarAviso("A palavra deve ter 5 letras!");
                return;
            }
            else
            {
                termo.ChecaPalavra(palavra);
                AtualizaTabuleiro();
                AtualizaTeclado();
                coluna = 1;
            }
        }

        public void btnBack(object sender, EventArgs e)
        {
            if (coluna == 1) return;
            coluna--;
            var button = retornButton(termo.palavraAtual, coluna);
            button.Text = "";
        }

        private Button retornButton(int linha, int coluna)
        {
            var nomeButton = $"btn{linha}{coluna}";
            var button = Controls.Find(nomeButton, true)[0];
            return (Button)button;
        }

        public void AtualizaTabuleiro()
        {
            for (int col = 0; col < 5; col++)
            {
                var letra = termo.tabuleiro[termo.palavraAtual - 2][col];
                var button = retornButton(termo.palavraAtual - 1, col + 1);
                button.BackColor = letra.cor switch
                {
                    'V' => ColorTranslator.FromHtml("#3aa394"),
                    'A' => ColorTranslator.FromHtml("#d3ad69"),
                    _ => ColorTranslator.FromHtml("#312a2c"),
                };
            }
        }

        public void AtualizaTeclado()
        {
            foreach (var key in termo.teclado.Keys)
            {
                var nomeButton = $"btn{key}";
                var button = Controls.Find(nomeButton, true)[0];
                button.BackColor = termo.teclado[key] switch
                {
                    'V' => ColorTranslator.FromHtml("#3aa394"),
                    'A' => ColorTranslator.FromHtml("#d3ad69"),
                    'P' => ColorTranslator.FromHtml("#504a4b"),
                    _ => ColorTranslator.FromHtml("#6e5c62"),
                };
            }
        }

        private void MostrarAviso(string mensagem)
        {
            Form aviso = new Form();
            aviso.FormBorderStyle = FormBorderStyle.None;
            aviso.StartPosition = FormStartPosition.Manual;
            aviso.BackColor = Color.DarkBlue;
            aviso.ForeColor = Color.White;
            aviso.TopMost = true;
            aviso.ShowInTaskbar = false;

            Label lbl = new Label()
            {
                Text = mensagem,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };

            aviso.Controls.Add(lbl);
            aviso.ClientSize = new Size(lbl.Width + 20, lbl.Height + 20);

            // posição fixa (pode calcular em cima do botão)
            aviso.Location = new Point((this.Width/2) - (aviso.ClientSize.Width/2), 100);

            // Timer para fechar sozinho
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 2000;
            t.Tick += (s, e) =>
            {
                t.Stop();
                aviso.Close();
            };
            t.Start();

            aviso.Show();
        }
       
        private void keyDown(object sender, KeyEventArgs e)
        {
            var tecla = e.KeyCode.ToString();
            if (tecla.Length == 1 && char.IsLetter(tecla[0]))
            {
                var button = Controls.Find($"btn{tecla}", true)[0];
                btnTecladoClick(button, new EventArgs());
            }
            else if (tecla == "Back")
            {
                btnBack(btnBackspace, new EventArgs());
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & Keys.KeyCode;
            if (key == Keys.Enter)
            {
                btnEnterClick(btnEnter, new EventArgs());
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
