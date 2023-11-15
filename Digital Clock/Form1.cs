using System;
using System.Windows.Forms;


namespace Digital_Clock
{
    public partial class frmDigitalClock : Form
    {
        public frmDigitalClock()
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}