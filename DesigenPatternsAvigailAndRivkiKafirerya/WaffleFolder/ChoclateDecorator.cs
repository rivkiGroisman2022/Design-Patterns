﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class ChoclateDecorator : WaffleDecorators
    {
        public ChoclateDecorator(Waffle waffle) : base(waffle)
        {
            Debug.WriteLine("ChoclateDecorator");
        }
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on ChoclateDecorator");
            return waffle.GetCost() + 5;
        }
    }
}
