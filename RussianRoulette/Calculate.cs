﻿using System;
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
            Random random = new Random(DateTime.Now.Millisecond);
            Rnd = random.Next(1, 7);
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
            SoundPlayer audio = new SoundPlayer(global::RussianRoulette.Properties.Resources.Revolver);
            audio.Play();
            if (kill == true)
            {

                MessageBox.Show("You are dead!");
                //losses++;
                TotalLosses++;
            }
            else
            {
                MessageBox.Show("You survived!");
                //  wins++;
                TotalWins++;
            }
            Total++;

            Away = 0;
            btnShoot = false;
            btnPointAway = false;
            btnSpin = true;
        }

       public void blank()
        {
            MessageBox.Show("Empty");
            btnShoot = true;
            btnSpin = false;

            Away = awayAdded(Away);

           

            btnPointAway = awayTrueOrFalse(Away);


        }
        public bool awayTrueOrFalse(int Away2)
        {
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

