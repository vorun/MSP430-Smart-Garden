using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading.Tasks;

namespace MSP430_Project
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        SerialPort port = new System.IO.Ports.SerialPort();
        
        public Form1()
        {
            InitializeComponent();           
        }
        public int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                if (comboBox1.Text == "")
                    return;
                port.BaudRate = 9600;
                port.PortName = comboBox1.SelectedItem.ToString();
                try
                {
                    port.Open();
                    label7.Text = "Port is open";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                label7.Text = "Connected";               
            }
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {            
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
           
            string[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
                comboBox1.Items.Add(port);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;

            timer1.Stop();
            if (port.IsOpen == true)
            {
                port.Close();
                label7.Text = "Port is closed";
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            port.Write("D");
            await Task.Delay(2000);
            port.Write("R");
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            port.Write("E");
            await Task.Delay(6000);
            port.Write("R");
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                groupBox5.Enabled = true;
                groupBox4.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = true;
                groupBox1.Enabled = true;
            }
                try
                {
                    string sensorData = port.ReadExisting();
                    string[] sensorDatas = sensorData.Split(" ");               
                    int a0 = (1023 - (Convert.ToInt32(sensorDatas[0]))) * 100 / 1023;
                    int a1 = ((Convert.ToInt32(sensorDatas[3]))) * 100 / 1023;
                    int a2 = (1023 - (Convert.ToInt32(sensorDatas[4]))) * 100 / 1023;
               
                    label4.Text = a2.ToString();
                    label6.Text = a1.ToString();
                    label2.Text = a0.ToString();                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                                  
                }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Close();
                label7.Text = "Port is closed";
            }
        }
        private async void button5_Click(object sender, EventArgs e)
        {
            port.Write("F");
            await Task.Delay(9000);
            port.Write("R");
        }
        private void iyabtn_Click(object sender, EventArgs e)
        {
            port.Write("J");
        }
        private async void sdabtn_Click(object sender, EventArgs e)
        {
            port.Write("A");
            await Task.Delay(2000);
            port.Write("C");
        }
        private void fcabtn_Click(object sender, EventArgs e)
        {
            port.Write("G");
        }
        private void fcobtn_Click(object sender, EventArgs e)
        {
            port.Write("H");
        }
        private void fccbtn_Click(object sender, EventArgs e)
        {
            port.Write("I");
        }
        private void iyobtn_Click(object sender, EventArgs e)
        {
            port.Write("K");
        }
        private void iycbtn_Click(object sender, EventArgs e)
        {
            port.Write("L");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private async void sdobtn_Click(object sender, EventArgs e)
        {
            port.Write("B");
            await Task.Delay(6000);
            port.Write("C");
        }
        private async void sdcbtn_Click(object sender, EventArgs e)
        {
            port.Write("B");
            await Task.Delay(9000);
            port.Write("C");
        }
        private void iabtn_Click(object sender, EventArgs e)
        {
            port.Write("M");
           
        }
        private void ikbtn_Click(object sender, EventArgs e)
        {
            port.Write("N");
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            port.Write("O");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            port.Write("P");
        }
        
    }
}

