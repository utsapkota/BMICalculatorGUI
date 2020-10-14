using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        float height;
        float weight;
        float bmi;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Adult");
                dt.Columns.Add("Women");
                dt.Columns.Add("Men");

                dt.Rows.Add(new object[] { "Anorexia", "< 17.5 ", "< 17.5" });
                dt.Rows.Add(new object[] { "Underweight", "<19.1", "<20.7" });
                dt.Rows.Add(new object[] { "In Normal Range", "19.1-25.8", "20.7-26.4" });
                dt.Rows.Add(new object[] { "Marginally Overweight", "25.8-27.3", "26.4-27.8" }); ;
                dt.Rows.Add(new object[] { "Overweight", "27.3-32.3", "27.8-31.1" });
                dt.Rows.Add(new object[] { "Very Overweight Or Obese", ">32.3", ">31.1" });
                dt.Rows.Add(new object[] { "Severely Obese", "35 – 40", "35 – 40" });
                dt.Rows.Add(new object[] { "Morbidly Obese", "40 – 50", "40 – 50" });
                dt.Rows.Add(new object[] { "Super Obese", " 50 – 60", " 50 – 60" });

                dataGridView1.DataSource = dt;
            }
        }

        private void man_bmi()
        {
            if (bmi < 17.5)
                MessageBox.Show("You have anorexia.", "Oh No! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (bmi >= 17.5 && bmi <= 20.7)
                MessageBox.Show("You are underweight.", "Not Good! Eat More",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 20.7 && bmi <= 26.4)
                MessageBox.Show("You are in normal range.", "Excellent!",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (bmi >= 26.4 && bmi <= 27.8)
                MessageBox.Show("You are marginally overweight.", "Excercise More!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 27.8 && bmi <= 31.1)
                MessageBox.Show("You are overweight.", "Do Regular Workouts!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 32.1 && bmi <= 35)
                MessageBox.Show("You are very overweight/obese.", "Do High Intensity Workouts!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 35 && bmi <= 40)
                MessageBox.Show("You are severely obese.", "Oh no! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi >= 40 && bmi <= 50)
                MessageBox.Show("You are morbidly obese.", "Oh no! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi >= 50 && bmi <= 130)
                MessageBox.Show("You are super obese.", "Oh no! Visit a Doctor",
       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi > 130)
                MessageBox.Show("Human Being With Such BMI Shouldn't Exist", "Something's Wrong!",
       MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void woman_bmi()
        {
            if (bmi < 17.5)
                MessageBox.Show("You have anorexia.", "Oh No! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (bmi >= 17.5 && bmi <= 19.1)
                MessageBox.Show("You are underweight.", "Not Good! Eat More",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 19.1 && bmi <= 25.8)
                MessageBox.Show("You are in normal range.", "Excellent!",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (bmi >= 25.8 && bmi <= 27.3)
                MessageBox.Show("You are marginally overweight.", "Excercise More!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 27.3 && bmi <= 32.3)
                MessageBox.Show("You are overweight.", "Do Regular Workouts!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 32.3 && bmi <= 35)
                MessageBox.Show("You are very overweight/obese.", "Do High Intensity Workouts!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (bmi >= 35 && bmi <= 40)
                MessageBox.Show("You are severely obese.", "Oh no! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi >= 40 && bmi <= 50)
                MessageBox.Show("You are morbidly obese.", "Oh no! Visit a Doctor",
        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi >= 50 && bmi <= 130)
                MessageBox.Show("You are super obese.", "Oh no! Visit a Doctor",
       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (bmi > 130)
                MessageBox.Show("Human Being With Such BMI Shouldn't Exist", "Something's Wrong!",
       MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                weight = Single.Parse(textBox2.Text);
                height = float.Parse(textBox3.Text);
                height = (float)Math.Round(height, 2);
                bmi = weight / (height * height);
                bmi = (float)Math.Round(bmi, 1);
                // textBox1.Text = String.Format("{0:f1}", bmi);
                String stringbmi = bmi.ToString();
                textBox1.Text = stringbmi;

                if (radioButton2.Checked == true)
                {
                    woman_bmi();
                }


                if (radioButton1.Checked == true)
                {
                    man_bmi();
                }

            }
            catch (Exception)
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Please Enter Your Weight");

                if (textBox3.Text == "")
                    MessageBox.Show("Please Enter Your Height");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox3.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
