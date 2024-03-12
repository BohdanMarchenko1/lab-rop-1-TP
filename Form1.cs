using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Краші_гірші_непорівняня_альтернатив_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //МЕТОДИ:

        public int[] StrArrIntoIntArr(string[] words)
        {
            int[] result = new int[words.Length];

            for (int i = 0; i<result.Length; i++)
            {
                result[i]=int.Parse(words[i]);
            }

            return result;
        }
        //вивід
        public string StringBest(int NmasCret)
        {
            string str="";
            for (int i = 0; i<NmasCret; i++)
            {
                str+="k"+(i+1)+1+", ";
                
            }
            str=str.Remove(str.Length - 2);
            str="Краща: ("+str+")";
            return str;
            
        }
        public string StringWorst(int[] MaxMasCret)
        {
            string str = "";
            for (int i = 0; i<MaxMasCret.Length; i++)
            {
                str+="k"+(i+1)+MaxMasCret[i]+", ";

            }
            str=str.Remove(str.Length - 2);
            str="Гірша: ("+str+")";
            return str;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            Calculation MyCalc = new Calculation(new StrInputData(textBox4.Text, textBox5.Text, textBox6.Text));

            //вивід введених даних
            labe1.Text="ввели: "+textBox4.Text;
            labe2.Text="ввели: "+textBox5.Text;
            labe3.Text="ввели: "+textBox6.Text;

            //вивід кращої та гіршої альтернативи
            labelBest.Text=MyCalc.StringBest();
            labelWorst.Text=MyCalc.StringWorst();

            //вивід скільки альтернатив кращіх/гірших/непорівняних/всього
            la1.Text="краші: "+MyCalc.CountGood();
            la2.Text="гірші: "+MyCalc.CountBad();
            la3.Text="всього: "+MyCalc.CountAll();
            la4.Text="непорівняні: "+MyCalc.CountDifrent();
        }
    }
}
