using TermoLib;
using System.Media;
namespace TermoApp

{
    public partial class FormTermo : Form
    {
        public Termo termo;
        public TemaForm tema;
        SoundPlayer player;
        int coluna;
        int[] placar;
        public FormTermo()
        {
            termo = new Termo();
            tema = new TemaForm();
            coluna = 1;
            placar = new int[7];
            InitializeComponent();
            InicializaTema();
            btnGroupBox.Paint += (s, e) => e.Graphics.Clear(btnGroupBox.BackColor);
            groupBox2.Paint += (s, e) => e.Graphics.Clear(groupBox2.BackColor);
            groupBox3.Paint += (s, e) => e.Graphics.Clear(groupBox3.BackColor);
            this.KeyPreview = true;
            this.ActiveControl = label1;
        }

        private void InicializaTema()
        {
            this.BackColor = tema.formBackground;
            label1.ForeColor = tema.formFontColor;
            btnTema.BackgroundImage = tema.img;
            btnTema.BackColor = tema.formBackground;
            lblPlacar.ForeColor = tema.formFontColor;
            lblPlacarDetalhado.ForeColor = tema.formFontColor;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    var button = retornButton(i, j);
                    if (i < termo.palavraAtual)
                    {
                        var letra = termo.tabuleiro[i - 1][j - 1];
                        button.BackColor = btnTabVefCor(letra.cor);
                        button.FlatAppearance.BorderColor = btnTabVefCor(letra.cor);
                    }
                    else
                    {
                        if (i == termo.palavraAtual)
                        {
                            button.BackColor = tema.tabuleiroAtivo;
                            button.FlatAppearance.BorderColor = tema.tabuleiroP;
                        }
                        else
                        {
                            button.BackColor = tema.tabuleiroDefault;
                            button.FlatAppearance.BorderColor = tema.tabuleiroDefault;
                        }
                    }
                    button.ForeColor = tema.tabuleiroFontColor;
                }
            }

            for (int i = 65; i <= 90; i++)
            {
                var button = (Button)Controls.Find($"btn{(char)i}", true)[0];
                button.BackColor = btnTecVefCor(termo.teclado[(char)i]);
                button.FlatAppearance.BorderSize = 0;
            }

