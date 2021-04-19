using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinProjektlabor
{
    class Drive
    {
        public string Start(string drive)
        {
            string iButtonID = "";
            if (File.Exists(drive + "\\config.txt")) {
                using (StreamReader sr = new StreamReader(drive + "\\config.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        iButtonID = sr.ReadLine();
                    }
                }
                return iButtonID;
            }
            return "0";
        }
    }
}
