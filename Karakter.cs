using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_1
{
    internal class Karakter
    {
        Random random = new Random();
        public int id { get; set; }
        public string ad { get; set; }

        public Karakter(int id,string ad)
        {
            this.id = id;
            this.ad = ad;
        }
    }
}