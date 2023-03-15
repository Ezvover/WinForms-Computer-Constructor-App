using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace laba2
{
    


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            computerList.Clear();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            try
            {
                using (FileStream stream = new FileStream("computer.xml", FileMode.OpenOrCreate))
                {
                    computerList.Add(xmlSerializer.Deserialize(stream) as Computer);
                }
            }
            catch
            {

            }
            try
            {
                using (FileStream stream = new FileStream("computer_temp.xml", FileMode.OpenOrCreate))
                {
                    computerList.Add(xmlSerializer.Deserialize(stream) as Computer);
                }
            }
            catch 
            {

            }
            try
            {
                using (FileStream stream = new FileStream("computer.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(stream, computerList);
                }
            }
            catch
            {

            }


        }

        List<Computer> computerList = new List<Computer>();
        public void OutputComputer()
        {
            foreach(Computer computer in computerList) 
            {
                string str = $"Тип: {computer.Type} \nРазмер: {computer.Size} \nДиск: {computer.Drive} \nПроизводитель ЦП: {computer.cpu.Creator} \nМодель ЦП: {computer.cpu.Model} \nКол-во ядер ЦП: {computer.cpu.Cores} \nЧастота ЦП: {computer.cpu.Clock} \nАрхитектура ЦП: {computer.cpu.Architecture} \nL1, L2, L3 кэш: {computer.cpu.L1Cache}, {computer.cpu.L2Cache}, {computer.cpu.L3Cache} \nПроиводитель ГК: {computer.gpu.Creator} \nСерия ГК: {computer.gpu.Series} \nМодель ГК: {computer.gpu.Model} \nЧастота ГК: {computer.gpu.Clock} \nНаличие DiretX: {computer.gpu.DiretX} \nКоличество видеопамяти: {computer.gpu.GPURAM}";
                OutputTextbox.Text = str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            OutputComputer();
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)

        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("computer.xml");
            XmlNode cpuNode = xmlDocument.SelectSingleNode("//cpu");
            foreach (XmlNode node in cpuNode.ChildNodes)
            {
                if (node.Name == "Creator" && node.InnerText == SearchText.Text)
                {
                    OutputTextbox.Clear();
                    OutputComputer();
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

    }
    [Serializable]
    public class Computer
    {
        public Computer()
        {

        }
        public Computer(string type, string size, int ram, string drive, string date, string cpuCreator, string cpuSeries, string cpuModel, int cpuCores, string cpuClock, string cpuArchitecture, int cpuL1Cache, int cpuL2Cache, int cpuL3Cache, string gpuCreator, string gpuSeries, string gpuModel, int gpuClock, string gpuDiretx, int gpuRAM)
        {
            Type = type;
            Size = size;
            RAM = ram;
            Drive = drive;
            Date = date;

            cpu.Creator = cpuCreator;
            cpu.Series = cpuSeries;
            cpu.Model = cpuModel;
            cpu.Cores = cpuCores;
            cpu.Clock = cpuClock;
            cpu.Architecture = cpuArchitecture;
            cpu.L1Cache = cpuL1Cache;
            cpu.L2Cache = cpuL2Cache;
            cpu.L3Cache = cpuL3Cache;

            gpu.Creator = gpuCreator;
            gpu.Series = gpuSeries;
            gpu.Model = gpuModel;
            gpu.Clock = gpuClock;
            gpu.DiretX = gpuDiretx;
            gpu.GPURAM = gpuRAM;
        }

        public CPU cpu;
        public GPU gpu;

        public string Type { get; set; }

        public string Size { get; set; }
        public int RAM { get; set; }
        public string Drive { get; set; }
        public string Date { get; set; }


    }

    [Serializable]
    public struct CPU
    {
        public CPU(string creator, string series, string model, int cores, string clock, string architecture, int l1Cache, int l2Cache, int l3Cache)
        {
            Creator = creator;
            Series = series;
            Model = model;
            Cores = cores;
            Clock = clock;
            Architecture = architecture;
            L1Cache = l1Cache;
            L2Cache = l2Cache;
            L3Cache = l3Cache;
        }

        public string Creator { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int Cores { get; set; }
        public string Clock { get; set; }
        public string Architecture { get; set; }
        public int L1Cache { get; set; }
        public int L2Cache { get; set; }
        public int L3Cache { get; set; }
    }

    [Serializable]
    public struct GPU
    {
        public GPU(string creator, string series, string model, int clock, string diretx, int gpuRAM)
        {
            Creator = creator;
            Series = series;
            Model = model;
            Clock = clock;
            DiretX = diretx;
            GPURAM = gpuRAM;
        }

        public string Creator { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int Clock { get; set; }
        public string DiretX { get; set; }
        public int GPURAM { get; set; }
    }


}