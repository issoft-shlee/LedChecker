using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.XtraGrid.Views.Grid;

namespace IsSoft.Sec.LedChecker
{
    public static class AppHelper
    {
        public static byte[] ToByte(double[] fData)
        {
            if (fData == null) return null;
            if (fData.Length == 0) return null;

            byte[] raw = new byte[fData.Length * sizeof(double)];
            Buffer.BlockCopy(fData, 0, raw, 0, raw.Length);

            return raw;
        }

        public static double[] ToDouble(byte[] byData)
        {
            if (byData == null) return null;
            if (byData.Length == 0) return null;

            double[] raw = new double[byData.Length / sizeof(double)];
            Buffer.BlockCopy(byData, 0, raw, 0, byData.Length);

            return raw;
        }

        public static void RefreshGridData(GridView view)
        {
            view.BeginUpdate();

            try
            {
                view.RefreshData();
            }
            finally
            {
                view.EndUpdate();
            }
        }

        public static string CombineSelectedRowValues(GridView view, string fieldName)
        {
            string ret = "";

            if (view.FocusedRowHandle < 0) return ret;

            for (int i = 0; i < view.SelectedRowsCount; i++)
            {
                DataRow row = view.GetDataRow(view.GetSelectedRows()[i]);
                string name = Convert.ToString(row[fieldName]);

                if (i == 0) ret = name;
                else ret += $",{name}";
            }

            return ret;
        }

        public static Int64 ExtractRecNo(string nameRecNo)
        {
            string[] nameRecNos = nameRecNo.Trim().Split('(');
            if (nameRecNos.Length < 2) return 0;

            string sRecNo = nameRecNos[nameRecNos.Length - 1];
            int recNo;

            try
            {
                recNo = int.Parse(sRecNo.Remove(sRecNo.Length - 1));
            }
            catch
            {
                recNo = 0;
            }

            return recNo;
        }
    }
}
