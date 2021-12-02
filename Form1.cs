using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        Button btn;
        Button btn2;
        public Form1()
        {
            this.Height = 700;//высота
            this.Width = 900;//ширина
            this.Text = "Rock_Paper_Scissors";//загловок формы
            this.BackColor = Color.Wheat;//цвет фона формы

            btn = new Button();
            btn.BackColor = Color.White;
            btn.Text = "Two player";
            btn.Location = new Point(Top = 250, 30);
            btn.Size = new Size(100, 30);
            btn.Click += Btn_Click;

            btn2 = new Button();
            btn2.BackColor = Color.White;
            btn2.Text = "Play with bot";
            btn2.Location = new Point(Top = 490, 30);
            btn2.Size = new Size(100, 30);
            btn2.Click += Btn2_Click;


            this.Controls.Add(btn2);
            this.Controls.Add(btn);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
