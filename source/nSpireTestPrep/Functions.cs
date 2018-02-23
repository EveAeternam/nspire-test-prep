using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Net;
using System.Reflection;
using System.Drawing;
using System.Resources;
using System.Media;

namespace nSpireTestPrep
{
    public static class Devices
    {
        private static List<Device> devices = new List<Device>()
        {
            new Device("TI nSpire CX"),
            new Device("TI nSpire CX CAS")
        };
        private static string[] brands = new string[]
        {
            "Texas Instruments"
        };

        public static string[] Brands
        {
            get { return brands; }
            set { brands = value; }
        }

        public static List<Device> DeviceList
        {
            get { return devices; }
            set { devices = value; }
        }

        public static Device[] All
        {
            get { return devices.ToArray(); }
            set { devices = value.ToList(); }
        }

        public class Device
        {
            public string Name { get; set; }
            public Image Icon { get; set; }
            public float Capacity { get; set; }
            public string FileFormat { get; set; }
            public string Manufacturer = "";

            public Device() { Name = "Unnamed"; }
            public Device(string name) { Name = name; }
            public Device(string name, Image img, float cap, string format)
            {
                Name = name;
                Icon = img;
                Capacity = cap;
                FileFormat = format;
            }
        }
    }

    public static class Ports
    {
        private static string[] coms = System.IO.Ports.SerialPort.GetPortNames();

        public static void Refresh()
        {
            coms = System.IO.Ports.SerialPort.GetPortNames();
        }

        public static string[] COM
        {
            get { return coms; }
            set { coms = value; }
        }
    }

    public static class DeviceInfo
    {
        private static double freeSpace = 0;
        

        public static string Name { get; set; }
        public static double FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }

    }
}
