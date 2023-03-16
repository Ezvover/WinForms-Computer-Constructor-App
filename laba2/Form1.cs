using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace laba2
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        List<Computer> computerList = new List<Computer>();
        public void OutputComputer()
        {
            if (computerList.Count > 0) 
            {
                string str = "";
                for (int i = 0; i < computerList.Count; i++)
                {
                    str += $"��������� #{i} \n���: {computerList[i].info.Type} \n������: {computerList[i].info.Size} \n����: {computerList[i].info.Drive} \n��: {computerList[i].info.RAM} \n������������� ��: {computerList[i].cpu.Creator} \n������ ��: {computerList[i].cpu.Model} \n���-�� ���� ��: {computerList[i].cpu.Cores} \n������� ��: {computerList[i].cpu.Clock} \n����������� ��: {computerList[i].cpu.Architecture} \nL1, L2, L3 ���: {computerList[i].cpu.L1Cache}, {computerList[i].cpu.L2Cache}, {computerList[i].cpu.L3Cache} \n������������ ��: {computerList[i].gpu.Creator} \n����� ��: {computerList[i].gpu.Series} \n������ ��: {computerList[i].gpu.Model} \n������� ��: {computerList[i].gpu.Clock} \n������� DiretX: {computerList[i].gpu.DiretX} \n���������� �����������: {computerList[i].gpu.GPURAM} \n\n";
                    OutputTextbox.Text = str;
                }
            }
            else
            {
                MessageBox.Show("���� ������, �� ������� ����� ����� ����������");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            OutputTextbox.Clear();
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
            OutputComputer();
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
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
            info.Type = type;
            info.Size = size;
            info.RAM = ram;
            info.Drive = drive;
            info.Date = date;

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
        public Info info;
    }

    [Serializable]
    public struct Info
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public int RAM { get; set; }
        public string Drive { get; set; }
        public string Date { get; set; }
    }

    [Serializable]
    public struct CPU
    {
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
        public string Creator { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int Clock { get; set; }
        public string DiretX { get; set; }
        public int GPURAM { get; set; }
    }
}