using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

using Ulee.Utils;
using Ulee.DllImport.Win32;

namespace IsSoft.Sec.LedChecker
{
    public static class AppRes
    {
        private const string csIniFName = @"..\..\Config\IsSoft.Sec.LedChecker.ini";

        public const string csDateFormat = "yyyy-MM-dd";

        public const string csDateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public const string Caption = "LED Checker";

        public const int WM_TEST_NORMAL_TERMINATED = (Win32.WM_USER + 0);

        public const int WM_TEST_ABNORMAL_TERMINATED = (Win32.WM_USER + 1);

        public static bool Busy { get; set; }

        public static EAppState State { get; set; }

        public static UlIniFile Ini { get; private set; }

        public static UlLogger TLog { get; private set; }

        public static AppDatabase DB { get; private set; }

        public static AppProperies Properties { get; private set; }

        //public static RecipeList Recipes { get; private set; }

        public static void Create()
        {
            Ini = new UlIniFile(csIniFName);

            TLog = new UlLogger();
            TLog.Path = Ini.GetString("Log", "TotalPath");
            TLog.FName = Ini.GetString("Log", "TotalFileName");
            TLog.AddHead("NOTE");
            TLog.AddHead("ERROR");
            TLog.AddHead("EXCEPTION");
        }

        public static void Initialize()
        {
            Busy = false;
            State = EAppState.Opening;

            Properties = new AppProperies();
            Properties.Load();

            string dbPath = Ini.GetString("Database", "FileName");
            if (Path.IsPathRooted(dbPath) == false)
            {
                dbPath = Path.GetFullPath(dbPath);
            }

            DB = new AppDatabase();
            DB.Database = dbPath;
            DB.Open();

            //Recipes = new RecipeList();
        }

        public static void Destroy()
        {
            DB.Close();
        }
    }

    public class AppProperies
    {
        public int SmuCount { get; set; }

        public List<KnownColor> SmuColors;

        public int BinCount { get; set; }

        public int FormulaCount { get; set; }

        public string FormWork { get; set; }

        public string FormResult { get; set; }

        public string FormBin { get; set; }

        public string FormWholeBin { get; set; }

        public AppProperies()
        {
            SmuColors = new List<KnownColor>();
        }

        public void Load()
        {
            SmuCount = AppRes.Ini.GetInteger("SMU", "Count");

            SmuColors.Clear();
            for (int i = 0; i < SmuCount; i++)
            {
                string name = AppRes.Ini.GetString("SMU", $"Color{i + 1}");
                SmuColors.Add((KnownColor)Enum.Parse(typeof(KnownColor), name));
            }

            BinCount = AppRes.Ini.GetInteger("Bin", "BinCount");
            FormulaCount = AppRes.Ini.GetInteger("Bin", "FormulaCount");

            FormBin = AppRes.Ini.GetString("Excel", "BinForm");
            FormWholeBin = AppRes.Ini.GetString("Excel", "BinWholeForm");
            FormWork = AppRes.Ini.GetString("Excel", "WorkForm");
            FormResult = AppRes.Ini.GetString("Excel", "ResultForm");
        }
    }
}
