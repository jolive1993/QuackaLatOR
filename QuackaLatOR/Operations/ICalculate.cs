﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public interface ICalculate
    {
        void calculate();
        int Priority { get; set; }
        int Num1 { get; set; }
        int Num2 { get; set; }
        int Result { get; set; }
        string Text { get; set; }
    }
}