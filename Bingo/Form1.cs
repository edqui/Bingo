using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class MarcadorBingo : Form
    {
        public MarcadorBingo()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Gray)
                button1.BackColor = Color.White;
            else
                button1.BackColor = Color.Gray;

            if (textBox1.Visible == false)
                textBox1.Visible = true;
            else
                textBox1.Visible = false;
            if (textBox1.Visible == true)
                textBox1.Text = "1";

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Gray)
                button2.BackColor = Color.White;
            else
                button2.BackColor = Color.Gray;

            if (textBox2.Visible == false)
                textBox2.Visible = true;
            else
                textBox2.Visible = false;
            if (textBox2.Visible == true)
                textBox2.Text = "2";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Gray)
                button3.BackColor = Color.White;
            else
                button3.BackColor = Color.Gray;

            if (textBox3.Visible == false)
                textBox3.Visible = true;
            else
                textBox3.Visible = false;
            if (textBox3.Visible == true)
                textBox3.Text = "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Gray)
                button4.BackColor = Color.White;
            else
                button4.BackColor = Color.Gray;

            if (textBox4.Visible == false)
                textBox4.Visible = true;
            else
                textBox4.Visible = false;
            if (textBox4.Visible == true)
                textBox4.Text = "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Gray)
                button5.BackColor = Color.White;
            else
                button5.BackColor = Color.Gray;

            if (textBox5.Visible == false)
                textBox5.Visible = true;
            else
                textBox5.Visible = false;
            if (textBox5.Visible == true)
                textBox5.Text = "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Gray)
                button6.BackColor = Color.White;
            else
                button6.BackColor = Color.Gray;

            if (textBox6.Visible == false)
                textBox6.Visible = true;
            else
                textBox6.Visible = false;
            if (textBox6.Visible == true)
                textBox6.Text = "6";
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Gray)
                button7.BackColor = Color.White;
            else
                button7.BackColor = Color.Gray;

            if (textBox7.Visible == false)
                textBox7.Visible = true;
            else
                textBox7.Visible = false;
            if (textBox7.Visible == true)
                textBox7.Text = "7";
        }


        private void Button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Gray)
                button8.BackColor = Color.White;
            else
                button8.BackColor = Color.Gray;

            if (textBox8.Visible == false)
                textBox8.Visible = true;
            else
                textBox8.Visible = false;
            if (textBox8.Visible == true)
                textBox8.Text = "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Gray)
                button9.BackColor = Color.White;
            else
                button9.BackColor = Color.Gray;

            if (textBox9.Visible == false)
                textBox9.Visible = true;
            else
                textBox9.Visible = false;
            if (textBox9.Visible == true)
                textBox9.Text = "9";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Gray)
                button10.BackColor = Color.White;
            else
                button10.BackColor = Color.Gray;

            if (textBox10.Visible == false)
                textBox10.Visible = true;
            else
                textBox10.Visible = false;
            if (textBox10.Visible == true)
                textBox10.Text = "10";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Gray)
                button11.BackColor = Color.White;
            else
                button11.BackColor = Color.Gray;

            if (textBox11.Visible == false)
                textBox11.Visible = true;
            else
                textBox11.Visible = false;
            if (textBox11.Visible == true)
                textBox11.Text = "11";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Gray)
                button12.BackColor = Color.White;
            else
                button12.BackColor = Color.Gray;

            if (textBox12.Visible == false)
                textBox12.Visible = true;
            else
                textBox12.Visible = false;
            if (textBox12.Visible == true)
                textBox12.Text = "12";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Gray)
                button13.BackColor = Color.White;
            else
                button13.BackColor = Color.Gray;

            if (textBox13.Visible == false)
                textBox13.Visible = true;
            else
                textBox13.Visible = false;
            if (textBox13.Visible == true)
                textBox13.Text = "13";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Gray)
                button14.BackColor = Color.White;
            else
                button14.BackColor = Color.Gray;

            if (textBox14.Visible == false)
                textBox14.Visible = true;
            else
                textBox14.Visible = false;
            if (textBox14.Visible == true)
                textBox14.Text = "14";
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Gray)
                button15.BackColor = Color.White;
            else
                button15.BackColor = Color.Gray;

            if (textBox15.Visible == false)
                textBox15.Visible = true;
            else
                textBox15.Visible = false;
            if (textBox15.Visible == true)
                textBox15.Text = "15";
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Gray)
                button16.BackColor = Color.White;
            else
                button16.BackColor = Color.Gray;

            if (textBox16.Visible == false)
                textBox16.Visible = true;
            else
                textBox16.Visible = false;
            if (textBox16.Visible == true)
                textBox16.Text = "16";
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Gray)
                button17.BackColor = Color.White;
            else
                button17.BackColor = Color.Gray;

            if (textBox17.Visible == false)
                textBox17.Visible = true;
            else
                textBox17.Visible = false;
            if (textBox17.Visible == true)
                textBox17.Text = "17";
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Gray)
                button18.BackColor = Color.White;
            else
                button18.BackColor = Color.Gray;

            if (textBox18.Visible == false)
                textBox18.Visible = true;
            else
                textBox18.Visible = false;
            if (textBox18.Visible == true)
                textBox18.Text = "18";
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Gray)
                button19.BackColor = Color.White;
            else
                button19.BackColor = Color.Gray;

            if (textBox19.Visible == false)
                textBox19.Visible = true;
            else
                textBox19.Visible = false;
            if (textBox19.Visible == true)
                textBox19.Text = "19";
        }
        private void Button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Gray)
                button20.BackColor = Color.White;
            else
                button20.BackColor = Color.Gray;

            if (textBox20.Visible == false)
                textBox20.Visible = true;
            else
                textBox20.Visible = false;
            if (textBox20.Visible == true)
                textBox20.Text = "20";
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Gray)
                button21.BackColor = Color.White;
            else
                button21.BackColor = Color.Gray;

            if (textBox21.Visible == false)
                textBox21.Visible = true;
            else
                textBox21.Visible = false;
            if (textBox21.Visible == true)
                textBox21.Text = "21";
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Gray)
                button22.BackColor = Color.White;
            else
                button22.BackColor = Color.Gray;

            if (textBox22.Visible == false)
                textBox22.Visible = true;
            else
                textBox22.Visible = false;
            if (textBox22.Visible == true)
                textBox22.Text = "22";
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Gray)
                button23.BackColor = Color.White;
            else
                button23.BackColor = Color.Gray;

            if (textBox23.Visible == false)
                textBox23.Visible = true;
            else
                textBox23.Visible = false;
            if (textBox23.Visible == true)
                textBox23.Text = "23";
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Gray)
                button24.BackColor = Color.White;
            else
                button24.BackColor = Color.Gray;

            if (textBox24.Visible == false)
                textBox24.Visible = true;
            else
                textBox24.Visible = false;
            if (textBox24.Visible == true)
                textBox24.Text = "24";
        }
        private void Button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Gray)
                button25.BackColor = Color.White;
            else
                button25.BackColor = Color.Gray;

            if (textBox25.Visible == false)
                textBox25.Visible = true;
            else
                textBox25.Visible = false;
            if (textBox25.Visible == true)
                textBox25.Text = "25";
        }
        private void Button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Gray)
                button26.BackColor = Color.White;
            else
                button26.BackColor = Color.Gray;

            if (textBox26.Visible == false)
                textBox26.Visible = true;
            else
                textBox26.Visible = false;
            if (textBox26.Visible == true)
                textBox26.Text = "26";
        }
        private void Button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.Gray)
                button27.BackColor = Color.White;
            else
                button27.BackColor = Color.Gray;

            if (textBox27.Visible == false)
                textBox27.Visible = true;
            else
                textBox27.Visible = false;
            if (textBox27.Visible == true)
                textBox27.Text = "27";
        }
        private void Button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.Gray)
                button28.BackColor = Color.White;
            else
                button28.BackColor = Color.Gray;

            if (textBox28.Visible == false)
                textBox28.Visible = true;
            else
                textBox28.Visible = false;
            if (textBox28.Visible == true)
                textBox28.Text = "28";
        }
        private void Button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.Gray)
                button29.BackColor = Color.White;
            else
                button29.BackColor = Color.Gray;

            if (textBox29.Visible == false)
                textBox29.Visible = true;
            else
                textBox29.Visible = false;
            if (textBox29.Visible == true)
                textBox29.Text = "29";
        }
        private void Button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.Gray)
                button30.BackColor = Color.White;
            else
                button30.BackColor = Color.Gray;

            if (textBox30.Visible == false)
                textBox30.Visible = true;
            else
                textBox30.Visible = false;
            if (textBox30.Visible == true)
                textBox30.Text = "30";
        }
        private void Button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == Color.Gray)
                button31.BackColor = Color.White;
            else
                button31.BackColor = Color.Gray;

            if (textBox31.Visible == false)
                textBox31.Visible = true;
            else
                textBox31.Visible = false;
            if (textBox31.Visible == true)
                textBox31.Text = "31";
        }
        private void Button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == Color.Gray)
                button32.BackColor = Color.White;
            else
                button32.BackColor = Color.Gray;

            if (textBox32.Visible == false)
                textBox32.Visible = true;
            else
                textBox32.Visible = false;
            if (textBox32.Visible == true)
                textBox32.Text = "32";
        }
        private void Button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Gray)
                button33.BackColor = Color.White;
            else
                button33.BackColor = Color.Gray;

            if (textBox33.Visible == false)
                textBox33.Visible = true;
            else
                textBox33.Visible = false;
            if (textBox33.Visible == true)
                textBox33.Text = "33";
        }
        private void Button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.Gray)
                button34.BackColor = Color.White;
            else
                button34.BackColor = Color.Gray;

            if (textBox34.Visible == false)
                textBox34.Visible = true;
            else
                textBox34.Visible = false;
            if (textBox34.Visible == true)
                textBox34.Text = "34";
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.Gray)
                button35.BackColor = Color.White;
            else
                button35.BackColor = Color.Gray;

            if (textBox35.Visible == false)
                textBox35.Visible = true;
            else
                textBox35.Visible = false;
            if (textBox35.Visible == true)
                textBox35.Text = "35";
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == Color.Gray)
                button36.BackColor = Color.White;
            else
                button36.BackColor = Color.Gray;

            if (textBox36.Visible == false)
                textBox36.Visible = true;
            else
                textBox36.Visible = false;
            if (textBox36.Visible == true)
                textBox36.Text = "36";
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.Gray)
                button37.BackColor = Color.White;
            else
                button37.BackColor = Color.Gray;

            if (textBox37.Visible == false)
                textBox37.Visible = true;
            else
                textBox37.Visible = false;
            if (textBox37.Visible == true)
                textBox37.Text = "37";
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            if (button38.BackColor == Color.Gray)
                button38.BackColor = Color.White;
            else
                button38.BackColor = Color.Gray;

            if (textBox38.Visible == false)
                textBox38.Visible = true;
            else
                textBox38.Visible = false;
            if (textBox38.Visible == true)
                textBox38.Text = "38";
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.Gray)
                button39.BackColor = Color.White;
            else
                button39.BackColor = Color.Gray;

            if (textBox39.Visible == false)
                textBox39.Visible = true;
            else
                textBox39.Visible = false;
            if (textBox39.Visible == true)
                textBox39.Text = "39";
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.Gray)
                button40.BackColor = Color.White;
            else
                button40.BackColor = Color.Gray;

            if (textBox40.Visible == false)
                textBox40.Visible = true;
            else
                textBox40.Visible = false;
            if (textBox40.Visible == true)
                textBox40.Text = "40";
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.Gray)
                button41.BackColor = Color.White;
            else
                button41.BackColor = Color.Gray;

            if (textBox41.Visible == false)
                textBox41.Visible = true;
            else
                textBox41.Visible = false;
            if (textBox41.Visible == true)
                textBox41.Text = "41";
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            if (button42.BackColor == Color.Gray)
                button42.BackColor = Color.White;
            else
                button42.BackColor = Color.Gray;

            if (textBox42.Visible == false)
                textBox42.Visible = true;
            else
                textBox42.Visible = false;
            if (textBox42.Visible == true)
                textBox42.Text = "42";
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor == Color.Gray)
                button43.BackColor = Color.White;
            else
                button43.BackColor = Color.Gray;

            if (textBox43.Visible == false)
                textBox43.Visible = true;
            else
                textBox43.Visible = false;
            if (textBox43.Visible == true)
                textBox43.Text = "43";
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            if (button44.BackColor == Color.Gray)
                button44.BackColor = Color.White;
            else
                button44.BackColor = Color.Gray;

            if (textBox44.Visible == false)
                textBox44.Visible = true;
            else
                textBox44.Visible = false;
            if (textBox44.Visible == true)
                textBox44.Text = "44";
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.Gray)
                button45.BackColor = Color.White;
            else
                button45.BackColor = Color.Gray;

            if (textBox45.Visible == false)
                textBox45.Visible = true;
            else
                textBox45.Visible = false;
            if (textBox45.Visible == true)
                textBox45.Text = "45";
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            if (button46.BackColor == Color.Gray)
                button46.BackColor = Color.White;
            else
                button46.BackColor = Color.Gray;

            if (textBox46.Visible == false)
                textBox46.Visible = true;
            else
                textBox46.Visible = false;
            if (textBox46.Visible == true)
                textBox46.Text = "46";
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor == Color.Gray)
                button47.BackColor = Color.White;
            else
                button47.BackColor = Color.Gray;

            if (textBox47.Visible == false)
                textBox47.Visible = true;
            else
                textBox47.Visible = false;
            if (textBox47.Visible == true)
                textBox47.Text = "47";
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            if (button48.BackColor == Color.Gray)
                button48.BackColor = Color.White;
            else
                button48.BackColor = Color.Gray;

            if (textBox48.Visible == false)
                textBox48.Visible = true;
            else
                textBox48.Visible = false;
            if (textBox48.Visible == true)
                textBox48.Text = "48";
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            if (button49.BackColor == Color.Gray)
                button49.BackColor = Color.White;
            else
                button49.BackColor = Color.Gray;

            if (textBox49.Visible == false)
                textBox49.Visible = true;
            else
                textBox49.Visible = false;
            if (textBox49.Visible == true)
                textBox49.Text = "49";
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            if (button50.BackColor == Color.Gray)
                button50.BackColor = Color.White;
            else
                button50.BackColor = Color.Gray;

            if (textBox50.Visible == false)
                textBox50.Visible = true;
            else
                textBox50.Visible = false;
            if (textBox50.Visible == true)
                textBox50.Text = "50";
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            if (button51.BackColor == Color.Gray)
                button51.BackColor = Color.White;
            else
                button51.BackColor = Color.Gray;

            if (textBox51.Visible == false)
                textBox51.Visible = true;
            else
                textBox51.Visible = false;
            if (textBox51.Visible == true)
                textBox51.Text = "51";
        }

        private void Button52_Click(object sender, EventArgs e)
        {
            if (button52.BackColor == Color.Gray)
                button52.BackColor = Color.White;
            else
                button52.BackColor = Color.Gray;

            if (textBox52.Visible == false)
                textBox52.Visible = true;
            else
                textBox52.Visible = false;
            if (textBox52.Visible == true)
                textBox52.Text = "52";
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            if (button53.BackColor == Color.Gray)
                button53.BackColor = Color.White;
            else
                button53.BackColor = Color.Gray;

            if (textBox53.Visible == false)
                textBox53.Visible = true;
            else
                textBox53.Visible = false;
            if (textBox53.Visible == true)
                textBox53.Text = "53";
        }

        private void Button54_Click(object sender, EventArgs e)
        {
            if (button54.BackColor == Color.Gray)
                button54.BackColor = Color.White;
            else
                button54.BackColor = Color.Gray;

            if (textBox54.Visible == false)
                textBox54.Visible = true;
            else
                textBox54.Visible = false;
            if (textBox54.Visible == true)
                textBox54.Text = "54";
        }

        private void Button55_Click(object sender, EventArgs e)
        {
            if (button55.BackColor == Color.Gray)
                button55.BackColor = Color.White;
            else
                button55.BackColor = Color.Gray;

            if (textBox55.Visible == false)
                textBox55.Visible = true;
            else
                textBox55.Visible = false;
            if (textBox55.Visible == true)
                textBox55.Text = "55";
        }

        private void Button56_Click(object sender, EventArgs e)
        {
            if (button56.BackColor == Color.Gray)
                button56.BackColor = Color.White;
            else
                button56.BackColor = Color.Gray;

            if (textBox56.Visible == false)
                textBox56.Visible = true;
            else
                textBox56.Visible = false;
            if (textBox56.Visible == true)
                textBox56.Text = "56";
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            if (button57.BackColor == Color.Gray)
                button57.BackColor = Color.White;
            else
                button57.BackColor = Color.Gray;

            if (textBox57.Visible == false)
                textBox57.Visible = true;
            else
                textBox57.Visible = false;
            if (textBox57.Visible == true)
                textBox57.Text = "57";
        }

        private void Button58_Click(object sender, EventArgs e)
        {
            if (button58.BackColor == Color.Gray)
                button58.BackColor = Color.White;
            else
                button58.BackColor = Color.Gray;

            if (textBox58.Visible == false)
                textBox58.Visible = true;
            else
                textBox58.Visible = false;
            if (textBox58.Visible == true)
                textBox58.Text = "58";
        }

        private void Button59_Click(object sender, EventArgs e)
        {
            if (button59.BackColor == Color.Gray)
                button59.BackColor = Color.White;
            else
                button59.BackColor = Color.Gray;

            if (textBox59.Visible == false)
                textBox59.Visible = true;
            else
                textBox59.Visible = false;
            if (textBox59.Visible == true)
                textBox59.Text = "59";
        }

        private void Button60_Click(object sender, EventArgs e)
        {
            if (button60.BackColor == Color.Gray)
                button60.BackColor = Color.White;
            else
                button60.BackColor = Color.Gray;

            if (textBox60.Visible == false)
                textBox60.Visible = true;
            else
                textBox60.Visible = false;
            if (textBox60.Visible == true)
                textBox60.Text = "60";
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            if (button61.BackColor == Color.Gray)
                button61.BackColor = Color.White;
            else
                button61.BackColor = Color.Gray;

            if (textBox61.Visible == false)
                textBox61.Visible = true;
            else
                textBox61.Visible = false;
            if (textBox61.Visible == true)
                textBox61.Text = "61";
        }

        private void Button62_Click(object sender, EventArgs e)
        {
            if (button62.BackColor == Color.Gray)
                button62.BackColor = Color.White;
            else
                button62.BackColor = Color.Gray;

            if (textBox62.Visible == false)
                textBox62.Visible = true;
            else
                textBox62.Visible = false;
            if (textBox62.Visible == true)
                textBox62.Text = "62";
        }

        private void Button63_Click(object sender, EventArgs e)
        {
            if (button63.BackColor == Color.Gray)
                button63.BackColor = Color.White;
            else
                button63.BackColor = Color.Gray;

            if (textBox63.Visible == false)
                textBox63.Visible = true;
            else
                textBox63.Visible = false;
            if (textBox63.Visible == true)
                textBox63.Text = "63";
        }

        private void Button64_Click(object sender, EventArgs e)
        {
            if (button64.BackColor == Color.Gray)
                button64.BackColor = Color.White;
            else
                button64.BackColor = Color.Gray;

            if (textBox64.Visible == false)
                textBox64.Visible = true;
            else
                textBox64.Visible = false;
            if (textBox64.Visible == true)
                textBox64.Text = "64";
        }

        private void Button65_Click(object sender, EventArgs e)
        {
            if (button65.BackColor == Color.Gray)
                button65.BackColor = Color.White;
            else
                button65.BackColor = Color.Gray;

            if (textBox65.Visible == false)
                textBox65.Visible = true;
            else
                textBox65.Visible = false;
            if (textBox65.Visible == true)
                textBox65.Text = "65";
        }

        private void Button66_Click(object sender, EventArgs e)
        {
            if (button66.BackColor == Color.Gray)
                button66.BackColor = Color.White;
            else
                button66.BackColor = Color.Gray;

            if (textBox66.Visible == false)
                textBox66.Visible = true;
            else
                textBox66.Visible = false;
            if (textBox66.Visible == true)
                textBox66.Text = "66";
        }

        private void Button67_Click(object sender, EventArgs e)
        {
            if (button67.BackColor == Color.Gray)
                button67.BackColor = Color.White;
            else
                button67.BackColor = Color.Gray;

            if (textBox67.Visible == false)
                textBox67.Visible = true;
            else
                textBox67.Visible = false;
            if (textBox67.Visible == true)
                textBox67.Text = "67";
        }

        private void Button68_Click(object sender, EventArgs e)
        {
            if (button68.BackColor == Color.Gray)
                button68.BackColor = Color.White;
            else
                button68.BackColor = Color.Gray;

            if (textBox68.Visible == false)
                textBox68.Visible = true;
            else
                textBox68.Visible = false;
            if (textBox68.Visible == true)
                textBox68.Text = "68";
        }

        private void Button69_Click(object sender, EventArgs e)
        {
            if (button69.BackColor == Color.Gray)
                button69.BackColor = Color.White;
            else
                button69.BackColor = Color.Gray;

            if (textBox69.Visible == false)
                textBox69.Visible = true;
            else
                textBox69.Visible = false;
            if (textBox69.Visible == true)
                textBox69.Text = "69";
        }

        private void Button70_Click(object sender, EventArgs e)
        {
            if (button70.BackColor == Color.Gray)
                button70.BackColor = Color.White;
            else
                button70.BackColor = Color.Gray;

            if (textBox70.Visible == false)
                textBox70.Visible = true;
            else
                textBox70.Visible = false;
            if (textBox70.Visible == true)
                textBox70.Text = "70";
        }

        private void Button71_Click(object sender, EventArgs e)
        {
            if (button71.BackColor == Color.Gray)
                button71.BackColor = Color.White;
            else
                button71.BackColor = Color.Gray;

            if (textBox71.Visible == false)
                textBox71.Visible = true;
            else
                textBox71.Visible = false;
            if (textBox71.Visible == true)
                textBox71.Text = "71";
        }

        private void Button72_Click(object sender, EventArgs e)
        {
            if (button72.BackColor == Color.Gray)
                button72.BackColor = Color.White;
            else
                button72.BackColor = Color.Gray;

            if (textBox72.Visible == false)
                textBox72.Visible = true;
            else
                textBox72.Visible = false;
            if (textBox72.Visible == true)
                textBox72.Text = "72";
        }

        private void Button73_Click(object sender, EventArgs e)
        {
            if (button73.BackColor == Color.Gray)
                button73.BackColor = Color.White;
            else
                button73.BackColor = Color.Gray;

            if (textBox73.Visible == false)
                textBox73.Visible = true;
            else
                textBox73.Visible = false;
            if (textBox73.Visible == true)
                textBox73.Text = "73";
        }

        private void Button74_Click(object sender, EventArgs e)
        {
            if (button74.BackColor == Color.Gray)
                button74.BackColor = Color.White;
            else
                button74.BackColor = Color.Gray;

            if (textBox74.Visible == false)
                textBox74.Visible = true;
            else
                textBox74.Visible = false;
            if (textBox74.Visible == true)
                textBox74.Text = "74";
        }

        private void Button75_Click(object sender, EventArgs e)
        {
            if (button75.BackColor == Color.Gray)
                button75.BackColor = Color.White;
            else
                button75.BackColor = Color.Gray;

            if (textBox75.Visible == false)
                textBox75.Visible = true;
            else
                textBox75.Visible = false;
            if (textBox75.Visible == true)
                textBox75.Text = "75";
        }



        private void Button76_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            backgroundBotao(this.Controls);


        }
        //MÉTODO PARA TROCAR A COR DOS BOTÕES
        private void backgroundBotao(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um Button...
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).BackColor = Color.White;
                }
            }

        }


        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Visible = false;
                }
            }
        }

        private void MarcadorBingo_Load(object sender, EventArgs e)
        {

        }
    }
}
