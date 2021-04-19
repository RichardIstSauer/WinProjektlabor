using System;

namespace WinProjektlabor
{
    class DriveInfoEventArgs : EventArgs
    {
        public string DriveName { get; set; }

        public string DriveLabel { get; set; }

        public DriveInfoEventArgs(string driveName, string driveLabel)
        {
            DriveName = driveName;
            DriveLabel = driveLabel;
        }
    }
}
