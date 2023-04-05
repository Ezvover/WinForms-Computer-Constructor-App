using Microsoft.VisualBasic.Devices;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace laba2
{
    /// <summary>
    /// ����� �������� � xml �������� ��������� �������� �� ������ �����, ����� ����� ����� �� ����� ������ ������
    /// </summary>
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            Deserialization();
            DateTimer.Start();
            toolStrip1.Dock = DockStyle.Top;
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

        private void toolStripButton1_Click(object sender, EventArgs e) // aboutButton
        {
            PredLabel.Text = $"�� ������ ��� ������ ���������";
            MessageBox.Show("�������� �������� ����������\n������ 1.0\n�. �����, 2023");
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // CreateComputer
        {
            PredLabel.Text = $"�� ������� ����� ���������";

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //OutputComputer
        {
            PredLabel.Text = $"�� ������ �� ����� ������ ��������� ��";

            this.Refresh();
            OutputTextbox.Clear();
            Deserialization();
            OutputComputer();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //SortRAM
        {
            PredLabel.Text = $"�� ��������� ���������� �� ���";

            Deserialization();
            var computerSort = from c in computerList
                               orderby c.info.RAM
                               select c;

            string str = "";
            int i = 0;
            foreach (var c in computerSort)
            {
                ++i;
                str += $"��������� #{i} \n���: {c.info.Type} \n������: {c.info.Size} \n����: {c.info.Drive} \n��: {c.info.RAM} \n������������� ��: {c.cpu.Creator} \n������ ��: {c.cpu.Model} \n���-�� ���� ��: {c.cpu.Cores} \n������� ��: {c.cpu.Clock} \n����������� ��: {c.cpu.Architecture} \nL1, L2, L3 ���: {c.cpu.L1Cache}, {c.cpu.L2Cache}, {c.cpu.L3Cache} \n������������ ��: {c.gpu.Creator} \n����� ��: {c.gpu.Series} \n������ ��: {c.gpu.Model} \n������� ��: {c.gpu.Clock} \n������� DiretX: {c.gpu.DiretX} \n���������� �����������: {c.gpu.GPURAM} \n\n";
                OutputTextbox.Text = str;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            using (FileStream stream = new FileStream($"sortedComputerRAM.xml", FileMode.OpenOrCreate))
            {
                foreach (var c in computerSort)
                {
                    xmlSerializer.Serialize(stream, c);
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // SortClock
        {
            PredLabel.Text = $"�� ��������� ���������� �� �������";

            Deserialization();
            var computerSort2 = from c in computerList
                                orderby c.cpu.Clock
                                select c;

            string str = "";
            int i = 0;
            foreach (var c in computerSort2)
            {
                ++i;
                str += $"��������� #{i} \n���: {c.info.Type} \n������: {c.info.Size} \n����: {c.info.Drive} \n��: {c.info.RAM} \n������������� ��: {c.cpu.Creator} \n������ ��: {c.cpu.Model} \n���-�� ���� ��: {c.cpu.Cores} \n������� ��: {c.cpu.Clock} \n����������� ��: {c.cpu.Architecture} \nL1, L2, L3 ���: {c.cpu.L1Cache}, {c.cpu.L2Cache}, {c.cpu.L3Cache} \n������������ ��: {c.gpu.Creator} \n����� ��: {c.gpu.Series} \n������ ��: {c.gpu.Model} \n������� ��: {c.gpu.Clock} \n������� DiretX: {c.gpu.DiretX} \n���������� �����������: {c.gpu.GPURAM} \n\n";
                OutputTextbox.Text = str;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Computer));
            using (FileStream stream = new FileStream($"sortedComputerClock.xml", FileMode.OpenOrCreate))
            {
                foreach (var c in computerSort2)
                {
                    xmlSerializer.Serialize(stream, c);
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e) // SearchDrive
        {
            PredLabel.Text = $"�� ��������� �����";

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //ClearButton
        {
            PredLabel.Text = $"�� ��������� ������� �����";

            OutputTextbox.Clear();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToString();
            amountLabel.Text = $"���-�� ��������: {computerList.Count}";
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            ShowToolBar.Visible = true;
        }

        private void ShowToolBar_Click(object sender, EventArgs e)
        {
            ShowToolBar.Visible = false;
            toolStrip1.Visible = true;
            toolStrip1.Dock = DockStyle.Top;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e) // SearchButtpn7
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PredLabel.Text = $"�� ������� ����� ���������";

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            PredLabel.Text = $"�� ������ �� ����� ������ ��������� ��";

            this.Refresh();
            OutputTextbox.Clear();
            Deserialization();
            OutputComputer();
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CustomValidationAttribute : Attribute
    {
        public string InvalidChars { get; set; }
    }

    [Serializable]
    public class Computer : ValidationAttribute
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

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Computer computer = (Computer)value;
            if (computer.cpu.Architecture != "x32" && computer.cpu.Architecture != "x64")
            {
                return new ValidationResult(ErrorMessage ?? "������������ ����������� ��.");
            }

            return ValidationResult.Success;
        }
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
        [Required]
        [StringLength(5, MinimumLength = 1)]
        public string Creator { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int Cores { get; set; }

        [RegularExpression(@"^\d+\.\d", ErrorMessage = "������������ �������� ������� ��.")]
        public string Clock { get; set; }
        public string Architecture { get; set; }
        [CustomValidation(InvalidChars = "9")]
        public int L1Cache { get; set; }
        [Range(1, 5, ErrorMessage = "�������� 5 ��������")]
        public int L2Cache { get; set; }
        [Range(1, 5, ErrorMessage = "�������� 5 ��������")]
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