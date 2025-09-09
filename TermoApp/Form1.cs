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
            if(coluna > 5) return;
            var button = (Button)sender;
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
                var button = retornButton(termo.palavraAtual  -1, col + 1);
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
        }
    }
}
