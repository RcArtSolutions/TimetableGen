namespace Rca.TtGen
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_Or8Driver = new System.Windows.Forms.TextBox();
            this.txt_OrtDriver = new System.Windows.Forms.TextBox();
            this.txt_Ore8Driver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ORE8 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.cmb_FinCnt = new System.Windows.Forms.ComboBox();
            this.rb_AdditionalFinals = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_GroupSize = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WaitOre8 = new System.Windows.Forms.TextBox();
            this.txt_WaitOrt = new System.Windows.Forms.TextBox();
            this.txt_WaitOr8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ChangeTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DurationOre8SubFin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DurationOrtSubFin = new System.Windows.Forms.TextBox();
            this.txt_DurationOr8Fin = new System.Windows.Forms.TextBox();
            this.txt_DurationOr8SubFin = new System.Windows.Forms.TextBox();
            this.txt_DurationOrtFin = new System.Windows.Forms.TextBox();
            this.txt_DurationOre8HalfFin = new System.Windows.Forms.TextBox();
            this.txt_DurationOre8Fin = new System.Windows.Forms.TextBox();
            this.txt_DurationOrtHalfFin = new System.Windows.Forms.TextBox();
            this.txt_DurationOr8HalfFin = new System.Windows.Forms.TextBox();
            this.cbx_AddLastFinal = new System.Windows.Forms.CheckBox();
            this.txt_StartTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Timetable = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ORE8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(12, 418);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(319, 35);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Zeitplan erstellen";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_Or8Driver
            // 
            this.txt_Or8Driver.Location = new System.Drawing.Point(15, 33);
            this.txt_Or8Driver.Name = "txt_Or8Driver";
            this.txt_Or8Driver.Size = new System.Drawing.Size(76, 20);
            this.txt_Or8Driver.TabIndex = 2;
            this.txt_Or8Driver.Text = "12";
            // 
            // txt_OrtDriver
            // 
            this.txt_OrtDriver.Location = new System.Drawing.Point(121, 33);
            this.txt_OrtDriver.Name = "txt_OrtDriver";
            this.txt_OrtDriver.Size = new System.Drawing.Size(76, 20);
            this.txt_OrtDriver.TabIndex = 5;
            this.txt_OrtDriver.Text = "34";
            // 
            // txt_Ore8Driver
            // 
            this.txt_Ore8Driver.Location = new System.Drawing.Point(227, 33);
            this.txt_Ore8Driver.Name = "txt_Ore8Driver";
            this.txt_Ore8Driver.Size = new System.Drawing.Size(76, 20);
            this.txt_Ore8Driver.TabIndex = 6;
            this.txt_Ore8Driver.Text = "56";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starter OR8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Starter ORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Starter ORE8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Or8Driver);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_OrtDriver);
            this.groupBox1.Controls.Add(this.txt_Ore8Driver);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ORE8);
            this.groupBox2.Controls.Add(this.cmb_GroupSize);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbx_AddLastFinal);
            this.groupBox2.Controls.Add(this.txt_StartTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 331);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einstellungen";
            // 
            // ORE8
            // 
            this.ORE8.Controls.Add(this.radioButton3);
            this.ORE8.Controls.Add(this.cmb_FinCnt);
            this.ORE8.Controls.Add(this.rb_AdditionalFinals);
            this.ORE8.Controls.Add(this.label14);
            this.ORE8.Location = new System.Drawing.Point(8, 246);
            this.ORE8.Name = "ORE8";
            this.ORE8.Size = new System.Drawing.Size(303, 78);
            this.ORE8.TabIndex = 1;
            this.ORE8.TabStop = false;
            this.ORE8.Text = "ORE8 (Reglement 2016)";
            this.toolTip1.SetToolTip(this.ORE8, "Diese Einstellungen sind nur für die Klasse\r\nORE8 gültig");
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Aufsteiger Klassisch";
            this.toolTip1.SetToolTip(this.radioButton3, "Klassischer Verbrenner-Aufsteiger-\r\nModus ohne Zusatzfinale");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // cmb_FinCnt
            // 
            this.cmb_FinCnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FinCnt.FormattingEnabled = true;
            this.cmb_FinCnt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_FinCnt.Location = new System.Drawing.Point(136, 48);
            this.cmb_FinCnt.Name = "cmb_FinCnt";
            this.cmb_FinCnt.Size = new System.Drawing.Size(42, 21);
            this.cmb_FinCnt.TabIndex = 38;
            this.toolTip1.SetToolTip(this.cmb_FinCnt, "Endfinale Wiederholen, ein Durchgang ist\r\nnur bei schlechten Wetter zulässig\r\n(Re" +
        "glement 2016)");
            // 
            // rb_AdditionalFinals
            // 
            this.rb_AdditionalFinals.AutoSize = true;
            this.rb_AdditionalFinals.Location = new System.Drawing.Point(141, 22);
            this.rb_AdditionalFinals.Name = "rb_AdditionalFinals";
            this.rb_AdditionalFinals.Size = new System.Drawing.Size(148, 17);
            this.rb_AdditionalFinals.TabIndex = 4;
            this.rb_AdditionalFinals.Text = "Aufsteiger mit Zusatzfinale";
            this.toolTip1.SetToolTip(this.rb_AdditionalFinals, "Nichtaufsteiger (auch der Sub-Fianle) werden\r\nin Zusatzfinale Eingeteilt (Regleme" +
        "nt 2016)");
            this.rb_AdditionalFinals.UseVisualStyleBackColor = true;
            this.rb_AdditionalFinals.CheckedChanged += new System.EventHandler(this.rb_AdditionaFinals_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Finale Wiederholungen";
            this.toolTip1.SetToolTip(this.label14, "Endfinale Wiederholen, ein Durchgang ist");
            // 
            // cmb_GroupSize
            // 
            this.cmb_GroupSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GroupSize.FormattingEnabled = true;
            this.cmb_GroupSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "15"});
            this.cmb_GroupSize.Location = new System.Drawing.Point(78, 35);
            this.cmb_GroupSize.Name = "cmb_GroupSize";
            this.cmb_GroupSize.Size = new System.Drawing.Size(74, 21);
            this.cmb_GroupSize.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_WaitOre8);
            this.groupBox3.Controls.Add(this.txt_WaitOrt);
            this.groupBox3.Controls.Add(this.txt_WaitOr8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_ChangeTime);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_DurationOre8SubFin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_DurationOrtSubFin);
            this.groupBox3.Controls.Add(this.txt_DurationOr8Fin);
            this.groupBox3.Controls.Add(this.txt_DurationOr8SubFin);
            this.groupBox3.Controls.Add(this.txt_DurationOrtFin);
            this.groupBox3.Controls.Add(this.txt_DurationOre8HalfFin);
            this.groupBox3.Controls.Add(this.txt_DurationOre8Fin);
            this.groupBox3.Controls.Add(this.txt_DurationOrtHalfFin);
            this.groupBox3.Controls.Add(this.txt_DurationOr8HalfFin);
            this.groupBox3.Location = new System.Drawing.Point(8, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 174);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finalzeiten in Minuten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Wartezeit";
            // 
            // txt_WaitOre8
            // 
            this.txt_WaitOre8.Enabled = false;
            this.txt_WaitOre8.Location = new System.Drawing.Point(218, 111);
            this.txt_WaitOre8.Name = "txt_WaitOre8";
            this.txt_WaitOre8.Size = new System.Drawing.Size(61, 20);
            this.txt_WaitOre8.TabIndex = 34;
            // 
            // txt_WaitOrt
            // 
            this.txt_WaitOrt.Enabled = false;
            this.txt_WaitOrt.Location = new System.Drawing.Point(151, 111);
            this.txt_WaitOrt.Name = "txt_WaitOrt";
            this.txt_WaitOrt.Size = new System.Drawing.Size(61, 20);
            this.txt_WaitOrt.TabIndex = 33;
            // 
            // txt_WaitOr8
            // 
            this.txt_WaitOr8.Enabled = false;
            this.txt_WaitOr8.Location = new System.Drawing.Point(84, 111);
            this.txt_WaitOr8.Name = "txt_WaitOr8";
            this.txt_WaitOr8.Size = new System.Drawing.Size(61, 20);
            this.txt_WaitOr8.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Wechselzeit (zw. Laufende und -start)";
            this.toolTip1.SetToolTip(this.label13, "Wechselzeit zwischen den einzelnen Läufen");
            // 
            // txt_ChangeTime
            // 
            this.txt_ChangeTime.Location = new System.Drawing.Point(218, 144);
            this.txt_ChangeTime.Name = "txt_ChangeTime";
            this.txt_ChangeTime.Size = new System.Drawing.Size(61, 20);
            this.txt_ChangeTime.TabIndex = 31;
            this.txt_ChangeTime.Text = "5";
            this.toolTip1.SetToolTip(this.txt_ChangeTime, "Wechselzeit zwischen den einzelnen Läufen\r\n(Laufende bis Start des nächsten Final" +
        "e)");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Subfinale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fianle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Halbfinale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "OR8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ORT";
            // 
            // txt_DurationOre8SubFin
            // 
            this.txt_DurationOre8SubFin.Location = new System.Drawing.Point(218, 85);
            this.txt_DurationOre8SubFin.Name = "txt_DurationOre8SubFin";
            this.txt_DurationOre8SubFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOre8SubFin.TabIndex = 27;
            this.txt_DurationOre8SubFin.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ORE8";
            // 
            // txt_DurationOrtSubFin
            // 
            this.txt_DurationOrtSubFin.Location = new System.Drawing.Point(151, 85);
            this.txt_DurationOrtSubFin.Name = "txt_DurationOrtSubFin";
            this.txt_DurationOrtSubFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOrtSubFin.TabIndex = 26;
            this.txt_DurationOrtSubFin.Text = "15";
            // 
            // txt_DurationOr8Fin
            // 
            this.txt_DurationOr8Fin.Location = new System.Drawing.Point(84, 33);
            this.txt_DurationOr8Fin.Name = "txt_DurationOr8Fin";
            this.txt_DurationOr8Fin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOr8Fin.TabIndex = 19;
            this.txt_DurationOr8Fin.Text = "45";
            // 
            // txt_DurationOr8SubFin
            // 
            this.txt_DurationOr8SubFin.Location = new System.Drawing.Point(84, 85);
            this.txt_DurationOr8SubFin.Name = "txt_DurationOr8SubFin";
            this.txt_DurationOr8SubFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOr8SubFin.TabIndex = 25;
            this.txt_DurationOr8SubFin.Text = "15";
            // 
            // txt_DurationOrtFin
            // 
            this.txt_DurationOrtFin.Location = new System.Drawing.Point(151, 33);
            this.txt_DurationOrtFin.Name = "txt_DurationOrtFin";
            this.txt_DurationOrtFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOrtFin.TabIndex = 20;
            this.txt_DurationOrtFin.Text = "30";
            // 
            // txt_DurationOre8HalfFin
            // 
            this.txt_DurationOre8HalfFin.Location = new System.Drawing.Point(218, 59);
            this.txt_DurationOre8HalfFin.Name = "txt_DurationOre8HalfFin";
            this.txt_DurationOre8HalfFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOre8HalfFin.TabIndex = 24;
            this.txt_DurationOre8HalfFin.Text = "10";
            // 
            // txt_DurationOre8Fin
            // 
            this.txt_DurationOre8Fin.Location = new System.Drawing.Point(218, 33);
            this.txt_DurationOre8Fin.Name = "txt_DurationOre8Fin";
            this.txt_DurationOre8Fin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOre8Fin.TabIndex = 21;
            this.txt_DurationOre8Fin.Text = "10";
            // 
            // txt_DurationOrtHalfFin
            // 
            this.txt_DurationOrtHalfFin.Location = new System.Drawing.Point(151, 59);
            this.txt_DurationOrtHalfFin.Name = "txt_DurationOrtHalfFin";
            this.txt_DurationOrtHalfFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOrtHalfFin.TabIndex = 23;
            this.txt_DurationOrtHalfFin.Text = "15";
            // 
            // txt_DurationOr8HalfFin
            // 
            this.txt_DurationOr8HalfFin.Location = new System.Drawing.Point(84, 59);
            this.txt_DurationOr8HalfFin.Name = "txt_DurationOr8HalfFin";
            this.txt_DurationOr8HalfFin.Size = new System.Drawing.Size(61, 20);
            this.txt_DurationOr8HalfFin.TabIndex = 22;
            this.txt_DurationOr8HalfFin.Text = "30";
            // 
            // cbx_AddLastFinal
            // 
            this.cbx_AddLastFinal.AutoSize = true;
            this.cbx_AddLastFinal.Checked = true;
            this.cbx_AddLastFinal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_AddLastFinal.Location = new System.Drawing.Point(171, 37);
            this.cbx_AddLastFinal.Name = "cbx_AddLastFinal";
            this.cbx_AddLastFinal.Size = new System.Drawing.Size(138, 17);
            this.cbx_AddLastFinal.TabIndex = 13;
            this.cbx_AddLastFinal.Text = "Finale zusammenfassen";
            this.toolTip1.SetToolTip(this.cbx_AddLastFinal, "Kleinstes Finale (A+B) zusammenfassen,wenn\r\nGruppengröße nicht überschritten wird" +
        "");
            this.cbx_AddLastFinal.UseVisualStyleBackColor = true;
            // 
            // txt_StartTime
            // 
            this.txt_StartTime.Location = new System.Drawing.Point(17, 36);
            this.txt_StartTime.Mask = "90:00";
            this.txt_StartTime.Name = "txt_StartTime";
            this.txt_StartTime.Size = new System.Drawing.Size(44, 20);
            this.txt_StartTime.TabIndex = 12;
            this.txt_StartTime.Text = "1300";
            this.txt_StartTime.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Startzeit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gruppengröße";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Timetable);
            this.groupBox4.Location = new System.Drawing.Point(340, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 445);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zeitplan";
            // 
            // dgv_Timetable
            // 
            this.dgv_Timetable.AllowUserToOrderColumns = true;
            this.dgv_Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Timetable.Location = new System.Drawing.Point(7, 17);
            this.dgv_Timetable.Name = "dgv_Timetable";
            this.dgv_Timetable.ReadOnly = true;
            this.dgv_Timetable.RowHeadersVisible = false;
            this.dgv_Timetable.Size = new System.Drawing.Size(379, 420);
            this.dgv_Timetable.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 500);
            this.MinimumSize = new System.Drawing.Size(760, 500);
            this.Name = "MainView";
            this.Text = "VT - Zeitplan-Generator - v0.33beta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ORE8.ResumeLayout(false);
            this.ORE8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_Or8Driver;
        private System.Windows.Forms.TextBox txt_OrtDriver;
        private System.Windows.Forms.TextBox txt_Ore8Driver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_StartTime;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_AdditionalFinals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbx_AddLastFinal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DurationOre8SubFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DurationOrtSubFin;
        private System.Windows.Forms.TextBox txt_DurationOr8Fin;
        private System.Windows.Forms.TextBox txt_DurationOr8SubFin;
        private System.Windows.Forms.TextBox txt_DurationOrtFin;
        private System.Windows.Forms.TextBox txt_DurationOre8HalfFin;
        private System.Windows.Forms.TextBox txt_DurationOre8Fin;
        private System.Windows.Forms.TextBox txt_DurationOrtHalfFin;
        private System.Windows.Forms.TextBox txt_DurationOr8HalfFin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ChangeTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_Timetable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_WaitOre8;
        private System.Windows.Forms.TextBox txt_WaitOrt;
        private System.Windows.Forms.TextBox txt_WaitOr8;
        private System.Windows.Forms.ComboBox cmb_FinCnt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_GroupSize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox ORE8;
    }
}

