using System;
using System.IO;

namespace LocalMaximum
{
    class Program
    {
        static void Main()
        {
            int indexOfLocalMax = -1;

            using (var reader = File.OpenText("Inlet.in.txt"))
            {
                int length = Convert.ToInt32(reader.ReadLine());
                int[] vector = new int[length];
                int index = 0;

                string element = null;

                while ((element = reader.ReadLine()) != null)
                {
                    vector[index] = Convert.ToInt32(element);
                    index++;
                }

                for (int i = 1; i < vector.Length - 1; i++)
                {
                    if (vector[i] > vector[i - 1] && vector[i] > vector[i + 1])
                    {
                        indexOfLocalMax = i + 1;

                        break;
                    }
                }
            }

            using (var writer = File.CreateText("Outlet.out.txt"))
            {
                writer.WriteLine(indexOfLocalMax);
            }
        }
    }
}
