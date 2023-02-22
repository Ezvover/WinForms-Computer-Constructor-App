using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form2 : Form
    {
        Computer computer;

        public Form2()
        {
            InitializeComponent();
            trackBar1.Scroll+= trackBar1_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format($"Необходимое ОЗУ: {trackBar1.Value} ГБ");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

  

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = String.Format($"Количество ядер: {trackBar2.Value}");

        }

        public void ToClass()
        {
            // type radiobutton
            if (radioButton1.Checked)
            {
                computer.type = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                computer.type = radioButton2.Text;
            }
            else if (radioButton3.Checked) 
            {
                computer.type = radioButton3.Text;
            }

            if (radioButton7.Checked)
            {
                computer.creator = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                computer.creator = radioButton6.Text;
            }

            computer.series = comboBox1.Text;

            computer.model = comboBox2.Text;

            computer.cores = trackBar2.Value;

            computer.clock = comboBox3.Text;

            if (radioButton4.Checked)
            {
                computer.architecture = radioButton5.Text;
            }
            else if (radioButton5.Checked) 
            {
                computer.architecture = radioButton6.Text;
            }

            try
            {
                computer.l1Cache = int.Parse(textBox1.Text);
                computer.l2Cache = int.Parse(textBox2.Text);
                computer.l3Cache = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (radioButton1.Checked)
            {
                computer.size= radioButton1.Text;
            }
            else if(radioButton2.Checked) 
            {
                computer.size = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                computer.size = radioButton3.Text;
            }

            computer.RAM = trackBar1.Value;

            if (checkBox1.Checked) 
            {
                computer.drive = radioButton1.Text;
            }
            else if (checkBox2.Checked)
            {
                computer.drive = radioButton2.Text;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                computer.drive = $"{checkBox1.Text}, {checkBox2.Text}";
            }

            computer.date = dateTimePicker1.Text;

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToClass();
            string str = computer.type + computer.creator + computer.series + computer.model + computer.cores + computer.clock + computer.architecture + computer.l1Cache + computer.l2Cache + computer.l3Cache + computer.size + computer.RAM + computer.drive + computer.date;
            richTextBox2.Text = str;
        }

        public struct Computer
        {
            public string type;
            public string creator;
            public string series;
            public string model;
            public int cores;
            public string clock;
            public string architecture;
            public int l1Cache;
            public int l2Cache;
            public int l3Cache;

            public string GPU;
            public string size;
            public int RAM;
            public string drive;
            public string date;


        }
    }

   
}
