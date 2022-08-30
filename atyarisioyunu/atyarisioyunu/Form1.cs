using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace atyarisioyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int delidumrulsolauzaklik, rusatisolauzaklik, gedifesolauzaklik;
        Random ras =new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int delidumrulgenislik = pictureBox1.Width;
            int rusatigenislik = pictureBox2.Width;
            int gedifegenislik = pictureBox3.Width;
            int fnish = pictureBox7.Left;
            int sure = Convert.ToInt32(lbl_sure.Text);
            sure++;
            lbl_sure.Text = sure.ToString();
            pictureBox1.Left += ras.Next(5,16);
            pictureBox2.Left+=ras.Next(5,16);
            pictureBox3.Left+=ras.Next(5,16);
            
            if (delidumrulgenislik + pictureBox1.Left >= fnish)
            {
                if(gedifegenislik + pictureBox2.Left > rusatigenislik) { 
                timer1.Enabled = false;
                pictureBox6.Visible = true;
                MessageBox.Show("delidumrul kazandııııııııı\n2.gedife\n3.rusatı");
               }else
                {
                    timer1.Enabled = false;
                    pictureBox6.Visible = true;
                    MessageBox.Show("delidumrul kazandııııııııı\n2.rusatı\n3.gedife");
                }
            }
            else if (rusatigenislik + pictureBox2.Left >= fnish)
            {
                if (delidumrulgenislik + pictureBox3.Left > gedifegenislik)
                {
                    timer1.Enabled = false;
                    pictureBox5.Visible = true;
                    MessageBox.Show("rus atı kazandıııııııııııı\n2.delidumrul\n3.gedife");
                }
                else
                {
                    timer1.Enabled = false;
                    pictureBox5.Visible = true;
                    MessageBox.Show("rus atı kazandıııııııııııı\n2.gedife\n3.delidumrul");                    
                }
               
            }
            else if(gedifegenislik + pictureBox3.Left >= fnish)
            {
                if (delidumrulgenislik + pictureBox1.Left > rusatigenislik + pictureBox2.Left)
                {
                   timer1.Enabled = false;
                   pictureBox4.Visible = true  ;
                   MessageBox.Show("gedife kazandıııııııııııııı\n2.delidumrul\n3.rusatı");
                }
                else
                {
                    timer1.Enabled = false;
                    pictureBox4.Visible = true;
                    MessageBox.Show("gedife kazandıııııııııııııı\n2.rusatı\n3.delidumrul");                    
                } 
            }
            if(pictureBox1.Left>pictureBox2.Left  && pictureBox1.Left > pictureBox3.Left )
            {
                lbl_durum.Text = "delidumrul yarışı önde götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left )
            {
                lbl_durum.Text = "rus atı harika bir şekilde önde ilerliyor";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                lbl_durum.Text = "gedife atak yaptı uçuyor emin adımlarla 1.liğe";
            }   
        }
        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            delidumrulsolauzaklik = pictureBox1.Left;
            rusatisolauzaklik = pictureBox2.Left;
            gedifesolauzaklik = pictureBox3.Left;
        }
    }
}