using System;
using System.Collections.Generic;
using System.Text;

namespace _20261111_BinarySerilationDemo
{
    [Serializable]
    public struct Student
    {
        public int RBN { get; set; }

        public string Name { get; set; }

        public double AvgMark { get; set; }

        public override string ToString()
        {
            return $"{RBN} - {Name}, {AvgMark}";
        }
    }
}
