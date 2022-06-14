using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCloser.Model
{
    public class InforSessionModel
    {
        public string Username { get; set; }
        public string Osuser { get; set; }
        public string Program { get; set; }
        public string Machine { get; set; }
        public string UsernameShort { get; set; }
        public string Status { get; set; }
        public int LastCallEt { get; set; }
        public int UserTimeout { get; set; }
        public string Process { get; set; }
        public string InforName { get; set; }
    }
}

