using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //обрахунок
        public int CountGood(int[] MyMasCret) 
        {
            int bad = 1;
            for (int i = 0; i < MyMasCret.Length; ++i)
            {
                bad*= MyMasCret[i];
            }
            bad -= 1;
            return bad;
        }
        public int CountBad(int[] MyMasCret, int[] MaxMasCret) 
        {
            int good = 1;   
            for (int i = 0; i < MaxMasCret.Length; ++i)
            {
                good*=MaxMasCret[i]-MyMasCret[i]+1;
            }
            good-=1;
            return good;
        }
        public int CountAll(int[] MaxMasCret)
        {
            int all = 1;
            for (int i = 0; i < MaxMasCret.Length; ++i)
            {
                all *=MaxMasCret[i];
            }
            return all;
        }
        public int CountDifrent(int[] MyMasCret, int[] MaxMasCret) 
        { 
            return CountAll(MaxMasCret)-CountGood(MyMasCret)-CountBad(MyMasCret, MaxMasCret)-1; 
        }




        private void button8_Click(object sender, EventArgs e)//розрахунок

        {


            //ввод даних
            int NMasCret = int.Parse(textBox4.Text);
            int[] MaxMasCret = StrArrIntoIntArr(textBox5.Text.Split(' '));
            int[] MyMasCret = StrArrIntoIntArr(textBox6.Text.Split(' '));

            //вивід введених даних
            labe1.Text="ввели: "+NMasCret;
            labe2.Text="ввели: "+textBox5.Text;
            labe3.Text="ввели: "+textBox6.Text;

            //вивід кращої та гіршої альтернативи
            labelBest.Text=StringBest(NMasCret);
            labelWorst.Text=StringWorst(MaxMasCret);


            //вивід скільки альтернатив кращіх/гірших/непорівняних/всього
            la1.Text="краші: "+CountGood(MyMasCret);
            la2.Text="гірші: "+CountBad(MyMasCret, MaxMasCret);
            la3.Text="всього: "+CountAll(MaxMasCret);
            la4.Text="непорівняні: "+CountDifrent(MyMasCret, MaxMasCret);


        }
    }
}
