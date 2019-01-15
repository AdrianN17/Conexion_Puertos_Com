using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Puertos_Com
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                MessageBox.Show("No existen puertos actualmente.\n Intente mas tarde.", "Error");
                Application.Exit();
            }
            else
            {
                cports.Items.AddRange(ports);
                cports.SelectedIndex = 0;

                try
                {
                    TextWriter tw = new StreamWriter("data.txt", true);
                    tw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btclose.Enabled = false;
            }

        }

        private void btopen_Click(object sender, EventArgs e)
        {
            btopen.Enabled = false;
            btclose.Enabled = true;
            timer1.Enabled = true;

            try
            {
                serialPort1.PortName = cports.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            btopen.Enabled = true;
            btclose.Enabled = false;

            timer1.Enabled = false;


            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            String data = null;
            try
            {
                if (serialPort1.IsOpen)
                {
                    data = serialPort1.ReadLine();

                    lb1.Text = "Recibido";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            StreamWriter fileWriter = new StreamWriter("data.txt");

            fileWriter.WriteLine(data);

            fileWriter.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }


            if (File.Exists(@"data.txt"))
            {
                try
                {
                    File.Delete(@"data.txt");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "nombre_proceso")
                {
                    proceso.Kill();
                }
            }

        }
    }
}
