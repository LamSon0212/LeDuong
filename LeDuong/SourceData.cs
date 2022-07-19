using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuong
{
    public class SourceData
    {
        public SourceData() { }

        private string luHao;
        private string chuGangJiHao;
        private DateTime riQi;
        private string guoCheng;
        private double c;
        private double si;
        private double mn;
        private double p;
        private double s;
        private double sAl;
        private double tAl;
        private double cU;
        private double nB;
        private double b;
        private double nI;
        private double cR;
        private double mO;
        private double tI;
        private double v;
        private double zR;
        private double pB;
        private double sN;
        private double aS;
        private double cA;
        private double sB;
        private double zN;
        private double h;//
        private double n;
        private double o;

        // Ctrl+R+E
        public string LuHao { get => luHao; set => luHao = value; }
        public string ChuGangJiHao { get => chuGangJiHao; set => chuGangJiHao = value; }
        public DateTime RiQi { get => riQi; set => riQi = value; }
        public string GuoCheng { get => guoCheng; set => guoCheng = value; }
        public double C { get => c; set => c = value; }
        public double Si { get => si; set => si = value; }
        public double Mn { get => mn; set => mn = value; }
        public double P { get => p; set => p = value; }
        public double S { get => s; set => s = value; }
        public double SAl { get => sAl; set => sAl = value; }
        public double TAl { get => tAl; set => tAl = value; }
        public double CU { get => cU; set => cU = value; }
        public double NB { get => nB; set => nB = value; }
        public double B { get => b; set => b = value; }
        public double NI { get => nI; set => nI = value; }
        public double CR { get => cR; set => cR = value; }
        public double MO { get => mO; set => mO = value; }
        public double TI { get => tI; set => tI = value; }
        public double V { get => v; set => v = value; }
        public double ZR { get => zR; set => zR = value; }
        public double PB { get => pB; set => pB = value; }
        public double SN { get => sN; set => sN = value; }
        public double AS { get => aS; set => aS = value; }
        public double CA { get => cA; set => cA = value; }
        public double SB { get => sB; set => sB = value; }
        public double ZN { get => zN; set => zN = value; }
        public double H { get => h; set => h = value; }
        public double N { get => n; set => n = value; }
        public double O { get => o; set => o = value; }
        public  SourceData(DataRow row)
        {
            //Id = (int)row["ID"];

            //var sExpirationDate = row["ExpirationDate"];
            //if (sExpirationDate.ToString() != "")
            //    ExpirationDate = (DateTime?)sExpirationDate;

            //var sDaysRemaininge = row["DaysRemaining"];
            //if (sDaysRemaininge.ToString() != "")
            //    DaysRemaining = (int)sDaysRemaininge;

            LuHao = row[1].ToString();
            ChuGangJiHao = row[3].ToString();
            GuoCheng = row[6].ToString();

            var sRiQi = row[4];
            if (sRiQi.ToString() != "")
               RiQi = (DateTime)sRiQi;

            var Value1 = row[8];
            if (Value1.ToString() != "")
                C = (double)Value1;

             var Value2 = row[9];
            if (Value2.ToString() != "")
                Si = (double)Value2;

            var Value3 = row[10];
            if (Value3.ToString() != "")
                Mn = (double)Value3;

            var Value4 = row[11];
            if (Value4.ToString() != "")
                P = (double)Value4;

            var Value5 = row[12];
            if (Value5.ToString() != "")
                S = (double)Value5;

            var Value6 = row[13];
            if (Value6.ToString() != "")
                SAl = (double)Value6;

            var Value7 = row[14];
            if (Value7.ToString() != "")
                TAl = (double)Value7;

            var Value8 = row[15];
            if (Value8.ToString() != "")
                CU = (double)Value8;

            var Value9 = row[16];
            if (Value9.ToString() != "")
                NB = (double)Value9;

            var Value10 = row[17];
            if (Value10.ToString() != "")
                B = (double)Value10;

            var Value11 = row[18];
            if (Value11.ToString() != "")
                NI = (double)Value11;

            var Value12 = row[19];
            if (Value12.ToString() != "")
                CR = (double)Value12;

            var Value13 = row[20];
            if (Value13.ToString() != "")
                MO = (double)Value13;

            var Value14 = row[21];
            if (Value14.ToString() != "")
                TI = (double)Value14;

            var Value15 = row[22];
            if (Value15.ToString() != "")
                V = (double)Value15;

            var Value16 = row[23];
            if (Value16.ToString() != "")
                ZR = (double)Value16;

            var Value17 = row[24];
            if (Value17.ToString() != "")
                PB = (double)Value17;

            var Value18 = row[25];
            if (Value18.ToString() != "")
                SN = (double)Value18;

            var Value19 = row[26];
            if (Value19.ToString() != "")
                AS = (double)Value19;

            var Value20 = row[27];
            if (Value20.ToString() != "")
                CA = (double)Value20;

            var Value21 = row[28];
            if (Value21.ToString() != "")
                SB = (double)Value21;

            var Value22 = row[29];
            if (Value22.ToString() != "")
                ZN = (double)Value22;

            var Value23 = row[30];
            if (Value23.ToString() != "")
                H = (double)Value23;

            var Value24 = row[31];
            if (Value24.ToString() != "")
                N = (double)Value24;
        
            var Value25 = row[32];
            if (Value25.ToString() != "")
                O = (double)Value25;

        }


    }

    public class adATA
    {
        public adATA() { }
    }
}
