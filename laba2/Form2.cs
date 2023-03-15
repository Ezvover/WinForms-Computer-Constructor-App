using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static laba2.Form2;

namespace laba2
{
    

    /// <summary>
    /// TODO #!: Add try-catch for each block + refresh form1, while closing form2
    /// </summary>
    public partial class Form2 : Form
    {
        Computer computer = new Computer();

        

        public Form2()
        {
            InitializeComponent();
            RamAmount.Scroll+= trackBar1_Scroll;
        }

        int amount = 0;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format($"Необходимое ОЗУ: {RamAmount.Value} ГБ");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CoresLabel.Text = String.Format($"Количество ядер: {CoresChoose.Value}");

        }

        private void GpuClock_Scroll(object sender, EventArgs e)
        {
            ClockGpuLabel.Text = String.Format($"Частота ГК: {GpuClock.Value}");
        }

        private void GpuRamGr_Click(object sender, EventArgs e)
        {
            GpuRamGr.Text = String.Format($"Кол-во памяти: {GpuRAM.Value} ГБ");
        }

        public void ToClass()
        {
            if (ComputerType.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали тип устройства");
            }
            else
            {
                computer.Type = ComputerType.Text;
                amount++;
            }

            if (CreatorIntel.Checked)
            {
                computer.cpu.Creator = CreatorIntel.Text;
                amount++;
            }
            else if (CreatorAMD.Checked)
            {
                computer.cpu.Creator = CreatorAMD.Text;
                amount++;
            }

            computer.cpu.Series = SeriesChoose.Text;

            computer.cpu.Model = ModelCombobox.Text;

            computer.cpu.Cores = CoresChoose.Value;

            computer.cpu.Clock = ClockChoose.Text;

            if (ArchitectureX32.Checked)
            {
                computer.cpu.Architecture = ArchitectureX32.Text;
            }
            else if (ArchitectureX64.Checked)
            {
                computer.cpu.Architecture = ArchitectureX64.Text;
            }

            try
            {
                computer.cpu.L1Cache = int.Parse(textBox1.Text);
                computer.cpu.L2Cache = int.Parse(textBox2.Text);
                computer.cpu.L3Cache = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (MicroRadio.Checked)
            {
                computer.Size = MicroRadio.Text;
            }
            else if (PortableRadio.Checked)
            {
                computer.Size = PortableRadio.Text;
            }
            else if (StandartRadio.Checked)
            {
                computer.Size = StandartRadio.Text;
            }

            computer.RAM = RamAmount.Value;

            if (checkBox1.Checked)
            {
                computer.Drive = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                computer.Drive = checkBox2.Text;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                computer.Drive = checkBox1.Text + ", " + checkBox2.Text;
            }

            computer.Date = dateTimePicker1.Text;


            if (NvidiaGPU.Checked)
            {
                computer.gpu.Creator = NvidiaGPU.Text;
            }
            else if (AmdGPU.Checked)
            {
                computer.gpu.Creator = AmdGPU.Text;
            }

            computer.gpu.Series = GPUSeries.Text;
            computer.gpu.Model = GPUModel.Text;
            computer.gpu.Clock = GpuClock.Value;

            if (DiretXYes.Checked)
            {
                computer.gpu.DiretX = DiretXYes.Text;
            }
            else if (DiretXNo.Checked)
            {
                computer.gpu.DiretX = DiretXNo.Text;
            }

            computer.gpu.GPURAM = GpuRAM.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ToClass();
            string str = $"Тип: {computer.Type} \nРазмер: {computer.Size} \nДиск: {computer.Drive} \nПроизводитель ЦП: {computer.cpu.Creator} \nМодель ЦП: {computer.cpu.Model} \nКол-во ядер ЦП: {computer.cpu.Cores} \nЧастота ЦП: {computer.cpu.Clock} \nАрхитектура ЦП: {computer.cpu.Architecture} \nL1, L2, L3 кэш: {computer.cpu.L1Cache}, {computer.cpu.L2Cache}, {computer.cpu.L3Cache} \nПроиводитель ГК: {computer.gpu.Creator} \nСерия ГК: {computer.gpu.Series} \nМодель ГК: {computer.gpu.Model} \nЧастота ГК: {computer.gpu.Clock} \nНаличие DiretX: {computer.gpu.DiretX} \nКоличество видеопамяти: {computer.gpu.GPURAM}";
            richTextBox2.Text = str;
            // List<Computer> computerList = new List<Computer>();
            //computerList.Add(new Computer(computer.Type, computer.Size, computer.RAM, computer.Drive, computer.Date, computer.cpu.Creator, computer.cpu.Series, computer.cpu.Model, computer.cpu.Cores, computer.cpu.Clock, computer.cpu.Architecture, computer.cpu.L1Cache, computer.cpu.L2Cache, computer.cpu.L3Cache, computer.gpu.Creator, computer.gpu.Series, computer.gpu.Model, computer.gpu.Clock, computer.gpu.DiretX, computer.gpu.GPURAM));
            // computerList.Add(computer);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            using (FileStream stream = new FileStream("computer_temp.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, computer);
            }


            /*List<Computer> computers = new List<Computer>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            using (FileStream stream = new FileStream("computer.xml", FileMode.OpenOrCreate))
            {
                computers.Add(xmlSerializer.Deserialize(stream) as Computer);
            }*/




        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Refresh();
        }
    }
}
