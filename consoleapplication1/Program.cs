using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            DateTime Start = new DateTime(2018, 1, 20);
            DateTime End = new DateTime(2018, 2, 20);         
            List<TemporaryProduct> listproduct = new List<TemporaryProduct>();
            listproduct.Add(new TemporaryProduct(2, "Коньяк",40,  Start, End));
            foreach(TemporaryProduct ff in listproduct)
            {
                ff.info();
                Console.WriteLine();
            }
            Console.ReadLine();            
        }        
    }
}
