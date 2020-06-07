namespace Views.Characters
{
    partial class CharacterCreate
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
            this.tcCharacter = new System.Windows.Forms.TabControl();
            this.tpRace = new System.Windows.Forms.TabPage();
            this.btnRaceNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRaceInfo = new System.Windows.Forms.GroupBox();
            this.lblRaceCharisma = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblRaceWisdom = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblRaceIntelligence = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblRaceConstitution = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblRaceDexterity = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRaceStrength = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblRaceSpeed = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbSubrace = new System.Windows.Forms.ListBox();
            this.lbRace = new System.Windows.Forms.ListBox();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.nudMaxHP = new System.Windows.Forms.NumericUpDown();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClassPrev = new System.Windows.Forms.Button();
            this.btnClassNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbClassInfo = new System.Windows.Forms.GroupBox();
            this.lblHitDice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.ListBox();
            this.tpAbilities = new System.Windows.Forms.TabPage();
            this.lblModCha = new System.Windows.Forms.Label();
            this.lblModWis = new System.Windows.Forms.Label();
            this.lblModInt = new System.Windows.Forms.Label();
            this.lblModCon = new System.Windows.Forms.Label();
            this.lblModDex = new System.Windows.Forms.Label();
            this.lblModStr = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnAbilitiesPrev = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblTotCha = new System.Windows.Forms.Label();
            this.lblTotWis = new System.Windows.Forms.Label();
            this.lblTotInt = new System.Windows.Forms.Label();
            this.lblTotCon = new System.Windows.Forms.Label();
            this.lblTotDex = new System.Windows.Forms.Label();
            this.lblTotStr = new System.Windows.Forms.Label();
            this.lblRaBoCha = new System.Windows.Forms.Label();
            this.lblRaBoWis = new System.Windows.Forms.Label();
            this.lblRaBoInt = new System.Windows.Forms.Label();
            this.lblRaBoCon = new System.Windows.Forms.Label();
            this.lblRaBoDex = new System.Windows.Forms.Label();
            this.lblRaBoStr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCharisma = new System.Windows.Forms.NumericUpDown();
            this.nudWisdom = new System.Windows.Forms.NumericUpDown();
            this.nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this.nudConstitution = new System.Windows.Forms.NumericUpDown();
            this.nudDexterity = new System.Windows.Forms.NumericUpDown();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tcCharacter.SuspendLayout();
            this.tpRace.SuspendLayout();
            this.gbRaceInfo.SuspendLayout();
            this.tpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).BeginInit();
            this.gbClassInfo.SuspendLayout();
            this.tpAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCharacter
            // 
            this.tcCharacter.Controls.Add(this.tpRace);
            this.tcCharacter.Controls.Add(this.tpClass);
            this.tcCharacter.Controls.Add(this.tpAbilities);
            this.tcCharacter.Location = new System.Drawing.Point(12, 47);
            this.tcCharacter.Name = "tcCharacter";
            this.tcCharacter.SelectedIndex = 0;
            this.tcCharacter.Size = new System.Drawing.Size(1003, 427);
            this.tcCharacter.TabIndex = 0;
            this.tcCharacter.SelectedIndexChanged += new System.EventHandler(this.tcCharacter_SelectedIndexChanged);
            // 
            // tpRace
            // 
            this.tpRace.Controls.Add(this.btnRaceNext);
            this.tpRace.Controls.Add(this.label3);
            this.tpRace.Controls.Add(this.label2);
            this.tpRace.Controls.Add(this.label1);
            this.tpRace.Controls.Add(this.gbRaceInfo);
            this.tpRace.Controls.Add(this.lbSubrace);
            this.tpRace.Controls.Add(this.lbRace);
            this.tpRace.Location = new System.Drawing.Point(4, 25);
            this.tpRace.Name = "tpRace";
            this.tpRace.Padding = new System.Windows.Forms.Padding(3);
            this.tpRace.Size = new System.Drawing.Size(995, 398);
            this.tpRace.TabIndex = 0;
            this.tpRace.Text = "Raza";
            this.tpRace.UseVisualStyleBackColor = true;
            // 
            // btnRaceNext
            // 
            this.btnRaceNext.Location = new System.Drawing.Point(6, 368);
            this.btnRaceNext.Name = "btnRaceNext";
            this.btnRaceNext.Size = new System.Drawing.Size(75, 23);
            this.btnRaceNext.TabIndex = 6;
            this.btnRaceNext.Text = "Siguiente";
            this.btnRaceNext.UseVisualStyleBackColor = true;
            this.btnRaceNext.Click += new System.EventHandler(this.btnRaceNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "=>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sub-raza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raza";
            // 
            // gbRaceInfo
            // 
            this.gbRaceInfo.Controls.Add(this.lblRaceCharisma);
            this.gbRaceInfo.Controls.Add(this.label37);
            this.gbRaceInfo.Controls.Add(this.lblRaceWisdom);
            this.gbRaceInfo.Controls.Add(this.label35);
            this.gbRaceInfo.Controls.Add(this.lblRaceIntelligence);
            this.gbRaceInfo.Controls.Add(this.label33);
            this.gbRaceInfo.Controls.Add(this.lblRaceConstitution);
            this.gbRaceInfo.Controls.Add(this.label31);
            this.gbRaceInfo.Controls.Add(this.lblRaceDexterity);
            this.gbRaceInfo.Controls.Add(this.label29);
            this.gbRaceInfo.Controls.Add(this.lblRaceStrength);
            this.gbRaceInfo.Controls.Add(this.label27);
            this.gbRaceInfo.Controls.Add(this.lblRaceSpeed);
            this.gbRaceInfo.Controls.Add(this.label25);
            this.gbRaceInfo.Location = new System.Drawing.Point(473, 18);
            this.gbRaceInfo.Name = "gbRaceInfo";
            this.gbRaceInfo.Size = new System.Drawing.Size(245, 326);
            this.gbRaceInfo.TabIndex = 2;
            this.gbRaceInfo.TabStop = false;
            this.gbRaceInfo.Text = "Atributos raciales";
            // 
            // lblRaceCharisma
            // 
            this.lblRaceCharisma.AutoSize = true;
            this.lblRaceCharisma.Location = new System.Drawing.Point(109, 254);
            this.lblRaceCharisma.Name = "lblRaceCharisma";
            this.lblRaceCharisma.Size = new System.Drawing.Size(24, 17);
            this.lblRaceCharisma.TabIndex = 13;
            this.lblRaceCharisma.Text = "+0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 254);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 17);
            this.label37.TabIndex = 12;
            this.label37.Text = "Carisma";
            // 
            // lblRaceWisdom
            // 
            this.lblRaceWisdom.AutoSize = true;
            this.lblRaceWisdom.Location = new System.Drawing.Point(109, 220);
            this.lblRaceWisdom.Name = "lblRaceWisdom";
            this.lblRaceWisdom.Size = new System.Drawing.Size(24, 17);
            this.lblRaceWisdom.TabIndex = 11;
            this.lblRaceWisdom.Text = "+0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 220);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 17);
            this.label35.TabIndex = 10;
            this.label35.Text = "Sabiduria";
            // 
            // lblRaceIntelligence
            // 
            this.lblRaceIntelligence.AutoSize = true;
            this.lblRaceIntelligence.Location = new System.Drawing.Point(109, 186);
            this.lblRaceIntelligence.Name = "lblRaceIntelligence";
            this.lblRaceIntelligence.Size = new System.Drawing.Size(24, 17);
            this.lblRaceIntelligence.TabIndex = 9;
            this.lblRaceIntelligence.Text = "+0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 186);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(79, 17);
            this.label33.TabIndex = 8;
            this.label33.Text = "Inteligencia";
            // 
            // lblRaceConstitution
            // 
            this.lblRaceConstitution.AutoSize = true;
            this.lblRaceConstitution.Location = new System.Drawing.Point(109, 152);
            this.lblRaceConstitution.Name = "lblRaceConstitution";
            this.lblRaceConstitution.Size = new System.Drawing.Size(24, 17);
            this.lblRaceConstitution.TabIndex = 7;
            this.lblRaceConstitution.Text = "+0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 152);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 17);
            this.label31.TabIndex = 6;
            this.label31.Text = "Constitucion";
            // 
            // lblRaceDexterity
            // 
            this.lblRaceDexterity.AutoSize = true;
            this.lblRaceDexterity.Location = new System.Drawing.Point(109, 118);
            this.lblRaceDexterity.Name = "lblRaceDexterity";
            this.lblRaceDexterity.Size = new System.Drawing.Size(24, 17);
            this.lblRaceDexterity.TabIndex = 5;
            this.lblRaceDexterity.Text = "+0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 17);
            this.label29.TabIndex = 4;
            this.label29.Text = "Destreza";
            // 
            // lblRaceStrength
            // 
            this.lblRaceStrength.AutoSize = true;
            this.lblRaceStrength.Location = new System.Drawing.Point(109, 84);
            this.lblRaceStrength.Name = "lblRaceStrength";
            this.lblRaceStrength.Size = new System.Drawing.Size(24, 17);
            this.lblRaceStrength.TabIndex = 3;
            this.lblRaceStrength.Text = "+0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 84);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 17);
            this.label27.TabIndex = 2;
            this.label27.Text = "Fuerza";
            // 
            // lblRaceSpeed
            // 
            this.lblRaceSpeed.AutoSize = true;
            this.lblRaceSpeed.Location = new System.Drawing.Point(109, 37);
            this.lblRaceSpeed.Name = "lblRaceSpeed";
            this.lblRaceSpeed.Size = new System.Drawing.Size(16, 17);
            this.lblRaceSpeed.TabIndex = 1;
            this.lblRaceSpeed.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Velocidad";
            // 
            // lbSubrace
            // 
            this.lbSubrace.FormattingEnabled = true;
            this.lbSubrace.ItemHeight = 16;
            this.lbSubrace.Location = new System.Drawing.Point(250, 35);
            this.lbSubrace.Name = "lbSubrace";
            this.lbSubrace.Size = new System.Drawing.Size(188, 308);
            this.lbSubrace.Sorted = true;
            this.lbSubrace.TabIndex = 1;
            this.lbSubrace.SelectedIndexChanged += new System.EventHandler(this.lbSubrace_SelectedIndexChanged);
            // 
            // lbRace
            // 
            this.lbRace.FormattingEnabled = true;
            this.lbRace.ItemHeight = 16;
            this.lbRace.Location = new System.Drawing.Point(6, 37);
            this.lbRace.Name = "lbRace";
            this.lbRace.Size = new System.Drawing.Size(188, 308);
            this.lbRace.Sorted = true;
            this.lbRace.TabIndex = 0;
            this.lbRace.SelectedIndexChanged += new System.EventHandler(this.lbRace_SelectedIndexChanged);
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.nudMaxHP);
            this.tpClass.Controls.Add(this.cbLevel);
            this.tpClass.Controls.Add(this.label16);
            this.tpClass.Controls.Add(this.label15);
            this.tpClass.Controls.Add(this.btnClassPrev);
            this.tpClass.Controls.Add(this.btnClassNext);
            this.tpClass.Controls.Add(this.label4);
            this.tpClass.Controls.Add(this.gbClassInfo);
            this.tpClass.Controls.Add(this.lbClass);
            this.tpClass.Location = new System.Drawing.Point(4, 25);
            this.tpClass.Name = "tpClass";
            this.tpClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpClass.Size = new System.Drawing.Size(995, 398);
            this.tpClass.TabIndex = 1;
            this.tpClass.Text = "Clase";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // nudMaxHP
            // 
            this.nudMaxHP.Location = new System.Drawing.Point(729, 71);
            this.nudMaxHP.Name = "nudMaxHP";
            this.nudMaxHP.Size = new System.Drawing.Size(93, 22);
            this.nudMaxHP.TabIndex = 37;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbLevel.Location = new System.Drawing.Point(621, 28);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(102, 24);
            this.cbLevel.TabIndex = 36;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Nivel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(559, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Puntos de vida maximos:";
            // 
            // btnClassPrev
            // 
            this.btnClassPrev.Location = new System.Drawing.Point(6, 368);
            this.btnClassPrev.Name = "btnClassPrev";
            this.btnClassPrev.Size = new System.Drawing.Size(75, 23);
            this.btnClassPrev.TabIndex = 33;
            this.btnClassPrev.Text = "Anterior";
            this.btnClassPrev.UseVisualStyleBackColor = true;
            this.btnClassPrev.Click += new System.EventHandler(this.btnClassPrev_Click);
            // 
            // btnClassNext
            // 
            this.btnClassNext.Location = new System.Drawing.Point(87, 368);
            this.btnClassNext.Name = "btnClassNext";
            this.btnClassNext.Size = new System.Drawing.Size(75, 23);
            this.btnClassNext.TabIndex = 7;
            this.btnClassNext.Text = "Siguiente";
            this.btnClassNext.UseVisualStyleBackColor = true;
            this.btnClassNext.Click += new System.EventHandler(this.btnClassNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clase";
            // 
            // gbClassInfo
            // 
            this.gbClassInfo.Controls.Add(this.lblHitDice);
            this.gbClassInfo.Controls.Add(this.label13);
            this.gbClassInfo.Controls.Add(this.lblClassName);
            this.gbClassInfo.Controls.Add(this.label26);
            this.gbClassInfo.Location = new System.Drawing.Point(245, 18);
            this.gbClassInfo.Name = "gbClassInfo";
            this.gbClassInfo.Size = new System.Drawing.Size(279, 325);
            this.gbClassInfo.TabIndex = 5;
            this.gbClassInfo.TabStop = false;
            this.gbClassInfo.Text = "Atributos de clase";
            // 
            // lblHitDice
            // 
            this.lblHitDice.AutoSize = true;
            this.lblHitDice.Location = new System.Drawing.Point(149, 81);
            this.lblHitDice.Name = "lblHitDice";
            this.lblHitDice.Size = new System.Drawing.Size(0, 17);
            this.lblHitDice.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Dados de vida";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(149, 37);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(0, 17);
            this.lblClassName.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "Nombre";
            // 
            // lbClass
            // 
            this.lbClass.FormattingEnabled = true;
            this.lbClass.ItemHeight = 16;
            this.lbClass.Location = new System.Drawing.Point(11, 31);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(188, 308);
            this.lbClass.Sorted = true;
            this.lbClass.TabIndex = 4;
            this.lbClass.SelectedIndexChanged += new System.EventHandler(this.lbClass_SelectedIndexChanged);
            // 
            // tpAbilities
            // 
            this.tpAbilities.Controls.Add(this.lblModCha);
            this.tpAbilities.Controls.Add(this.lblModWis);
            this.tpAbilities.Controls.Add(this.lblModInt);
            this.tpAbilities.Controls.Add(this.lblModCon);
            this.tpAbilities.Controls.Add(this.lblModDex);
            this.tpAbilities.Controls.Add(this.lblModStr);
            this.tpAbilities.Controls.Add(this.label39);
            this.tpAbilities.Controls.Add(this.btnAbilitiesPrev);
            this.tpAbilities.Controls.Add(this.btnFinish);
            this.tpAbilities.Controls.Add(this.lblTotCha);
            this.tpAbilities.Controls.Add(this.lblTotWis);
            this.tpAbilities.Controls.Add(this.lblTotInt);
            this.tpAbilities.Controls.Add(this.lblTotCon);
            this.tpAbilities.Controls.Add(this.lblTotDex);
            this.tpAbilities.Controls.Add(this.lblTotStr);
            this.tpAbilities.Controls.Add(this.lblRaBoCha);
            this.tpAbilities.Controls.Add(this.lblRaBoWis);
            this.tpAbilities.Controls.Add(this.lblRaBoInt);
            this.tpAbilities.Controls.Add(this.lblRaBoCon);
            this.tpAbilities.Controls.Add(this.lblRaBoDex);
            this.tpAbilities.Controls.Add(this.lblRaBoStr);
            this.tpAbilities.Controls.Add(this.label11);
            this.tpAbilities.Controls.Add(this.label12);
            this.tpAbilities.Controls.Add(this.nudCharisma);
            this.tpAbilities.Controls.Add(this.nudWisdom);
            this.tpAbilities.Controls.Add(this.nudIntelligence);
            this.tpAbilities.Controls.Add(this.nudConstitution);
            this.tpAbilities.Controls.Add(this.nudDexterity);
            this.tpAbilities.Controls.Add(this.nudStrength);
            this.tpAbilities.Controls.Add(this.label10);
            this.tpAbilities.Controls.Add(this.label9);
            this.tpAbilities.Controls.Add(this.label8);
            this.tpAbilities.Controls.Add(this.label7);
            this.tpAbilities.Controls.Add(this.label6);
            this.tpAbilities.Controls.Add(this.label5);
            this.tpAbilities.Location = new System.Drawing.Point(4, 25);
            this.tpAbilities.Name = "tpAbilities";
            this.tpAbilities.Size = new System.Drawing.Size(995, 398);
            this.tpAbilities.TabIndex = 2;
            this.tpAbilities.Text = "Habilidades";
            this.tpAbilities.UseVisualStyleBackColor = true;
            // 
            // lblModCha
            // 
            this.lblModCha.AutoSize = true;
            this.lblModCha.Location = new System.Drawing.Point(864, 154);
            this.lblModCha.Name = "lblModCha";
            this.lblModCha.Size = new System.Drawing.Size(24, 17);
            this.lblModCha.TabIndex = 39;
            this.lblModCha.Text = "+0";
            // 
            // lblModWis
            // 
            this.lblModWis.AutoSize = true;
            this.lblModWis.Location = new System.Drawing.Point(731, 154);
            this.lblModWis.Name = "lblModWis";
            this.lblModWis.Size = new System.Drawing.Size(24, 17);
            this.lblModWis.TabIndex = 38;
            this.lblModWis.Text = "+0";
            // 
            // lblModInt
            // 
            this.lblModInt.AutoSize = true;
            this.lblModInt.Location = new System.Drawing.Point(599, 154);
            this.lblModInt.Name = "lblModInt";
            this.lblModInt.Size = new System.Drawing.Size(24, 17);
            this.lblModInt.TabIndex = 37;
            this.lblModInt.Text = "+0";
            // 
            // lblModCon
            // 
            this.lblModCon.AutoSize = true;
            this.lblModCon.Location = new System.Drawing.Point(465, 154);
            this.lblModCon.Name = "lblModCon";
            this.lblModCon.Size = new System.Drawing.Size(24, 17);
            this.lblModCon.TabIndex = 36;
            this.lblModCon.Text = "+0";
            // 
            // lblModDex
            // 
            this.lblModDex.AutoSize = true;
            this.lblModDex.Location = new System.Drawing.Point(332, 154);
            this.lblModDex.Name = "lblModDex";
            this.lblModDex.Size = new System.Drawing.Size(24, 17);
            this.lblModDex.TabIndex = 35;
            this.lblModDex.Text = "+0";
            // 
            // lblModStr
            // 
            this.lblModStr.AutoSize = true;
            this.lblModStr.Location = new System.Drawing.Point(199, 154);
            this.lblModStr.Name = "lblModStr";
            this.lblModStr.Size = new System.Drawing.Size(24, 17);
            this.lblModStr.TabIndex = 34;
            this.lblModStr.Text = "+0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 154);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 17);
            this.label39.TabIndex = 33;
            this.label39.Text = "Modificador";
            // 
            // btnAbilitiesPrev
            // 
            this.btnAbilitiesPrev.Location = new System.Drawing.Point(6, 371);
            this.btnAbilitiesPrev.Name = "btnAbilitiesPrev";
            this.btnAbilitiesPrev.Size = new System.Drawing.Size(75, 23);
            this.btnAbilitiesPrev.TabIndex = 32;
            this.btnAbilitiesPrev.Text = "Anterior";
            this.btnAbilitiesPrev.UseVisualStyleBackColor = true;
            this.btnAbilitiesPrev.Click += new System.EventHandler(this.btnAbilitiesPrev_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(87, 371);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 31;
            this.btnFinish.Text = "Finalizar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblTotCha
            // 
            this.lblTotCha.AutoSize = true;
            this.lblTotCha.Location = new System.Drawing.Point(864, 216);
            this.lblTotCha.Name = "lblTotCha";
            this.lblTotCha.Size = new System.Drawing.Size(16, 17);
            this.lblTotCha.TabIndex = 30;
            this.lblTotCha.Text = "0";
            // 
            // lblTotWis
            // 
            this.lblTotWis.AutoSize = true;
            this.lblTotWis.Location = new System.Drawing.Point(731, 216);
            this.lblTotWis.Name = "lblTotWis";
            this.lblTotWis.Size = new System.Drawing.Size(16, 17);
            this.lblTotWis.TabIndex = 29;
            this.lblTotWis.Text = "0";
            // 
            // lblTotInt
            // 
            this.lblTotInt.AutoSize = true;
            this.lblTotInt.Location = new System.Drawing.Point(598, 216);
            this.lblTotInt.Name = "lblTotInt";
            this.lblTotInt.Size = new System.Drawing.Size(16, 17);
            this.lblTotInt.TabIndex = 28;
            this.lblTotInt.Text = "0";
            // 
            // lblTotCon
            // 
            this.lblTotCon.AutoSize = true;
            this.lblTotCon.Location = new System.Drawing.Point(465, 216);
            this.lblTotCon.Name = "lblTotCon";
            this.lblTotCon.Size = new System.Drawing.Size(16, 17);
            this.lblTotCon.TabIndex = 27;
            this.lblTotCon.Text = "0";
            // 
            // lblTotDex
            // 
            this.lblTotDex.AutoSize = true;
            this.lblTotDex.Location = new System.Drawing.Point(332, 216);
            this.lblTotDex.Name = "lblTotDex";
            this.lblTotDex.Size = new System.Drawing.Size(16, 17);
            this.lblTotDex.TabIndex = 26;
            this.lblTotDex.Text = "0";
            // 
            // lblTotStr
            // 
            this.lblTotStr.AutoSize = true;
            this.lblTotStr.Location = new System.Drawing.Point(199, 216);
            this.lblTotStr.Name = "lblTotStr";
            this.lblTotStr.Size = new System.Drawing.Size(16, 17);
            this.lblTotStr.TabIndex = 25;
            this.lblTotStr.Text = "0";
            // 
            // lblRaBoCha
            // 
            this.lblRaBoCha.AutoSize = true;
            this.lblRaBoCha.Location = new System.Drawing.Point(864, 92);
            this.lblRaBoCha.Name = "lblRaBoCha";
            this.lblRaBoCha.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoCha.TabIndex = 24;
            this.lblRaBoCha.Text = "+0";
            // 
            // lblRaBoWis
            // 
            this.lblRaBoWis.AutoSize = true;
            this.lblRaBoWis.Location = new System.Drawing.Point(731, 92);
            this.lblRaBoWis.Name = "lblRaBoWis";
            this.lblRaBoWis.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoWis.TabIndex = 23;
            this.lblRaBoWis.Text = "+0";
            // 
            // lblRaBoInt
            // 
            this.lblRaBoInt.AutoSize = true;
            this.lblRaBoInt.Location = new System.Drawing.Point(599, 92);
            this.lblRaBoInt.Name = "lblRaBoInt";
            this.lblRaBoInt.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoInt.TabIndex = 22;
            this.lblRaBoInt.Text = "+0";
            // 
            // lblRaBoCon
            // 
            this.lblRaBoCon.AutoSize = true;
            this.lblRaBoCon.Location = new System.Drawing.Point(465, 92);
            this.lblRaBoCon.Name = "lblRaBoCon";
            this.lblRaBoCon.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoCon.TabIndex = 21;
            this.lblRaBoCon.Text = "+0";
            // 
            // lblRaBoDex
            // 
            this.lblRaBoDex.AutoSize = true;
            this.lblRaBoDex.Location = new System.Drawing.Point(332, 92);
            this.lblRaBoDex.Name = "lblRaBoDex";
            this.lblRaBoDex.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoDex.TabIndex = 20;
            this.lblRaBoDex.Text = "+0";
            // 
            // lblRaBoStr
            // 
            this.lblRaBoStr.AutoSize = true;
            this.lblRaBoStr.Location = new System.Drawing.Point(199, 92);
            this.lblRaBoStr.Name = "lblRaBoStr";
            this.lblRaBoStr.Size = new System.Drawing.Size(24, 17);
            this.lblRaBoStr.TabIndex = 19;
            this.lblRaBoStr.Text = "+0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Bonus Racial";
            // 
            // nudCharisma
            // 
            this.nudCharisma.Location = new System.Drawing.Point(867, 36);
            this.nudCharisma.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudCharisma.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCharisma.Name = "nudCharisma";
            this.nudCharisma.Size = new System.Drawing.Size(97, 22);
            this.nudCharisma.TabIndex = 16;
            this.nudCharisma.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCharisma.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // nudWisdom
            // 
            this.nudWisdom.Location = new System.Drawing.Point(734, 36);
            this.nudWisdom.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudWisdom.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWisdom.Name = "nudWisdom";
            this.nudWisdom.Size = new System.Drawing.Size(97, 22);
            this.nudWisdom.TabIndex = 15;
            this.nudWisdom.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWisdom.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // nudIntelligence
            // 
            this.nudIntelligence.Location = new System.Drawing.Point(601, 36);
            this.nudIntelligence.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudIntelligence.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudIntelligence.Name = "nudIntelligence";
            this.nudIntelligence.Size = new System.Drawing.Size(97, 22);
            this.nudIntelligence.TabIndex = 14;
            this.nudIntelligence.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudIntelligence.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // nudConstitution
            // 
            this.nudConstitution.Location = new System.Drawing.Point(468, 36);
            this.nudConstitution.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudConstitution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudConstitution.Name = "nudConstitution";
            this.nudConstitution.Size = new System.Drawing.Size(97, 22);
            this.nudConstitution.TabIndex = 13;
            this.nudConstitution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudConstitution.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // nudDexterity
            // 
            this.nudDexterity.Location = new System.Drawing.Point(335, 36);
            this.nudDexterity.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudDexterity.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDexterity.Name = "nudDexterity";
            this.nudDexterity.Size = new System.Drawing.Size(97, 22);
            this.nudDexterity.TabIndex = 12;
            this.nudDexterity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDexterity.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(202, 36);
            this.nudStrength.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudStrength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(97, 22);
            this.nudStrength.TabIndex = 11;
            this.nudStrength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudStrength.ValueChanged += new System.EventHandler(this.UpdateAbilitiesInfo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(879, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "CARISMA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "SABIDURIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "INTELIGENCIA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "CONSTITUCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "DESTREZA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "FUERZA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nombre:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(344, 22);
            this.tbName.TabIndex = 2;
            // 
            // CharacterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 483);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tcCharacter);
            this.Name = "CharacterCreate";
            this.Text = "CharacterCreate";
            this.tcCharacter.ResumeLayout(false);
            this.tpRace.ResumeLayout(false);
            this.tpRace.PerformLayout();
            this.gbRaceInfo.ResumeLayout(false);
            this.gbRaceInfo.PerformLayout();
            this.tpClass.ResumeLayout(false);
            this.tpClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).EndInit();
            this.gbClassInfo.ResumeLayout(false);
            this.gbClassInfo.PerformLayout();
            this.tpAbilities.ResumeLayout(false);
            this.tpAbilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcCharacter;
        private System.Windows.Forms.TabPage tpRace;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.TabPage tpAbilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRaceInfo;
        private System.Windows.Forms.ListBox lbSubrace;
        private System.Windows.Forms.ListBox lbRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbClassInfo;
        private System.Windows.Forms.ListBox lbClass;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCharisma;
        private System.Windows.Forms.NumericUpDown nudWisdom;
        private System.Windows.Forms.NumericUpDown nudIntelligence;
        private System.Windows.Forms.NumericUpDown nudConstitution;
        private System.Windows.Forms.NumericUpDown nudDexterity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRaceNext;
        private System.Windows.Forms.Button btnClassPrev;
        private System.Windows.Forms.Button btnClassNext;
        private System.Windows.Forms.Button btnAbilitiesPrev;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblTotCha;
        private System.Windows.Forms.Label lblTotWis;
        private System.Windows.Forms.Label lblTotInt;
        private System.Windows.Forms.Label lblTotCon;
        private System.Windows.Forms.Label lblTotDex;
        private System.Windows.Forms.Label lblTotStr;
        private System.Windows.Forms.Label lblRaBoCha;
        private System.Windows.Forms.Label lblRaBoWis;
        private System.Windows.Forms.Label lblRaBoInt;
        private System.Windows.Forms.Label lblRaBoCon;
        private System.Windows.Forms.Label lblRaBoDex;
        private System.Windows.Forms.Label lblRaBoStr;
        private System.Windows.Forms.Label lblRaceCharisma;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblRaceWisdom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblRaceIntelligence;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblRaceConstitution;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblRaceDexterity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRaceStrength;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblRaceSpeed;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblModCha;
        private System.Windows.Forms.Label lblModWis;
        private System.Windows.Forms.Label lblModInt;
        private System.Windows.Forms.Label lblModCon;
        private System.Windows.Forms.Label lblModDex;
        private System.Windows.Forms.Label lblModStr;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblHitDice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudMaxHP;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}