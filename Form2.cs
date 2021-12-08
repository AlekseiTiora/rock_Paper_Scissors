using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_Paper_Scissors
{
    public partial class Form2 : Form
    {
        Button btn;
        TextBox txt;
        Label lbl_p;
        Label lbl_bot;
        RadioButton rb;
        RadioButton rb1;
        RadioButton rb2;
        public Form2()
        {
            this.Size = new Size(500, 300);
            this.Text = "Rock_Paper_Scissors";
            this.BackgroundImage = new Bitmap(@"../../img/fon.jpg"); //картина фона формы

            Label lbl = new Label();
            lbl.Text = "kirjuta oma nickName:";
            lbl.Location = new Point(190, 70);
            lbl.Size = new Size(125, 15);
            lbl.BackColor= Color.White;

            txt = new TextBox();
            txt.Location = new Point(125, 90);
            txt.Size = new Size(250, 30);

            Button btn = new Button();
            btn.Size = new Size(150, 30);
            btn.Location = new Point(170, 120);
            btn.Text = "Edasi";
            btn.Click += Btn_Click;

            lbl_p = new Label();
            lbl_p.Location = new Point(240, 70);
            lbl_p.Font = new Font("Arial", 22, FontStyle.Bold);
            lbl_p.BackColor = Color.White;
            lbl_p.ForeColor = Color.Black;
            lbl_p.TextChanged += Lbl_p_TextChanged;

            lbl_bot = new Label();
            lbl_bot.Text = "BOT";
            lbl_bot.Location = new Point(560, 70);
            lbl_bot.Size = new Size(100, 30);
            lbl_bot.Font = new Font("Arial",20, FontStyle.Bold);
            lbl_bot.BackColor = Color.White;
            lbl_bot.ForeColor = Color.Black;

            rb = new RadioButton();
            rb.Text = "Kivi";
            rb


            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(btn);
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            List<string> list = new List<string>();  // List of random NickName
            list.Add("draken");
            list.Add("maiky");


            Random rnd = new Random();
            int numb = rnd.Next(list.Count);



            using (StreamWriter writer = new StreamWriter(@"../../player.txt"))  // Write file using StreamWriter
            {
                writer.WriteLine(txt.Text);
            } 

            this.Size = new Size(900, 700);

            string readText = File.ReadAllText(@"../../player.txt");  // Read file 
            if (String.IsNullOrEmpty(txt.Text))
            {
                lbl_p.Text = list[numb];
            }
            else
            {
                lbl_p.Text = readText;
            }

            this.Controls.Add(lbl_p);
            this.Controls.Add(lbl_bot);

        }       
        private void Lbl_p_TextChanged(object sender, EventArgs e)
        {
            Size size_p = TextRenderer.MeasureText(lbl_p.Text, lbl_p.Font);
            lbl_p.Size = new Size(size_p.Width, size_p.Height);
        }
    }
}
