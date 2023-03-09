using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("computer.xml");

            XmlNode cpuNode = xmlDocument.SelectSingleNode("//cpu");
            XmlNode gpuNode = xmlDocument.SelectSingleNode("//gpu");
            XmlNode computerNode = xmlDocument.SelectSingleNode("//Computer");

            OutputTextbox.AppendText("Параметры устройства:\n");
            foreach (XmlNode node in computerNode.ChildNodes)
            {
                if (node.Name == "gpu" || node.Name == "cpu")
                {
                    continue;
                }
                else
                {
                    OutputTextbox.AppendText(node.Name + ": " + node.InnerText + "\n");
                }
            }
            OutputTextbox.AppendText("\nПараметры ЦП:\n");
            foreach (XmlNode node in cpuNode.ChildNodes)
            {
                OutputTextbox.AppendText(node.Name + ": " + node.InnerText + "\n");
            }
            OutputTextbox.AppendText("\nПараметры ГК:\n");
            foreach (XmlNode node in gpuNode.ChildNodes)
            {
                OutputTextbox.AppendText(node.Name + ": " + node.InnerText + "\n");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
        }
    }
}