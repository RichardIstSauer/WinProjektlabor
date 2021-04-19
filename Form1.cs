﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProjektlabor
{
    public partial class Form1 : Form
    {
        UsbDetect usbDetect;
        Drive drive = new Drive();
        string driveName;
        string driveLabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveDetected += UsbDetect_DriveDetected;
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;
        }



        private void UsbDetect_DriveDetected(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            driveLabel = ((DriveInfoEventArgs)e).DriveLabel;
            //MessageBox.Show($"Drive {driveName} detected");
            string iButtonID = drive.Start($"{driveName}");
        }

        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            //MessageBox.Show($"Drive {driveName} removed");
        }
    }
}
