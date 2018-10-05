using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap3._2
{
    public class Laundry
    {
        public List<Clothes> Clothes { get; set; }

        public List<Clothes> Laundered()
        {
            Clothes.ForEach(s => s.Clean = true);
            return Clothes;
        }

    }
}
