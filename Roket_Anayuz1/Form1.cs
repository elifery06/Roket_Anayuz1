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

namespace Roket_Anayuz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            ComPortBox.Items.AddRange(portNames);
            // ComPortBox.Text = portNames[0];
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        

        private void ComPortOpenButton_Click(object sender, EventArgs e)
        {
            ComPortOpen();
        }


        private void ComPortOpen()
        {
            try
            {
                seriP1.PortName = ComPortBox.Text;
                seriP1.Open();
                ComPortStatus.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Bir hatanız var!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        #region Com Port Close
       

        private void ComPortClose()
        {
            if (seriP1.IsOpen)
            {
                seriP1.Close();
            }
            else
            {
                MessageBox.Show("Seri port zaten kapalı.", "Seri Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComPortStatus.Value = 0;
        }
        #endregion

        private void ComPortCloseButton_Click(object sender, EventArgs e)
        {
            ComPortClose();
        }
    }
}
