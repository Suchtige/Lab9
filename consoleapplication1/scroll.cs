using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class scroll
    {
        private int _scrollID;
        private string _scrollName;
        private double _scrollStregth;

        public int scrollID
        {
            get
            {
                return _scrollID;
            }
            set
            {
                if (value > 0)
                    _scrollID = value;
                else
                    Console.WriteLine("Недопустимый индетификатор номенклатуры");
            }
        }

        public string scrollName
        {
            get
            {
                if (String.IsNullOrEmpty(_scrollName))
                    throw new Exception("Напиток не может не исеть названия");
                else
                    return _scrollName;
            }
            set
            {
                _scrollName = value;
            }
        }

        public double scrollStrength
        {
            get
            {
                if (_scrollStregth < 0)
                    throw new Exception("Напиток не может иметь отрицательную крепость");
                else
                    return _scrollStregth;
            }
            set
            {
                _scrollStregth = value;
            }
        }

        public scroll (int scrollID, string scrollName, double scrollStrength)
        {
            this.scrollID = scrollID;
            this.scrollName = scrollName;
            this.scrollStrength = scrollStrength;
        }

        public virtual void info()
        {
            Console.WriteLine("Код номенклатуры: {0}\nНазвание номенклатуры: {1}\nГрадус: {2}", 
                scrollID, scrollName, scrollStrength);
        }

        public override string ToString()
        {
            return scrollID.ToString() + ": " + scrollName;
        }
    }
}
