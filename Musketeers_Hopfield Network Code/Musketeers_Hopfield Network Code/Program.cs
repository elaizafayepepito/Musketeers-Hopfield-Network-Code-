namespace Musketeers_Hopfield_Network_Code
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            /*
            int[] patrn1 = { -1, 1, -1, 1, 1, 1, -1, 1, -1 };
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
            h1.Activation(patrn1);
            for (int i = 0; i < 9; i++)
            {
                if (h1.output[i] == patrn1[i])
                {
                    Console.WriteLine("Pattern = " + patrn1[i] + " \nOutput = " + h1.output[i] + " component matches");
                }
                else
                {
                    Console.WriteLine("Pattern = " + patrn1[i] + " \nOutput = " + h1.output[i] + " discrepancy occurred");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int[] patrn2 = { -1, -1, -1, 1, 1, 1, -1, -1, -1 };
            h1.Activation(patrn2);
            for (int i = 0; i < 9; i++)
            {
                if (h1.output[i] == patrn2[i])
                {
                    Console.WriteLine("Pattern = " + patrn2[i] + " \nOutput = " + h1.output[i] + " component matches");
                }
                else
                {
                    Console.WriteLine("Pattern = " + patrn2[i] + " \nOutput = " + h1.output[i] + " discrepancy occurred");
                }
            }*/
        }
    }
}