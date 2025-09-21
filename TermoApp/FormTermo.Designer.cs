namespace TermoApp
{
    partial class FormTermo
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
            btnGroupBox = new GroupBox();
            lblPlacarDetalhado = new Label();
            groupBox3 = new GroupBox();
            btnReset = new Button();
            btnTema = new Button();
            label1 = new Label();
            btn65 = new Button();
            groupBox2 = new GroupBox();
            btnBackspace = new Button();
            btnEnter = new Button();
            btnM = new Button();
            btnN = new Button();
            btnB = new Button();
            btnV = new Button();
            btnC = new Button();
            btnX = new Button();
            btnZ = new Button();
            btnL = new Button();
            btnK = new Button();
            btnJ = new Button();
            btnH = new Button();
            btnG = new Button();
            btnF = new Button();
            btnD = new Button();
            btnS = new Button();
            btnA = new Button();
            btnP = new Button();
            btnO = new Button();
            btnI = new Button();
            btnU = new Button();
            btnY = new Button();
            btnT = new Button();
            btnR = new Button();
            btnE = new Button();
            btnW = new Button();
            btnQ = new Button();
            btn64 = new Button();
            btn63 = new Button();
            btn62 = new Button();
            btn61 = new Button();
            btn55 = new Button();
            btn54 = new Button();
            btn53 = new Button();
            btn52 = new Button();
            btn51 = new Button();
            btn45 = new Button();
            btn44 = new Button();
            btn43 = new Button();
            btn42 = new Button();
            btn41 = new Button();
            btn35 = new Button();
            btn34 = new Button();
            btn33 = new Button();
            btn32 = new Button();
            btn31 = new Button();
            btn25 = new Button();
            btn24 = new Button();
            btn23 = new Button();
            btn22 = new Button();
            btn21 = new Button();
            btn15 = new Button();
            btn14 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            btnGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGroupBox
            // 
            btnGroupBox.Anchor = AnchorStyles.None;
            btnGroupBox.Controls.Add(lblPlacarDetalhado);
            btnGroupBox.Controls.Add(groupBox3);
            btnGroupBox.Controls.Add(btn65);
            btnGroupBox.Controls.Add(groupBox2);
            btnGroupBox.Controls.Add(btn64);
            btnGroupBox.Controls.Add(btn63);
            btnGroupBox.Controls.Add(btn62);
            btnGroupBox.Controls.Add(btn61);
            btnGroupBox.Controls.Add(btn55);
            btnGroupBox.Controls.Add(btn54);
            btnGroupBox.Controls.Add(btn53);
            btnGroupBox.Controls.Add(btn52);
            btnGroupBox.Controls.Add(btn51);
            btnGroupBox.Controls.Add(btn45);
            btnGroupBox.Controls.Add(btn44);
            btnGroupBox.Controls.Add(btn43);
            btnGroupBox.Controls.Add(btn42);
            btnGroupBox.Controls.Add(btn41);
            btnGroupBox.Controls.Add(btn35);
            btnGroupBox.Controls.Add(btn34);
            btnGroupBox.Controls.Add(btn33);
            btnGroupBox.Controls.Add(btn32);
            btnGroupBox.Controls.Add(btn31);
            btnGroupBox.Controls.Add(btn25);
            btnGroupBox.Controls.Add(btn24);
            btnGroupBox.Controls.Add(btn23);
            btnGroupBox.Controls.Add(btn22);
            btnGroupBox.Controls.Add(btn21);
            btnGroupBox.Controls.Add(btn15);
            btnGroupBox.Controls.Add(btn14);
            btnGroupBox.Controls.Add(btn13);
            btnGroupBox.Controls.Add(btn12);
            btnGroupBox.Controls.Add(btn11);
            btnGroupBox.ForeColor = SystemColors.ControlText;
            btnGroupBox.Location = new Point(0, 7);
            btnGroupBox.Name = "btnGroupBox";
            btnGroupBox.Size = new Size(800, 877);
            btnGroupBox.TabIndex = 0;
            btnGroupBox.TabStop = false;
            // 
            // lblPlacarDetalhado
            // 
            lblPlacarDetalhado.AutoSize = true;
            lblPlacarDetalhado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacarDetalhado.Location = new Point(11, 216);
            lblPlacarDetalhado.Name = "lblPlacarDetalhado";
            lblPlacarDetalhado.Size = new Size(0, 23);
            lblPlacarDetalhado.TabIndex = 31;
            lblPlacarDetalhado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacar.ForeColor = Color.Aqua;
            lblPlacar.Location = new Point(5, 100);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(154, 44);
            lblPlacar.TabIndex = 30;
            lblPlacar.Text = "< Placar >";
            lblPlacar.Click += lblPlacar_Click;
            lblPlacar.MouseLeave += EscondePlacar;
            lblPlacar.MouseHover += DetalhaPlacar;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.Controls.Add(btnReset);
            groupBox3.Controls.Add(btnTema);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(6, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 93);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.BackgroundImage = Properties.Resources.reset;
            btnReset.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(747, 27);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 40);
            btnReset.TabIndex = 2;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnResetClick;
            // 
            // btnTema
            // 
            btnTema.BackColor = Color.Transparent;
            btnTema.BackgroundImage = Properties.Resources.DarkMode;
            btnTema.BackgroundImageLayout = ImageLayout.Stretch;
            btnTema.Cursor = Cursors.Hand;
            btnTema.FlatAppearance.BorderSize = 0;
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.Location = new Point(6, 27);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(40, 40);
            btnTema.TabIndex = 1;
            btnTema.UseVisualStyleBackColor = false;
            btnTema.Click += TrocaTema;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 33);
            label1.Name = "label1";
            label1.Size = new Size(177, 55);
            label1.TabIndex = 0;
            label1.Text = "TERMO";
            // 
            // btn65
            // 
            btn65.BackColor = Color.FromArgb(110, 92, 98);
            btn65.FlatAppearance.BorderColor = Color.Black;
            btn65.FlatAppearance.BorderSize = 2;
            btn65.FlatStyle = FlatStyle.Flat;
            btn65.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn65.ForeColor = Color.White;
            btn65.Location = new Point(525, 503);
            btn65.Margin = new Padding(0);
            btn65.Name = "btn65";
            btn65.Size = new Size(72, 72);
            btn65.TabIndex = 29;
            btn65.UseVisualStyleBackColor = false;
            btn65.Click += btnPosicaoClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(btnBackspace);
            groupBox2.Controls.Add(btnEnter);
            groupBox2.Controls.Add(btnM);
            groupBox2.Controls.Add(btnN);
            groupBox2.Controls.Add(btnB);
            groupBox2.Controls.Add(btnV);
            groupBox2.Controls.Add(btnC);
            groupBox2.Controls.Add(btnX);
            groupBox2.Controls.Add(btnZ);
            groupBox2.Controls.Add(btnL);
            groupBox2.Controls.Add(btnK);
            groupBox2.Controls.Add(btnJ);
            groupBox2.Controls.Add(btnH);
            groupBox2.Controls.Add(btnG);
            groupBox2.Controls.Add(btnF);
            groupBox2.Controls.Add(btnD);
            groupBox2.Controls.Add(btnS);
            groupBox2.Controls.Add(btnA);
            groupBox2.Controls.Add(btnP);
            groupBox2.Controls.Add(btnO);
            groupBox2.Controls.Add(btnI);
            groupBox2.Controls.Add(btnU);
            groupBox2.Controls.Add(btnY);
            groupBox2.Controls.Add(btnT);
            groupBox2.Controls.Add(btnR);
            groupBox2.Controls.Add(btnE);
            groupBox2.Controls.Add(btnW);
            groupBox2.Controls.Add(btnQ);
            groupBox2.Location = new Point(0, 587);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.FromArgb(110, 92, 98);
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBackspace.ForeColor = Color.White;
            btnBackspace.Location = new Point(679, 91);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(59, 60);
            btnBackspace.TabIndex = 28;
            btnBackspace.Text = "<=";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBack;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(110, 92, 98);
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(569, 156);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(160, 60);
            btnEnter.TabIndex = 27;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnterClick;
            // 
            // btnM
            // 
            btnM.BackColor = Color.FromArgb(110, 92, 98);
            btnM.FlatStyle = FlatStyle.Flat;
            btnM.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnM.ForeColor = Color.White;
            btnM.Location = new Point(489, 156);
            btnM.Name = "btnM";
            btnM.Size = new Size(59, 60);
            btnM.TabIndex = 26;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            btnM.Click += btnTecladoClick;
            // 
            // btnN
            // 
            btnN.BackColor = Color.FromArgb(110, 92, 98);
            btnN.FlatStyle = FlatStyle.Flat;
            btnN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnN.ForeColor = Color.White;
            btnN.Location = new Point(424, 156);
            btnN.Name = "btnN";
            btnN.Size = new Size(59, 60);
            btnN.TabIndex = 25;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            btnN.Click += btnTecladoClick;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(110, 92, 98);
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(359, 156);
            btnB.Name = "btnB";
            btnB.Size = new Size(59, 60);
            btnB.TabIndex = 24;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnTecladoClick;
            // 
            // btnV
            // 
            btnV.BackColor = Color.FromArgb(110, 92, 98);
            btnV.FlatStyle = FlatStyle.Flat;
            btnV.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnV.ForeColor = Color.White;
            btnV.Location = new Point(294, 156);
            btnV.Name = "btnV";
            btnV.Size = new Size(59, 60);
            btnV.TabIndex = 23;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            btnV.Click += btnTecladoClick;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(110, 92, 98);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(229, 156);
            btnC.Name = "btnC";
            btnC.Size = new Size(59, 60);
            btnC.TabIndex = 22;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnTecladoClick;
            // 
            // btnX
            // 
            btnX.BackColor = Color.FromArgb(110, 92, 98);
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnX.ForeColor = Color.White;
            btnX.Location = new Point(165, 156);
            btnX.Name = "btnX";
            btnX.Size = new Size(59, 60);
            btnX.TabIndex = 21;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnTecladoClick;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.FromArgb(110, 92, 98);
            btnZ.FlatStyle = FlatStyle.Flat;
            btnZ.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnZ.ForeColor = Color.White;
            btnZ.Location = new Point(99, 156);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(59, 60);
            btnZ.TabIndex = 20;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            btnZ.Click += btnTecladoClick;
            // 
            // btnL
            // 
            btnL.BackColor = Color.FromArgb(110, 92, 98);
            btnL.FlatStyle = FlatStyle.Flat;
            btnL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnL.ForeColor = Color.White;
            btnL.Location = new Point(599, 91);
            btnL.Name = "btnL";
            btnL.Size = new Size(59, 60);
            btnL.TabIndex = 19;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            btnL.Click += btnTecladoClick;
            // 
            // btnK
            // 
            btnK.BackColor = Color.FromArgb(110, 92, 98);
            btnK.FlatStyle = FlatStyle.Flat;
            btnK.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnK.ForeColor = Color.White;
            btnK.Location = new Point(534, 91);
            btnK.Name = "btnK";
            btnK.Size = new Size(59, 60);
            btnK.TabIndex = 18;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            btnK.Click += btnTecladoClick;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.FromArgb(110, 92, 98);
            btnJ.FlatStyle = FlatStyle.Flat;
            btnJ.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnJ.ForeColor = Color.White;
            btnJ.Location = new Point(469, 91);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(59, 60);
            btnJ.TabIndex = 17;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            btnJ.Click += btnTecladoClick;
            // 
            // btnH
            // 
            btnH.BackColor = Color.FromArgb(110, 92, 98);
            btnH.FlatStyle = FlatStyle.Flat;
            btnH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnH.ForeColor = Color.White;
            btnH.Location = new Point(405, 91);
            btnH.Name = "btnH";
            btnH.Size = new Size(59, 60);
            btnH.TabIndex = 16;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            btnH.Click += btnTecladoClick;
            // 
            // btnG
            // 
            btnG.BackColor = Color.FromArgb(110, 92, 98);
            btnG.FlatStyle = FlatStyle.Flat;
            btnG.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnG.ForeColor = Color.White;
            btnG.Location = new Point(339, 91);
            btnG.Name = "btnG";
            btnG.Size = new Size(59, 60);
            btnG.TabIndex = 15;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            btnG.Click += btnTecladoClick;
            // 
            // btnF
            // 
            btnF.BackColor = Color.FromArgb(110, 92, 98);
            btnF.FlatStyle = FlatStyle.Flat;
            btnF.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnF.ForeColor = Color.White;
            btnF.Location = new Point(274, 91);
            btnF.Name = "btnF";
            btnF.Size = new Size(59, 60);
            btnF.TabIndex = 14;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            btnF.Click += btnTecladoClick;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(110, 92, 98);
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(209, 91);
            btnD.Name = "btnD";
            btnD.Size = new Size(59, 60);
            btnD.TabIndex = 13;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnTecladoClick;
            // 
            // btnS
            // 
            btnS.BackColor = Color.FromArgb(110, 92, 98);
            btnS.FlatStyle = FlatStyle.Flat;
            btnS.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnS.ForeColor = Color.White;
            btnS.Location = new Point(144, 91);
            btnS.Name = "btnS";
            btnS.Size = new Size(59, 60);
            btnS.TabIndex = 12;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            btnS.Click += btnTecladoClick;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(110, 92, 98);
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(79, 91);
            btnA.Name = "btnA";
            btnA.Size = new Size(59, 60);
            btnA.TabIndex = 11;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnTecladoClick;
            // 
            // btnP
            // 
            btnP.BackColor = Color.FromArgb(110, 92, 98);
            btnP.FlatStyle = FlatStyle.Flat;
            btnP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnP.ForeColor = Color.White;
            btnP.Location = new Point(645, 27);
            btnP.Name = "btnP";
            btnP.Size = new Size(59, 60);
            btnP.TabIndex = 10;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            btnP.Click += btnTecladoClick;
            // 
            // btnO
            // 
            btnO.BackColor = Color.FromArgb(110, 92, 98);
            btnO.FlatStyle = FlatStyle.Flat;
            btnO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnO.ForeColor = Color.White;
            btnO.Location = new Point(579, 27);
            btnO.Name = "btnO";
            btnO.Size = new Size(59, 60);
            btnO.TabIndex = 9;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnTecladoClick;
            // 
            // btnI
            // 
            btnI.BackColor = Color.FromArgb(110, 92, 98);
            btnI.FlatStyle = FlatStyle.Flat;
            btnI.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnI.ForeColor = Color.White;
            btnI.Location = new Point(449, 27);
            btnI.Name = "btnI";
            btnI.Size = new Size(59, 60);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            btnI.Click += btnTecladoClick;
            // 
            // btnU
            // 
            btnU.BackColor = Color.FromArgb(110, 92, 98);
            btnU.FlatStyle = FlatStyle.Flat;
            btnU.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnU.ForeColor = Color.White;
            btnU.Location = new Point(514, 27);
            btnU.Name = "btnU";
            btnU.Size = new Size(59, 60);
            btnU.TabIndex = 7;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            btnU.Click += btnTecladoClick;
            // 
            // btnY
            // 
            btnY.BackColor = Color.FromArgb(110, 92, 98);
            btnY.FlatStyle = FlatStyle.Flat;
            btnY.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnY.ForeColor = Color.White;
            btnY.Location = new Point(384, 27);
            btnY.Name = "btnY";
            btnY.Size = new Size(59, 60);
            btnY.TabIndex = 6;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            btnY.Click += btnTecladoClick;
            // 
            // btnT
            // 
            btnT.BackColor = Color.FromArgb(110, 92, 98);
            btnT.FlatStyle = FlatStyle.Flat;
            btnT.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnT.ForeColor = Color.White;
            btnT.Location = new Point(319, 27);
            btnT.Name = "btnT";
            btnT.Size = new Size(59, 60);
            btnT.TabIndex = 5;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            btnT.Click += btnTecladoClick;
            // 
            // btnR
            // 
            btnR.BackColor = Color.FromArgb(110, 92, 98);
            btnR.FlatStyle = FlatStyle.Flat;
            btnR.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnR.ForeColor = Color.White;
            btnR.Location = new Point(254, 27);
            btnR.Name = "btnR";
            btnR.Size = new Size(59, 60);
            btnR.TabIndex = 4;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnTecladoClick;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(110, 92, 98);
            btnE.FlatStyle = FlatStyle.Flat;
            btnE.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(189, 27);
            btnE.Name = "btnE";
            btnE.Size = new Size(59, 60);
            btnE.TabIndex = 3;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnTecladoClick;
            // 
            // btnW
            // 
            btnW.BackColor = Color.FromArgb(110, 92, 98);
            btnW.FlatStyle = FlatStyle.Flat;
            btnW.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnW.ForeColor = Color.White;
            btnW.Location = new Point(123, 27);
            btnW.Name = "btnW";
            btnW.Size = new Size(59, 60);
            btnW.TabIndex = 2;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            btnW.Click += btnTecladoClick;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.FromArgb(110, 92, 98);
            btnQ.FlatStyle = FlatStyle.Flat;
            btnQ.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnQ.ForeColor = Color.White;
            btnQ.Location = new Point(59, 27);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(59, 60);
            btnQ.TabIndex = 1;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            btnQ.Click += btnTecladoClick;
            // 
            // btn64
            // 
            btn64.BackColor = Color.FromArgb(110, 92, 98);
            btn64.FlatAppearance.BorderColor = Color.Black;
            btn64.FlatAppearance.BorderSize = 2;
            btn64.FlatStyle = FlatStyle.Flat;
            btn64.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn64.ForeColor = Color.White;
            btn64.Location = new Point(451, 503);
            btn64.Margin = new Padding(0);
            btn64.Name = "btn64";
            btn64.Size = new Size(72, 72);
            btn64.TabIndex = 28;
            btn64.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn64.UseVisualStyleBackColor = false;
            btn64.Click += btnPosicaoClick;
            // 
            // btn63
            // 
            btn63.BackColor = Color.FromArgb(110, 92, 98);
            btn63.FlatAppearance.BorderColor = Color.Black;
            btn63.FlatAppearance.BorderSize = 2;
            btn63.FlatStyle = FlatStyle.Flat;
            btn63.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn63.ForeColor = Color.White;
            btn63.Location = new Point(377, 503);
            btn63.Margin = new Padding(0);
            btn63.Name = "btn63";
            btn63.Size = new Size(72, 72);
            btn63.TabIndex = 27;
            btn63.UseVisualStyleBackColor = false;
            btn63.Click += btnPosicaoClick;
            // 
            // btn62
            // 
            btn62.BackColor = Color.FromArgb(110, 92, 98);
            btn62.FlatAppearance.BorderColor = Color.Black;
            btn62.FlatAppearance.BorderSize = 2;
            btn62.FlatStyle = FlatStyle.Flat;
            btn62.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn62.ForeColor = Color.White;
            btn62.Location = new Point(303, 503);
            btn62.Margin = new Padding(0);
            btn62.Name = "btn62";
            btn62.Size = new Size(72, 72);
            btn62.TabIndex = 26;
            btn62.UseVisualStyleBackColor = false;
            btn62.Click += btnPosicaoClick;
            // 
            // btn61
            // 
            btn61.BackColor = Color.FromArgb(110, 92, 98);
            btn61.FlatAppearance.BorderColor = Color.Black;
            btn61.FlatAppearance.BorderSize = 2;
            btn61.FlatStyle = FlatStyle.Flat;
            btn61.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn61.ForeColor = Color.White;
            btn61.Location = new Point(229, 503);
            btn61.Margin = new Padding(0);
            btn61.Name = "btn61";
            btn61.Size = new Size(72, 72);
            btn61.TabIndex = 25;
            btn61.UseVisualStyleBackColor = false;
            btn61.Click += btnPosicaoClick;
            // 
            // btn55
            // 
            btn55.BackColor = Color.FromArgb(110, 92, 98);
            btn55.FlatAppearance.BorderColor = Color.Black;
            btn55.FlatAppearance.BorderSize = 2;
            btn55.FlatStyle = FlatStyle.Flat;
            btn55.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn55.ForeColor = Color.White;
            btn55.Location = new Point(525, 429);
            btn55.Margin = new Padding(0);
            btn55.Name = "btn55";
            btn55.Size = new Size(72, 72);
            btn55.TabIndex = 24;
            btn55.UseVisualStyleBackColor = false;
            btn55.Click += btnPosicaoClick;
            // 
            // btn54
            // 
            btn54.BackColor = Color.FromArgb(110, 92, 98);
            btn54.FlatAppearance.BorderColor = Color.Black;
            btn54.FlatAppearance.BorderSize = 2;
            btn54.FlatStyle = FlatStyle.Flat;
            btn54.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn54.ForeColor = Color.White;
            btn54.Location = new Point(451, 429);
            btn54.Margin = new Padding(0);
            btn54.Name = "btn54";
            btn54.Size = new Size(72, 72);
            btn54.TabIndex = 23;
            btn54.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn54.UseVisualStyleBackColor = false;
            btn54.Click += btnPosicaoClick;
            // 
            // btn53
            // 
            btn53.BackColor = Color.FromArgb(110, 92, 98);
            btn53.FlatAppearance.BorderColor = Color.Black;
            btn53.FlatAppearance.BorderSize = 2;
            btn53.FlatStyle = FlatStyle.Flat;
            btn53.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn53.ForeColor = Color.White;
            btn53.Location = new Point(377, 429);
            btn53.Margin = new Padding(0);
            btn53.Name = "btn53";
            btn53.Size = new Size(72, 72);
            btn53.TabIndex = 22;
            btn53.UseVisualStyleBackColor = false;
            btn53.Click += btnPosicaoClick;
            // 
            // btn52
            // 
            btn52.BackColor = Color.FromArgb(110, 92, 98);
            btn52.FlatAppearance.BorderColor = Color.Black;
            btn52.FlatAppearance.BorderSize = 2;
            btn52.FlatStyle = FlatStyle.Flat;
            btn52.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn52.ForeColor = Color.White;
            btn52.Location = new Point(303, 429);
            btn52.Margin = new Padding(0);
            btn52.Name = "btn52";
            btn52.Size = new Size(72, 72);
            btn52.TabIndex = 21;
            btn52.UseVisualStyleBackColor = false;
            btn52.Click += btnPosicaoClick;
            // 
            // btn51
            // 
            btn51.BackColor = Color.FromArgb(110, 92, 98);
            btn51.FlatAppearance.BorderColor = Color.Black;
            btn51.FlatAppearance.BorderSize = 2;
            btn51.FlatStyle = FlatStyle.Flat;
            btn51.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn51.ForeColor = Color.White;
            btn51.Location = new Point(229, 429);
            btn51.Margin = new Padding(0);
            btn51.Name = "btn51";
            btn51.Size = new Size(72, 72);
            btn51.TabIndex = 20;
            btn51.UseVisualStyleBackColor = false;
            btn51.Click += btnPosicaoClick;
            // 
            // btn45
            // 
            btn45.BackColor = Color.FromArgb(110, 92, 98);
            btn45.FlatAppearance.BorderColor = Color.Black;
            btn45.FlatAppearance.BorderSize = 2;
            btn45.FlatStyle = FlatStyle.Flat;
            btn45.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn45.ForeColor = Color.White;
            btn45.Location = new Point(525, 355);
            btn45.Margin = new Padding(0);
            btn45.Name = "btn45";
            btn45.Size = new Size(72, 72);
            btn45.TabIndex = 19;
            btn45.UseVisualStyleBackColor = false;
            btn45.Click += btnPosicaoClick;
            // 
            // btn44
            // 
            btn44.BackColor = Color.FromArgb(110, 92, 98);
            btn44.FlatAppearance.BorderColor = Color.Black;
            btn44.FlatAppearance.BorderSize = 2;
            btn44.FlatStyle = FlatStyle.Flat;
            btn44.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn44.ForeColor = Color.White;
            btn44.Location = new Point(451, 355);
            btn44.Margin = new Padding(0);
            btn44.Name = "btn44";
            btn44.Size = new Size(72, 72);
            btn44.TabIndex = 18;
            btn44.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn44.UseVisualStyleBackColor = false;
            btn44.Click += btnPosicaoClick;
            // 
            // btn43
            // 
            btn43.BackColor = Color.FromArgb(110, 92, 98);
            btn43.FlatAppearance.BorderColor = Color.Black;
            btn43.FlatAppearance.BorderSize = 2;
            btn43.FlatStyle = FlatStyle.Flat;
            btn43.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn43.ForeColor = Color.White;
            btn43.Location = new Point(377, 355);
            btn43.Margin = new Padding(0);
            btn43.Name = "btn43";
            btn43.Size = new Size(72, 72);
            btn43.TabIndex = 17;
            btn43.UseVisualStyleBackColor = false;
            btn43.Click += btnPosicaoClick;
            // 
            // btn42
            // 
            btn42.BackColor = Color.FromArgb(110, 92, 98);
            btn42.FlatAppearance.BorderColor = Color.Black;
            btn42.FlatAppearance.BorderSize = 2;
            btn42.FlatStyle = FlatStyle.Flat;
            btn42.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn42.ForeColor = Color.White;
            btn42.Location = new Point(303, 355);
            btn42.Margin = new Padding(0);
            btn42.Name = "btn42";
            btn42.Size = new Size(72, 72);
            btn42.TabIndex = 16;
            btn42.UseVisualStyleBackColor = false;
            btn42.Click += btnPosicaoClick;
            // 
            // btn41
            // 
            btn41.BackColor = Color.FromArgb(110, 92, 98);
            btn41.FlatAppearance.BorderColor = Color.Black;
            btn41.FlatAppearance.BorderSize = 2;
            btn41.FlatStyle = FlatStyle.Flat;
            btn41.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn41.ForeColor = Color.White;
            btn41.Location = new Point(229, 355);
            btn41.Margin = new Padding(0);
            btn41.Name = "btn41";
            btn41.Size = new Size(72, 72);
            btn41.TabIndex = 15;
            btn41.UseVisualStyleBackColor = false;
            btn41.Click += btnPosicaoClick;
            // 
            // btn35
            // 
            btn35.BackColor = Color.FromArgb(110, 92, 98);
            btn35.FlatAppearance.BorderColor = Color.Black;
            btn35.FlatAppearance.BorderSize = 2;
            btn35.FlatStyle = FlatStyle.Flat;
            btn35.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn35.ForeColor = Color.White;
            btn35.Location = new Point(525, 281);
            btn35.Margin = new Padding(0);
            btn35.Name = "btn35";
            btn35.Size = new Size(72, 72);
            btn35.TabIndex = 14;
            btn35.UseVisualStyleBackColor = false;
            btn35.Click += btnPosicaoClick;
            // 
            // btn34
            // 
            btn34.BackColor = Color.FromArgb(110, 92, 98);
            btn34.FlatAppearance.BorderColor = Color.Black;
            btn34.FlatAppearance.BorderSize = 2;
            btn34.FlatStyle = FlatStyle.Flat;
            btn34.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn34.ForeColor = Color.White;
            btn34.Location = new Point(451, 281);
            btn34.Margin = new Padding(0);
            btn34.Name = "btn34";
            btn34.Size = new Size(72, 72);
            btn34.TabIndex = 13;
            btn34.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn34.UseVisualStyleBackColor = false;
            btn34.Click += btnPosicaoClick;
            // 
            // btn33
            // 
            btn33.BackColor = Color.FromArgb(110, 92, 98);
            btn33.FlatAppearance.BorderColor = Color.Black;
            btn33.FlatAppearance.BorderSize = 2;
            btn33.FlatStyle = FlatStyle.Flat;
            btn33.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn33.ForeColor = Color.White;
            btn33.Location = new Point(377, 281);
            btn33.Margin = new Padding(0);
            btn33.Name = "btn33";
            btn33.Size = new Size(72, 72);
            btn33.TabIndex = 12;
            btn33.UseVisualStyleBackColor = false;
            btn33.Click += btnPosicaoClick;
            // 
            // btn32
            // 
            btn32.BackColor = Color.FromArgb(110, 92, 98);
            btn32.FlatAppearance.BorderColor = Color.Black;
            btn32.FlatAppearance.BorderSize = 2;
            btn32.FlatStyle = FlatStyle.Flat;
            btn32.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn32.ForeColor = Color.White;
            btn32.Location = new Point(303, 281);
            btn32.Margin = new Padding(0);
            btn32.Name = "btn32";
            btn32.Size = new Size(72, 72);
            btn32.TabIndex = 11;
            btn32.UseVisualStyleBackColor = false;
            btn32.Click += btnPosicaoClick;
            // 
            // btn31
            // 
            btn31.BackColor = Color.FromArgb(110, 92, 98);
            btn31.FlatAppearance.BorderColor = Color.Black;
            btn31.FlatAppearance.BorderSize = 2;
            btn31.FlatStyle = FlatStyle.Flat;
            btn31.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn31.ForeColor = Color.White;
            btn31.Location = new Point(229, 281);
            btn31.Margin = new Padding(0);
            btn31.Name = "btn31";
            btn31.Size = new Size(72, 72);
            btn31.TabIndex = 10;
            btn31.UseVisualStyleBackColor = false;
            btn31.Click += btnPosicaoClick;
            // 
            // btn25
            // 
            btn25.BackColor = Color.FromArgb(110, 92, 98);
            btn25.FlatAppearance.BorderColor = Color.Black;
            btn25.FlatAppearance.BorderSize = 2;
            btn25.FlatStyle = FlatStyle.Flat;
            btn25.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn25.ForeColor = Color.White;
            btn25.Location = new Point(525, 207);
            btn25.Margin = new Padding(0);
            btn25.Name = "btn25";
            btn25.Size = new Size(72, 72);
            btn25.TabIndex = 9;
            btn25.UseVisualStyleBackColor = false;
            btn25.Click += btnPosicaoClick;
            // 
            // btn24
            // 
            btn24.BackColor = Color.FromArgb(110, 92, 98);
            btn24.FlatAppearance.BorderColor = Color.Black;
            btn24.FlatAppearance.BorderSize = 2;
            btn24.FlatStyle = FlatStyle.Flat;
            btn24.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn24.ForeColor = Color.White;
            btn24.Location = new Point(451, 207);
            btn24.Margin = new Padding(0);
            btn24.Name = "btn24";
            btn24.Size = new Size(72, 72);
            btn24.TabIndex = 8;
            btn24.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn24.UseVisualStyleBackColor = false;
            btn24.Click += btnPosicaoClick;
            // 
            // btn23
            // 
            btn23.BackColor = Color.FromArgb(110, 92, 98);
            btn23.FlatAppearance.BorderColor = Color.Black;
            btn23.FlatAppearance.BorderSize = 2;
            btn23.FlatStyle = FlatStyle.Flat;
            btn23.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn23.ForeColor = Color.White;
            btn23.Location = new Point(377, 207);
            btn23.Margin = new Padding(0);
            btn23.Name = "btn23";
            btn23.Size = new Size(72, 72);
            btn23.TabIndex = 7;
            btn23.UseVisualStyleBackColor = false;
            btn23.Click += btnPosicaoClick;
            // 
            // btn22
            // 
            btn22.BackColor = Color.FromArgb(110, 92, 98);
            btn22.FlatAppearance.BorderColor = Color.Black;
            btn22.FlatAppearance.BorderSize = 2;
            btn22.FlatStyle = FlatStyle.Flat;
            btn22.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn22.ForeColor = Color.White;
            btn22.Location = new Point(303, 207);
            btn22.Margin = new Padding(0);
            btn22.Name = "btn22";
            btn22.Size = new Size(72, 72);
            btn22.TabIndex = 6;
            btn22.UseVisualStyleBackColor = false;
            btn22.Click += btnPosicaoClick;
            // 
            // btn21
            // 
            btn21.BackColor = Color.FromArgb(110, 92, 98);
            btn21.FlatAppearance.BorderColor = Color.Black;
            btn21.FlatAppearance.BorderSize = 2;
            btn21.FlatStyle = FlatStyle.Flat;
            btn21.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn21.ForeColor = Color.White;
            btn21.Location = new Point(229, 207);
            btn21.Margin = new Padding(0);
            btn21.Name = "btn21";
            btn21.Size = new Size(72, 72);
            btn21.TabIndex = 5;
            btn21.UseVisualStyleBackColor = false;
            btn21.Click += btnPosicaoClick;
            // 
            // btn15
            // 
            btn15.BackColor = Color.FromArgb(110, 92, 98);
            btn15.FlatAppearance.BorderColor = Color.Black;
            btn15.FlatAppearance.BorderSize = 2;
            btn15.FlatStyle = FlatStyle.Flat;
            btn15.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn15.ForeColor = Color.White;
            btn15.Location = new Point(525, 133);
            btn15.Margin = new Padding(0);
            btn15.Name = "btn15";
            btn15.Size = new Size(72, 72);
            btn15.TabIndex = 4;
            btn15.UseVisualStyleBackColor = false;
            btn15.Click += btnPosicaoClick;
            // 
            // btn14
            // 
            btn14.BackColor = Color.FromArgb(110, 92, 98);
            btn14.FlatAppearance.BorderColor = Color.Black;
            btn14.FlatAppearance.BorderSize = 2;
            btn14.FlatStyle = FlatStyle.Flat;
            btn14.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn14.ForeColor = Color.White;
            btn14.Location = new Point(451, 133);
            btn14.Margin = new Padding(0);
            btn14.Name = "btn14";
            btn14.Size = new Size(72, 72);
            btn14.TabIndex = 3;
            btn14.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn14.UseVisualStyleBackColor = false;
            btn14.Click += btnPosicaoClick;
            // 
            // btn13
            // 
            btn13.BackColor = Color.FromArgb(110, 92, 98);
            btn13.FlatAppearance.BorderColor = Color.Black;
            btn13.FlatAppearance.BorderSize = 2;
            btn13.FlatStyle = FlatStyle.Flat;
            btn13.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn13.ForeColor = Color.White;
            btn13.Location = new Point(377, 133);
            btn13.Margin = new Padding(0);
            btn13.Name = "btn13";
            btn13.Padding = new Padding(0, 0, 0, 3);
            btn13.Size = new Size(72, 72);
            btn13.TabIndex = 2;
            btn13.UseVisualStyleBackColor = false;
            btn13.Click += btnPosicaoClick;
            // 
            // btn12
            // 
            btn12.BackColor = Color.FromArgb(110, 92, 98);
            btn12.FlatAppearance.BorderColor = Color.Black;
            btn12.FlatAppearance.BorderSize = 2;
            btn12.FlatStyle = FlatStyle.Flat;
            btn12.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn12.ForeColor = Color.White;
            btn12.Location = new Point(303, 133);
            btn12.Margin = new Padding(0);
            btn12.Name = "btn12";
            btn12.Size = new Size(72, 72);
            btn12.TabIndex = 1;
            btn12.UseVisualStyleBackColor = false;
            btn12.Click += btnPosicaoClick;
            // 
            // btn11
            // 
            btn11.BackColor = Color.FromArgb(110, 92, 98);
            btn11.CausesValidation = false;
            btn11.FlatAppearance.BorderColor = Color.Black;
            btn11.FlatAppearance.BorderSize = 2;
            btn11.FlatStyle = FlatStyle.Flat;
            btn11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn11.ForeColor = Color.White;
            btn11.Location = new Point(229, 133);
            btn11.Margin = new Padding(0);
            btn11.Name = "btn11";
            btn11.Size = new Size(72, 72);
            btn11.TabIndex = 0;
            btn11.UseVisualStyleBackColor = false;
            btn11.Click += btnPosicaoClick;
            // 
            // FormTermo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(110, 92, 98);
            ClientSize = new Size(800, 819);
            Controls.Add(btnGroupBox);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormTermo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Termo";
            KeyDown += keyDown;
            btnGroupBox.ResumeLayout(false);
            btnGroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox btnGroupBox;
        private Button btn11;
        private Button btn15;
        private Button btn14;
        private Button btn13;
        private Button btn12;
        private Button btn65;
        private Button btn64;
        private Button btn63;
        private Button btn62;
        private Button btn61;
        private Button btn55;
        private Button btn54;
        private Button btn53;
        private Button btn52;
        private Button btn51;
        private Button btn45;
        private Button btn44;
        private Button btn43;
        private Button btn42;
        private Button btn41;
        private Button btn35;
        private Button btn34;
        private Button btn33;
        private Button btn32;
        private Button btn31;
        private Button btn25;
        private Button btn24;
        private Button btn23;
        private Button btn22;
        private Button btn21;
        private Button btnQ;
        private GroupBox groupBox2;
        private Button button9;
        private Button btnA;
        private Button btnP;
        private Button btnO;
        private Button btnI;
        private Button btnU;
        private Button btnY;
        private Button btnT;
        private Button btnR;
        private Button btnE;
        private Button btnW;
        private Button btnL;
        private Button btnK;
        private Button btnJ;
        private Button btnH;
        private Button btnG;
        private Button btnF;
        private Button btnD;
        private Button btnS;
        private Button button1;
        private Button btnM;
        private Button btnN;
        private Button btnB;
        private Button btnV;
        private Button btnC;
        private Button btnX;
        private Button btnZ;
        private Button btnBackspace;
        public Button btnEnter;
        private GroupBox groupBox3;
        private Label label1;
        private Button btnTema;
        private Button btnReset;
        private Label lblPlacarDetalhado;
    }
}
