using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{   public enum Level
    {
        low,
        medium,
        high
    }
    public class Amulet
    {
        string itemid;
        string design;
        Level quality;

        public Amulet(string itemid, Level quality, string design)
        {
            this.itemid = itemid;
            this.quality = quality;
            this.design = design;
        }
        public Amulet(string itemid, Level quality) :
            this(itemid, quality, "")
        {
            //this.itemid = itemid;
            //this.quality = quality;
        }
        public Amulet (string itemid):
            this(itemid, Level.medium, "")
        {
            //this.itemid = itemid;
        }
        
        
    }
}
