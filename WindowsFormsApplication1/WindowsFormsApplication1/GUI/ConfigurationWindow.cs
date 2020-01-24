using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ConfigurationWindow : Form
    {
        public ConfigurationWindow()
        {
            InitializeComponent();

            txtBoxHostname.Text = "192.168.1.101";






            btnOk.Click += delegate
            {
                CommunicationChannel.SetConnectionParameters(txtBoxHostname.Text, Convert.ToInt32(txtBoxPort.Text));
                CommunicationChannel.StartCommunication();
               

                Close();
            };


        }
    }
}
