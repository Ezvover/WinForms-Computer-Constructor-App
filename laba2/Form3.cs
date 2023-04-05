using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace laba2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Computer computer = new Computer();

        int count = 0;
        List<Computer> computerList = new List<Computer>();

        public void Deserialization()
        {
            computerList.Clear();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            string directoryPath = @"C:\Users\vovas\Desktop\repos\WinForms-Computer-Constructor-App\laba2\bin\Debug\net7.0-windows";
            string searchPattern = "computer*";
            count = Directory.GetFiles(directoryPath, searchPattern).Count();
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    using (FileStream stream = new FileStream($"computer{i}.xml", FileMode.OpenOrCreate))
                    {
                        computerList.Add(xmlSerializer.Deserialize(stream) as Computer);
                    }
                }
                catch
                {

                }
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Computer> searchList = new List<Computer>();
            searchList.Clear();
            Deserialization();
            if (TextSearch.Text.Length > 0)
            {
                if (PartRadioSearch.Checked)
                {
                    SearchOutput.Clear();
                    for (int i = 0; i < computerList.Count; i++)
                    {
                        if (computerList[i].info.Type.Contains(TextSearch.Text) || computerList[i].info.Size.Contains(TextSearch.Text) || computerList[i].info.Drive.Contains(TextSearch.Text) || computerList[i].info.Date.Contains(TextSearch.Text) || computerList[i].cpu.Creator.Contains(TextSearch.Text) || computerList[i].cpu.Series.Contains(TextSearch.Text) || computerList[i].cpu.Model.Contains(TextSearch.Text) || computerList[i].cpu.Clock.Contains(TextSearch.Text) || computerList[i].cpu.Architecture.Contains(TextSearch.Text) || computerList[i].gpu.Creator.Contains(TextSearch.Text) || computerList[i].gpu.Series.Contains(TextSearch.Text) || computerList[i].gpu.Model.Contains(TextSearch.Text) || computerList[i].gpu.DiretX.Contains(TextSearch.Text))
                        {
                            SearchOutput.Text += $"Компьютер #{i} \nТип: {computerList[i].info.Type} \nРазмер: {computerList[i].info.Size} \nДиск: {computerList[i].info.Drive} \nОП: {computerList[i].info.RAM} \nПроизводитель ЦП: {computerList[i].cpu.Creator} \nМодель ЦП: {computerList[i].cpu.Model} \nКол-во ядер ЦП: {computerList[i].cpu.Cores} \nЧастота ЦП: {computerList[i].cpu.Clock} \nАрхитектура ЦП: {computerList[i].cpu.Architecture} \nL1, L2, L3 кэш: {computerList[i].cpu.L1Cache}, {computerList[i].cpu.L2Cache}, {computerList[i].cpu.L3Cache} \nПроиводитель ГК: {computerList[i].gpu.Creator} \nСерия ГК: {computerList[i].gpu.Series} \nМодель ГК: {computerList[i].gpu.Model} \nЧастота ГК: {computerList[i].gpu.Clock} \nНаличие DiretX: {computerList[i].gpu.DiretX} \nКоличество видеопамяти: {computerList[i].gpu.GPURAM} \n\n";
                        }
                        else
                        {
                            continue;
                        }
                    }

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
                    using (FileStream stream = new FileStream($"Search.xml", FileMode.OpenOrCreate))
                    {
                        foreach (var c in searchList)
                        {
                            xmlSerializer.Serialize(stream, c);
                        }
                    }
                }
                if (ModelRadioSearch.Checked)
                {
                    SearchOutput.Clear();
                    for (int i = 0; i < computerList.Count; ++i)
                    {
                        if (computerList[i].cpu.Model.Equals(TextSearch.Text))
                        {
                            SearchOutput.Text += $"Компьютер #{i} \nТип: {computerList[i].info.Type} \nРазмер: {computerList[i].info.Size} \nДиск: {computerList[i].info.Drive} \nОП: {computerList[i].info.RAM} \nПроизводитель ЦП: {computerList[i].cpu.Creator} \nМодель ЦП: {computerList[i].cpu.Model} \nКол-во ядер ЦП: {computerList[i].cpu.Cores} \nЧастота ЦП: {computerList[i].cpu.Clock} \nАрхитектура ЦП: {computerList[i].cpu.Architecture} \nL1, L2, L3 кэш: {computerList[i].cpu.L1Cache}, {computerList[i].cpu.L2Cache}, {computerList[i].cpu.L3Cache} \nПроиводитель ГК: {computerList[i].gpu.Creator} \nСерия ГК: {computerList[i].gpu.Series} \nМодель ГК: {computerList[i].gpu.Model} \nЧастота ГК: {computerList[i].gpu.Clock} \nНаличие DiretX: {computerList[i].gpu.DiretX} \nКоличество видеопамяти: {computerList[i].gpu.GPURAM} \n\n";
                            searchList.Add(computerList[i]);
                        }
                    }

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
                    using (FileStream stream = new FileStream($"Search.xml", FileMode.OpenOrCreate))
                    {
                        foreach (var c in searchList)
                        {
                            xmlSerializer.Serialize(stream, c);
                        }
                    }
                }
                if (CreatorRadioSearch.Checked)
                {
                    SearchOutput.Clear();
                    for (int i = 0; i < computerList.Count; ++i)
                    {
                        if (computerList[i].cpu.Creator.Equals(TextSearch.Text))
                        {
                            SearchOutput.Text += $"Компьютер #{i} \nТип: {computerList[i].info.Type} \nРазмер: {computerList[i].info.Size} \nДиск: {computerList[i].info.Drive} \nОП: {computerList[i].info.RAM} \nПроизводитель ЦП: {computerList[i].cpu.Creator} \nМодель ЦП: {computerList[i].cpu.Model} \nКол-во ядер ЦП: {computerList[i].cpu.Cores} \nЧастота ЦП: {computerList[i].cpu.Clock} \nАрхитектура ЦП: {computerList[i].cpu.Architecture} \nL1, L2, L3 кэш: {computerList[i].cpu.L1Cache}, {computerList[i].cpu.L2Cache}, {computerList[i].cpu.L3Cache} \nПроиводитель ГК: {computerList[i].gpu.Creator} \nСерия ГК: {computerList[i].gpu.Series} \nМодель ГК: {computerList[i].gpu.Model} \nЧастота ГК: {computerList[i].gpu.Clock} \nНаличие DiretX: {computerList[i].gpu.DiretX} \nКоличество видеопамяти: {computerList[i].gpu.GPURAM} \n\n";
                            searchList.Add(computerList[i]);
                        }
                    }

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
                    using (FileStream stream = new FileStream($"Search.xml", FileMode.OpenOrCreate))
                    {
                        foreach (var c in searchList)
                        {
                            xmlSerializer.Serialize(stream, c);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Поле пустое");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchOutput.Clear();
        }
    }
}
