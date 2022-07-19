using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuong
{
    public class ChuGangJiHao_Data
    {
        private string chuGangJiHao;
        private string beizhu;

        private string fanWei;
        private string guoCheng;

        private double c_xia;
        private double c_shang;
        private double c_mubiao;//

        private double si_xia;
        private double si_shang;
        private double si_mubiao;//

        private double mn_xia;
        private double mn_shang;
        private double mn_mubiao;//

        private double p_xia;
        private double p_shang;
        private double p_mubiao;//

        private double s_xia;
        private double s_shang;
        private double s_mubiao;//

        private double al_xia;
        private double al_shang;
        private double al_mubiao;//

        private double sal_xia;
        private double sal_shang;
        private double sal_mubiao;//

        private double cu_xia;
        private double cu_shang;
        private double cu_mubiao;//

        private double ni_xia;
        private double ni_shang;
        private double ni_mubiao;//

        private double cr_xia;
        private double cr_shang;
        private double cr_mubiao;//

        private double nb_xia;
        private double nb_shang;
        private double nb_mubiao;//

        private double ti_xia;
        private double ti_shang;
        private double ti_mubiao;//

        private double v_xia;
        private double v_shang;
        private double v_mubiao;//

        private double mo_xia;
        private double mo_shang;
        private double mo_mubiao;//

        private double b_xia;
        private double b_shang;
        private double b_mubiao;//

        private double zr_xia;
        private double zr_shang;
        private double zr_mubiao;//

        private double pb_xia;
        private double pb_shang;
        private double pb_mubiao;//

        private double sn_xia;
        private double sn_shang;
        private double sn_mubiao;//

        private double as_xia;
        private double as_shang;
        private double as_mubiao;//

        private double ca_xia;
        private double ca_shang;
        private double ca_mubiao;//

        private double sb_xia;
        private double sb_shang;
        private double sb_mubiao;//

        private double zn_xia;
        private double zn_shang;
        private double zn_mubiao;//

        private double n_xia;
        private double n_shang;
        private double n_mubiao;//

        private double o_xia;
        private double o_shang;
        private double o_mubiao;//

        // Ctrl+R+E

        public string ChuGangJiHao { get => chuGangJiHao; set => chuGangJiHao = value; }
        public string Beizhu { get => beizhu; set => beizhu = value; }
        public string FanWei { get => fanWei; set => fanWei = value; }
        public string GuoCheng { get => guoCheng; set => guoCheng = value; }
        public double C_xia { get => c_xia; set => c_xia = value; }
        public double C_shang { get => c_shang; set => c_shang = value; }
        public double C_mubiao { get => c_mubiao; set => c_mubiao = value; }
        public double Si_xia { get => si_xia; set => si_xia = value; }
        public double Si_shang { get => si_shang; set => si_shang = value; }
        public double Si_mubiao { get => si_mubiao; set => si_mubiao = value; }
        public double Mn_xia { get => mn_xia; set => mn_xia = value; }
        public double Mn_shang { get => mn_shang; set => mn_shang = value; }
        public double Mn_mubiao { get => mn_mubiao; set => mn_mubiao = value; }
        public double P_xia { get => p_xia; set => p_xia = value; }
        public double P_shang { get => p_shang; set => p_shang = value; }
        public double P_mubiao { get => p_mubiao; set => p_mubiao = value; }
        public double S_xia { get => s_xia; set => s_xia = value; }
        public double S_shang { get => s_shang; set => s_shang = value; }
        public double S_mubiao { get => s_mubiao; set => s_mubiao = value; }
        public double Al_xia { get => al_xia; set => al_xia = value; }
        public double Al_shang { get => al_shang; set => al_shang = value; }
        public double Al_mubiao { get => al_mubiao; set => al_mubiao = value; }
        public double Sal_xia { get => sal_xia; set => sal_xia = value; }
        public double Sal_shang { get => sal_shang; set => sal_shang = value; }
        public double Sal_mubiao { get => sal_mubiao; set => sal_mubiao = value; }
        public double Cu_xia { get => cu_xia; set => cu_xia = value; }
        public double Cu_shang { get => cu_shang; set => cu_shang = value; }
        public double Cu_mubiao { get => cu_mubiao; set => cu_mubiao = value; }
        public double Ni_xia { get => ni_xia; set => ni_xia = value; }
        public double Ni_shang { get => ni_shang; set => ni_shang = value; }
        public double Ni_mubiao { get => ni_mubiao; set => ni_mubiao = value; }
        public double Cr_xia { get => cr_xia; set => cr_xia = value; }
        public double Cr_shang { get => cr_shang; set => cr_shang = value; }
        public double Cr_mubiao { get => cr_mubiao; set => cr_mubiao = value; }
        public double Nb_xia { get => nb_xia; set => nb_xia = value; }
        public double Nb_shang { get => nb_shang; set => nb_shang = value; }
        public double Nb_mubiao { get => nb_mubiao; set => nb_mubiao = value; }
        public double Ti_xia { get => ti_xia; set => ti_xia = value; }
        public double Ti_shang { get => ti_shang; set => ti_shang = value; }
        public double Ti_mubiao { get => ti_mubiao; set => ti_mubiao = value; }
        public double V_xia { get => v_xia; set => v_xia = value; }
        public double V_shang { get => v_shang; set => v_shang = value; }
        public double V_mubiao { get => v_mubiao; set => v_mubiao = value; }
        public double Mo_xia { get => mo_xia; set => mo_xia = value; }
        public double Mo_shang { get => mo_shang; set => mo_shang = value; }
        public double Mo_mubiao { get => mo_mubiao; set => mo_mubiao = value; }
        public double B_xia { get => b_xia; set => b_xia = value; }
        public double B_shang { get => b_shang; set => b_shang = value; }
        public double B_mubiao { get => b_mubiao; set => b_mubiao = value; }
        public double Zr_xia { get => zr_xia; set => zr_xia = value; }
        public double Zr_shang { get => zr_shang; set => zr_shang = value; }
        public double Zr_mubiao { get => zr_mubiao; set => zr_mubiao = value; }
        public double Pb_xia { get => pb_xia; set => pb_xia = value; }
        public double Pb_shang { get => pb_shang; set => pb_shang = value; }
        public double Pb_mubiao { get => pb_mubiao; set => pb_mubiao = value; }
        public double Sn_xia { get => sn_xia; set => sn_xia = value; }
        public double Sn_shang { get => sn_shang; set => sn_shang = value; }
        public double Sn_mubiao { get => sn_mubiao; set => sn_mubiao = value; }
        public double As_xia { get => as_xia; set => as_xia = value; }
        public double As_shang { get => as_shang; set => as_shang = value; }
        public double As_mubiao { get => as_mubiao; set => as_mubiao = value; }
        public double Ca_xia { get => ca_xia; set => ca_xia = value; }
        public double Ca_shang { get => ca_shang; set => ca_shang = value; }
        public double Ca_mubiao { get => ca_mubiao; set => ca_mubiao = value; }
        public double Sb_xia { get => sb_xia; set => sb_xia = value; }
        public double Sb_shang { get => sb_shang; set => sb_shang = value; }
        public double Sb_mubiao { get => sb_mubiao; set => sb_mubiao = value; }
        public double Zn_xia { get => zn_xia; set => zn_xia = value; }
        public double Zn_shang { get => zn_shang; set => zn_shang = value; }
        public double Zn_mubiao { get => zn_mubiao; set => zn_mubiao = value; }
        public double N_xia { get => n_xia; set => n_xia = value; }
        public double N_shang { get => n_shang; set => n_shang = value; }
        public double N_mubiao { get => n_mubiao; set => n_mubiao = value; }
        public double O_xia { get => o_xia; set => o_xia = value; }
        public double O_shang { get => o_shang; set => o_shang = value; }
        public double O_mubiao { get => o_mubiao; set => o_mubiao = value; }


        public ChuGangJiHao_Data(DataRow row)
        {
            ChuGangJiHao = row[0].ToString();
            Beizhu = row[1].ToString();
            FanWei = row[5].ToString();
            // GuoCheng = row[6].ToString();

            var Value1 = row[9].ToString().Replace(" ", "");
            if (Value1 != "")
                C_xia = Convert.ToDouble(Value1);

            var Value2 = row[10].ToString().Replace(" ", "");
            if (Value2 != "")
                C_shang = Convert.ToDouble(Value2);

            var Value3 = row[11].ToString().Replace(" ", "");
            if (Value3 != "")
                C_mubiao = Convert.ToDouble(Value3);

            var Value4 = row[12].ToString().Replace(" ", "");
            if (Value4 != "")
                Si_xia = Convert.ToDouble(Value4);

            var Value5 = row[13].ToString().Replace(" ", "");
            if (Value5 != "")
                Si_shang = Convert.ToDouble(Value5);

            var Value6 = row[14].ToString().Replace(" ", "");
            if (Value6 != "")
                Si_mubiao = Convert.ToDouble(Value6);

            var Value7 = row[15].ToString().Replace(" ", "");
            if (Value7 != "")
                Mn_xia = Convert.ToDouble(Value7);

            var Value8 = row[16].ToString().Replace(" ", "");
            if (Value8 != "")
                Mn_shang = Convert.ToDouble(Value8);

            var Value9 = row[17].ToString().Replace(" ", "");
            if (Value9 != "")
                Mn_mubiao = Convert.ToDouble(Value9);

            var Value10 = row[18].ToString().Replace(" ", "");
            if (Value10 != "")
                P_xia = Convert.ToDouble(Value10);

            var Value11 = row[19].ToString().Replace(" ", "");
            if (Value11 != "")
                P_shang = Convert.ToDouble(Value11);

            var Value12 = row[20].ToString().Replace(" ", "");
            if (Value12 != "")
                P_mubiao = Convert.ToDouble(Value12);

            var Value13 = row[21].ToString().Replace(" ", "");
            if (Value13 != "")
                S_xia = Convert.ToDouble(Value13);

            var Value14 = row[22].ToString().Replace(" ", "");
            if (Value14 != "")
                S_shang = Convert.ToDouble(Value14);

            var Value15 = row[23].ToString().Replace(" ", "");
            if (Value15 != "")
                S_mubiao = Convert.ToDouble(Value15);

            var Value16 = row[24].ToString().Replace(" ", "");
            if (Value16 != "")
                Al_xia = Convert.ToDouble(Value16);

            var Value17 = row[25].ToString().Replace(" ", "");
            if (Value17 != "")
                Al_shang = Convert.ToDouble(Value17);

            var Value18 = row[26].ToString().Replace(" ", "");
            if (Value18 != "")
                Al_mubiao = Convert.ToDouble(Value18);

            var Value19 = row[27].ToString().Replace(" ", "");
            if (Value19 != "")
                Sal_xia = Convert.ToDouble(Value19);

            var Value20 = row[28].ToString().Replace(" ", "");
            if (Value20 != "")
                Sal_shang = Convert.ToDouble(Value20);

            var Value21 = row[29].ToString().Replace(" ", "");
            if (Value21 != "")
                Sal_mubiao = Convert.ToDouble(Value21);

            var Value22 = row[33].ToString().Replace(" ", "");
            if (Value22 != "")
                Cu_xia = Convert.ToDouble(Value22);

            var Value23 = row[34].ToString().Replace(" ", "");
            if (Value23 != "")
                Cu_shang = Convert.ToDouble(Value23);

            var Value24 = row[35].ToString().Replace(" ", "");
            if (Value24 != "")
                Cu_mubiao = Convert.ToDouble(Value24);

            var Value25 = row[36].ToString().Replace(" ", "");
            if (Value25 != "")
                Ni_xia = Convert.ToDouble(Value25);

            var Value26 = row[37].ToString().Replace(" ", "");
            if (Value26 != "")
                Ni_shang = Convert.ToDouble(Value26);

            var Value27 = row[38].ToString().Replace(" ", "");
            if (Value27 != "")
                Ni_mubiao = Convert.ToDouble(Value25);

            var Value28 = row[39].ToString().Replace(" ", "");
            if (Value28 != "")
                Cr_xia = Convert.ToDouble(Value28);

            var Value29 = row[40].ToString().Replace(" ", "");
            if (Value29 != "")
                Cr_shang = Convert.ToDouble(Value29);

            var Value30 = row[41].ToString().Replace(" ", "");
            if (Value30 != "")
                Cr_mubiao = Convert.ToDouble(Value30);

            var Value31 = row[42].ToString().Replace(" ", "");
            if (Value31 != "")
                Nb_xia = Convert.ToDouble(Value31);

            var Value32 = row[43].ToString().Replace(" ", "");
            if (Value32 != "")
                Nb_shang = Convert.ToDouble(Value32);

            var Value33 = row[44].ToString().Replace(" ", "");
            if (Value33 != "")
                Nb_mubiao = Convert.ToDouble(Value33);

            var Value34 = row[45].ToString().Replace(" ", "");
            if (Value34 != "")
                Ti_xia = Convert.ToDouble(Value34);

            var Value35 = row[46].ToString().Replace(" ", "");
            if (Value35 != "")
                Ti_shang = Convert.ToDouble(Value35);

            var Value36 = row[47].ToString().Replace(" ", "");
            if (Value36 != "")
                Ti_mubiao = Convert.ToDouble(Value36);

            var Value37 = row[48].ToString().Replace(" ", "");
            if (Value37 != "")
                V_xia = Convert.ToDouble(Value37);

            var Value38 = row[49].ToString().Replace(" ", "");
            if (Value38 != "")
                V_shang = Convert.ToDouble(Value38);

            var Value39 = row[50].ToString().Replace(" ", "");
            if (Value39 != "")
                V_mubiao = Convert.ToDouble(Value39);

            var Value40 = row[51].ToString().Replace(" ", "");
            if (Value40 != "")
                Mo_xia = Convert.ToDouble(Value40);

            var Value41 = row[52].ToString().Replace(" ", "");
            if (Value41 != "")
                Mo_shang = Convert.ToDouble(Value41);

            var Value42 = row[53].ToString().Replace(" ", "");
            if (Value42 != "")
                Mo_mubiao = Convert.ToDouble(Value42);

            var Value43 = row[54].ToString().Replace(" ", "");
            if (Value43 != "")
                B_xia = Convert.ToDouble(Value43);

            var Value44 = row[55].ToString().Replace(" ", "");
            if (Value44 != "")
                B_shang = Convert.ToDouble(Value44);

            var Value45 = row[56].ToString().Replace(" ", "");
            if (Value45 != "")
                B_mubiao = Convert.ToDouble(Value45);

            var Value46 = row[69].ToString().Replace(" ", "");
            if (Value46 != "")
                Zr_xia = Convert.ToDouble(Value46);

            var Value47 = row[70].ToString().Replace(" ", "");
            if (Value47 != "")
                Zr_shang = Convert.ToDouble(Value47);

            var Value48 = row[71].ToString().Replace(" ", "");
            if (Value48 != "")
                Zr_mubiao = Convert.ToDouble(Value48);

            var Value49 = row[72].ToString().Replace(" ", "");
            if (Value49 != "")
                Pb_xia = Convert.ToDouble(Value49);

            var Value50 = row[73].ToString().Replace(" ", "");
            if (Value50 != "")
                Pb_shang = Convert.ToDouble(Value50);

            var Value51 = row[74].ToString().Replace(" ", "");
            if (Value51 != "")
                Pb_mubiao = Convert.ToDouble(Value51);

            var Value52 = row[63].ToString().Replace(" ", "");
            if (Value52 != "")
                Sn_xia = Convert.ToDouble(Value52);

            var Value53 = row[64].ToString().Replace(" ", "");
            if (Value53 != "")
                Sn_shang = Convert.ToDouble(Value53);

            var Value54 = row[65].ToString().Replace(" ", "");
            if (Value54 != "")
                Sn_mubiao = Convert.ToDouble(Value54);

            var Value55 = row[60].ToString().Replace(" ", "");
            if (Value55 != "")
                As_xia = Convert.ToDouble(Value55);

            var Value56 = row[61].ToString().Replace(" ", "");
            if (Value56 != "")
                As_shang = Convert.ToDouble(Value56);

            var Value57 = row[62].ToString().Replace(" ", "");
            if (Value57 != "")
                As_mubiao = Convert.ToDouble(Value57);

            var Value58 = row[57].ToString().Replace(" ", "");
            if (Value58 != "")
                Ca_xia = Convert.ToDouble(Value58);

            var Value59 = row[58].ToString().Replace(" ", "");
            if (Value59 != "")
                Ca_shang = Convert.ToDouble(Value59);

            var Value60 = row[59].ToString().Replace(" ", "");
            if (Value60 != "")
                Ca_mubiao = Convert.ToDouble(Value60);

            var Value61 = row[75].ToString().Replace(" ", "");
            if (Value61 != "")
                Sb_xia = Convert.ToDouble(Value61);

            var Value62 = row[76].ToString().Replace(" ", "");
            if (Value62 != "")
                Sb_shang = Convert.ToDouble(Value62);

            var Value63 = row[77].ToString().Replace(" ", "");
            if (Value63 != "")
                Sb_mubiao = Convert.ToDouble(Value63);

            var Value64 = row[78].ToString().Replace(" ", "");
            if (Value64 != "")
                Zn_xia = Convert.ToDouble(Value64);

            var Value65 = row[79].ToString().Replace(" ", "");
            if (Value65 != "")
                Zn_shang = Convert.ToDouble(Value65);

            var Value66 = row[80].ToString().Replace(" ", "");
            if (Value66 != "")
                Zn_mubiao = Convert.ToDouble(Value66);

            var Value67 = row[30].ToString().Replace(" ", "");
            if (Value67 != "")
                N_xia = Convert.ToDouble(Value67);

            var Value68 = row[31].ToString().Replace(" ", "");
            if (Value68 != "")
                N_shang = Convert.ToDouble(Value68);

            var Value69 = row[32].ToString().Replace(" ", "");
            if (Value69 != "")
                N_mubiao = Convert.ToDouble(Value69);

            var Value70 = row[66].ToString().Replace(" ", "");
            if (Value70 != "")
                O_xia = Convert.ToDouble(Value70);

            var Value71 = row[67].ToString().Replace(" ", "");
            if (Value71 != "")
                O_shang = Convert.ToDouble(Value71);

            var Value72 = row[68].ToString().Replace(" ", "");
            if (Value72 != "")
                O_mubiao = Convert.ToDouble(Value72);


        }
    }
}
