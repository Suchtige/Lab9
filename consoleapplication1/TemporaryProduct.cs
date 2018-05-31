using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TemporaryProduct : scroll
    {
        public DateTime _StartSelling;
        public DateTime _EndSelling;
        public DateTime StartSelling
        {
            get
            {
                if (_StartSelling == null)
                    throw new Exception("Укажите время начала продаж");
                else
                    return _StartSelling;
            }
            set
            {
                _StartSelling = value;
            }
        }
        public DateTime EndSelling
        {
            get
            {
                if (_EndSelling == null)
                    throw new Exception("Укажите вермя конца продаж");
                else if (_EndSelling == _StartSelling)
                    throw new Exception("Дата конца продаж не может совпадать с датой начала продаж");
                else
                    return _EndSelling;
            }
            set
            {
                _EndSelling = value;
            }
        }
        public TemporaryProduct(int scrollID,string scrollName, double scrollStrength, 
            DateTime StartSelling, DateTime EndSelling) : 
            base (scrollID, scrollName, scrollStrength)
        {
            this.StartSelling = StartSelling;
            this.EndSelling = EndSelling;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine("Дата поступления в продажу: {0}", StartSelling);
            Console.WriteLine("Дата конца продажи: {0}", EndSelling);
        }            
    }
}
