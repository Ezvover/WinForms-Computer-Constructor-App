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

        public struct CPU
        {
            public string creator;
            public string series;
            public string model;
            public int cores;
            public string clock;
            public string architecture;
            public int l1Cache;
            public int l2Cache;
            public int l3Cache;
        }

        public struct GPU
        {
            public string creator;
            public string series;
            public string model;
            public int clock;
            public string diretX;
            public int GPURAM;
        }

        public Form2()
        {
            InitializeComponent();
            RamAmount.Scroll+= trackBar1_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format($"Необходимое ОЗУ: {RamAmount.Value} ГБ");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

  

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = String.Format($"Количество ядер: {CoresChoose.Value}");

        }

        public void ToClass()
        {
            // type radiobutton
            computer.type = ComputerType.Text;

            if (CreatorIntel.Checked)
            {
                computer.cpu.creator = CreatorIntel.Text;
            }
            else if (CreatorAMD.Checked)
            {
                computer.cpu.creator = CreatorAMD.Text;
            }

            computer.cpu.series = SeriesChoose.Text;

            computer.cpu.model = comboBox1.Text;

            computer.cpu.cores = CoresChoose.Value;

            computer.cpu.clock = ClockChoose.Text;

            if (ArchitectureX32.Checked)
            {
                computer.cpu.architecture = ArchitectureX32.Text;
            }
            else if (ArchitectureX64.Checked)
            {
                computer.cpu.architecture = ArchitectureX64.Text;
            }

            try
            {
                computer.cpu.l1Cache = int.Parse(textBox1.Text);
                computer.cpu.l2Cache = int.Parse(textBox2.Text);
                computer.cpu.l3Cache = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (MicroRadio.Checked)
            {
                computer.size = MicroRadio.Text;
            }
            else if (PortableRadio.Checked)
            {
                computer.size = PortableRadio.Text;
            }
            else if (StandartRadio.Checked)
            {
                computer.size = StandartRadio.Text;
            }

            computer.RAM = RamAmount.Value;

            if (checkBox1.Checked)
            {
                computer.drive = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                computer.drive = checkBox2.Text;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                computer.drive = $"{checkBox1.Text}, {checkBox2.Text}";
            }

            computer.date = dateTimePicker1.Text;


            if (NvidiaGPU.Checked)
            {
                computer.gpu.creator = NvidiaGPU.Text;
            }
            else if (AmdGPU.Checked)
            {
                computer.gpu.creator = AmdGPU.Text;
            }

            computer.gpu.series = GPUSeries.Text;
            computer.gpu.model = GPUModel.Text;
            computer.gpu.clock = GpuClock.Value;

            if (DiretXYes.Checked)
            {
                computer.gpu.diretX = DiretXYes.Text;
            }
            else if (DiretXNo.Checked)
            {
                computer.gpu.diretX = DiretXNo.Text;
            }

            computer.gpu.GPURAM = GpuRAM.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToClass();
            string str = computer.type + ' ' + computer.cpu.creator + ' ' + computer.cpu.series + ' ' + computer.cpu.model + ' ' + computer.cpu.cores + ' ' + computer.cpu.clock + ' ' + computer.cpu.architecture + ' ' + computer.cpu.l1Cache + ' ' + computer.cpu.l2Cache + ' ' + computer.cpu.l3Cache + ' ' + computer.size + ' ' + computer.RAM + ' ' + computer.drive + ' ' + computer.date + ' ' + computer.gpu.creator + ' ' + computer.gpu.series + ' ' + computer.gpu.model + ' ' + computer.gpu.clock + ' ' + computer.gpu.diretX + ' ' + computer.gpu.GPURAM;
            richTextBox2.Text = str;
        }

        public struct Computer
        {
            public CPU cpu;
            public GPU gpu;

            public string type;
            
            public string size;
            public int RAM;
            public string drive;
            public string date;


        }

    }

   
}
