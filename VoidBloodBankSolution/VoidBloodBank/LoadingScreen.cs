using System;
using System.Windows.Forms;

namespace VoidBloodBank
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            new RoundCornerForm(this);
        }

        //Loading Screens Loading Time
        private void Timer_Loading_Tick(object sender, EventArgs e)
        {
            Panel_FillProgress.Width += 2;
            if (Panel_FillProgress.Width >= 600)
            {
                Timer_Loading.Enabled = false;
                this.Hide();
                new Login().Show();
            }
        }
    }
}
