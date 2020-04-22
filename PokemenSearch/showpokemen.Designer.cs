namespace PokemenSearch
{
    partial class showpokemen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showpokemen));
            this.AfterSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type1 = new System.Windows.Forms.ComboBox();
            this.Type2 = new System.Windows.Forms.ComboBox();
            this.ZS = new System.Windows.Forms.TextBox();
            this.TX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SD = new System.Windows.Forms.ComboBox();
            this.pokename = new System.Windows.Forms.Label();
            this.PHP = new System.Windows.Forms.TextBox();
            this.PAtk = new System.Windows.Forms.TextBox();
            this.PDef = new System.Windows.Forms.TextBox();
            this.PSpa = new System.Windows.Forms.TextBox();
            this.PSpf = new System.Windows.Forms.TextBox();
            this.PSpe = new System.Windows.Forms.TextBox();
            this.HHP = new System.Windows.Forms.TextBox();
            this.HAtk = new System.Windows.Forms.TextBox();
            this.HDef = new System.Windows.Forms.TextBox();
            this.HSpa = new System.Windows.Forms.TextBox();
            this.HSpf = new System.Windows.Forms.TextBox();
            this.HSpe = new System.Windows.Forms.TextBox();
            this.RHP = new System.Windows.Forms.TextBox();
            this.RAtk = new System.Windows.Forms.TextBox();
            this.RDef = new System.Windows.Forms.TextBox();
            this.RSpa = new System.Windows.Forms.TextBox();
            this.RSpf = new System.Windows.Forms.TextBox();
            this.RSpe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Rsum = new System.Windows.Forms.Label();
            this.Hsum = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.rss = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.pokehead = new System.Windows.Forms.Label();
            this.level11 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ZSt = new System.Windows.Forms.Button();
            this.ZSlist1 = new System.Windows.Forms.GroupBox();
            this.CLEAR = new System.Windows.Forms.Button();
            this.sortra = new System.Windows.Forms.CheckBox();
            this.evfield = new System.Windows.Forms.Label();
            this.typel = new System.Windows.Forms.Label();
            this.egggroup = new System.Windows.Forms.Label();
            this.TXp = new System.Windows.Forms.Label();
            this.TXM = new System.Windows.Forms.Label();
            this.sorttag = new System.Windows.Forms.ComboBox();
            this.ZSlist1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AfterSearch
            // 
            this.AfterSearch.FormattingEnabled = true;
            this.AfterSearch.Location = new System.Drawing.Point(47, 50);
            this.AfterSearch.Name = "AfterSearch";
            this.AfterSearch.Size = new System.Drawing.Size(100, 20);
            this.AfterSearch.TabIndex = 0;
            this.AfterSearch.SelectedIndexChanged += new System.EventHandler(this.AfterSearch_SelectedIndexChanged);
            this.AfterSearch.TextChanged += new System.EventHandler(this.AfterSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "匹配此类型的宝可梦";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "属性1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "属性2:";
            // 
            // Type1
            // 
            this.Type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type1.FormattingEnabled = true;
            this.Type1.Items.AddRange(new object[] {
            "(无)",
            "一般",
            "格斗",
            "飞行",
            "毒",
            "地面",
            "岩石",
            "虫",
            "幽灵",
            "钢",
            "火",
            "水",
            "草",
            "电",
            "超能力",
            "冰",
            "龙",
            "恶",
            "妖精"});
            this.Type1.Location = new System.Drawing.Point(72, 105);
            this.Type1.Name = "Type1";
            this.Type1.Size = new System.Drawing.Size(75, 20);
            this.Type1.TabIndex = 6;
            this.Type1.SelectedIndexChanged += new System.EventHandler(this.Type1_SelectedIndexChanged);
            // 
            // Type2
            // 
            this.Type2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type2.FormattingEnabled = true;
            this.Type2.Items.AddRange(new object[] {
            "(无)",
            "一般",
            "格斗",
            "飞行",
            "毒",
            "地面",
            "岩石",
            "虫",
            "幽灵",
            "钢",
            "火",
            "水",
            "草",
            "电",
            "超能力",
            "冰",
            "龙",
            "恶",
            "妖精"});
            this.Type2.Location = new System.Drawing.Point(72, 134);
            this.Type2.Name = "Type2";
            this.Type2.Size = new System.Drawing.Size(75, 20);
            this.Type2.TabIndex = 6;
            this.Type2.SelectedIndexChanged += new System.EventHandler(this.Type1_SelectedIndexChanged);
            // 
            // ZS
            // 
            this.ZS.Location = new System.Drawing.Point(72, 191);
            this.ZS.Name = "ZS";
            this.ZS.Size = new System.Drawing.Size(75, 21);
            this.ZS.TabIndex = 7;
            this.ZS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TX
            // 
            this.TX.Location = new System.Drawing.Point(72, 163);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(75, 21);
            this.TX.TabIndex = 8;
            this.TX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "招式:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "特性:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(57, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "招式世代限制";
            this.label6.Visible = false;
            // 
            // SD
            // 
            this.SD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SD.Enabled = false;
            this.SD.FormattingEnabled = true;
            this.SD.Items.AddRange(new object[] {
            "迦勒尔图鉴"});
            this.SD.Location = new System.Drawing.Point(47, 280);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(100, 20);
            this.SD.TabIndex = 12;
            this.SD.Visible = false;
            this.SD.SelectedIndexChanged += new System.EventHandler(this.SD_SelectedIndexChanged);
            // 
            // pokename
            // 
            this.pokename.AutoSize = true;
            this.pokename.Location = new System.Drawing.Point(256, 22);
            this.pokename.Name = "pokename";
            this.pokename.Size = new System.Drawing.Size(41, 12);
            this.pokename.TabIndex = 13;
            this.pokename.Text = "斗笠菇";
            this.pokename.TextChanged += new System.EventHandler(this.pokename_TextChanged);
            this.pokename.Click += new System.EventHandler(this.info_Click);
            // 
            // PHP
            // 
            this.PHP.Location = new System.Drawing.Point(303, 92);
            this.PHP.Name = "PHP";
            this.PHP.Size = new System.Drawing.Size(39, 21);
            this.PHP.TabIndex = 14;
            this.PHP.Text = "0";
            this.PHP.TextChanged += new System.EventHandler(this.PHP_TextChanged);
            this.PHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PHP.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // PAtk
            // 
            this.PAtk.Location = new System.Drawing.Point(303, 118);
            this.PAtk.Name = "PAtk";
            this.PAtk.Size = new System.Drawing.Size(39, 21);
            this.PAtk.TabIndex = 14;
            this.PAtk.Text = "0";
            this.PAtk.TextChanged += new System.EventHandler(this.PAtk_TextChanged);
            this.PAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PAtk.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // PDef
            // 
            this.PDef.Location = new System.Drawing.Point(303, 144);
            this.PDef.Name = "PDef";
            this.PDef.Size = new System.Drawing.Size(39, 21);
            this.PDef.TabIndex = 14;
            this.PDef.Text = "0";
            this.PDef.TextChanged += new System.EventHandler(this.PDef_TextChanged);
            this.PDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PDef.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // PSpa
            // 
            this.PSpa.Location = new System.Drawing.Point(303, 171);
            this.PSpa.Name = "PSpa";
            this.PSpa.Size = new System.Drawing.Size(39, 21);
            this.PSpa.TabIndex = 14;
            this.PSpa.Text = "0";
            this.PSpa.TextChanged += new System.EventHandler(this.PSpa_TextChanged);
            this.PSpa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PSpa.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // PSpf
            // 
            this.PSpf.Location = new System.Drawing.Point(303, 198);
            this.PSpf.Name = "PSpf";
            this.PSpf.Size = new System.Drawing.Size(39, 21);
            this.PSpf.TabIndex = 14;
            this.PSpf.Text = "0";
            this.PSpf.TextChanged += new System.EventHandler(this.PSpf_TextChanged);
            this.PSpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PSpf.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // PSpe
            // 
            this.PSpe.Location = new System.Drawing.Point(303, 225);
            this.PSpe.Name = "PSpe";
            this.PSpe.Size = new System.Drawing.Size(39, 21);
            this.PSpe.TabIndex = 14;
            this.PSpe.Text = "0";
            this.PSpe.TextChanged += new System.EventHandler(this.PSpe_TextChanged);
            this.PSpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.PSpe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PSpe_KeyUp);
            this.PSpe.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HHP
            // 
            this.HHP.Location = new System.Drawing.Point(348, 92);
            this.HHP.Name = "HHP";
            this.HHP.Size = new System.Drawing.Size(39, 21);
            this.HHP.TabIndex = 14;
            this.HHP.Text = "0";
            this.HHP.TextChanged += new System.EventHandler(this.HHP_TextChanged);
            this.HHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HHP.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HAtk
            // 
            this.HAtk.Location = new System.Drawing.Point(348, 118);
            this.HAtk.Name = "HAtk";
            this.HAtk.Size = new System.Drawing.Size(39, 21);
            this.HAtk.TabIndex = 14;
            this.HAtk.Text = "0";
            this.HAtk.TextChanged += new System.EventHandler(this.HAtk_TextChanged);
            this.HAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HAtk.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HDef
            // 
            this.HDef.Location = new System.Drawing.Point(348, 144);
            this.HDef.Name = "HDef";
            this.HDef.Size = new System.Drawing.Size(39, 21);
            this.HDef.TabIndex = 14;
            this.HDef.Text = "0";
            this.HDef.TextChanged += new System.EventHandler(this.HDef_TextChanged);
            this.HDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HDef.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HSpa
            // 
            this.HSpa.Location = new System.Drawing.Point(348, 171);
            this.HSpa.Name = "HSpa";
            this.HSpa.Size = new System.Drawing.Size(39, 21);
            this.HSpa.TabIndex = 14;
            this.HSpa.Text = "0";
            this.HSpa.TextChanged += new System.EventHandler(this.HSpa_TextChanged);
            this.HSpa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HSpa.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HSpf
            // 
            this.HSpf.Location = new System.Drawing.Point(348, 198);
            this.HSpf.Name = "HSpf";
            this.HSpf.Size = new System.Drawing.Size(39, 21);
            this.HSpf.TabIndex = 14;
            this.HSpf.Text = "0";
            this.HSpf.TextChanged += new System.EventHandler(this.HSpf_TextChanged);
            this.HSpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HSpf.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // HSpe
            // 
            this.HSpe.Location = new System.Drawing.Point(348, 225);
            this.HSpe.Name = "HSpe";
            this.HSpe.Size = new System.Drawing.Size(39, 21);
            this.HSpe.TabIndex = 14;
            this.HSpe.Text = "0";
            this.HSpe.TextChanged += new System.EventHandler(this.HSpe_TextChanged);
            this.HSpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PSpe_KeyPress);
            this.HSpe.Leave += new System.EventHandler(this.PSpe_Leave);
            // 
            // RHP
            // 
            this.RHP.Location = new System.Drawing.Point(258, 92);
            this.RHP.Name = "RHP";
            this.RHP.ReadOnly = true;
            this.RHP.Size = new System.Drawing.Size(39, 21);
            this.RHP.TabIndex = 14;
            this.RHP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RAtk
            // 
            this.RAtk.Location = new System.Drawing.Point(258, 118);
            this.RAtk.Name = "RAtk";
            this.RAtk.ReadOnly = true;
            this.RAtk.Size = new System.Drawing.Size(39, 21);
            this.RAtk.TabIndex = 14;
            this.RAtk.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // RDef
            // 
            this.RDef.Location = new System.Drawing.Point(258, 144);
            this.RDef.Name = "RDef";
            this.RDef.ReadOnly = true;
            this.RDef.Size = new System.Drawing.Size(39, 21);
            this.RDef.TabIndex = 14;
            this.RDef.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // RSpa
            // 
            this.RSpa.Location = new System.Drawing.Point(258, 171);
            this.RSpa.Name = "RSpa";
            this.RSpa.ReadOnly = true;
            this.RSpa.Size = new System.Drawing.Size(39, 21);
            this.RSpa.TabIndex = 14;
            this.RSpa.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // RSpf
            // 
            this.RSpf.Location = new System.Drawing.Point(258, 198);
            this.RSpf.Name = "RSpf";
            this.RSpf.ReadOnly = true;
            this.RSpf.Size = new System.Drawing.Size(39, 21);
            this.RSpf.TabIndex = 14;
            this.RSpf.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // RSpe
            // 
            this.RSpe.Location = new System.Drawing.Point(258, 225);
            this.RSpe.Name = "RSpe";
            this.RSpe.ReadOnly = true;
            this.RSpe.Size = new System.Drawing.Size(39, 21);
            this.RSpe.TabIndex = 14;
            this.RSpe.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "性格";
            // 
            // Rsum
            // 
            this.Rsum.AutoSize = true;
            this.Rsum.Location = new System.Drawing.Point(258, 257);
            this.Rsum.Name = "Rsum";
            this.Rsum.Size = new System.Drawing.Size(0, 12);
            this.Rsum.TabIndex = 15;
            // 
            // Hsum
            // 
            this.Hsum.AutoSize = true;
            this.Hsum.Location = new System.Drawing.Point(349, 257);
            this.Hsum.Name = "Hsum";
            this.Hsum.Size = new System.Drawing.Size(0, 12);
            this.Hsum.TabIndex = 15;
            this.Hsum.TextAlignChanged += new System.EventHandler(this.Hsum_TextAlignChanged);
            this.Hsum.TextChanged += new System.EventHandler(this.Hsum_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(256, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 15;
            this.label24.Text = "种族值";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(346, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 15;
            this.label25.Text = "努力值";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(303, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 15;
            this.label26.Text = "个体值";
            // 
            // stat
            // 
            this.stat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stat.FormattingEnabled = true;
            this.stat.Location = new System.Drawing.Point(424, 19);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(90, 20);
            this.stat.TabIndex = 16;
            this.stat.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(374, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 13;
            this.label27.Text = "形态";
            this.label27.Click += new System.EventHandler(this.label7_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(406, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 15;
            this.label28.Text = "能力值";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(202, 257);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 15;
            this.label29.Text = "总和";
            this.label29.Click += new System.EventHandler(this.label21_Click);
            // 
            // Sex
            // 
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.FormattingEnabled = true;
            this.Sex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sex.Location = new System.Drawing.Point(258, 280);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(104, 20);
            this.Sex.TabIndex = 16;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.Sex_SelectedIndexChanged);
            // 
            // rss
            // 
            this.rss.AutoSize = true;
            this.rss.Location = new System.Drawing.Point(206, 311);
            this.rss.Name = "rss";
            this.rss.Size = new System.Drawing.Size(101, 12);
            this.rss.TabIndex = 17;
            this.rss.Text = "不可食用的rss果:";
            // 
            // textBox21
            // 
            this.textBox21.AcceptsReturn = true;
            this.textBox21.AcceptsTab = true;
            this.textBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox21.Location = new System.Drawing.Point(474, 86);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox21.Size = new System.Drawing.Size(130, 237);
            this.textBox21.TabIndex = 18;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(473, 64);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 15;
            this.label31.Text = "招式列表";
            // 
            // pokehead
            // 
            this.pokehead.Image = ((System.Drawing.Image)(resources.GetObject("pokehead.Image")));
            this.pokehead.Location = new System.Drawing.Point(185, -8);
            this.pokehead.Name = "pokehead";
            this.pokehead.Size = new System.Drawing.Size(65, 65);
            this.pokehead.TabIndex = 13;
            this.pokehead.Click += new System.EventHandler(this.info_Click);
            // 
            // level11
            // 
            this.level11.AutoSize = true;
            this.level11.Location = new System.Drawing.Point(368, 283);
            this.level11.Name = "level11";
            this.level11.Size = new System.Drawing.Size(29, 12);
            this.level11.TabIndex = 15;
            this.level11.Text = "等级";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(408, 279);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(39, 21);
            this.level.TabIndex = 14;
            this.level.Text = "50";
            this.level.TextChanged += new System.EventHandler(this.level_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "6V";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZSt
            // 
            this.ZSt.Location = new System.Drawing.Point(153, 191);
            this.ZSt.Name = "ZSt";
            this.ZSt.Size = new System.Drawing.Size(21, 21);
            this.ZSt.TabIndex = 20;
            this.ZSt.Text = "+";
            this.ZSt.UseVisualStyleBackColor = true;
            this.ZSt.Click += new System.EventHandler(this.ZSt_Click);
            // 
            // ZSlist1
            // 
            this.ZSlist1.Controls.Add(this.CLEAR);
            this.ZSlist1.Location = new System.Drawing.Point(622, 64);
            this.ZSlist1.Name = "ZSlist1";
            this.ZSlist1.Size = new System.Drawing.Size(169, 259);
            this.ZSlist1.TabIndex = 21;
            this.ZSlist1.TabStop = false;
            this.ZSlist1.Text = "查询招式列表";
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(47, 216);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 22;
            this.CLEAR.Text = "清空";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // sortra
            // 
            this.sortra.AutoSize = true;
            this.sortra.Enabled = false;
            this.sortra.Location = new System.Drawing.Point(39, 306);
            this.sortra.Name = "sortra";
            this.sortra.Size = new System.Drawing.Size(108, 16);
            this.sortra.TabIndex = 22;
            this.sortra.Text = "依照种族值降序";
            this.sortra.UseVisualStyleBackColor = true;
            this.sortra.Visible = false;
            this.sortra.CheckedChanged += new System.EventHandler(this.sortra_CheckedChanged);
            // 
            // evfield
            // 
            this.evfield.Location = new System.Drawing.Point(620, 19);
            this.evfield.Name = "evfield";
            this.evfield.Size = new System.Drawing.Size(220, 38);
            this.evfield.TabIndex = 23;
            this.evfield.Click += new System.EventHandler(this.evfield_Click);
            // 
            // typel
            // 
            this.typel.Location = new System.Drawing.Point(521, 22);
            this.typel.Name = "typel";
            this.typel.Size = new System.Drawing.Size(83, 61);
            this.typel.TabIndex = 24;
            // 
            // egggroup
            // 
            this.egggroup.Location = new System.Drawing.Point(25, 221);
            this.egggroup.Name = "egggroup";
            this.egggroup.Size = new System.Drawing.Size(172, 23);
            this.egggroup.TabIndex = 25;
            // 
            // TXp
            // 
            this.TXp.Location = new System.Drawing.Point(24, 244);
            this.TXp.Name = "TXp";
            this.TXp.Size = new System.Drawing.Size(172, 23);
            this.TXp.TabIndex = 26;
            // 
            // TXM
            // 
            this.TXM.Location = new System.Drawing.Point(24, 267);
            this.TXM.Name = "TXM";
            this.TXM.Size = new System.Drawing.Size(172, 23);
            this.TXM.TabIndex = 26;
            // 
            // sorttag
            // 
            this.sorttag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sorttag.FormattingEnabled = true;
            this.sorttag.Items.AddRange(new object[] {
            "依照图鉴编号排序",
            "依照种族值降序",
            "依照种族值升序",
            "依照HP降序",
            "依照HP升序",
            "依照攻击降序",
            "依照攻击升序",
            "依照防御降序",
            "依照防御升序",
            "依照特攻降序",
            "依照特攻升序",
            "依照特防降序",
            "依照特防升序",
            "依照速度降序",
            "依照速度升序"});
            this.sorttag.Location = new System.Drawing.Point(26, 302);
            this.sorttag.Name = "sorttag";
            this.sorttag.Size = new System.Drawing.Size(148, 20);
            this.sorttag.TabIndex = 27;
            this.sorttag.SelectedIndexChanged += new System.EventHandler(this.sorttag_SelectedIndexChanged);
            // 
            // showpokemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 353);
            this.Controls.Add(this.sorttag);
            this.Controls.Add(this.TXM);
            this.Controls.Add(this.TXp);
            this.Controls.Add(this.egggroup);
            this.Controls.Add(this.typel);
            this.Controls.Add(this.evfield);
            this.Controls.Add(this.sortra);
            this.Controls.Add(this.ZSlist1);
            this.Controls.Add(this.ZSt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.rss);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Hsum);
            this.Controls.Add(this.Rsum);
            this.Controls.Add(this.level11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.level);
            this.Controls.Add(this.HSpe);
            this.Controls.Add(this.RSpe);
            this.Controls.Add(this.PSpe);
            this.Controls.Add(this.RSpf);
            this.Controls.Add(this.HSpf);
            this.Controls.Add(this.PSpf);
            this.Controls.Add(this.RSpa);
            this.Controls.Add(this.HSpa);
            this.Controls.Add(this.PSpa);
            this.Controls.Add(this.RDef);
            this.Controls.Add(this.HDef);
            this.Controls.Add(this.PDef);
            this.Controls.Add(this.RAtk);
            this.Controls.Add(this.HAtk);
            this.Controls.Add(this.PAtk);
            this.Controls.Add(this.RHP);
            this.Controls.Add(this.HHP);
            this.Controls.Add(this.PHP);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.pokename);
            this.Controls.Add(this.pokehead);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ZS);
            this.Controls.Add(this.TX);
            this.Controls.Add(this.Type2);
            this.Controls.Add(this.Type1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AfterSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "showpokemen";
            this.Text = "宝可梦搜索器-by moob";
            this.Load += new System.EventHandler(this.showpokemen_Load);
            this.ZSlist1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AfterSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type1;
        private System.Windows.Forms.ComboBox Type2;
        private System.Windows.Forms.TextBox ZS;
        private System.Windows.Forms.TextBox TX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SD;
        private System.Windows.Forms.Label pokehead;
        private System.Windows.Forms.Label pokename;
        private System.Windows.Forms.TextBox PHP;
        private System.Windows.Forms.TextBox PAtk;
        private System.Windows.Forms.TextBox PDef;
        private System.Windows.Forms.TextBox PSpa;
        private System.Windows.Forms.TextBox PSpf;
        private System.Windows.Forms.TextBox PSpe;
        private System.Windows.Forms.TextBox HHP;
        private System.Windows.Forms.TextBox HAtk;
        private System.Windows.Forms.TextBox HDef;
        private System.Windows.Forms.TextBox HSpa;
        private System.Windows.Forms.TextBox HSpf;
        private System.Windows.Forms.TextBox HSpe;
        private System.Windows.Forms.TextBox RHP;
        private System.Windows.Forms.TextBox RAtk;
        private System.Windows.Forms.TextBox RDef;
        private System.Windows.Forms.TextBox RSpa;
        private System.Windows.Forms.TextBox RSpf;
        private System.Windows.Forms.TextBox RSpe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Rsum;
        private System.Windows.Forms.Label Hsum;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox stat;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Label rss;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label level11;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ZSt;
        private System.Windows.Forms.GroupBox ZSlist1;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.CheckBox sortra;
        private System.Windows.Forms.Label evfield;
        private System.Windows.Forms.Label typel;
        private System.Windows.Forms.Label egggroup;
        private System.Windows.Forms.Label TXp;
        private System.Windows.Forms.Label TXM;
        private System.Windows.Forms.ComboBox sorttag;
    }
}