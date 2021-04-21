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
            string iButtonID = string.Empty;
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


        public string RandomString(Int64 Length)
        {
            System.Random rnd = new System.Random();
            StringBuilder Temp = new StringBuilder();
            for (Int64 i = 0; i < Length; i++)
            {
                Temp.Append(Convert.ToChar(((byte)rnd.Next(48,57))).ToString());
                Temp.Append(Convert.ToChar(((byte)rnd.Next(65,90))).ToString());
            }
            return Temp.ToString();
        }

        public string New(string drive)
        {
            string iButtonID = RandomString(8);
            using (StreamWriter sw = new StreamWriter(drive + "\\config.txt"))
            {
                
                sw.WriteLine(iButtonID);
                return iButtonID;
            }
        }
    }
}
