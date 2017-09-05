using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace RussianRoulette
{
    public partial class RussianRoulette : Form
    {
        Calculate myCalc =new Calculate();
        public RussianRoulette()
        {
            InitializeComponent();
            

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            //runs spinner class.  
            myCalc.spinner();

           
            lblRandom.Text = myCalc.Rnd.ToString();
            lblBulletsFired.Text = myCalc.BulletsFired.ToString();
            lblAway.Text = myCalc.Away.ToString();

            //Enables shoot and point away. Disables spin.

            btnShoot.Enabled = true;
            btnPointAway2.Enabled = true;
            btnSpin.Enabled = false;
            
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            
            myCalc.shoot();
            calculate();
            

        }

        private void btnPointAway2_Click(object sender, EventArgs e)
        {
            myCalc.pointAway();
            calculate();
        }

        public void calculate()
        {
            //runs calculate method in class
            myCalc.calculate();


            //changes whether you can shoot, point away, or spin as necessary depending on variables in class
            btnSpin.Enabled = myCalc.btnSpin;
            btnShoot.Enabled = myCalc.btnShoot;
            btnPointAway2.Enabled = myCalc.btnPointAway;


            //shows the number of bullets you have fired and times you have pointed away
            lblBulletsFired.Text = myCalc.BulletsFired.ToString();
            lblAway.Text = myCalc.Away.ToString();

            //displays winners, losers, and total on the form
            lblWins.Text = myCalc.TotalWins.ToString();
            lblLosses.Text = myCalc.TotalLosses.ToString();
            lblTotal.Text = myCalc.Total.ToString();
        }

        
        



    }
}
