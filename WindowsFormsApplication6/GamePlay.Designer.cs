namespace WindowsFormsApplication6
{
    partial class GamePlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.RaceGroundPBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ThirdTxt = new System.Windows.Forms.TextBox();
            this.SecondTxt = new System.Windows.Forms.TextBox();
            this.FirstTxt = new System.Windows.Forms.TextBox();
            this.dogscount = new System.Windows.Forms.NumericUpDown();
            this.GetSetBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.bettornumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dognolbl = new System.Windows.Forms.Label();
            this.BetBtn = new System.Windows.Forms.Button();
            this.bettorlbl = new System.Windows.Forms.Label();
            this.MaxBetAmtLabel = new System.Windows.Forms.Label();
            this.MaxBetLabel = new System.Windows.Forms.Label();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.JoeRadio1 = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.FirstPBox = new System.Windows.Forms.PictureBox();
            this.SecondPBox = new System.Windows.Forms.PictureBox();
            this.ThirdPBox = new System.Windows.Forms.PictureBox();
            this.FourthPBox = new System.Windows.Forms.PictureBox();
            this.IL1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RaceGroundPBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettornumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceGroundPBox
            // 
            this.RaceGroundPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaceGroundPBox.BackgroundImage")));
            this.RaceGroundPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaceGroundPBox.ErrorImage = null;
            this.RaceGroundPBox.ImageLocation = "";
            this.RaceGroundPBox.Location = new System.Drawing.Point(13, 14);
            this.RaceGroundPBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RaceGroundPBox.Name = "RaceGroundPBox";
            this.RaceGroundPBox.Size = new System.Drawing.Size(1015, 373);
            this.RaceGroundPBox.TabIndex = 0;
            this.RaceGroundPBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.ThirdTxt);
            this.panel1.Controls.Add(this.SecondTxt);
            this.panel1.Controls.Add(this.FirstTxt);
            this.panel1.Controls.Add(this.dogscount);
            this.panel1.Controls.Add(this.GetSetBtn);
            this.panel1.Controls.Add(this.RestartBtn);
            this.panel1.Controls.Add(this.bettornumericUpDown1);
            this.panel1.Controls.Add(this.dognolbl);
            this.panel1.Controls.Add(this.BetBtn);
            this.panel1.Controls.Add(this.bettorlbl);
            this.panel1.Controls.Add(this.MaxBetAmtLabel);
            this.panel1.Controls.Add(this.MaxBetLabel);
            this.panel1.Controls.Add(this.AlRadio);
            this.panel1.Controls.Add(this.BobRadio);
            this.panel1.Controls.Add(this.JoeRadio1);
            this.panel1.Location = new System.Drawing.Point(13, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 198);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(901, 137);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 48);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ThirdTxt
            // 
            this.ThirdTxt.Enabled = false;
            this.ThirdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThirdTxt.Location = new System.Drawing.Point(483, 90);
            this.ThirdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThirdTxt.Name = "ThirdTxt";
            this.ThirdTxt.Size = new System.Drawing.Size(337, 30);
            this.ThirdTxt.TabIndex = 11;
            // 
            // SecondTxt
            // 
            this.SecondTxt.Enabled = false;
            this.SecondTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SecondTxt.Location = new System.Drawing.Point(483, 46);
            this.SecondTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondTxt.Name = "SecondTxt";
            this.SecondTxt.Size = new System.Drawing.Size(337, 30);
            this.SecondTxt.TabIndex = 10;
            // 
            // FirstTxt
            // 
            this.FirstTxt.Enabled = false;
            this.FirstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstTxt.Location = new System.Drawing.Point(483, 10);
            this.FirstTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstTxt.Name = "FirstTxt";
            this.FirstTxt.Size = new System.Drawing.Size(337, 30);
            this.FirstTxt.TabIndex = 9;
            // 
            // dogscount
            // 
            this.dogscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dogscount.Location = new System.Drawing.Point(332, 48);
            this.dogscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dogscount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogscount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogscount.Name = "dogscount";
            this.dogscount.Size = new System.Drawing.Size(120, 30);
            this.dogscount.TabIndex = 8;
            this.dogscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GetSetBtn
            // 
            this.GetSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetSetBtn.Location = new System.Drawing.Point(576, 137);
            this.GetSetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetSetBtn.Name = "GetSetBtn";
            this.GetSetBtn.Size = new System.Drawing.Size(140, 48);
            this.GetSetBtn.TabIndex = 3;
            this.GetSetBtn.Text = "Get Set Go";
            this.GetSetBtn.UseVisualStyleBackColor = true;
            this.GetSetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RestartBtn.Location = new System.Drawing.Point(795, 137);
            this.RestartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(99, 48);
            this.RestartBtn.TabIndex = 4;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bettornumericUpDown1
            // 
            this.bettornumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bettornumericUpDown1.Location = new System.Drawing.Point(332, 11);
            this.bettornumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bettornumericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.bettornumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bettornumericUpDown1.Name = "bettornumericUpDown1";
            this.bettornumericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.bettornumericUpDown1.TabIndex = 7;
            this.bettornumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dognolbl
            // 
            this.dognolbl.AutoSize = true;
            this.dognolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dognolbl.Location = new System.Drawing.Point(167, 51);
            this.dognolbl.Name = "dognolbl";
            this.dognolbl.Size = new System.Drawing.Size(136, 25);
            this.dognolbl.TabIndex = 6;
            this.dognolbl.Text = "on Dog No.   #";
            // 
            // BetBtn
            // 
            this.BetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BetBtn.Location = new System.Drawing.Point(252, 137);
            this.BetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BetBtn.Name = "BetBtn";
            this.BetBtn.Size = new System.Drawing.Size(303, 48);
            this.BetBtn.TabIndex = 2;
            this.BetBtn.Text = "Put Bet on Dog";
            this.BetBtn.UseVisualStyleBackColor = true;
            this.BetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bettorlbl
            // 
            this.bettorlbl.AutoSize = true;
            this.bettorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bettorlbl.Location = new System.Drawing.Point(167, 14);
            this.bettorlbl.Name = "bettorlbl";
            this.bettorlbl.Size = new System.Drawing.Size(63, 25);
            this.bettorlbl.TabIndex = 5;
            this.bettorlbl.Text = "Bettor";
            // 
            // MaxBetAmtLabel
            // 
            this.MaxBetAmtLabel.AutoSize = true;
            this.MaxBetAmtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaxBetAmtLabel.Location = new System.Drawing.Point(16, 153);
            this.MaxBetAmtLabel.Name = "MaxBetAmtLabel";
            this.MaxBetAmtLabel.Size = new System.Drawing.Size(157, 25);
            this.MaxBetAmtLabel.TabIndex = 4;
            this.MaxBetAmtLabel.Text = "Max Bet Amount";
            // 
            // MaxBetLabel
            // 
            this.MaxBetLabel.AutoSize = true;
            this.MaxBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaxBetLabel.Location = new System.Drawing.Point(15, 113);
            this.MaxBetLabel.Name = "MaxBetLabel";
            this.MaxBetLabel.Size = new System.Drawing.Size(103, 25);
            this.MaxBetLabel.TabIndex = 3;
            this.MaxBetLabel.Text = "Max Bet is";
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AlRadio.Location = new System.Drawing.Point(20, 66);
            this.AlRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(51, 29);
            this.AlRadio.TabIndex = 2;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BobRadio.Location = new System.Drawing.Point(20, 38);
            this.BobRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(68, 29);
            this.BobRadio.TabIndex = 1;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // JoeRadio1
            // 
            this.JoeRadio1.AutoSize = true;
            this.JoeRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.JoeRadio1.Location = new System.Drawing.Point(20, 10);
            this.JoeRadio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoeRadio1.Name = "JoeRadio1";
            this.JoeRadio1.Size = new System.Drawing.Size(66, 29);
            this.JoeRadio1.TabIndex = 0;
            this.JoeRadio1.TabStop = true;
            this.JoeRadio1.Text = "Joe";
            this.JoeRadio1.UseVisualStyleBackColor = true;
            this.JoeRadio1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // t1
            // 
            this.t1.Interval = 500;
            this.t1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 1000;
            this.t2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FirstPBox
            // 
            this.FirstPBox.Image = ((System.Drawing.Image)(resources.GetObject("FirstPBox.Image")));
            this.FirstPBox.Location = new System.Drawing.Point(58, 41);
            this.FirstPBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstPBox.Name = "FirstPBox";
            this.FirstPBox.Size = new System.Drawing.Size(57, 33);
            this.FirstPBox.TabIndex = 9;
            this.FirstPBox.TabStop = false;
            // 
            // SecondPBox
            // 
            this.SecondPBox.Image = ((System.Drawing.Image)(resources.GetObject("SecondPBox.Image")));
            this.SecondPBox.Location = new System.Drawing.Point(58, 138);
            this.SecondPBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondPBox.Name = "SecondPBox";
            this.SecondPBox.Size = new System.Drawing.Size(57, 33);
            this.SecondPBox.TabIndex = 10;
            this.SecondPBox.TabStop = false;
            // 
            // ThirdPBox
            // 
            this.ThirdPBox.Image = ((System.Drawing.Image)(resources.GetObject("ThirdPBox.Image")));
            this.ThirdPBox.Location = new System.Drawing.Point(60, 243);
            this.ThirdPBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThirdPBox.Name = "ThirdPBox";
            this.ThirdPBox.Size = new System.Drawing.Size(55, 33);
            this.ThirdPBox.TabIndex = 11;
            this.ThirdPBox.TabStop = false;
            // 
            // FourthPBox
            // 
            this.FourthPBox.Image = ((System.Drawing.Image)(resources.GetObject("FourthPBox.Image")));
            this.FourthPBox.Location = new System.Drawing.Point(60, 323);
            this.FourthPBox.Margin = new System.Windows.Forms.Padding(4);
            this.FourthPBox.Name = "FourthPBox";
            this.FourthPBox.Size = new System.Drawing.Size(55, 32);
            this.FourthPBox.TabIndex = 12;
            this.FourthPBox.TabStop = false;
            // 
            // IL1
            // 
            this.IL1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IL1.ImageSize = new System.Drawing.Size(16, 16);
            this.IL1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.FourthPBox);
            this.Controls.Add(this.ThirdPBox);
            this.Controls.Add(this.SecondPBox);
            this.Controls.Add(this.FirstPBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RaceGroundPBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GamePlay";
            this.Text = "Game Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaceGroundPBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettornumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RaceGroundPBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BetBtn;
        private System.Windows.Forms.Button GetSetBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.NumericUpDown dogscount;
        private System.Windows.Forms.NumericUpDown bettornumericUpDown1;
        private System.Windows.Forms.Label dognolbl;
        private System.Windows.Forms.Label bettorlbl;
        private System.Windows.Forms.Label MaxBetAmtLabel;
        private System.Windows.Forms.Label MaxBetLabel;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton JoeRadio1;
        private System.Windows.Forms.TextBox ThirdTxt;
        private System.Windows.Forms.TextBox SecondTxt;
        private System.Windows.Forms.TextBox FirstTxt;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.PictureBox FirstPBox;
        private System.Windows.Forms.PictureBox SecondPBox;
        private System.Windows.Forms.PictureBox ThirdPBox;
        private System.Windows.Forms.PictureBox FourthPBox;
        private System.Windows.Forms.ImageList IL1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
    }
}

