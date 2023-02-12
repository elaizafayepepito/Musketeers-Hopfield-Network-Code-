using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Musketeers_Hopfield_Network_Code
{
    /*
    public class Hopfield
    {
        static void Main(string[] args)
        {
            int[] pattern1 = new int[] { 1, -1, 1, -1 };
            int[] pattern2 = new int[] { -1, 1, -1, 1 };

            HopfieldNetwork network = new HopfieldNetwork(4);

            network.Train(pattern1);
            network.Train(pattern2);

            int[] test = new int[] { 1, 1, 1, -1 };

            network.Recall(test);

            Console.WriteLine("Recalled pattern:");
            foreach (var item in test)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class HopfieldNetwork
    {
        int size;
        int[,] weights;

        public HopfieldNetwork(int size)
        {
            this.size = size;
            this.weights = new int[size, size];
        }

        public void Train(int[] pattern)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        weights[i, j] += pattern[i] * pattern[j];
                    }
                }
            }
        }

        public void Recall(int[] pattern)
        {
            int[] newState = (int[])pattern.Clone();

            while (true)
            {
                int[] oldState = (int[])newState.Clone();

                for (int i = 0; i < size; i++)
                {
                    int sum = 0;

                    for (int j = 0; j < size; j++)
                    {
                        sum += weights[i, j] * newState[j];
                    }

                    newState[i] = Math.Sign(sum);
                }

                if (oldState.SequenceEqual(newState))
                {
                    break;
                }
            }

            for (int i = 0; i < size; i++)
            {
                pattern[i] = newState[i];
            }
        }
    }
}

using System;

public class Neuron
{
    int[] weightv = new int[4];

    public Neuron(int[] j)
    {
        for (int i = 0; i < 4; i++)
        {
            weightv[i] = j[i];
        }
    }

    public int act(int m, int[] x)
    {
        int a = 0;
        for (int i = 0; i < m; i++)
        {
            a += x[i] * weightv[i];
        }
        return a;
    }
}

class Network
{
    Neuron[] nrn = new Neuron[4];
    int[] output = new int[4];

    public Network(int[] a, int[] b, int[] c, int[] d)
    {
        nrn[0] = new Neuron(a);
        nrn[1] = new Neuron(b);
        nrn[2] = new Neuron(c);
        nrn[3] = new Neuron(d);
    }

    public int threshld(int k)
    {
        if (k >= 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public void activation(int[] patrn)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("\n nrn[" + i + "].weightv[" + j + "] is " + nrn[i].weightv[j]);
            }
            nrn[i].activation = nrn[i].act(4, patrn);
            Console.WriteLine("\nactivation is " + nrn[i].activation);
            output[i] = threshld(nrn[i].activation);
            Console.WriteLine("\noutput value is " + output[i] + "\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] patrn1 = { 1, 0, 1, 0 };
        int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
        int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
        int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
        int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
        int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
        int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
        int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
        int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
        int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };
        Console.WriteLine("\nTHIS PROGRAM IS FOR A HOPFIELD NETWORK WITH A SINGLE LAYER OF");
        Console.WriteLine("\n4 FULLY INTERCONNECTED NEURONS. THE NETWORK SHOULD RECALL THE");
        Console.WriteLine("\nPATTERNS 1010 AND 0101 CORRECTLY.\n");
        Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);
        h1.activation(patrn1);
        for (int i = 0; i < 4; i++)
        {
            if (h1.output[i] == patrn1[i])
            {
                Console.WriteLine("Pattern = ")
        */
}