using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        public Form1()
        {
            sp = new SoundPlayer(@"background_music1.wav");
            sp.PlayLooping();
            InitializeComponent();

            MapController.Init(this);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
