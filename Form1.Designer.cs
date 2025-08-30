namespace Coach
{
    partial class Form1
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
            this.btnHackerTool = new System.Windows.Forms.Button();
            this.BtnTorch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAlien = new System.Windows.Forms.Button();
            this.btnAndroid = new System.Windows.Forms.Button();
            this.btnHeavyAndroid = new System.Windows.Forms.Button();
            this.btnFaceHugger = new System.Windows.Forms.Button();
            this.btnRiotGuards = new System.Windows.Forms.Button();
            this.btnCivilian = new System.Windows.Forms.Button();
            this.btnSecGuards = new System.Windows.Forms.Button();
            this.btnEnableGasMask = new System.Windows.Forms.Button();
            this.btnDisableIntroMovies = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInnocent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioSteam = new System.Windows.Forms.RadioButton();
            this.radioEpic = new System.Windows.Forms.RadioButton();
            this.radioGOG = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHackerTool
            // 
            this.btnHackerTool.Location = new System.Drawing.Point(7, 48);
            this.btnHackerTool.Name = "btnHackerTool";
            this.btnHackerTool.Size = new System.Drawing.Size(215, 23);
            this.btnHackerTool.TabIndex = 4;
            this.btnHackerTool.Text = "Enable Hacker Tool (lvl3)";
            this.btnHackerTool.UseVisualStyleBackColor = true;
            this.btnHackerTool.Click += new System.EventHandler(this.btnHackerTool_Click);
            // 
            // BtnTorch
            // 
            this.BtnTorch.Location = new System.Drawing.Point(7, 79);
            this.BtnTorch.Name = "BtnTorch";
            this.BtnTorch.Size = new System.Drawing.Size(215, 23);
            this.BtnTorch.TabIndex = 19;
            this.BtnTorch.Text = "Enable Ion Torch (lvl3)";
            this.BtnTorch.UseVisualStyleBackColor = true;
            this.BtnTorch.Click += new System.EventHandler(this.BtnTorch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Novice",
            "Easy",
            "Medium",
            "Hard",
            "Nightmare"});
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAlien
            // 
            this.btnAlien.Location = new System.Drawing.Point(6, 19);
            this.btnAlien.Name = "btnAlien";
            this.btnAlien.Size = new System.Drawing.Size(215, 23);
            this.btnAlien.TabIndex = 21;
            this.btnAlien.Text = "Disable Alien";
            this.btnAlien.UseVisualStyleBackColor = true;
            this.btnAlien.Click += new System.EventHandler(this.btnAlien_Click);
            // 
            // btnAndroid
            // 
            this.btnAndroid.Location = new System.Drawing.Point(6, 59);
            this.btnAndroid.Name = "btnAndroid";
            this.btnAndroid.Size = new System.Drawing.Size(215, 23);
            this.btnAndroid.TabIndex = 22;
            this.btnAndroid.Text = "Disable Normal Androids";
            this.btnAndroid.UseVisualStyleBackColor = true;
            this.btnAndroid.Click += new System.EventHandler(this.btnAndroid_Click);
            // 
            // btnHeavyAndroid
            // 
            this.btnHeavyAndroid.Location = new System.Drawing.Point(6, 100);
            this.btnHeavyAndroid.Name = "btnHeavyAndroid";
            this.btnHeavyAndroid.Size = new System.Drawing.Size(215, 23);
            this.btnHeavyAndroid.TabIndex = 23;
            this.btnHeavyAndroid.Text = "Disable Hazmat Androids";
            this.btnHeavyAndroid.UseVisualStyleBackColor = true;
            this.btnHeavyAndroid.Click += new System.EventHandler(this.btnHeavyAndroid_Click);
            // 
            // btnFaceHugger
            // 
            this.btnFaceHugger.Location = new System.Drawing.Point(6, 140);
            this.btnFaceHugger.Name = "btnFaceHugger";
            this.btnFaceHugger.Size = new System.Drawing.Size(215, 23);
            this.btnFaceHugger.TabIndex = 24;
            this.btnFaceHugger.Text = "Disable Facehuggers";
            this.btnFaceHugger.UseVisualStyleBackColor = true;
            this.btnFaceHugger.Click += new System.EventHandler(this.btnFaceHugger_Click);
            // 
            // btnRiotGuards
            // 
            this.btnRiotGuards.Location = new System.Drawing.Point(6, 179);
            this.btnRiotGuards.Name = "btnRiotGuards";
            this.btnRiotGuards.Size = new System.Drawing.Size(215, 23);
            this.btnRiotGuards.TabIndex = 25;
            this.btnRiotGuards.Text = "Disable Riot Guards";
            this.btnRiotGuards.UseVisualStyleBackColor = true;
            this.btnRiotGuards.Click += new System.EventHandler(this.btnRiotGuards_Click);
            // 
            // btnCivilian
            // 
            this.btnCivilian.Location = new System.Drawing.Point(6, 262);
            this.btnCivilian.Name = "btnCivilian";
            this.btnCivilian.Size = new System.Drawing.Size(215, 23);
            this.btnCivilian.TabIndex = 26;
            this.btnCivilian.Text = "Disable Civilians (hostile)";
            this.btnCivilian.UseVisualStyleBackColor = true;
            this.btnCivilian.Click += new System.EventHandler(this.btnCivilian_Click);
            // 
            // btnSecGuards
            // 
            this.btnSecGuards.Location = new System.Drawing.Point(6, 222);
            this.btnSecGuards.Name = "btnSecGuards";
            this.btnSecGuards.Size = new System.Drawing.Size(215, 23);
            this.btnSecGuards.TabIndex = 27;
            this.btnSecGuards.Text = "Disable Security Guards";
            this.btnSecGuards.UseVisualStyleBackColor = true;
            this.btnSecGuards.Click += new System.EventHandler(this.btnSecGuards_Click);
            // 
            // btnEnableGasMask
            // 
            this.btnEnableGasMask.Location = new System.Drawing.Point(6, 108);
            this.btnEnableGasMask.Name = "btnEnableGasMask";
            this.btnEnableGasMask.Size = new System.Drawing.Size(215, 23);
            this.btnEnableGasMask.TabIndex = 28;
            this.btnEnableGasMask.Text = "Enable Gas mask";
            this.btnEnableGasMask.UseVisualStyleBackColor = true;
            this.btnEnableGasMask.Click += new System.EventHandler(this.btnGasmask_Click);
            // 
            // btnDisableIntroMovies
            // 
            this.btnDisableIntroMovies.Location = new System.Drawing.Point(7, 19);
            this.btnDisableIntroMovies.Name = "btnDisableIntroMovies";
            this.btnDisableIntroMovies.Size = new System.Drawing.Size(215, 23);
            this.btnDisableIntroMovies.TabIndex = 29;
            this.btnDisableIntroMovies.Text = "Disable Intro Movies";
            this.btnDisableIntroMovies.UseVisualStyleBackColor = true;
            this.btnDisableIntroMovies.Click += new System.EventHandler(this.btnDisableIntroMovies_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInnocent);
            this.groupBox1.Controls.Add(this.btnAndroid);
            this.groupBox1.Controls.Add(this.btnAlien);
            this.groupBox1.Controls.Add(this.btnHeavyAndroid);
            this.groupBox1.Controls.Add(this.btnSecGuards);
            this.groupBox1.Controls.Add(this.btnFaceHugger);
            this.groupBox1.Controls.Add(this.btnCivilian);
            this.groupBox1.Controls.Add(this.btnRiotGuards);
            this.groupBox1.Location = new System.Drawing.Point(258, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 336);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPC AI:";
            // 
            // btnInnocent
            // 
            this.btnInnocent.Location = new System.Drawing.Point(7, 300);
            this.btnInnocent.Name = "btnInnocent";
            this.btnInnocent.Size = new System.Drawing.Size(215, 23);
            this.btnInnocent.TabIndex = 28;
            this.btnInnocent.Text = "Disable Civilians (innocent)";
            this.btnInnocent.UseVisualStyleBackColor = true;
            this.btnInnocent.Click += new System.EventHandler(this.btnInnocent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHackerTool);
            this.groupBox2.Controls.Add(this.BtnTorch);
            this.groupBox2.Controls.Add(this.btnEnableGasMask);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 142);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory Hacks:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisableIntroMovies);
            this.groupBox3.Location = new System.Drawing.Point(258, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 54);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other settings:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioGOG);
            this.groupBox4.Controls.Add(this.radioEpic);
            this.groupBox4.Controls.Add(this.radioSteam);
            this.groupBox4.Location = new System.Drawing.Point(13, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 95);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Override game version:";
            // 
            // radioSteam
            // 
            this.radioSteam.AutoSize = true;
            this.radioSteam.Location = new System.Drawing.Point(7, 20);
            this.radioSteam.Name = "radioSteam";
            this.radioSteam.Size = new System.Drawing.Size(55, 17);
            this.radioSteam.TabIndex = 0;
            this.radioSteam.TabStop = true;
            this.radioSteam.Text = "Steam";
            this.radioSteam.UseVisualStyleBackColor = true;
            this.radioSteam.CheckedChanged += new System.EventHandler(this.radioSteam_CheckedChanged);
            // 
            // radioEpic
            // 
            this.radioEpic.AutoSize = true;
            this.radioEpic.Location = new System.Drawing.Point(7, 43);
            this.radioEpic.Name = "radioEpic";
            this.radioEpic.Size = new System.Drawing.Size(46, 17);
            this.radioEpic.TabIndex = 1;
            this.radioEpic.TabStop = true;
            this.radioEpic.Text = "Epic";
            this.radioEpic.UseVisualStyleBackColor = true;
            this.radioEpic.CheckedChanged += new System.EventHandler(this.radioSteam_CheckedChanged);
            // 
            // radioGOG
            // 
            this.radioGOG.AutoSize = true;
            this.radioGOG.Location = new System.Drawing.Point(7, 66);
            this.radioGOG.Name = "radioGOG";
            this.radioGOG.Size = new System.Drawing.Size(49, 17);
            this.radioGOG.TabIndex = 2;
            this.radioGOG.TabStop = true;
            this.radioGOG.Text = "GOG";
            this.radioGOG.UseVisualStyleBackColor = true;
            this.radioGOG.CheckedChanged += new System.EventHandler(this.radioSteam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI v1.6.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHackerTool;
        private System.Windows.Forms.Button BtnTorch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAlien;
        private System.Windows.Forms.Button btnAndroid;
        private System.Windows.Forms.Button btnHeavyAndroid;
        private System.Windows.Forms.Button btnFaceHugger;
        private System.Windows.Forms.Button btnRiotGuards;
        private System.Windows.Forms.Button btnCivilian;
        private System.Windows.Forms.Button btnSecGuards;
        private System.Windows.Forms.Button btnEnableGasMask;
        private System.Windows.Forms.Button btnDisableIntroMovies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInnocent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioGOG;
        private System.Windows.Forms.RadioButton radioEpic;
        private System.Windows.Forms.RadioButton radioSteam;
        private System.Windows.Forms.Label label1;
    }
}

