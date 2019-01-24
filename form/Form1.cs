using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://youtu.be/VZrx1dNyn9U");
            i = 0;
        }
        Random r = new Random();
        TimeSpan intervalTimespan = new TimeSpan(0, 0, 0, 2, 2);

        private void ZZZ(object sender, EventArgs e)
        {
          

               
                this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                
                
              

           
        }

        private void EVENT__(object sender, EventArgs e)
        {
            if(textBox1.Text[textBox1.Text.Length-1] >= 'a' && textBox1.Text[textBox1.Text.Length - 1] <= 'z')
            {
                textBox1.Text = "";
                MessageBox.Show("eror by input ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jkk.ShowDialog();
            if (jkk.CheckPathExists)
            {
                textBox2.Text = jkk.FileName;
               pictureBox1.Image = Image.FromFile(@"" + textBox2.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); //פתח אץ הדיאלוג לצפייה 

            this.BackColor = colorDialog1.Color;//
        }

        private void gg_Click(object sender, EventArgs e)
        {
            if (r.Next(6) %2== 0)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }
    }
}
