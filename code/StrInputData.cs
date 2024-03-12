using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Краші_гірші_непорівняня_альтернатив_V2
{
    public class StrInputData
    {
        public StrInputData(string StrNMasCret, string StrMaxCret, string StrMyCret)
        {
            this.StrNMasCret = StrNMasCret;
            if (StrMaxCret.Split(' ').Length != StrMyCret.Split(' ').Length)
            {
                throw new ArgumentException("Массивы должны иметь одинаковую длину.");
            }
            else
            {
                StrMaxMasCret = StrMaxCret.Split(' ');
                StrMyMasCret= StrMyCret.Split(' ');
            }

        }
        public string StrNMasCret;
        public string[] StrMaxMasCret;
        public string[] StrMyMasCret;

        public int[] StrArrIntoIntArr(string[] words)
        {
            int[] result = new int[words.Length];

            for (int i = 0; i<result.Length; i++)
            {
                result[i]=int.Parse(words[i]);
            }

            return result;
        }
    }
}
