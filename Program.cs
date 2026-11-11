using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _20261111_BinarySerilationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter frmtr = new BinaryFormatter();

            int[] data = new int[] { 1, 2, 3, 4, 5 };

            using (FileStream fs = new FileStream("data.dat", FileMode.Create, FileAccess.Write))
            {
                frmtr.Serialize(fs, data);
            }

            using (FileStream fs = new FileStream("data.dat", FileMode.Open, FileAccess.Read))
            {
                int[] dataCopy = (int[])frmtr.Deserialize(fs);

                Console.WriteLine("dataCopy:");
                for (int i = 0; i < dataCopy.Length; i++)
                {
                    Console.Write($"{dataCopy[i]} ");
                }
                Console.WriteLine();
           }

            List<Student> group1 = new List<Student>
            {
                new Student { RBN = 1, Name = "Ivan", AvgMark = 4.5 },
                new Student { RBN = 2, Name = "Petar", AvgMark = 3.8 },
                new Student { RBN = 3, Name = "Georgi", AvgMark = 5.0 }
            };

            using (FileStream fs = new FileStream("group1.dat", FileMode.Create, FileAccess.Write))
            {
                frmtr.Serialize(fs, group1);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            using (FileStream fs = new FileStream("group1.dat", FileMode.Open, FileAccess.Read))
            {
                List<Student> group1Copy = (List<Student>)frmtr.Deserialize(fs);

                Console.WriteLine("group1Copy:");
                foreach (var student in group1Copy)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
