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

namespace RussianRoulette
{
    public partial class MainForm : Form
    {

        RussianRouletteClass Logic = new RussianRouletteClass();
       

        public MainForm()
        {
            InitializeComponent();
            Logic.Bullet = 0;


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // disable spin, playagain, textbox, shoot button and enable load button only at MainForm Load
            LoadBtn.Enabled = true;
            SpinBtn.Enabled = false;
            EXIT.Enabled = false;
            GamePoints.Enabled = false;
            ShootheadBtn.Enabled = false;
            ShootawayBtn.Enabled = false;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Logic.Load();
            SoundPlayer player = new SoundPlayer(Resource1.Gunload);// playing sound when gun will be loaded
            player.Play();

            Logic.Bullet = 0;
            LoadgunPicture.Image = Resource1.loadgun;
            LoadBtn.Enabled = false;

            SpinBtn.Enabled = true;

        }
        private void SpinBtn_Click(object sender, EventArgs e)
        {
            Logic.Spin();
            LoadgunPicture.Image = Resource1.spin;
            SpinBtn.Enabled = false;
            ShootheadBtn.Enabled = true;
            ShootawayBtn.Enabled = true;

        }
        private void ShootheadBtn_Click(object sender, EventArgs e)
        {
            Logic.ShootAtHead();
            LoadgunPicture.Image = Resource1.loadgun;
            GamePoints.Text = Logic.Point + "";
                SoundPlayer player = new SoundPlayer(Resource1.Shot);
                player.Play();
            if (Logic.die == true)
            {
                
                ShootheadBtn.Enabled = false;
                ShootawayBtn.Enabled = false;

                EXIT.Enabled = true;
            }
            else
            {
                ShootheadBtn.Enabled = true;
                ShootawayBtn.Enabled = true;
                EXIT.Enabled = true;
            }
           
        }
          
        private void ShootawayBtn_Click_1(object sender, EventArgs e)
        {
            Logic.ShootAway();
            GamePoints.Text = Logic.Point + "";
            LoadgunPicture.Image = Resource1.loadgun;
            SoundPlayer player = new SoundPlayer(Resource1.Shot);
            player.Play();
            if (Logic.die == true)
            {
              
                    ShootheadBtn.Enabled = false;
                    ShootawayBtn.Enabled = false;

                    EXIT.Enabled = true;
               
           
            }
            else
            {
                ShootheadBtn.Enabled = true;
                ShootawayBtn.Enabled = true;

                EXIT.Enabled = true;

            }

        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit the game", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void PlayAgainbtn_Click_1(object sender, EventArgs e)
        {
            (new MainForm()).Show();
            this.Hide();
            EXIT.Enabled = true;


        }
    }
      
    }

      