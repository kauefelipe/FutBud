using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBud.Services
{
    static class WriteLog
    {
        public static void DoWrite(string str)
        {
            var log = !File.Exists("log.txt") ? new StreamWriter("log.txt") : File.AppendText("log.txt");
            log.WriteLine(DateTime.Now + " # " + str);
            log.Close();
        }
    }
    
}
