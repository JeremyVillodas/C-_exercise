using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caso01
{
    public partial class Inicio2 : Form
    {
        public Inicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double note1,note2,note3,note4,note5,average,Total=0,noteDeleted;


            note1 = double.Parse(textBox6.Text);
            note2 = double.Parse(textBox5.Text);
            note3 = double.Parse(textBox4.Text);
            note4 = double.Parse(textBox1.Text);
            note5 = double.Parse(textBox2.Text);

            double[] notas = {note1,note2,note3,note4,note5};

            noteDeleted = notas[0];
            for (int i=0; i < notas.Length; i++)
            {
                if (notas[i] >20)
                {
                    MessageBox.Show("Ingrese una nota entre 1 y 20 en la nota : " + (i + 1));
                }

               if (notas[i] < noteDeleted)
               {
                    noteDeleted = notas[i];
                }
            }
            
            for (int x=0; x<notas.Length; x++)
            {
                Total += notas[x];
            }
            Total -= noteDeleted;
            average = Total / 4;

            textBox3.Text = average.ToString();
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