            btnEnter.BackColor = tema.tecladoDefault;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnBackspace.BackColor = tema.tecladoDefault;
            btnBackspace.FlatAppearance.BorderSize = 0;

        }

        public void btnTecladoClick(object sender, EventArgs e)
        {
            TocarSom(sender, e);
            if ((coluna > 5) || (termo.vitoria == true)) return;
            var button = (Button)sender;
            if (button.BackColor == tema.tecladoP) return;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;

            coluna++;
        }

        public void btnEnterClick(object sender, EventArgs e)
        {
            if (termo.vitoria) return;
            string palavra = "";

            for (int i = 1; i <= 5; i++)
            {
                var button = retornButton(termo.palavraAtual, i);
                palavra += button.Text;
            }

            if (palavra.Length < 5)
            {
                MostrarAviso("A palavra deve ter 5 letras!", true, 2000);
                return;
            }
            else
            {
                termo.ChecaPalavra(palavra);
                AtualizaTabuleiro();
                AtualizaTeclado();
                coluna = 1;

                if(termo.palavraAtual <= 6 && !termo.vitoria)
                {
                    for(int i = 1; i <=5; i++)
                    {
                        var button = retornButton(termo.palavraAtual, i);
                        button.BackColor = tema.tabuleiroAtivo;
                        button.FlatAppearance.BorderColor = tema.tabuleiroP;
                    }
                }

                if (termo.vitoria)
                {
                    MostrarAviso("Parabéns! Você acertou a palavra!", true, 3000);
                    placar[termo.palavraAtual - 2]++;
                    player = new SoundPlayer(Properties.Resources.vitoria);
                    player.Play();
                }
                else if (termo.palavraAtual == 7)
                {
                    MostrarAviso($"Que pena! A palavra era {termo.palavraSorteada}.", true, 3000);
                    placar[6]++;
                }

                AtualizaPlacar();
            }
        }

        private void AtualizaPlacar()
        {
            int count = 0;
            int vit = 0;

            lblPlacar.Text = "Placar:\n";
            for (int i = 0; i < 7; i++)
            {
                if (i < 6)
                {
                    count += placar[i];
                    vit += placar[i];
                }
                else
                {
                    count += placar[i];
                    lblPlacar.Text += $"Vitórias: {vit}\n";
                    lblPlacar.Text += $"Derrotas: {placar[i]}\n";
                    lblPlacar.Text += $"Total de jogos: {count}\n";
                }
            }
        }

        public void DetalhaPlacar(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                lblPlacarDetalhado.Text += $"{i + 1} tentativa: {placar[i]}\n";
            }
        }

        public void EscondePlacar(object sender, EventArgs e)
        {
            lblPlacarDetalhado.Text = "";
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
                button.BackColor = btnTabVefCor(letra.cor);
                button.FlatAppearance.BorderColor = btnTabVefCor(letra.cor);
            }
        }

        public void AtualizaTeclado()
        {
            foreach (var key in termo.teclado.Keys)
            {
                var nomeButton = $"btn{key}";
                var button = Controls.Find(nomeButton, true)[0];
                button.BackColor = btnTecVefCor(termo.teclado[key]);
            }
        }

        private Color btnTabVefCor(char letra)
        {
            return letra switch
            {
                'V' => tema.tabuleiroV,
                'A' => tema.tabuleiroA,
                _ => tema.tabuleiroP,
            };
        }

        private Color btnTecVefCor(char letra)
        {
            return letra switch
            {
                'V' => tema.tecladoV,
                'A' => tema.tecladoA,
                'P' => tema.tecladoP,
                _ => tema.tecladoDefault,
            };
        }

        private void MostrarAviso(string mensagem, bool autoclose, int duracao)
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

            aviso.Location = new Point((this.Location.X) + this.Width / 2 - (aviso.ClientSize.Width / 2), this.Location.Y + aviso.Height);
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            if (autoclose)
            {
                t.Interval = duracao;
                t.Tick += (s, e) =>
                {
                    t.Stop();
                    aviso.Close();
                };
            }
            t.Start();

            aviso.Show();
        }

        public void btnResetClick(object sender, EventArgs e)
        {
            termo = new Termo();
            coluna = 1;

            foreach(var element in btnGroupBox.Controls)
            {
                if (element is Button button)
                {
                    button.Text = "";
                }
            }

            InicializaTema();
        }

        public void btnPosicaoClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int posx = (int)(btn.Name[4]) - 48;
            int posy = (int)(btn.Name[3]) - 48;
            if (termo.palavraAtual == posy){
                coluna = posx;
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            var tecla = e.KeyCode.ToString();
            if (tecla.Length == 1 && char.IsLetter(tecla[0]))
            {
                var button = Controls.Find($"btn{tecla}", true)[0];
                btnTecladoClick(button, new EventArgs());
            }
            if (tecla == "Back")
            {
                btnBack(btnBackspace, new EventArgs());
            }
        }

        public void TrocaTema(object sender, EventArgs e)
        {
            if (tema.temaStyle == "Dark")
            {
                tema.TemaLight();
            }
            else
            {
                tema.TemaDark();
            }
            InicializaTema();
        }

        private void TocarSom(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.keyboard);
            player.Play();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & Keys.KeyCode;
            if (key == Keys.Enter)
            {
                btnEnterClick(btnEnter, new EventArgs());
                return true;
            }
            if (key == Keys.Left)
            {
                if (coluna > 1) coluna--;
                return true;
            }
            if (key == Keys.Right)
            {
                if (coluna < 6) coluna++;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
