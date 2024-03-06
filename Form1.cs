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


        static DataTable FPrit(List<object[]> matr)
        {

            DataTable table = new DataTable();



            // Добавление столбцов в DataTable
            for (int i = 0; i < matr[0].Length; i++)
            {
                table.Columns.Add($"Column{i}");
            }

            // Добавление данных в DataTable
            for (int i = 0; i < matr.Count; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < matr[0].Length; j++)
                {
                    row[j] = "k"+(j+1)+matr[i][j];
                }
                table.Rows.Add(row);
            }


            return table;
        }



        private void button8_Click(object sender, EventArgs e)//розрахунок

        {
            int NMasCret;
            int[] maxMasCret;
            int[] MyMasCret;


            //заповнення 1:
            NMasCret=9;
            maxMasCret = Enumerable.Repeat(3, NMasCret).ToArray();

            //оберемо альтернативу: 1,2,3, 3,2,1, 2,2,1.
            //заповнення 2:

            MyMasCret =new int[NMasCret];
            MyMasCret[0]=1;
            MyMasCret[1]=2;
            MyMasCret[2]=3;

            MyMasCret[3]=3;
            MyMasCret[4]=2;
            MyMasCret[5]=1;

            MyMasCret[6]=2;
            MyMasCret[7]=2;
            MyMasCret[8]=1;


            //заповненя 1:

            //NMasCret = 3;
            //maxMasCret= new int[NMasCret];
            //maxMasCret[0]=3;
            //maxMasCret[1]=3;
            //maxMasCret[2]=7;
            //заповненя 2:

            //MyMasCret=new int[NMasCret];
            //MyMasCret[0]=2;
            //MyMasCret[1]=2;
            //MyMasCret[2]=3;





            NMasCret= int.Parse(textBox4.Text);
            maxMasCret= new int[NMasCret];
            MyMasCret=new int[NMasCret];

            ////заповненя 1
            labe2.Text="ввели: ";
            string[] words = textBox5.Text.Split(' ');

            for (int i = 0; i<maxMasCret.Length; i++)
            {
                maxMasCret[i]=int.Parse(words[i]);
                labe2.Text += maxMasCret[i];
            }

            ////заповненя 2
            labe3.Text="ввели: ";
            string[] words1 = textBox6.Text.Split(' ');

            for (int i = 0; i<MyMasCret.Length; i++)
            {
                MyMasCret[i]=int.Parse(words1[i]);
                labe2.Text += maxMasCret[i];
            }


            //
            labe1.Text="кількість критеріїв: "+NMasCret;
            labelBest.Text="Краща: (";
            labelWorst.Text="Гірша: (";
            for (int i = 0; i<maxMasCret.Length; i++)
            {
                labelBest.Text+="k"+(i+1)+1+", ";
                labelWorst.Text+="k"+(i+1)+maxMasCret[i]+", ";
            }
            //видалення останніх двох символів
            labelBest.Text=labelBest.Text.Remove(labelBest.Text.Length - 2);
            labelWorst.Text=labelWorst.Text.Remove(labelWorst.Text.Length - 2);

            labelBest.Text+=")";
            labelWorst.Text+=")";


            int bad = 1;
            for (int i = 0; i < maxMasCret.Length; ++i)
            {
                bad*= MyMasCret[i];
            }
            bad -= 1;
            la1.Text="краші: "+bad;

            int good = 1;
            for (int i = 0; i < maxMasCret.Length; ++i)
            {
                good*=maxMasCret[i]-MyMasCret[i]+1;
            }
            good-=1;
            la2.Text="гірші: "+good;


            int all = 1;
            for (int i = 0; i < maxMasCret.Length; ++i)
            {
                all *=maxMasCret[i];
            }

            la31.Text="всього гіпотетично: "+all;

            //хитро:
            int difrent = all-good-bad-1;
            la4.Text="непорівняні: "+difrent;

            la3.Text="всього фактично: "+(difrent+good+bad+1);





        }
    }
}
