using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Openingscreen : Form
    {
        public Openingscreen()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit the frame
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //starting the gameplay by creating the object
            GamePlay f = new GamePlay(firstplayertxt.Text,secondplayertxt.Text,thirdplayertxt.Text);
            this.Visible = false;
            f.Show();
        }
    }
}
