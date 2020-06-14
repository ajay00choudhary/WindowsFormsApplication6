using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class GamePlay : Form
    {
       //creating objects of three players
        Joe object1 = new Joe();
        Bob object2 = new Bob();
        Al object3 = new Al();
            //argumented constructor   
        public GamePlay(string f,string g, string h)
        {

            InitializeComponent();
            //assigning references
            object1.s1 = f;
            object1.s2 = g;
            object1.s3 = h;
            //setting text field values
            JoeRadio1.Text = object1.s1;
            BobRadio.Text = object1.s2;
            AlRadio.Text = object1.s3;
        }
        //form load function
        private void Form1_Load(object sender, EventArgs e)
        {
            //setting the image
            RaceGroundPBox.ImageLocation = @"Images\first.png";
            RaceGroundPBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //first event procedure called against the button click
        private void button3_Click(object sender, EventArgs e)
        {
            //setting the initial values
            object1.amt = 50;
            object1.joe_bet_amt = 0;
            object1.joe_bet_runer = 0;
            object2.amt = 50;
            object2.bob_bet_amt = 0;
            object2.bob_bet_runer = 0;
            object3.amt = 50;
            object3.al_bet_amt = 0;
            object3.al_bet_runer = 0;
            //setting the dog count and betteror values
            bettornumericUpDown1.Value = 1;
            dogscount.Value = 1;
            //empting up the text fields
            FirstTxt.Text = "";
            SecondTxt.Text = "";
            ThirdTxt.Text = "";
            //setting the initial positions 
            FirstPBox.Location = new Point(50, FirstPBox.Location.Y);
            SecondPBox.Location = new Point(50, SecondPBox.Location.Y);
            ThirdPBox.Location = new Point(50, ThirdPBox.Location.Y);
            FourthPBox.Location = new Point(50, FourthPBox.Location.Y);
            object1.counter1 = 0;
        }
        //event called against the cliock of the radiobutton
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //setting the bettor value
            bettornumericUpDown1.Value = 1;
            dogscount.Value = 1;
            //checking the amount value against zero
            if (object1.amt == 0)
            {
                bettornumericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
            else
            {
                //setting the alternative value
                bettornumericUpDown1.Maximum = object1.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object1.amt);
            }
        }
        //second radion button click event
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //setting the bettor value for second player
            bettornumericUpDown1.Value = 1;
            dogscount.Value = 1;
            //checking the condition for second player
            if (object2.amt == 0)
            {
                bettornumericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
            else
            {
                //setting the alternative values
                bettornumericUpDown1.Maximum = object2.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object2.amt);
            }
        }
        //event called against the exit button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //third radio button event
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bettornumericUpDown1.Value = 1;
            dogscount.Value = 1;
            //checking the condition
            if (object3.amt == 0)
            {
                bettornumericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
                //setting the laternative action
            else
            {
                bettornumericUpDown1.Maximum = object3.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object3.amt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking the status of the  radio
            if (JoeRadio1.Checked == true)
            {
                if (object1.joe_bet_runer != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    //setting the alternative actions
                    object1.joe_bet_amt = Convert.ToInt16(bettornumericUpDown1.Value);
                    object1.joe_bet_runer = Convert.ToInt16(dogscount.Value);
                    object1.amt = object1.amt - object1.joe_bet_amt;
                    MaxBetAmtLabel.Text = object1.amt.ToString();
                    FirstTxt.Text = object1.s1 + " bets $" + object1.joe_bet_amt + " on runer " + object1.joe_bet_runer;
                }
            }
                //check for bob radio
            else if (BobRadio.Checked==true)
            {
                if (object2.bob_bet_runer != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    //setting the laternative action for joe amount
                    object2.bob_bet_amt = Convert.ToInt16(bettornumericUpDown1.Value);
                    object2.bob_bet_runer = Convert.ToInt16(dogscount.Value);
                    object2.amt = object2.amt - object2.bob_bet_amt;
                    MaxBetAmtLabel.Text = object2.amt.ToString();
                    SecondTxt.Text = object1.s2 + " bets $" + object2.bob_bet_amt + " on runer " + object2.bob_bet_runer;
                }
            }
                //checking the ALradio
            else if (AlRadio.Checked==true)
            {

                if (object3.al_bet_runer!=0)
                {
                    //setting the bet runner radio
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    //setting the alternative amount
                    object3.al_bet_amt = Convert.ToInt16(bettornumericUpDown1.Value);
                    object3.al_bet_runer = Convert.ToInt16(dogscount.Value);
                    object3.amt = object3.amt - object3.al_bet_amt;
                    MaxBetAmtLabel.Text = object3.amt.ToString();
                    ThirdTxt.Text = object1.s3 + " bets $" + object3.al_bet_amt + " on runer " + object3.al_bet_runer;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //checking the random variable for player win
            int i;
            Random r = new Random();
            object1.num = r.Next(1, 5);

            t1.Enabled = true;
            t2.Enabled = true;
        }
        //will be for the timer tick event
        private void timer1_Tick(object sender, EventArgs e)
        {
            //checking the object value
            if (object1.num == 1)
            {
                object1.f1 = 1;
                FirstPBox.Left = FirstPBox.Left + 95;
                //increment the counter value
                object1.counter1++;
            }
            else if (object1.num == 2)
            {
                object1.f2 = 1;
                SecondPBox.Left = SecondPBox.Left + 95;
                //increment the counter value
                object1.counter1++;
            }
            else if (object1.num == 3)
            {
                object1.f3 = 1;
                ThirdPBox.Left = ThirdPBox.Left + 95;
                //increment the counter value
                object1.counter1++;
            }
            else if (object1.num == 4)
            {
                object1.f4 = 1;
                FourthPBox.Left = FourthPBox.Left + 95;
                object1.counter1++;
            }
            if (object1.counter1 == 7)
            {
                t1.Enabled = false;
                t2.Enabled = false;
                //showing the winner
                MessageBox.Show("Winning bet is " + object1.num);
                //checking the condition for objext status
                if (object1.joe_bet_runer == object1.num)
                {
                    object1.amt = object1.amt + object1.joe_bet_amt;
                }
                //checking the runner value
                if (object2.bob_bet_runer == object1.num)
                {
                    object2.amt = object2.amt + object2.bob_bet_amt;
                }
                //checking for third runner value
                if (object3.al_bet_runer == object1.num)
                {
                    object3.amt = object3.amt + object3.al_bet_amt;
                }
                //checking for the amount
                if (object1.amt == 0)
                {
                    JoeRadio1.Enabled = false;
                    FirstTxt.Text = "Busted";
                    FirstTxt.ForeColor = Color.Red;
                    object1.players--;
                }
                //checking the amount for second runner
                if (object2.amt == 0)
                {
                    BobRadio.Enabled = false;
                    SecondTxt.Text = "Busted";
                    SecondTxt.ForeColor = Color.Red;
                    object1.players--;
                }
                //checking the amount for third runner
                if (object3.amt == 0)
                {
                    AlRadio.Enabled = false;
                    ThirdTxt.Text = "Busted";
                    ThirdTxt.ForeColor = Color.Red;
                   object1.players--;
                }
                //setting the value for first runner
                if (object1.players == 0)
                {
                    MessageBox.Show("All Players Lose");
                    JoeRadio1.Checked = false;
                    BobRadio.Checked = false;
                    AlRadio.Checked = false;
                    BetBtn.Enabled = false;
                    GetSetBtn.Enabled = false;
                }
                    //checking the value for first player
                else if (object1.players == 1)
                {
                    MessageBox.Show("Bet End");
                    JoeRadio1.Checked = false;
                    BobRadio.Checked = false;
                    AlRadio.Checked = false;
                    BetBtn.Enabled = false;
                    GetSetBtn.Enabled = false;
                }
                //set all the players amt and bet to zero
                object1.joe_bet_amt = 0;
                object1.joe_bet_runer = 0;
                object2.bob_bet_amt = 0;
                object2.bob_bet_runer = 0;
                object3.al_bet_amt = 0;
                object3.al_bet_runer = 0;
                //setting the text fields to zero
                FirstTxt.Text = "";
                SecondTxt.Text = "";
                ThirdTxt.Text = "";

                bettornumericUpDown1.Value = 1;
                dogscount.Value = 1;
                //setting the values for the pictureboxes
                FirstPBox.Location = new Point(50,FirstPBox.Location.Y);
                SecondPBox.Location = new Point(50, SecondPBox.Location.Y);
                ThirdPBox.Location = new Point(50, ThirdPBox.Location.Y);
                FourthPBox.Location = new Point(50, FourthPBox.Location.Y);
                object1.counter1 = 0;
            }
        }
        //timer event
        private void timer2_Tick(object sender, EventArgs e)
        {
            //check for first value
            if (object1.f1 == 1)
            {
                SecondPBox.Left = SecondPBox.Left + 65;
                ThirdPBox.Left = ThirdPBox.Left + 70;
                FourthPBox.Left = FourthPBox.Left + 80;
            }
                //check for second value
            else if (object1.f2 == 1)
            {
                FirstPBox.Left = FirstPBox.Left + 50;
                ThirdPBox.Left = ThirdPBox.Left + 75;
                FourthPBox.Left = FourthPBox.Left + 50;
            }
                //check for third value
            else if (object1.f3 == 1)
            {
                SecondPBox.Left = SecondPBox.Left + 50;
                FirstPBox.Left = FirstPBox.Left + 70;
                FourthPBox.Left = FourthPBox.Left + 80;
            }
                //check for fourth value
            else if (object1.f4 == 1)
            {
                SecondPBox.Left = SecondPBox.Left + 80;
                ThirdPBox.Left = ThirdPBox.Left + 85;
                FirstPBox.Left = FirstPBox.Left + 66;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
