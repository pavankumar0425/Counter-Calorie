using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Calorie
{
    public partial class Form1 : Form
    {
        int totalCalories=0;
        int BanCt = 0;
        int PeaCt = 0;
        int AppCt = 0;
        int OraCt = 0;
        const int BAN_CAL = 115;
        const int PEA_CAL = 120;
        const int ORA_CAL = 90;
        const int APP_CAL = 80;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void picBoxBanana_Click(object sender, EventArgs e)
        {
            
            BanCt = BanCt + 1;
            totalCalories = totalCalories + (BanCt * BAN_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            lblCtBan.Text = BanCt.ToString();
                       
        }

        private void picBoxPear_Click(object sender, EventArgs e)
        {
           
            PeaCt = PeaCt + 1;
            totalCalories = totalCalories + (PeaCt * PEA_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            lblCtPea.Text = PeaCt.ToString();
        }

        private void picBoxOrange_Click(object sender, EventArgs e)
        {
           
            OraCt = OraCt + 1;
            totalCalories = totalCalories + (OraCt * ORA_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            lblCtOra.Text = OraCt.ToString();
        }

        private void picBoxApple_Click(object sender, EventArgs e)
        {
            
            AppCt = AppCt + 1;
            totalCalories = totalCalories + (AppCt * APP_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            lblCtApp.Text = AppCt.ToString();
        }

        private void btnResetBanana_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories - (BanCt * BAN_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            BanCt = 0;
            lblCtBan.Text = 0.ToString();

        }

        private void btnPearReset_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories - (PeaCt * PEA_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            PeaCt = 0;
            lblCtPea.Text = 0.ToString();

        }

        private void btnOrgReset_Click(object sender, EventArgs e)
        {
           totalCalories = totalCalories - (OraCt * ORA_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            OraCt = 0;
            lblCtOra.Text = 0.ToString();
        }

        private void btnAppleReset_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories - (AppCt * APP_CAL);
            lblTotalCalories.Text = totalCalories.ToString();
            AppCt = 0;
            lblCtApp.Text = 0.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotalCalories.Text = 0.ToString();
            lblCtBan.Text = 0.ToString();
            lblCtPea.Text = 0.ToString();
            lblCtOra.Text = 0.ToString();
            lblCtApp.Text = 0.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
