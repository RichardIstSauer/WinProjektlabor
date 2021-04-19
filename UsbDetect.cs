using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management;

namespace WinProjektlabor
{
    class UsbDetect
    {
        public event EventHandler DriveDetected;
        public event EventHandler DriveRemoved;

        BackgroundWorker bgwDriveDetector;
        string driveName = null;

        public UsbDetect()
        {
            bgwDriveDetector = new BackgroundWorker();
            bgwDriveDetector.DoWork += bgwDriveDetector_DoWork;
            bgwDriveDetector.RunWorkerAsync();
        }

        void bgwDriveDetector_DoWork(object sender, DoWorkEventArgs e)
        {
            var insertQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            var insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += DeviceInsertedEvent;
            insertWatcher.Start();

            var removeQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            var removeWatcher = new ManagementEventWatcher(removeQuery);
            removeWatcher.EventArrived += DeviceRemovedEvent;
            removeWatcher.Start();
        }

        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            try
            {
                do
                {
                    driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    var driveQuery = from d in drives
                                     where d.Name.Contains(driveName)
                                     select d;
                    DriveInfo drive = driveQuery.FirstOrDefault<DriveInfo>();
                    if (drive != null)
                    {
                        onDriveDetected(driveName, drive.VolumeLabel);
                    }
                } while (driveName == null);
            }
            catch
            {

            }
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            try
            {
                string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
                onDriveRemoved(driveName);
            }
            catch
            {

            }
        }

        private void onDriveDetected(string driveName, string driveLabel)
        {
            DriveDetected?.Invoke(this, new DriveInfoEventArgs(driveName, driveLabel));
        }

        private void onDriveRemoved(string driveName)
        {
            DriveRemoved?.Invoke(this, new DriveInfoEventArgs(driveName, string.Empty));
        }
    }
}
