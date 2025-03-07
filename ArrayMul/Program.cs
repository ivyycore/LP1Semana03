using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            float[,] Mb = new float [2,2]; // creates a matrix

            float[] Ma = new float [2]; // creates a matrix 

            Ma[0,0] = float.Parse(args[0]);
            Ma[0,1] = float.Parse(args[1]);
            Ma[1,0] = float.Parse(args[2]);
            Ma[1,1] = float.Parse(args[3]);
            Mb[0] = float.Parse(args[4]);
            Mb[1] = float.Parse(args[5]);


            
        }
    }
}
