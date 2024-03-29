﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class Form2 : Form
    {
        Computer computer = new Computer();

        int amount = 0;
        int amountClick = 0;

        public Form2()
        {
            InitializeComponent();
            RamAmount.Scroll+= trackBar1_Scroll;
        }

        public void GetAmoutFiles()
        {
            string directoryPath = @"C:\Users\vovas\Desktop\repos\WinForms-Computer-Constructor-App\laba2\bin\Debug\net7.0-windows";
            string searchPattern = "computer*";
            amountClick = Directory.GetFiles(directoryPath, searchPattern).Count();
        }


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

        private bool ValidateCPU()
        {
            if (string.IsNullOrEmpty(computer.cpu.Creator))
            {
                MessageBox.Show("Вы не выбрали производителя ЦП");
                return false;
            }

            if (string.IsNullOrEmpty(computer.cpu.Series))
            {
                MessageBox.Show("Вы не выбрали серию ЦП");
                return false;
            }

            if (string.IsNullOrEmpty(computer.cpu.Model))
            {
                MessageBox.Show("Вы не выбрали модель ЦП");
                return false;
            }

            if (string.IsNullOrEmpty(computer.cpu.Clock))
            {
                MessageBox.Show("Вы не выбрали частоту ЦП");
                return false;
            }

            if (string.IsNullOrEmpty(computer.cpu.Architecture))
            {
                MessageBox.Show("Вы не выбрали архитектуру ЦП");
                return false;
            }

            if (computer.cpu.L1Cache <= 0 || computer.cpu.L2Cache <= 0 || computer.cpu.L3Cache <= 0)
            {
                MessageBox.Show("Кэш ЦП должен быть больше 0");
                return false;
            }

            return true;
        }

        public void ToClass()
        {
            if (ComputerType.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали тип устройства");
            }
            else
            {
                computer.info.Type = ComputerType.Text;
                amount++;
            }

            if (MicroRadio.Checked)
            {
                computer.info.Size = MicroRadio.Text;
                amount++;
            }
            else if (PortableRadio.Checked)
            {
                computer.info.Size = PortableRadio.Text;
                amount++;
            }
            else if (StandartRadio.Checked)
            {
                computer.info.Size = StandartRadio.Text;
                amount++;
            }
            else if (MicroRadio.Checked == false && PortableRadio.Checked == false && StandartRadio.Checked == false)
            {
                MessageBox.Show("Вы не выбрали размер устройства");
            }

            computer.info.RAM = RamAmount.Value;

            if (checkBox1.Checked)
            {
                computer.info.Drive = checkBox1.Text;
                amount++;
            }
            else if (checkBox2.Checked)
            {
                computer.info.Drive = checkBox2.Text;
                amount++;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                computer.info.Drive = checkBox1.Text + ", " + checkBox2.Text;
                amount++;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Вы не выбрали тип накопителя");
            }


            computer.info.Date = dateTimePicker1.Text;
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(computer, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(computer, context, validationResults, true);
            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                }
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
            amount++;

            computer.cpu.Model = ModelCombobox.Text;
            amount++;

            computer.cpu.Cores = CoresChoose.Value;

            computer.cpu.Clock = ClockChoose.Text;
            amount++;

            if (ArchitectureX32.Checked)
            {
                computer.cpu.Architecture = ArchitectureX32.Text;
                amount++;
            }
            else if (ArchitectureX64.Checked)
            {
                computer.cpu.Architecture = ArchitectureX64.Text;
                amount++;
            }

            computer.cpu.L1Cache = int.Parse(textBox1.Text);
            computer.cpu.L2Cache = int.Parse(textBox2.Text);
            computer.cpu.L3Cache = int.Parse(textBox3.Text);
            amount++;

            if (!ValidateCPU())
            {
                return;
            }

            if (NvidiaGPU.Checked)
            {
                computer.gpu.Creator = NvidiaGPU.Text;
                amount++;
            }
            else if (AmdGPU.Checked)
            {
                computer.gpu.Creator = AmdGPU.Text;
                amount++;
            }
            else if(NvidiaGPU.Checked == false && AmdGPU.Checked == false)
            {
                MessageBox.Show("Вы не выбрали производителя ГК");
            }

            if (GPUSeries.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали серию ГК");
            }
            else
            {
                computer.gpu.Series = GPUSeries.Text;
                amount++;
            }

            if (GPUModel.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не модель ГК");
            }
            else
            {
                computer.gpu.Model = GPUModel.Text;
                amount++;
            }
            
            computer.gpu.Clock = GpuClock.Value;

            if (DiretXYes.Checked)
            {
                computer.gpu.DiretX = DiretXYes.Text;
                amount++;
            }
            else if (DiretXNo.Checked)
            {
                computer.gpu.DiretX = DiretXNo.Text;
                amount++;
            }
            else if (DiretXYes.Checked == false && DiretXNo.Checked == false)
            {
                MessageBox.Show("Вы не выбрали наличие DirectX");
            }

            computer.gpu.GPURAM = GpuRAM.Value;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            ToClass();
            if (amount >= 13 && (computer.cpu.L1Cache > 0 && computer.cpu.L2Cache > 0 && computer.cpu.L3Cache > 0))
            {
                amountClick++;
                string str = $"Тип: {computer.info.Type} \nРазмер: {computer.info.Size} \nДиск: {computer.info.Drive} \nОП: {computer.info.RAM} \nПроизводитель ЦП: {computer.cpu.Creator} \nМодель ЦП: {computer.cpu.Model} \nКол-во ядер ЦП: {computer.cpu.Cores} \nЧастота ЦП: {computer.cpu.Clock} \nАрхитектура ЦП: {computer.cpu.Architecture} \nL1, L2, L3 кэш: {computer.cpu.L1Cache}, {computer.cpu.L2Cache}, {computer.cpu.L3Cache} \nПроиводитель ГК: {computer.gpu.Creator} \nСерия ГК: {computer.gpu.Series} \nМодель ГК: {computer.gpu.Model} \nЧастота ГК: {computer.gpu.Clock} \nНаличие DiretX: {computer.gpu.DiretX} \nКоличество видеопамяти: {computer.gpu.GPURAM}";
                richTextBox2.Text = str;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
                using (FileStream stream = new FileStream($"computer{amountClick}.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(stream, computer);
                }
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Refresh();
            this.Close();
        }
    }
}
