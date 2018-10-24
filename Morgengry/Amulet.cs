using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Amulet
    {
        string itemid;
        string design;
        level quality;       
        public enum level
        {
            low,
            medium,
            high
        }
        public Amulet (string itemid)
        {
            this.itemid = itemid;
        }
        public Amulet(string itemid, level quality)
        {
            this.itemid = itemid;
            this.quality = quality;
        }
        public Amulet(string itemid, level quality, string design)
        {
            this.itemid = itemid;
            this.quality = quality;
            this.design = design;
            ToString();
        }
    }
}
