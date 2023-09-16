using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void CmdWoerter_Click(object sender, EventArgs e)
        {
            //this.Hide();
            WoerterScreen w = new WoerterScreen();
            w.Show();
        }
    }
}
