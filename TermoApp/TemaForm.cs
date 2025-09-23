namespace TermoApp
{
    public class TemaForm
    {
        public String temaStyle;
        public Image img;

        public Color formBackground;
        public Color formFontColor;

        public Color formEndBackground;
        public Font placarFont;

        public Color tabuleiroBackground;
        public Color tabuleiroFontColor;
        public Color tabuleiroV;
        public Color tabuleiroA;
        public Color tabuleiroP;
        public Color tabuleiroAtivo;
        public Color tabuleiroDefault;

        public Color tecladoBackground;
        public Color tecladoV;
        public Color tecladoA;
        public Color tecladoP;
        public Color tecladoDefault;

        public Color avisoBackground;

        public TemaForm()
        {
            this.temaStyle = "Dark";
            Inicializa();
            TemaLight();

        }

        private void Inicializa()
        {
            placarFont = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        public void TemaLight()
        {
            this.temaStyle = "Light";
            this.img = Properties.Resources.DarkMode;
            this.formBackground = ColorTranslator.FromHtml("#6E5C62");
            this.formFontColor = ColorTranslator.FromHtml("#ffffff");

            this.formEndBackground = ColorTranslator.FromHtml("#312B2D");

            this.tabuleiroBackground = ColorTranslator.FromHtml("#6E5C62");
            this.tabuleiroFontColor = ColorTranslator.FromHtml("#ffffff");
            this.tabuleiroV = ColorTranslator.FromHtml("#3aa394");
            this.tabuleiroA = ColorTranslator.FromHtml("#d3ad69");
            this.tabuleiroP = ColorTranslator.FromHtml("#312a2c");
            this.tabuleiroAtivo = ColorTranslator.FromHtml("#6E5C62");
            this.tabuleiroDefault = ColorTranslator.FromHtml("#615458");

            this.tecladoBackground = ColorTranslator.FromHtml("#4C4347");
            this.tecladoV = ColorTranslator.FromHtml("#3aa394");
            this.tecladoA = ColorTranslator.FromHtml("#d3ad69");
            this.tecladoP = ColorTranslator.FromHtml("#594B4F");
            this.tecladoDefault = ColorTranslator.FromHtml("#4C4347");

            this.avisoBackground = ColorTranslator.FromHtml("#009AFE");
        }

        public void TemaDark()
        {
            this.temaStyle = "Dark";
            this.img = Properties.Resources.LightMode;
            this.formBackground = ColorTranslator.FromHtml("#212121");
            this.formFontColor = ColorTranslator.FromHtml("#ffffff");

            this.formEndBackground = ColorTranslator.FromHtml("#1A1A1A");

            this.tabuleiroBackground = ColorTranslator.FromHtml("#212121");
            this.tabuleiroFontColor = ColorTranslator.FromHtml("#ffffff");
            this.tabuleiroV = ColorTranslator.FromHtml("#3aa394");
            this.tabuleiroA = ColorTranslator.FromHtml("#d3ad69");
            this.tabuleiroP = ColorTranslator.FromHtml("#525252");
            this.tabuleiroAtivo = ColorTranslator.FromHtml("#212121");
            this.tabuleiroDefault = ColorTranslator.FromHtml("#111111");

            this.tecladoBackground = ColorTranslator.FromHtml("#4C4347");
            this.tecladoV = ColorTranslator.FromHtml("#3aa394");
            this.tecladoA = ColorTranslator.FromHtml("#d3ad69");
            this.tecladoP = ColorTranslator.FromHtml("#525252");
            this.tecladoDefault = ColorTranslator.FromHtml("#3a3a3c");

            this.avisoBackground = ColorTranslator.FromHtml("#009AFE");
        }
    }
}
