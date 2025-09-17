namespace TermoLib
{
    public class Letra
    {
        public char caracter;
        public char cor;
        public Letra(char caracter, char cor)
        {
            this.caracter = caracter;
            this.cor = cor;
        }
    }
    public class Termo
    {
        public List<string> palavras;
        public string palavraSorteada;
        public List<List<Letra>> tabuleiro;
        public Dictionary<char, char> teclado;
        public int palavraAtual;

        public Termo()
        {
            CarregaPalavras("palavras.txt");
            palavraAtual = 1;
            SorteiaPalavra();
            tabuleiro = new List<List<Letra>>();
            teclado = new Dictionary<char, char>();
            for(int i = 65; i <= 90; i++)
            {
                //C - Não digitado | V - Posição correta | A - Posição errada | P - Não faz parte
                teclado.Add((char)i, 'C');
            }
        }

        public void CarregaPalavras(string fileName)
        {
            palavras = File.ReadAllLines(fileName).ToList();
        }

        public void SorteiaPalavra()
        {
            Random rdn = new Random();
            var index = rdn.Next(palavras.Count - 1);
            palavraSorteada = palavras[index];
        }

        public void ChecaPalavra(string palavra)
        {
            if(palavra.Length != 5)
            {
                throw new Exception("A palavra deve ter 5 letras.");
            }
            var palavraTabuleiro = new List<Letra>();
            char cor;
            for (int i = 0; i < palavra.Length; i++)
            {
               var letra = new Dictionary<char, char>();
                if (palavra[i] == palavraSorteada[i])
                {
                   cor = 'V';
                }
                else if (palavraSorteada.Contains(palavra[i]))
                {
                    cor = 'A';
                }
                else
                {
                    cor = 'P';
                }

                if (teclado[palavra[i]] != 'V')
                {
                    teclado[palavra[i]] = cor;
                }
                palavraTabuleiro.Add(new Letra(palavra[i], cor));
                
            }
            tabuleiro.Add(palavraTabuleiro);
            palavraAtual++;
        }
    }
}
