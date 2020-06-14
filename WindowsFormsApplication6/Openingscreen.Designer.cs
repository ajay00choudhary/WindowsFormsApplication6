namespace WindowsFormsApplication6
{
    partial class Openingscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Openingscreen));
            this.OpenScreenPBox = new System.Windows.Forms.PictureBox();
            this.firstplayertxt = new System.Windows.Forms.TextBox();
            this.secondplayertxt = new System.Windows.Forms.TextBox();
            this.thirdplayertxt = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.ThirdNameLabel = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OpenScreenPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenScreenPBox
            // 
            this.OpenScreenPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenScreenPBox.BackgroundImage")));
            this.OpenScreenPBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("OpenScreenPBox.InitialImage")));
            this.OpenScreenPBox.Location = new System.Drawing.Point(3, 0);
            this.OpenScreenPBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpenScreenPBox.Name = "OpenScreenPBox";
            this.OpenScreenPBox.Size = new System.Drawing.Size(1027, 457);
            this.OpenScreenPBox.TabIndex = 0;
            this.OpenScreenPBox.TabStop = false;
            // 
            // firstplayertxt
            // 
            this.firstplayertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstplayertxt.Location = new System.Drawing.Point(168, 476);
            this.firstplayertxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstplayertxt.Name = "firstplayertxt";
            this.firstplayertxt.Size = new System.Drawing.Size(219, 30);
            this.firstplayertxt.TabIndex = 1;
            this.firstplayertxt.Text = "Joe";
            // 
            // secondplayertxt
            // 
            this.secondplayertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondplayertxt.Location = new System.Drawing.Point(168, 516);
            this.secondplayertxt.Margin = new System.Windows.Forms.Padding(4);
            this.secondplayertxt.Name = "secondplayertxt";
            this.secondplayertxt.Size = new System.Drawing.Size(219, 30);
            this.secondplayertxt.TabIndex = 2;
            this.secondplayertxt.Text = "Bob";
            // 
            // thirdplayertxt
            // 
            this.thirdplayertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdplayertxt.Location = new System.Drawing.Point(168, 555);
            this.thirdplayertxt.Margin = new System.Windows.Forms.Padding(4);
            this.thirdplayertxt.Name = "thirdplayertxt";
            this.thirdplayertxt.Size = new System.Drawing.Size(219, 30);
            this.thirdplayertxt.TabIndex = 3;
            this.thirdplayertxt.Text = "Al";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(9, 484);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNameLabel.Location = new System.Drawing.Point(9, 523);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(137, 25);
            this.SecondNameLabel.TabIndex = 5;
            this.SecondNameLabel.Text = "Second Name";
            // 
            // ThirdNameLabel
            // 
            this.ThirdNameLabel.AutoSize = true;
            this.ThirdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdNameLabel.Location = new System.Drawing.Point(9, 562);
            this.ThirdNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThirdNameLabel.Name = "ThirdNameLabel";
            this.ThirdNameLabel.Size = new System.Drawing.Size(114, 25);
            this.ThirdNameLabel.TabIndex = 6;
            this.ThirdNameLabel.Text = "Third Name";
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(663, 471);
            this.Startbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(213, 52);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(663, 530);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(213, 52);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Openingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.ThirdNameLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.thirdplayertxt);
            this.Controls.Add(this.secondplayertxt);
            this.Controls.Add(this.firstplayertxt);
            this.Controls.Add(this.OpenScreenPBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Openingscreen";
            this.Text = "Openingscreen";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenScreenPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OpenScreenPBox;
        private System.Windows.Forms.TextBox firstplayertxt;
        private System.Windows.Forms.TextBox secondplayertxt;
        private System.Windows.Forms.TextBox thirdplayertxt;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label ThirdNameLabel;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}