using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace IsSoft.Sec.LedChecker
{
    public class RecipeList
    {
        private Dictionary<Int64, RecipeItem> keys;

        private Dictionary<string, RecipeItem> names;

        private RecipeDataSet recipeSet;

        public RecipeItem this[int index]
        { get { return keys[index]; } }

        public RecipeItem this[string name]
        { get { return names[name]; } }

        public RecipeList()
        {
            keys = new Dictionary<Int64, RecipeItem>();
            names = new Dictionary<string, RecipeItem>();
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            Load();
        }

        private void Load()
        {
            recipeSet.Select();

            for (int i = 0; i < recipeSet.RowCount; i++)
            {
                recipeSet.Fetch(i);

                RecipeItem item = new RecipeItem();
                item.Load(recipeSet.Name);
                keys.Add(item.RecNo, item);
                names.Add(item.Code, item);
            }
        }
    }

    public class RecipeItem
    {
        public Int64 RecNo { get; set; }

        public string Code { get; set; }

        public string Memo { get; set; }

        public double ST1_X { get; set; }

        public double ST1_Y { get; set; }

        public string ST1_QR { get; set; }

        public double ST2_X { get; set; }

        public double ST2_Y { get; set; }

        public string ST2_QR { get; set; }

        public PatternList Pattern { get; private set; }

        public RankList Rank { get; private set; }

        public Dictionary<EWorkType, WorkItem> Work { get; private set; }

        public BinList Bin { get; private set; }

        private RecipeDataSet recipeSet;

        public RecipeItem()
        {
            RecNo = 0;
            Code = "";
            Memo = "";

            Pattern = null;
            Rank = null;
            Work = null;
            Bin = null;

            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
        }

        public void Load(Int64 recipeNo)
        {
            if ((RecNo == recipeNo)) return;

            recipeSet.Select(recipeNo);
            if (recipeSet.Empty == true)
            {
                RecNo = 0;
                Code = "None";
                Memo = "";
                ST1_X = 0;
                ST1_Y = 0;
                ST1_QR = "";
                ST2_X = 0;
                ST2_Y = 0;
                ST2_QR = "";

                Work = null;
                Pattern = null;
                Rank = null;
                Bin = null;
            }
            else
            {
                recipeSet.Fetch();
                RecNo = recipeSet.RecNo;
                Code = recipeSet.Name;
                Memo = recipeSet.Memo;
                ST1_X = recipeSet.ST1_X;
                ST1_Y = recipeSet.ST1_Y;
                ST1_QR = recipeSet.ST1_QR;
                ST2_X = recipeSet.ST2_X;
                ST2_Y = recipeSet.ST2_Y;
                ST2_QR = recipeSet.ST2_QR;

                Work = new Dictionary<EWorkType, WorkItem>();
                Pattern = new PatternList(RecNo);
                Rank = new RankList(RecNo);
                Bin = new BinList(RecNo);

                Work.Add(EWorkType.Full, new WorkItem(RecNo, EWorkType.Full));
                Work.Add(EWorkType.Sampling, new WorkItem(RecNo, EWorkType.Sampling));
            }
        }

        public void Load(string code)
        {
            if ((RecNo > 0) && (code == Code)) return;

            recipeSet.SelectName(code);
            if (recipeSet.Empty == true)
            {
                RecNo = 0;
                Code = "None";
                Memo = "";
                ST1_X = 0;
                ST1_Y = 0;
                ST1_QR = "";
                ST2_X = 0;
                ST2_Y = 0;
                ST2_QR = "";

                Work = null;
                Pattern = null;
                Rank = null;
                Bin = null;
            }
            else
            {
                recipeSet.Fetch();
                RecNo = recipeSet.RecNo;
                Code = recipeSet.Name;
                Memo = recipeSet.Memo;
                ST1_X = recipeSet.ST1_X;
                ST1_Y = recipeSet.ST1_Y;
                ST1_QR = recipeSet.ST1_QR;
                ST2_X = recipeSet.ST2_X;
                ST2_Y = recipeSet.ST2_Y;
                ST2_QR = recipeSet.ST2_QR;

                Work = new Dictionary<EWorkType, WorkItem>();
                Pattern = new PatternList(RecNo);
                Rank = new RankList(RecNo);
                Bin = new BinList(RecNo);

                Work.Add(EWorkType.Full, new WorkItem(RecNo, EWorkType.Full));
                Work.Add(EWorkType.Sampling, new WorkItem(RecNo, EWorkType.Sampling));
            }
        }
    }

    public class PatternList
    {
        public Int64 MasterNo { get; private set; }

        private Dictionary<Int64, PatternItem> keys;

        private Dictionary<string, PatternItem> names;

        private MasterPatternDataSet masterSet;

        private SlavePatternDataSet slaveSet;

        public PatternItem this[Int64 recNo]
        { get { return keys[recNo]; } }

        public PatternItem this[string name]
        { get { return names[name]; } }

        public PatternList(Int64 recipeNo)
        {
            masterSet = new MasterPatternDataSet(AppRes.DB.Connect, null, null);
            slaveSet = new SlavePatternDataSet(AppRes.DB.Connect, null, null);

            Load(recipeNo);
        }

        private void Load(Int64 recipeNo)
        {
            masterSet.Select(recipeNo);
            masterSet.Fetch(0);

            MasterNo = masterSet.RecipeNo;

            keys = new Dictionary<Int64, PatternItem>();
            names = new Dictionary<string, PatternItem>();

            slaveSet.Select(MasterNo);
            for (int i = 0; i < slaveSet.RowCount; i++)
            {
                slaveSet.Fetch(i);

                PatternItem item = new PatternItem(slaveSet.RecNo);
                item.RecNo = slaveSet.RecNo;
                item.Name = slaveSet.Name;
                item.Memo = slaveSet.Memo;

                keys.Add(item.RecNo, item);
                names.Add(item.Name, item);
            }
        }
    }

    public class PatternItem
    {
        public Int64 RecNo { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }

        private SlavePatternLedDataSet slaveLedSet;

        private Dictionary<string, PatternLedItem> xyLeds;

        private Dictionary<string, PatternLedItem> strLeds;

        private PatternLedItem GetXY(int x, int y) { return xyLeds[$"{x}-{y}"]; }

        private PatternLedItem GetStr(int strNo, int ledNo) { return strLeds[$"{strNo}-{ledNo}"]; }

        public PatternLedItem this[int x, int y, ELedCoordinateType type=ELedCoordinateType.XY]
        { get { return (type == ELedCoordinateType.XY) ? GetXY(x, y) : GetStr(x, y); } }

        public PatternItem(Int64 slaveNo)
        {
            xyLeds = new Dictionary<string, PatternLedItem>();
            strLeds = new Dictionary<string, PatternLedItem>();
            slaveLedSet = new SlavePatternLedDataSet(AppRes.DB.Connect, null, null);

            Load(slaveNo);
        }

        private void Load(Int64 slaveNo)
        {
            slaveLedSet.Select(slaveNo);

            for (int i=0; i<slaveLedSet.RowCount; i++)
            {
                slaveLedSet.Fetch(i);

                PatternLedItem item = new PatternLedItem();
                item.RecNo = slaveLedSet.RecNo;
                item.PatternNo = slaveLedSet.SlavePatternNo;
                item.X = slaveLedSet.X;
                item.Y = slaveLedSet.Y;
                item.StrNo = slaveLedSet.StrNo;
                item.LedNo = slaveLedSet.LedNo;
                item.TurnOn = slaveLedSet.TurnOn;
                item.Measuring = slaveLedSet.Measuring;
                item.Type = slaveLedSet.Type;

                xyLeds.Add(item.XY, item);
                strLeds.Add(item.StrLed, item);
            }
        }
    }

    public class PatternLedItem
    {
        public Int64 RecNo { get; set; }

        public Int64 PatternNo { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public string XY { get { return $"{X}-{Y}"; } }

        public int StrNo { get; set; }

        public int LedNo { get; set; }

        public string StrLed
        {
            get
            {
                string ret = $"{StrNo}-{LedNo}";

                if (ret == "0-0")
                {
                    ret = $"X{X}-Y{Y}";
                }

                return ret;
            }
        }

        public bool TurnOn { get; set; }

        public bool Measuring { get; set; }

        public ELedType Type { get; set; }

        public PatternLedItem()
        {
        }
    }

    public class RankList
    {
        private RankDataSet rankSet;

        private Dictionary<Int64, RankItem> keys;

        private Dictionary<string, RankItem> names;

        public RankItem this[Int64 recNo]
        { get { return keys[recNo]; } }

        public RankItem this[string name]
        { get { return names[name]; } }

        public RankList(Int64 recipeNo)
        {
            keys = new Dictionary<Int64, RankItem>();
            names = new Dictionary<string, RankItem>();
            rankSet = new RankDataSet(AppRes.DB.Connect, null, null);

            Load(recipeNo);
        }

        private void Load(Int64 recipeNo)
        {
            rankSet.Select(recipeNo);

            for (int i=0; i<rankSet.RowCount; i++)
            {
                rankSet.Fetch(i);
                RankItem item = new RankItem(rankSet);

                keys.Add(item.RecNo, item);
                names.Add(item.Name, item);
            }
        }
    }

    public class RankItem
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }

        private RankRowList rows;

        public RankRowItem this[int index]
        { get { return rows[index]; } }

        public RankRowItem this[string name]
        { get { return rows[name]; } }

        public RankItem(RankDataSet set)
        {
            RecNo = set.RecNo;
            RecipeNo = set.RecipeNo;
            ItemCode = set.ItemCode;
            Name = set.Name;
            Memo = set.Memo;
            rows = new RankRowList(RecNo);
        }
    }

    public class RankRowList
    {
        private RankRowDataSet rankRowSet;

        private Dictionary<int, RankRowItem> indexes;

        private Dictionary<string, RankRowItem> names;

        public RankRowItem this[int index]
        { get { return indexes[index]; } }

        public RankRowItem this[string name]
        { get { return names[name]; } }

        public RankRowList(Int64 rankNo)
        {
            indexes = new Dictionary<int, RankRowItem>();
            names = new Dictionary<string, RankRowItem>();
            rankRowSet = new RankRowDataSet(AppRes.DB.Connect, null, null);

            Load(rankNo);
        }

        private void Load(Int64 rankNo)
        {
            rankRowSet.Select(rankNo);

            for (int i=0; i<rankRowSet.RowCount; i++)
            {
                rankRowSet.Fetch(i);

                RankRowItem item = new RankRowItem();
                item.RecNo = rankRowSet.RecNo;
                item.RankNo = rankRowSet.RankNo;
                item.Index = rankRowSet.Index;
                item.Name = rankRowSet.Name;
                item.Lower1 = rankRowSet.Lower1;
                item.Upper1 = rankRowSet.Upper1;
                item.Lower2 = rankRowSet.Lower2;
                item.Upper2 = rankRowSet.Upper2;

                indexes.Add(item.Index, item);
                names.Add(item.Name, item);
            }
        }
    }

    public class RankRowItem
    {
        public Int64 RecNo { get; set; }

        public Int64 RankNo { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public double Lower1 { get; set; }

        public double Upper1 { get; set; }

        public double Lower2 { get; set; }

        public double Upper2 { get; set; }

        public RankRowItem()
        {
        }
    }

    public class WorkItem
    {
        public TestWorkList Tests { get; set; }

        public ReportWorkList Reports { get; set; }

        public WorkItem(Int64 recipeNo, EWorkType type)
        {
            Tests = new TestWorkList(recipeNo, type);
            Reports = new ReportWorkList(recipeNo, type);
        }
    }

    public class TestWorkList
    {
        private TestWorkDataSet testSet;

        private Dictionary<int, TestWorkItem> indexes;

        private Dictionary<string, TestWorkItem> names;

        public int Count { get; private set; }

        public TestWorkItem this[int index]
        { get { return indexes[index]; } }

        public TestWorkItem this[string name]
        { get { return names[name]; } }

        public TestWorkList(Int64 recipeNo, EWorkType type)
        {
            testSet = new TestWorkDataSet(AppRes.DB.Connect, null, null);
            indexes = new Dictionary<int, TestWorkItem>();
            names = new Dictionary<string, TestWorkItem>();

            Load(recipeNo, type);
        }

        private void Load(Int64 recipeNo, EWorkType type)
        {
            testSet.Select(recipeNo, type);

            Count = testSet.RowCount;
            for (int i=0; i<Count; i++)
            {
                testSet.Fetch(i);

                TestWorkItem item = new TestWorkItem();
                item.RecNo = testSet.RecNo;
                item.RecipeNo = testSet.RecipeNo;
                item.SlavePatternNo = testSet.SlavePatternNo;
                item.Type = testSet.Type;
                item.Index = testSet.Index;
                item.ItemCode = testSet.ItemCode;
                item.ItemName = testSet.ItemName;
                item.ItemRef = testSet.ItemRef;
                item.TestPattern = testSet.TestPattern;
                item.BiasValue = testSet.BiasValue;
                item.BiasRange = testSet.BiasRange;
                item.BiasCH = testSet.BiasCH;
                item.ApplyTime = testSet.ApplyTime;
                item.TransientTime = testSet.TransientTime;
                item.HumCount = testSet.HumCount;
                item.Optical = testSet.Optical;
                item.IntegVL = testSet.IntegVL;
                item.IntegX1 = testSet.IntegX1;
                item.IntegX2 = testSet.IntegX2;
                item.IntegZ = testSet.IntegZ;
                item.Gain = testSet.Gain;
                item.Offset = testSet.Offset;

                indexes.Add(item.Index, item);
                names.Add(item.ItemName, item);
            }
        }
    }

    public class TestWorkItem
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public Int64 SlavePatternNo { get; set; }

        public EWorkType Type { get; set; }

        public int Index { get; set; }

        public ETestItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string TestPattern { get; set; }

        public string BiasValue { get; set; }

        public string BiasRange { get; set; }

        public string BiasCH { get; set; }

        public double ApplyTime { get; set; }

        public double TransientTime { get; set; }

        public int HumCount { get; set; }

        public EOpticalType Optical { get; set; }

        public double IntegVL { get; set; }

        public double IntegX1 { get; set; }

        public double IntegX2 { get; set; }

        public double IntegZ { get; set; }

        public double Gain { get; set; }

        public double Offset { get; set; }

        public TestWorkItem()
        {
        }
    }


    public class ReportWorkList
    {
        private ReportWorkDataSet reportSet;

        private Dictionary<int, ReportWorkItem> indexes;

        private Dictionary<string, ReportWorkItem> names;

        public ReportWorkItem this[int index]
        { get { return indexes[index]; } }

        public ReportWorkItem this[string name]
        { get { return names[name]; } }

        public int Count { get; set; }

        public ReportWorkList(Int64 recipeNo, EWorkType type)
        {
            reportSet = new ReportWorkDataSet(AppRes.DB.Connect, null, null);
            indexes = new Dictionary<int, ReportWorkItem>();
            names = new Dictionary<string, ReportWorkItem>();

            Load(recipeNo, type);
        }

        private void Load(Int64 recipeNo, EWorkType type)
        {
            reportSet.Select(recipeNo, type);
            Count = reportSet.RowCount;

            for (int i = 0; i < reportSet.RowCount; i++)
            {
                reportSet.Fetch(i);

                ReportWorkItem item = new ReportWorkItem();
                item.RecNo = reportSet.RecNo;
                item.RecipeNo = reportSet.RecipeNo;
                item.Type = reportSet.Type;
                item.Index = reportSet.Index;
                item.ItemCode = reportSet.ItemCode;
                item.ItemName = reportSet.ItemName;
                item.ItemRef = reportSet.ItemRef;
                item.BiasCH = reportSet.BiasCH;
                item.Rank = reportSet.Rank;
                item.Lower = reportSet.Lower;
                item.Upper = reportSet.Upper;

                indexes.Add(item.Index, item);
                names.Add(item.ItemName, item);
            }
        }
    }

    public class ReportWorkItem
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EWorkType Type { get; set; }

        public int Index { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string BiasCH { get; set; }

        public string Rank { get; set; }

        public double Lower { get; set; }

        public double Upper { get; set; }

        public ReportWorkItem()
        {
        }
    }

    public class BinList
    {
        private BinDataSet binSet;

        private Dictionary<int, BinItem> indexes;

        private Dictionary<string, BinItem> names;

        public int Count { get; private set; }

        public BinItem this[int index]
        { get { return indexes[index]; } }

        public BinItem this[string name]
        { get { return names[name]; } }

        public BinList(Int64 recipeNo)
        {
            binSet = new BinDataSet(AppRes.DB.Connect, null, null);
            indexes = new Dictionary<int, BinItem>();
            names = new Dictionary<string, BinItem>();

            Load(recipeNo);
        }

        private void Load(Int64 recipeNo)
        {
            binSet.Select(recipeNo);
            Count = binSet.RowCount;

            for (int i = 0; i < binSet.RowCount; i++)
            {
                binSet.Fetch(i);

                BinItem item = new BinItem(binSet);
                indexes.Add(item.Index, item);

                if (string.IsNullOrWhiteSpace(item.Name) == true)
                    names.Add($"Bin-{i+1}", item);
                else
                    names.Add(item.Name, item);
            }
        }
    }

    public class BinItem
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EBinType Type { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public Color Mark { get; set; }

        public Dictionary<EWorkType, List<BinFormulaItem>> Formulas { get; set; }

        private BinFormulaDataSet formulaSet;

        public BinItem(BinDataSet set)
        {
            RecNo = set.RecNo;
            RecipeNo = set.RecipeNo;
            Type = set.Type;
            Index = set.Index;
            Name = set.Name;
            Mark = set.Mark;
            Formulas = new Dictionary<EWorkType, List<BinFormulaItem>>();

            formulaSet = new BinFormulaDataSet(AppRes.DB.Connect, null, null);
            Load(RecNo);
        }

        private void Load(Int64 recNo)
        {
            List<BinFormulaItem> formulaList = new List<BinFormulaItem>();

            formulaSet.Select(recNo, EWorkType.Full);
            for (int i = 0; i < formulaSet.RowCount; i++)
            {
                formulaSet.Fetch(i);

                BinFormulaItem item = new BinFormulaItem(formulaSet.Formula);
                item.RecNo = formulaSet.RecNo;
                item.BinNo = formulaSet.BinNo;
                item.Logic = formulaSet.Logic;
                formulaList.Add(item);
            }
            Formulas.Add(EWorkType.Full, formulaList);

            formulaSet.Select(recNo, EWorkType.Sampling);
            for (int i = 0; i < formulaSet.RowCount; i++)
            {
                formulaSet.Fetch(i);

                BinFormulaItem item = new BinFormulaItem(formulaSet.Formula);
                item.RecNo = formulaSet.RecNo;
                item.BinNo = formulaSet.BinNo;
                item.Logic = formulaSet.Logic;
                formulaList.Add(item);
            }
            Formulas.Add(EWorkType.Sampling, formulaList);
        }
    }

    public class BinFormulaItem
    {
        public Int64 RecNo { get; set; }

        public Int64 BinNo { get; set; }

        public EBinLogic Logic { get; set; }

        public BinTokenItem Token { get; set; }

        public BinFormulaItem(string formula)
        {
            Token = new BinTokenItem(formula);
        }
    }

    public class BinTokenItem
    {
        public string ItemName { get; set; }

        public EBinCondition Condition { get; set; }

        public List<string> Ranks { get; set; }

        public BinTokenItem(string formula)
        {
            Ranks = new List<string>();

            Condition = (formula.Contains(" = ") == true) ? EBinCondition.Equal : EBinCondition.NotEqual;
            string delimiter = (Condition == EBinCondition.Equal) ? " = " : " <> ";
            string[] items = formula.Split(new string[] { delimiter }, StringSplitOptions.RemoveEmptyEntries);

            if (items.Length == 2)
            {
                ItemName = items[0];
                items = items[1].Split(',');

                for (int i=0; i<items.Length; i++)
                {
                    Ranks.Add(items[i]);
                }
            }
        }
    }
}
