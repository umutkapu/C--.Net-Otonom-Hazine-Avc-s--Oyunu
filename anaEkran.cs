
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prolab2_1
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
            
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(anaEkran_KeyDown);
        }

        private void anaEkran_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && (xTextBox.Focused || yTextBox.Focused))
            {
                
                button1_Click_1(sender, e);
            }
        }



        private void cikisButonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int genislik = Convert.ToInt32(xTextBox.Text);
            int yukseklik = Convert.ToInt32(yTextBox.Text);

            if (yukseklik == 0 && genislik == 0)
            {
                MessageBox.Show("x ve y değerleri girmelisiniz");
            }
            else if (yukseklik == 0)
            {
                MessageBox.Show("y değeri girmelisiniz");
            }
            else if (genislik == 0)
            {
                MessageBox.Show("x değeri girmelisiniz");
            }

            HazineAvcisi form1 = new HazineAvcisi();
            form1.CreateMap(genislik, yukseklik);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
