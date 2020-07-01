using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public class RussianRouletteClass
    {
        public int Bullet;
        public int[] Gun = new int[6] { 0, 1, 2, 3, 4, 5 };
        public int ShootAwayChances = 2;
        public int Point = 0;
        public bool die = false;
       
       

        //load function will load the bullet in gun
        public void Load()
        {
            Bullet = 0;
        }

        //spin function used to spin chambers
        public void Spin()
        {
            Random rand = new Random();  // Random  is used to make bullet in a random position not in a static position
            Bullet = rand.Next(0, 6);
        }

        public void ShootAtHead()
        {

           if (Bullet == 5)
            {
               
                    MessageBox.Show("You Are Dead And You Lost the game");
                    Point = Point - 10; // Game Points will be deducted whenever person will die
                }


                else 
                {
                    MessageBox.Show("Lucky you, you can keep playing!");
                    Bullet++;
                }

            
        }

        public void ShootAway()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("You Survived and You Won The Game");
                Point = Point + 10; // Game Points will be added whenever person will survive
            }
            else
            {
                if (ShootAwayChances == 1)
                {
                    MessageBox.Show("You lost all the chances and you will definitely die");
                    Point = Point - 5;
                }
                else
                {
                    MessageBox.Show("You missed one of your chances");
                    Bullet++;
                    ShootAwayChances--;
                }
            }

        }
       

    }
}
