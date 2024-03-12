using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Краші_гірші_непорівняня_альтернатив_V2
{
    public class Calculation
    {

        public Calculation(StrInputData MyInput)//розмір масивів MaxMasCret та MyMasCret повинен бути однаковий
        {
            NMasCret = int.Parse(MyInput.StrNMasCret);
            MaxMasCret = MyInput.StrArrIntoIntArr(MyInput.StrMaxMasCret);
            MyMasCret= MyInput.StrArrIntoIntArr(MyInput.StrMyMasCret);
        }
        public Calculation(int NMasCret,int[] MaxMasCret,int[] MyMasCret)//розмір масивів MaxMasCret та MyMasCret повинен бути однаковий
        {
            if (MaxMasCret.Length != MyMasCret.Length)
            {
                throw new ArgumentException("Массивы должны иметь одинаковую длину.");
            }
            else
            {
                this.NMasCret = NMasCret;
                this.MaxMasCret = MaxMasCret;
                this.MyMasCret= MyMasCret;
            }
        }
        public int NMasCret;
        public int[] MaxMasCret;
        public int[] MyMasCret;

        public int CountGood()
        {
            int bad = 1;
            for (int i = 0; i < MyMasCret.Length; ++i)
            {
                bad*= MyMasCret[i];
            }
            bad -= 1;
            return bad;
        }
        public int CountBad()
        {
            int good = 1;
            for (int i = 0; i < MaxMasCret.Length; ++i)
            {
                good*=MaxMasCret[i]-MyMasCret[i]+1;
            }
            good-=1;
            return good;
        }
        public int CountAll()
        {
            int all = 1;
            for (int i = 0; i < MaxMasCret.Length; ++i)
            {
                all *=MaxMasCret[i];
            }
            return all;
        }
        public int CountDifrent()
        {
            return CountAll()-CountGood()-CountBad()-1;
        }
    }
}
