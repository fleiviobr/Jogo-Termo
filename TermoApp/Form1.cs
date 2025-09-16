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
            termo = new Termo();
        }

        public void btnTecladoClick(object sender, EventArgs e)
        {
            if (coluna > 5) return;
            var button = (Button)sender;
            if (button.BackColor == Color.Gray) return;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;

            coluna++;
        }

        public void btnEnterClick(object sender, EventArgs e)
        {
            string palavra = "";

            for(int i = 1; i <= 5; i++)
            {
                var button = retornButton(termo.palavraAtual, i);
                palavra += button.Text;
            }
            termo.ChecaPalavra(palavra);
            AtualizaTabuleiro();
            AtualizaTeclado();
            coluna = 1;
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
                    'V' => Color.Green,
                    'A' => Color.Yellow,
                    _ => Color.Gray,
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
                    'V' => Color.Green,
                    'A' => Color.Yellow,
                    'P' => Color.Gray,
                    _ => SystemColors.Control,
                };
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            var tecla = e.KeyCode.ToString();
            if(tecla.Length == 1 && char.IsLetter(tecla[0]))
            {
                var button = Controls.Find($"btn{tecla}", true)[0];
                btnTecladoClick(button, new EventArgs());
            }
            else if(tecla == "Back")
            {
                btnBack(btnBackspace, new EventArgs());
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnEnterClick(btnEnter, new EventArgs());
            }
        }
    }
}
