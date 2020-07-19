using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFTest
{
    public class Alarm
    {
        private string source;
        private string tag;
        private string name;
        private string description;

        public string Source { get => source; set => source = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
