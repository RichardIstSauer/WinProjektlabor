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
            // Abfrage ob die config-File auf dem USB existiert
            if (File.Exists(drive + "\\config.txt")) {
                // Wenn ja config auslesen
                using (StreamReader sr = new StreamReader(drive + "\\config.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        // iButtonID auslesen
                        iButtonID = sr.ReadLine();
                    }
                }
                // iButtonID zurückgeben
                return iButtonID;
            }
            // Wenn keine Config existiert return 0
            return "0";
        }
    }
}
