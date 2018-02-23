using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nSpireTestPrep
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Ports.Refresh();
            foreach (string port in Ports.COM)
            {
                cOMPortsToolStripMenuItem.DropDownItems.Add(port);
            }


            /*foreach (Devices.Device dev in Devices.All)
            {
                devicesToolStripMenuItem.DropDownItems.Add(dev.Name,dev.Icon);

            }*/
        }
    }
}
