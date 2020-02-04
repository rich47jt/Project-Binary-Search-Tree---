using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary_Tree BTS = new Binary_Tree();
            BTS.Add(45);
            BTS.Add(40);
            BTS.Add(67);
            BTS.Add(66);
            BTS.Search(67);
            BTS.Search(50);
            Console.ReadLine();
        
        }
    }
}
