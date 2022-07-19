using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeDuong
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        iniFile iniFile = new iniFile(Application.StartupPath + "\\AppConfig\\config.ini");

        string filePath1 = "";
        string filePath2 = "";
        DataTable TableConvert;

        List<SourceData> lsFileDatas;
        List<ChuGangJiHao_Data> lsChuGangJiHaos;

        TenNguyenTo excel1 = new TenNguyenTo();
        TenNguyenTo excel2 = new TenNguyenTo();
        TenNguyenTo IndexExcel2 = new TenNguyenTo();

        // docc file du lieu
        void FileDataLoadExcel()
        {
            lsFileDatas = new List<SourceData>();
            DataTable dtFileData = new DataTable();

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txbFilePath1.Text = ofd.SafeFileName;
                    SplashScreenManager.ShowDefaultWaitForm();
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 1)
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }
                        else
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }

                        var i = 0;
                        var conf = new ExcelDataSetConfiguration
                        {
                            UseColumnDataType = true,
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                FilterRow = rowReader => 3 <= ++i - 1,
                                UseHeaderRow = false
                            }
                        };

                        DataSet ds = reader.AsDataSet(conf);
                        reader.Close();

                        dtFileData = ds.Tables[0];
                    }
                    SplashScreenManager.CloseDefaultSplashScreen();
                }
            }
            foreach (DataRow item in dtFileData.Rows)
            {
                SourceData data = new SourceData(item);
                lsFileDatas.Add(data);
            }

        }

        // doc file chugangjihao
        void ChuGangJiHaoLoadExcel()
        {
            lsChuGangJiHaos = new List<ChuGangJiHao_Data>();
            DataTable dtChuGangJiHao = new DataTable();

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txbFilePath2.Text = ofd.SafeFileName;
                    SplashScreenManager.ShowDefaultWaitForm();
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 1)
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }
                        else
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }

                        var i = 0;
                        var conf = new ExcelDataSetConfiguration
                        {
                            UseColumnDataType = true,
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                FilterRow = rowReader => 6 <= ++i - 1,
                                UseHeaderRow = false
                            }
                        };

                        DataSet ds = reader.AsDataSet(conf);
                        reader.Close();

                        dtChuGangJiHao = ds.Tables[0];
                    }
                    SplashScreenManager.CloseDefaultSplashScreen();
                }
            }

            foreach (DataRow item in dtChuGangJiHao.Rows)
            {
                ChuGangJiHao_Data data = new ChuGangJiHao_Data(item);
                lsChuGangJiHaos.Add(data);
            }
        }

        private void txbFilePath1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FileDataLoadExcel();

        }

        private void txbFilePath2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ChuGangJiHaoLoadExcel();
            //OpenFileDialog odf = new OpenFileDialog();
            //odf.Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls";
            //// odf.Filter = "All files (*.*)|*.*";
            //if (odf.ShowDialog() == DialogResult.OK)
            //{
            //    filePath2 = odf.FileName;
            //    txbFilePath2.Text = odf.SafeFileName;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            excel1.C = iniFile.Read("C1", "Excel1");
            excel1.Si = iniFile.Read("Si1", "Excel1");
            excel1.Mn = iniFile.Read("Mn1", "Excel1");
            excel1.P = iniFile.Read("P1", "Excel1");
            excel1.S = iniFile.Read("S1", "Excel1");
            excel1.TAl = iniFile.Read("TAl1", "Excel1");
            excel1.SAl = iniFile.Read("SAl1", "Excel1");
            excel1.N = iniFile.Read("N1", "Excel1");
            excel1.Cu = iniFile.Read("Cu1", "Excel1");
            excel1.Ni = iniFile.Read("Ni1", "Excel1");
            excel1.Cr = iniFile.Read("Cr1", "Excel1");
            excel1.Nb = iniFile.Read("Nb1", "Excel1");
            excel1.Ti = iniFile.Read("Ti1", "Excel1");
            excel1.V = iniFile.Read("V1", "Excel1");
            excel1.Mo = iniFile.Read("Mo1", "Excel1");
            excel1.B = iniFile.Read("B1", "Excel1");
            excel1.Ca = iniFile.Read("Ca1", "Excel1");
            excel1.As = iniFile.Read("As1", "Excel1");
            excel1.Sn = iniFile.Read("Sn1", "Excel1");
            excel1.O = iniFile.Read("O1", "Excel1");
            excel1.Zr = iniFile.Read("Zr1", "Excel1");
            excel1.Pb = iniFile.Read("Pb1", "Excel1");
            excel1.Sb = iniFile.Read("Sb1", "Excel1");
            excel1.Zn = iniFile.Read("Zn1", "Excel1");


            excel2.C = iniFile.Read("C1", "Excel2");
            excel2.Si = iniFile.Read("Si1", "Excel2");
            excel2.Mn = iniFile.Read("Mn1", "Excel2");
            excel2.P = iniFile.Read("P1", "Excel2");
            excel2.S = iniFile.Read("S1", "Excel2");
            excel2.TAl = iniFile.Read("TAl1", "Excel2");
            excel2.SAl = iniFile.Read("SAl1", "Excel2");
            excel2.N = iniFile.Read("N1", "Excel2");
            excel2.Cu = iniFile.Read("Cu1", "Excel2");
            excel2.Ni = iniFile.Read("Ni1", "Excel2");
            excel2.Cr = iniFile.Read("Cr1", "Excel2");
            excel2.Nb = iniFile.Read("Nb1", "Excel2");
            excel2.Ti = iniFile.Read("Ti1", "Excel2");
            excel2.V = iniFile.Read("V1", "Excel2");
            excel2.Mo = iniFile.Read("Mo1", "Excel2");
            excel2.B = iniFile.Read("B1", "Excel2");
            excel2.Ca = iniFile.Read("Ca1", "Excel2");
            excel2.As = iniFile.Read("As1", "Excel2");
            excel2.Sn = iniFile.Read("Sn1", "Excel2");
            excel2.O = iniFile.Read("O1", "Excel2");
            excel2.Zr = iniFile.Read("Zr1", "Excel2");
            excel2.Pb = iniFile.Read("Pb1", "Excel2");
            excel2.Sb = iniFile.Read("Sb1", "Excel2");
            excel2.Zn = iniFile.Read("Zn1", "Excel2");

            //IndexExcel2.C = iniFile.Read("C1", "IndexExcel2");
            //IndexExcel2.Si = iniFile.Read("Si1", "IndexExcel2");
            //IndexExcel2.Mn = iniFile.Read("Mn1", "IndexExcel2");
            //IndexExcel2.P = iniFile.Read("P1", "IndexExcel2");
            //IndexExcel2.S = iniFile.Read("S1", "IndexExcel2");
            //IndexExcel2.TAl = iniFile.Read("TAl1", "IndexExcel2");
            //IndexExcel2.SAl = iniFile.Read("SAl1", "IndexExcel2");
            //IndexExcel2.N = iniFile.Read("N1", "IndexExcel2");
            //IndexExcel2.Cu = iniFile.Read("Cu1", "IndexExcel2");
            //IndexExcel2.Ni = iniFile.Read("Ni1", "IndexExcel2");
            //IndexExcel2.Cr = iniFile.Read("Cr1", "IndexExcel2");
            //IndexExcel2.Nb = iniFile.Read("Nb1", "IndexExcel2");
            //IndexExcel2.Ti = iniFile.Read("Ti1", "IndexExcel2");
            //IndexExcel2.V = iniFile.Read("V1", "IndexExcel2");
            //IndexExcel2.Mo = iniFile.Read("Mo1", "IndexExcel2");
            //IndexExcel2.B = iniFile.Read("B1", "IndexExcel2");
            //IndexExcel2.Ca = iniFile.Read("Ca1", "IndexExcel2");
            //IndexExcel2.As = iniFile.Read("As1", "IndexExcel2");
            //IndexExcel2.Sn = iniFile.Read("Sn1", "IndexExcel2");
            //IndexExcel2.O = iniFile.Read("O1", "IndexExcel2");
            //IndexExcel2.Zr = iniFile.Read("Zr1", "IndexExcel2");
            //IndexExcel2.Pb = iniFile.Read("Pb1", "IndexExcel2");
            //IndexExcel2.Sb = iniFile.Read("Sb1", "IndexExcel2");
            //IndexExcel2.Zn = iniFile.Read("Zn1", "IndexExcel2");


        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            List<Excel2_OK> lsExcel2_OK = new List<Excel2_OK>();
            
            int Index = 0;
            Index = Convert.ToInt16( iniFile.Read(txbThanhPhan.Text, "IndexExcel2"));
            string nguyenTo = txbThanhPhan.Text;
            double up = Convert.ToDouble(txbGioiHanTren.EditValue);
            double down = Convert.ToDouble(txbGioiHanDuoi.EditValue);
            var queryRR = (from data in lsChuGangJiHaos
                           where data.FanWei == "RR"
                           && (nguyenTo == excel2.C ? data.C_xia >= down && data.C_shang <= up : true)
                           && (nguyenTo == excel2.Si ? data.Si_xia >= down && data.Si_shang <= up : true)
                           && (nguyenTo == excel2.Mn ? data.Mn_xia >= down && data.Mn_shang <= up : true)
                           && (nguyenTo == excel2.P ? data.P_xia >= down && data.P_shang <= up : true)
                           && (nguyenTo == excel2.S ? data.S_xia >= down && data.S_shang <= up : true)
                           && (nguyenTo == excel2.TAl ? data.Al_xia >= down && data.Al_shang <= up : true)
                           && (nguyenTo == excel2.SAl ? data.Sal_xia >= down && data.Sal_shang <= up : true)
                           && (nguyenTo == excel2.N ? data.N_xia >= down && data.N_shang <= up : true)
                           && (nguyenTo == excel2.Cu ? data.Cu_xia >= down && data.Cu_shang <= up : true)
                           && (nguyenTo == excel2.Ni ? data.Ni_xia >= down && data.Ni_shang <= up : true)
                           && (nguyenTo == excel2.Cr ? data.Cr_xia >= down && data.Cr_shang <= up : true)
                           && (nguyenTo == excel2.Nb ? data.Nb_xia >= down && data.Nb_shang <= up : true)
                           && (nguyenTo == excel2.Ti ? data.Ti_xia >= down && data.Ti_shang <= up : true)
                           && (nguyenTo == excel2.V ? data.V_xia >= down && data.V_shang <= up : true)
                           && (nguyenTo == excel2.Mo ? data.Mo_xia >= down && data.Mo_shang <= up : true)
                           && (nguyenTo == excel2.B ? data.B_xia >= down && data.B_shang <= up : true)
                           && (nguyenTo == excel2.Ca ? data.Ca_xia >= down && data.Ca_shang <= up : true)
                           && (nguyenTo == excel2.As ? data.As_xia >= down && data.As_shang <= up : true)
                           && (nguyenTo == excel2.Sn ? data.Sn_xia >= down && data.Sn_shang <= up : true)
                           && (nguyenTo == excel2.O ? data.O_xia >= down && data.O_shang <= up : true)
                           && (nguyenTo == excel2.Zr ? data.Zr_xia >= down && data.Zr_shang <= up : true)
                           && (nguyenTo == excel2.Pb ? data.Pb_xia >= down && data.Pb_shang <= up : true)
                           && (nguyenTo == excel2.Sb ? data.Sb_xia >= down && data.Sb_shang <= up : true)
                           && (nguyenTo == excel2.Zn ? data.Zn_xia >= down && data.Zn_shang <= up : true)

                           select data).ToList();
            //           {
            //ChugangJihao = data.ChuGangJiHao,
            //               xia = data.C_xia,
            //               ten = data.Beizhu,
            //               shang = data.C_shang,
            //               phamvi = data.FanWei
            //           }).ToList();
            DataTable dtRR = ToDataTable(queryRR);

            var queryGioiHan = (from data in lsChuGangJiHaos
                                where (nguyenTo == excel2.C ? data.C_xia >= down && data.C_shang <= up : true)
                                && (nguyenTo == excel2.Si ? data.Si_xia >= down && data.Si_shang <= up : true)
                                && (nguyenTo == excel2.Mn ? data.Mn_xia >= down && data.Mn_shang <= up : true)
                                && (nguyenTo == excel2.P ? data.P_xia >= down && data.P_shang <= up : true)
                                && (nguyenTo == excel2.S ? data.S_xia >= down && data.S_shang <= up : true)
                                && (nguyenTo == excel2.TAl ? data.Al_xia >= down && data.Al_shang <= up : true)
                                && (nguyenTo == excel2.SAl ? data.Sal_xia >= down && data.Sal_shang <= up : true)
                                && (nguyenTo == excel2.N ? data.N_xia >= down && data.N_shang <= up : true)
                                && (nguyenTo == excel2.Cu ? data.Cu_xia >= down && data.Cu_shang <= up : true)
                                && (nguyenTo == excel2.Ni ? data.Ni_xia >= down && data.Ni_shang <= up : true)
                                && (nguyenTo == excel2.Cr ? data.Cr_xia >= down && data.Cr_shang <= up : true)
                                && (nguyenTo == excel2.Nb ? data.Nb_xia >= down && data.Nb_shang <= up : true)
                                && (nguyenTo == excel2.Ti ? data.Ti_xia >= down && data.Ti_shang <= up : true)
                                && (nguyenTo == excel2.V ? data.V_xia >= down && data.V_shang <= up : true)
                                && (nguyenTo == excel2.Mo ? data.Mo_xia >= down && data.Mo_shang <= up : true)
                                && (nguyenTo == excel2.B ? data.B_xia >= down && data.B_shang <= up : true)
                                && (nguyenTo == excel2.Ca ? data.Ca_xia >= down && data.Ca_shang <= up : true)
                                && (nguyenTo == excel2.As ? data.As_xia >= down && data.As_shang <= up : true)
                                && (nguyenTo == excel2.Sn ? data.Sn_xia >= down && data.Sn_shang <= up : true)
                                && (nguyenTo == excel2.O ? data.O_xia >= down && data.O_shang <= up : true)
                                && (nguyenTo == excel2.Zr ? data.Zr_xia >= down && data.Zr_shang <= up : true)
                                && (nguyenTo == excel2.Pb ? data.Pb_xia >= down && data.Pb_shang <= up : true)
                                && (nguyenTo == excel2.Sb ? data.Sb_xia >= down && data.Sb_shang <= up : true)
                                && (nguyenTo == excel2.Zn ? data.Zn_xia >= down && data.Zn_shang <= up : true)

                                select data).ToList();
            //{
            //    ChugangJihao = data.ChuGangJiHao,
            //                        ten = data.Beizhu,
            //                        xia = data.C_xia,
            //                        shang = data.C_shang,
            //                        phamvi = data.FanWei
            //                    }).ToList();
            DataTable dtGioiHan = ToDataTable(queryGioiHan);
            string so = "0123456789";
            string ChuGangJiHao = "";
            Double MuBiao = 0;
            for (int i = 0; i < dtRR.Rows.Count; i++)
            {
                for (int j = 0; j < dtGioiHan.Rows.Count; j++)
                {
                    if (dtGioiHan.Rows[j][0] == dtRR.Rows[i][0])
                    {
                        if (dtGioiHan.Rows[j-1][2].ToString() == "MR")
                        {
                            ChuGangJiHao = dtGioiHan.Rows[j - 1][0].ToString();
                            MuBiao = Convert.ToDouble(dtGioiHan.Rows[j - 1][(Index + 1) * 3]);
                        }

                        Excel2_OK excel2_OK = new Excel2_OK();
                        excel2_OK.ChuGangJiHao = ChuGangJiHao;
                        excel2_OK.MuBiao = MuBiao;
                        lsExcel2_OK.Add(excel2_OK);

                    }
                }
            }
            //var query2 = (from dataGioiHan in queryGioiHan
            //              from dataRR in queryRR.Select(r => (r.ChugangJihao.ToString().Substring(0, 4) + r.ChugangJihao.ToString().Substring(5, 3))).Distinct().ToList()
            //              where (so.Contains(dataGioiHan.ChugangJihao.ToString().Substring(4, 1))) ?
            //              (dataGioiHan.ChugangJihao.StartsWith(dataRR.ToString().Substring(0, 4))
            //              && dataGioiHan.ChugangJihao.EndsWith(dataRR.ToString().Substring(4, 3))
            //              && (dataGioiHan.ChugangJihao.ToString().Substring(4, 1) == "0" || dataGioiHan.ChugangJihao.ToString().Substring(4, 1) == "1" || dataGioiHan.ChugangJihao.ToString().Substring(4, 1) == "2" || dataGioiHan.ChugangJihao.ToString().Substring(4, 1) == "3")) : //truong hop khac
            //              (dataGioiHan.ChugangJihao.StartsWith(dataRR.ToString().Substring(0, 5))
            //              && dataGioiHan.ChugangJihao.EndsWith(dataRR.ToString().Substring(5, 2))
            //              && (Convert.ToInt16(dataGioiHan.ChugangJihao.Substring(5, 1)) == Convert.ToInt16(dataRR.Substring(5, 1)) - 1))


            //              select new
            //              {
            //                  chugangjihao = dataGioiHan.ChugangJihao,
            //                  ten1 = dataGioiHan.ten,
            //                  phamvi1 = dataGioiHan.phamvi
            //              }).ToList();

           DataTable aabb2 = ToDataTable(lsExcel2_OK);


        }

        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

      public  class Excel2_OK
        {
            public string ChuGangJiHao { get; set; }
            public Double MuBiao { get; set; }
        }
    }
}
