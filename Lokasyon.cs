using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_1
{
    internal class Lokasyon
    {
        
            private Random random = new Random();
            public int locx { get; private set; }
            public int locy { get; private set; }
            public Lokasyon()
            {
                locx = random.Next(0, 120);
                locy = random.Next(0, 120);
            }
        }
    }

