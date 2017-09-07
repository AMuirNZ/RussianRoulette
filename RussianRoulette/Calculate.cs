using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;



namespace RussianRoulette


{
    public class Calculate
    {

        //variables linked to the lables in the form
        public int BulletsFired { get; set; }
        public int Away { get; set; }
        public int Total { get; set; }
        public int TotalLosses { get; set; }
        public int TotalWins { get; set; }
        public int Rnd { get; set; }
        public bool btnShoot { get; set; }
        public bool btnPointAway { get; set; }
        public bool btnSpin { get; set; }
        public bool kill { get; set; }


       
        public void spinner()
        {
            //randomly picks number
            Random random = new Random(DateTime.Now.Millisecond);
            Rnd = random.Next(1, 7);

            //resets point away and bullets fired
            BulletsFired = 0;
            Away = 0;
        }

        public void shoot()
        {
            
            kill = true;
            
        }

        public void pointAway()
        {
            kill = false;
            
        }

        public void calculate()
        {
            BulletsFired++;



            if (BulletsFired == Rnd || Away == 2)
            

            {

                fires();





            }
            else
            {
                blank();
               
            }

            


        }
         public void fires()
        {
            //plays audio 
            SoundPlayer audio = new SoundPlayer(global::RussianRoulette.Properties.Resources.Revolver);
            audio.Play();

            // 
            if (kill == true)
            {

                //Winning solution
                MessageBox.Show("You are dead!");
                //losses++;
                TotalLosses++;
            }
            else
            {
                //Losing solution
                MessageBox.Show("You survived!");
                //  wins++;
                TotalWins++;
            }
            Total++;

            //changes variables to reset game
            Away = 0;
            btnShoot = false;
            btnPointAway = false;
            btnSpin = true;
        }

       public void blank()
        {

            //if bullet chamber is empty
            MessageBox.Show("Empty");
            btnShoot = true;
            btnSpin = false;

            Away = awayAdded(Away);

           

            btnPointAway = awayTrueOrFalse(Away);


        }
        public bool awayTrueOrFalse(int Away2)
        {
            //If away is 2 disables PointAway button

            if (Away2 == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int awayAdded(int Away2)
        {
            //Adds an away if point away is fired
            int AwayPlusPlus = Away + 1;
            if (kill == false)
            {
                return AwayPlusPlus;
            }
            else
            {
                return Away;
            }
                
        }
       

        
    }
}

