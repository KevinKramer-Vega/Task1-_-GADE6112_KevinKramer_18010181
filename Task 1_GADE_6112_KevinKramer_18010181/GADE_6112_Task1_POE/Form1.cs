using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kevin Kramer 18010181
//Task 1 GADE 6112
namespace GADE_6112_Task1_POE
{
    public partial class MainForm : Form
    {
       Map battleGround =new Map(10,10);


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            battleGround.CreateUnits();
            battleGround.Display(gBoxBattle);
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = false;
        }

        private void rtbInfo_TextChanged(object sender, EventArgs e)
        {
           //gBoxBattle.SelectionStart = gBoxBattle.Text.Length;
           // // scroll it automatically
           //gBoxBattle.ScrollToCaret();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            battleGround.NewPostions();
            battleGround.Display(gBoxBattle);
        }
    }
}
