﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musketeers_Hopfield_Network_Code
{
    public class Neuron
    {
        public int[] weightv = new int[9];
        public int activation;

        public Neuron(int[] j)
        {
            for (int i = 0; i < 9; i++)
            {
                weightv[i] = j[i];
            }
        }

        public int Act(int m, int[] x)
        {
            int a = 0;
            for (int i = 0; i < m; i++)
            {
                a += x[i] * weightv[i];
            }
            return a;
        }
    }
}
