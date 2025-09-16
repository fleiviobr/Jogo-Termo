using System.Security.Cryptography;
using System.Windows.Forms;
using TermoLib;
using static System.Windows.Forms.AxHost;

namespace TelaTermo
{
    public partial class Form1 : Form
    {
        public Termo termo;
        public List<Label> tabuleiro;
        public List<Button> teclas;
        public string[] rowOne = new string[] { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
        public string[] rowTwo = new string[] { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
        public string[] rowThree = new string[] { "Z", "X", "C", "V", "B", "N", "M" };
        public int x = 200;
        public int y = 350;
        public int Labelx = 200;
        public int Labely = 50;
        public int sizeButton = 60;
        public int marginButton = 6;


        public Form1()
        {
            InitializeComponent();
            termo = new Termo();
            tabuleiro = new List<Label>();
            teclas = new List<Button>();

            createKeyboard(rowOne, 1);
            createKeyboard(rowTwo, 2);
            createKeyboard(rowThree, 3);

            createBoard(1);

            foreach (var tecla in termo.teclado)
            {
                foreach (var btn in teclas)
                {
                    if (btn.Text == tecla.Key.ToString())
                    {
                        btn.BackColor = colorButton(tecla.Value);
                    }
                }
            }
        }

        private Color colorButton(char color)
        {
            return (color == 'C') ? Color.DimGray : (color == 'V') ? Color.LimeGreen : (color == 'A') ? Color.Gold : Color.DimGray;
        }

        private Button configButton(int i)
        {
            Button btn = new Button();

            return btn;
        }

        public void createKeyboard(string[] keys, int row)
        {
            int posX = x + ((sizeButton * (row - 1)) / 2);
            int posY = y + row * (sizeButton + 10);
            for (int i = 0; i < keys.Length; i++)
            {
                Button btn = new Button();
                btn.Text = keys[i];
                btn.Height = sizeButton;
                btn.Width = sizeButton;
                btn.Location = new Point(posX, posY);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.FlatAppearance.BorderSize = 0;

                teclas.Add(btn);
                this.Controls.Add(btn);

                posX += btn.Width + 10;
            }
        }

        public void createBoard(int row)
        {
            int posX = Labelx + ((sizeButton * (row - 1)) / 2);
            int posY = Labely + row * (sizeButton + 10);
            for (int i = 0; i < 5; i++)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
                label.Location = new Point(posX, posY);
                label.Name = "label";
                label.Size = new Size(sizeButton, sizeButton);
                label.TabIndex = 1;
                label.BackColor = Color.White;
                label.Text = " ";
                label.BorderStyle = BorderStyle.FixedSingle;

                tabuleiro.Add(label);
                this.Controls.Add(label);

                posX += label.Width + 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }
    }
}
