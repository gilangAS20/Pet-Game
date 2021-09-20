using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_hewan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> listOfHistory = new List<String>();
        int arah;
        private void timerKucing_Tick(object sender, EventArgs e)
        {
            
            if (pictureBoxKucing.Left < 1)
            {
                arah = 1;
                pictureBoxKucing.Image = Properties.Resources.happy_cat;
            }
            if (pictureBoxKucing.Right >= this.Width)
            {
                arah = -1;
                pictureBoxKucing.Image = Properties.Resources.happy_cat;
            }
            pictureBoxKucing.Left += arah * 10;
        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            
            timerKucing.Enabled = true;
            timerRandom.Enabled = true;
            /*
            timerBugar.Enabled = true;
            timerKenyang.Enabled = true;
            timerSenang.Enabled = true;
            */
             

        }

        private void buttonBerhenti_Click(object sender, EventArgs e)
        {
            timerRandom.Enabled = false;
            /*
            timerKucing.Enabled = false;
            timerBugar.Enabled = false;
            timerKenyang.Enabled = false;
            timerSenang.Enabled = false; 
            */
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arah = 1;
            this.DoubleBuffered = true;
            progressBarKenyang.Value = 70;
            progressBarBugar.Value = 40;
            progressBarSenang.Value = 80;

            //textBoxSenang.Enabled = true;
            labelUwu.Enabled = true;

           // labelKenyang.Text = "kjbdsf";
            //labelUwu.Text = "aniewf";


            /* if (progressBarBugar.Value ==0)
             {
                 timerRandom.Enabled = false;
             }  */

            if (progressBarBugar.Value == 0)
            {
                //timerBugar.Enabled = false;
               
            }

            if (progressBarKenyang.Value == 0)
            {
                //timerKenyang.Enabled = false;
            }

            if (progressBarSenang.Value == 0)
            {
               // timerSenang.Enabled = false;
            }

            if(progressBarBugar.Value == 0)
            {
                pictureBoxKucing.Image = Properties.Resources.dead_cat;
            }

            if(progressBarKenyang.Value==0)
            {
                timerRandom.Enabled = false;
                MessageBox.Show("game over");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButtonMakan.Checked == true)
            {
                if (progressBarKenyang.Value < progressBarKenyang.Maximum)
                {
                    progressBarKenyang.Value += 10;
                    pictureBoxKucing.Image = Properties.Resources.eat_cat;
                    listOfHistory.Add("kenyang +10");

                }
                else
                {
                    MessageBox.Show("udah kenyang");
                    pictureBoxKucing.Image = Properties.Resources.happy_cat;
                }
            }

            else if (radioButtonMain.Checked == true)
            {
                if (progressBarSenang.Value < progressBarSenang.Maximum)
                {
                    progressBarSenang.Value += 10;
                    pictureBoxKucing.Image = Properties.Resources.play_cat;
                    listOfHistory.Add("senang +10");
                }
                else
                {
                    MessageBox.Show("udah senang");
                    pictureBoxKucing.Image = Properties.Resources.happy_cat;
                }
            }

            else if(radioButtonTidur.Checked == true)
            {
                if(progressBarBugar.Value < progressBarBugar.Maximum)
                {
                    progressBarBugar.Value += 10;
                    pictureBoxKucing.Image = Properties.Resources.sleep_cat;
                    listOfHistory.Add("bugar +10");
                }
                else
                {
                    MessageBox.Show("udah bugar");
                }
            }

            else if (radioButtonPijat.Checked == true)
            {
                if (progressBarBugar.Value < progressBarBugar.Maximum)
                {
                    progressBarBugar.Value += 10;
                    pictureBoxKucing.Image = Properties.Resources.cat_pijat;
                    listOfHistory.Add("bugar +10");
                }
                else
                {
                    MessageBox.Show("udah bugar");
                }
            }
            listBox1.Items.Clear();
            for (int i = 0; i < listOfHistory.Count; i++)
            {
                listBox1.Items.Add(listOfHistory[i]);
            }
            
        }

         private void timerKenyang_Tick(object sender, EventArgs e)
        {

            //timerProgress.Enabled = true;
            if (progressBarKenyang.Value != 0)
            {
                progressBarKenyang.Value -= 10;
            }
           /* if(progressBarKenyang.Value == 0)
            {
                timerKenyang.Enabled = false;
            }
           */
        }

        private void timerSenang_Tick(object sender, EventArgs e)
        {
            if (progressBarSenang.Value != 0)
            {
                progressBarSenang.Value -= 10;
            }
          /*  if(progressBarSenang.Value == 0)
            {
                timerSenang.Enabled = false;

            }
          */
        }

        private void progressBarSenang_Click(object sender, EventArgs e)
        {

        }

        private void timerBugar_Tick(object sender, EventArgs e)
        {   
            if (progressBarBugar.Value != 0)
            {
                progressBarBugar.Value -= 10;
            }
           /* if(progressBarBugar.Value == 0)
            {
                timerBugar.Enabled = false;
            }
           */
        }

        private void progressBarKenyang_Click(object sender, EventArgs e)
        {
            /*if (progressBarKenyang.Value < 10)
            {
                MessageBox.Show("lapar bos");
            } */
          /*  if(progressBarKenyang.Value < 50)
            {
                labelKenyang.Text = "lapar";
            }
          */
          /*  if (progressBarKenyang.Value == 0)
            {
                timerKenyang.Enabled = false;
            }
          */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxKucing.Visible = false;
        }

        private void buttonSini_Click(object sender, EventArgs e)
        {
            pictureBoxKucing.Visible = true;
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {
            Random kurang = new Random();
            int hasil = kurang.Next(1, 3);
            /*
            if(progressBarKenyang.Value == 0)
            {
                timerRandom.Enabled = false;
            }
            */
            
           

            if (hasil == 1)
            {
                
                
                    progressBarKenyang.Value -= 10;
                
                
            }
            if (hasil == 2)
            {
                
                
                    progressBarSenang.Value -= 10;
                
                
            }
            if(hasil == 3)
            {
                
                
                    progressBarBugar.Value -= 10;
                
                
            }
                
        }

        private void labelKenyang_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSenang_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMakan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
