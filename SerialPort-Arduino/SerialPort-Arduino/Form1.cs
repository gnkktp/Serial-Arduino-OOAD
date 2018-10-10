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
    }
}
