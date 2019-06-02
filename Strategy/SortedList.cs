using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _List = new List<string>();
        private SortStrategy _ShellSort;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._ShellSort = sortStrategy;
        }

        public void Add(string name)
        {
            _List.Add(name);
        }

        public void Sort()
        {
            _ShellSort.Sort(_List);

            foreach (var item in _List)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine();
        }
    }
}
