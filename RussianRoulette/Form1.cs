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
        public RussianRoulette()
        {
            InitializeComponent();
            
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int ranNum;
          
            ranNum = random.Next(1, 7);
            lblRandom.Text = ranNum.ToString();
           
            lblBulletsFired.Text = 0.ToString();
            lblAway.Text = 0.ToString();

            btnShoot.Enabled = true;
            btnPointAway.Enabled = true;
            btnSpin.Enabled = false;
            
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            bool kill = true;
            calculate(kill);

        }

        private void btnPointAway_Click(object sender, EventArgs e)
        {
            
            bool kill = false;
            calculate(kill);
        }

        private void calculate(bool kill)
        {
            int ranNumber, bulletsFired, awayNumber, wins, losses, total;

            wins = Convert.ToInt16(lblWins.Text);
            losses = Convert.ToInt16(lblLosses.Text);
            total = Convert.ToInt16(lblTotal.Text);
            ranNumber = Convert.ToInt16(lblRandom.Text);
            bulletsFired = Convert.ToInt16(lblBulletsFired.Text);
            awayNumber = Convert.ToInt16(lblAway.Text);



            bulletsFired++;

             
            if (bulletsFired == ranNumber || awayNumber == 2)
            {
                SoundPlayer audio = new SoundPlayer(global::RussianRoulette.Properties.Resources.Revolver);
                audio.Play();
                if (kill == true)
            {
                    
                    MessageBox.Show("You are dead!");
                    losses++;
                }
                else
                {
                    MessageBox.Show("You survived!");
                    wins++;
                }
                total++;


                btnShoot.Enabled = false;
                btnPointAway.Enabled = false;
                btnSpin.Enabled = true;


            }
            else
            {
                MessageBox.Show("Empty");
            }
            if (kill == false)
            {
                awayNumber++;
            }

            lblBulletsFired.Text = bulletsFired.ToString();
            lblAway.Text = awayNumber.ToString();
            if (awayNumber == 2)
            {
                btnPointAway.Enabled = false;
            }
            lblWins.Text = wins.ToString();
            lblLosses.Text = losses.ToString();
            lblTotal.Text = total.ToString();
        }

        private void RussianRoulette_Load(object sender, EventArgs e)
        {

        }
    }
}
