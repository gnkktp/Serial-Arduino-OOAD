using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace SerialPort_Arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListSerialPort_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(ports);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ports);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                return;
            }
            else
            {
                serialPort1.Open();
                open.Enabled = false;
                close.Enabled = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
            {
                return;
            }
            else
            {
                serialPort1.Close();
                open.Enabled = true;
                close.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            Console.WriteLine(serialPort1.PortName);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Int32.Parse(comboBox2.Text);
        }
    }
}
