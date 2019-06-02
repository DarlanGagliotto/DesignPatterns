using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList student = new SortedList();
            student.Add("Paulo");
            student.Add("Zeca");
            student.Add("Juca");
            student.Add("Antonio");
            student.Add("Carla");
            student.Add("Joana");
            student.Add("Maria");

            student.SetSortStrategy(new QuickSort());
            student.Sort();

            student.SetSortStrategy(new ShellSort());
            student.Sort();

            student.SetSortStrategy(new MergeSort());
            student.Sort();

            Console.ReadKey();
        }
    }
}
