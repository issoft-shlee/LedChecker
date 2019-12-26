using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSoft.Sec.LedChecker
{
    public class TestContext
    {
        public DateTime StartTime { get; set; }

        public TimeSpan ElapsedTime { get; set; }

        public RecipeObject Recipe { get; set; }

        public TestCounter Counter { get; set; }

        public Dictionary<EWorkType, MeasuredValue> Values { get; set; }

        public TestContext()
        {
            Counter = new TestCounter();
            Values = new Dictionary<EWorkType, MeasuredValue>();
        }

        public void Initialize()
        {
            InitializeCounter();
            InitializeValues();
        }

        public void Clear()
        {
            foreach (var work in Values)
            {
                foreach (var test in work.Value.Tests)
                {
                    test.Clear();
                }

                foreach (var report in work.Value.Reports)
                {
                    report.Clear();
                }
            }
        }

        public void Clear(EWorkType type)
        {
            foreach (var test in Values[type].Tests)
            {
                test.Clear();
            }

            foreach (var report in Values[type].Reports)
            {
                report.Clear();
            }
        }

        private void InitializeCounter()
        {
            if (testCounterSet.Empty == true)
            {
                Counter.RecNo = 0;
                TestDate = testDate;
                Total = 0;
                Ok = 0;
                Ng = 0;

                Bins.Clear();
                for (int i = 0; i < recipe.Bin.Count; i++)
                {
                    BinCounter binCounter = new BinCounter();

                    binCounter.RecNo = 0;
                    binCounter.TestCounterNo = 0;
                    binCounter.BinNo = recipe.Bin[i + 1].RecNo;
                    binCounter.Count = 0;

                    Bins.Add(binCounter);
                }
            }
            else
            {
                testCounterSet.Fetch();

                RecNo = testCounterSet.RecNo;
                RecipeNo = testCounterSet.RecipeNo;
                TestDate = testCounterSet.TestDate;
                Total = testCounterSet.TotalCount;
                Ok = testCounterSet.OkCount;
                Ng = testCounterSet.NgCount;

                Bins.Clear();
                binCounterSet.Select(RecNo);

                for (int i = 0; i < binCounterSet.RowCount; i++)
                {
                    binCounterSet.Fetch(i);
                    BinCounter binCounter = new BinCounter();

                    binCounter.RecNo = binCounterSet.RecNo;
                    binCounter.TestCounterNo = binCounterSet.TestCounterNo;
                    binCounter.BinNo = binCounterSet.BinNo;
                    binCounter.Name = binCounterSet.;
                    binCounter.Count = 0;

                    Bins.Add(binCounter);
                }
            }

        private void InitializeValues()
        {
            TestProcedureValue testValue;
            ReportProcedureValue reportValue;

            MeasuredValue full = new MeasuredValue();
            MeasuredValue sampling = new MeasuredValue();

            for (int i = 0; i < Recipe.Work[EWorkType.Full].Tests.Count; i++)
            {
                testValue = new TestProcedureValue();
                testValue.Index = Recipe.Work[EWorkType.Full].Tests[i].Index;
                testValue.ItemCode = Recipe.Work[EWorkType.Full].Tests[i].ItemCode;

                full.Tests.Add(testValue);
            }

            for (int i = 0; i < Recipe.Work[EWorkType.Full].Reports.Count; i++)
            {
                reportValue = new ReportProcedureValue();
                reportValue.Index = Recipe.Work[EWorkType.Full].Reports[i].Index;
                reportValue.ItemCode = Recipe.Work[EWorkType.Full].Reports[i].ItemCode;

                full.Reports.Add(reportValue);
            }

            Values.Add(EWorkType.Full, full);

            for (int i = 0; i < Recipe.Work[EWorkType.Sampling].Tests.Count; i++)
            {
                testValue = new TestProcedureValue();
                testValue.Index = Recipe.Work[EWorkType.Sampling].Tests[i].Index;
                testValue.ItemCode = Recipe.Work[EWorkType.Sampling].Tests[i].ItemCode;

                sampling.Tests.Add(testValue);
            }

            for (int i = 0; i < Recipe.Work[EWorkType.Sampling].Reports.Count; i++)
            {
                reportValue = new ReportProcedureValue();
                reportValue.Index = Recipe.Work[EWorkType.Sampling].Reports[i].Index;
                reportValue.ItemCode = Recipe.Work[EWorkType.Sampling].Reports[i].ItemCode;

                sampling.Reports.Add(reportValue);
            }

            Values.Add(EWorkType.Sampling, sampling);
        }
    }

    public class MeasuredValue
    {
        public DateTime StartTime { get; set; }

        public TimeSpan ElapsedTime { get; set; }

        public Int64 BinNo { get; set; }

        public List<TestProcedureValue> Tests { get; set; }

        public List<ReportProcedureValue> Reports { get; set; }

        public MeasuredValue()
        {
            StartTime = DateTime.Now;
            ElapsedTime = TimeSpan.Zero;
            BinNo = 0;
            Tests = new List<TestProcedureValue>();
            Reports = new List<ReportProcedureValue>();
        }

        public void Clear()
        {
            Tests.Clear();
            Reports.Clear();
        }
    }

    public class TestProcedureValue
    {
        public int Index { get; set; }

        public ETestItemCode ItemCode { get; set; }

        public ETestDecision Decision { get; set; }

        public Dictionary<string, double[]> Raws;

        public TestProcedureValue()
        {
            Raws = new Dictionary<string, double[]>();
            Clear();
        }

        public void Clear()
        {
            Decision = ETestDecision.Nt;
            Raws.Clear();
        }
    }

    public class ReportProcedureValue
    {
        public int Index { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public Int64 RankRowNo { get; set; }

        public ETestDecision Decision { get; set; }

        public int StartPosition { get; set; }

        public int Length { get; set; }

        public double[] Value { get; set; }

        public double[] Raw { get; set; }

        public ReportProcedureValue()
        {
            Value = new double[2];
            Clear();
        }

        public void Clear()
        {
            Decision = ETestDecision.Nt;
            Value[0] = 0;
            Value[1] = 0;
            Raw = null;
        }

        public void Calcurate()
        {
            switch (ItemCode)
            {
                case EReportItemCode.VF:
                case EReportItemCode.IF:
                case EReportItemCode.VR:
                case EReportItemCode.IR:
                    CalcuratePower();
                    break;

                case EReportItemCode.Die_Lv:
                case EReportItemCode.Die_X:
                case EReportItemCode.Die_Y:
                    CalcurateDieXY();
                    break;

                case EReportItemCode.Die_XY:
                    CalcurateDieXY();
                    break;

                case EReportItemCode.Die_Lv_Uniformity:
                case EReportItemCode.Die_X_Uniformity:
                case EReportItemCode.Die_Y_Uniformity:
                    CalcurateDieUniformity();
                    break;

                case EReportItemCode.Die_Contrast:
                    CalcurateDieContrast();
                    break;

                case EReportItemCode.Die_Glare:
                    CalcurateDieGrare();
                    break;

                case EReportItemCode.Cell_Lv:
                case EReportItemCode.Cell_X:
                case EReportItemCode.Cell_Y:
                    CalcurateCell();
                    break;

                case EReportItemCode.Cell_XY:
                    CalcurateCellXY();
                    break;

                case EReportItemCode.Cell_Lv_Uniformity:
                case EReportItemCode.Cell_X_Uniformity:
                case EReportItemCode.Cell_Y_Uniformity:
                    CalcurateCellUniformity();
                    break;

                case EReportItemCode.Cell_Contrast:
                    CalcurateCellContrast();
                    break;

                case EReportItemCode.IC_ON:
                case EReportItemCode.IC_OFF:
                case EReportItemCode.IC_INIT:
                case EReportItemCode.Safety_Check:
                case EReportItemCode.EEPROM_Check:
                case EReportItemCode.Watchdog_Enable:
                case EReportItemCode.Watchdog_Disable:
                case EReportItemCode.NTC_Check:
                    CalcurateDriveIC();
                    break;
           }
        }

        private void CalcuratePower()
        {
            if (Raw == null)
            {
                throw new Exception("Raw is null exception in ReportProcedureValue.CalcuratePower");
            }

            double total = 0;

            for (int i = 0; i < Length; i++)
            {
                total += Raw[StartPosition];
            }

            Value[0] = total / Length;
            Value[1] = double.NaN;
        }

        private void CalcurateDie()
        {
        }

        private void CalcurateDieUniformity()
        {
        }

        private void CalcurateDieXY()
        {
        }

        private void CalcurateDieContrast()
        {
        }

        private void CalcurateDieGrare()
        {
        }

        private void CalcurateCell()
        {
        }

        private void CalcurateCellUniformity()
        {
        }

        private void CalcurateCellXY()
        {
        }

        private void CalcurateCellContrast()
        {
        }

        private void CalcurateDriveIC()
        {
            Value[0] = double.NaN;
            Value[1] = double.NaN;
        }
    }

    public class TestHead
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public Int64 BinNo { get; set; }

        public EWorkType Type { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ElpasedTime { get; set; }

        public List<TestData> Datas { get; set; }

        public TestHead()
        {
            Datas = new List<TestData>();
        }
    }

    public class TestData
    {
        public Int64 RecNo { get; set; }

        public Int64 TestHeadNo { get; set; }

        public Int64 TestWorkNo { get; set; }

        public Int64 RankRowNo { get; set; }

        public string RankName { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public ETestDecision Decision { get; set; }

        public double XValue { get; set; }

        public double YValue { get; set; }

        public double[] Raw { get; set; }

        public TestData()
        {
            RecNo = 0;
            TestHeadNo = 0;
            TestWorkNo = 0;
            RankRowNo = 0;
            RankName = "";
            ItemCode = EReportItemCode.VF;
            ItemName = "";
            Decision = ETestDecision.Nt;
            XValue = double.NaN;
            YValue = double.NaN;
            Raw = null;
        }
    }

    public class TestRawData<T>
    {
        public Int64 RecNo { get; set; }

        public Int64 TestDataNo { get; set; }

        public int Index { get; set; }

        public T[] Raw { get; set; }

        public TestRawData()
        {
            RecNo = 0;
            TestDataNo = 0;
            Index = 0;
            Raw = null;
        }
    }

    public class TestCounter
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public string TestDate { get; set; }

        public int Total { get; set; }

        public int Ok { get; set; }

        public int Ng { get; set; }

        public double OkRate
        {
            get
            {
                double ret = 0;

                if (Total > 0)
                {
                    ret = ((double)Ok / (double)Total) * 100.0;
                }

                return ret;
            }
        }

        public List<BinCounter> Bins { get; set; }

        private TestCounterDataSet testCounterSet;

        private BinCounterDataSet binCounterSet;

        public TestCounter()
        {
            Bins = new List<BinCounter>();

            testCounterSet = new TestCounterDataSet(AppRes.DB.Connect, null, null);
            binCounterSet = new BinCounterDataSet(AppRes.DB.Connect, null, null);
        }

        public void Load(Int64 recipeNo, string testDate)
        {
            testCounterSet.Select(recipeNo, testDate);

            if (testCounterSet.Empty == true)
            {
                RecNo = 0;
                RecipeNo = recipeNo;
                TestDate = testDate;
                Total = 0;
                Ok = 0;
                Ng = 0;

                Bins.Clear();
                for (int i = 0; i < recipe.Bin.Count; i++)
                {
                    BinCounter binCounter = new BinCounter();

                    binCounter.RecNo = 0;
                    binCounter.TestCounterNo = 0;
                    binCounter.BinNo = recipe.Bin[i + 1].RecNo;
                    binCounter.Count = 0;

                    Bins.Add(binCounter);
                }
            }
            else
            {
                testCounterSet.Fetch();

                RecNo = testCounterSet.RecNo;
                RecipeNo = testCounterSet.RecipeNo;
                TestDate = testCounterSet.TestDate;
                Total = testCounterSet.TotalCount;
                Ok = testCounterSet.OkCount;
                Ng = testCounterSet.NgCount;

                Bins.Clear();
                binCounterSet.Select(RecNo);

                for (int i = 0; i < binCounterSet.RowCount; i++)
                {
                    binCounterSet.Fetch(i);
                    BinCounter binCounter = new BinCounter();

                    binCounter.RecNo = binCounterSet.RecNo;
                    binCounter.TestCounterNo = binCounterSet.TestCounterNo;
                    binCounter.BinNo = binCounterSet.BinNo;
                    binCounter.Name = binCounterSet.;
                    binCounter.Count = 0;

                    Bins.Add(binCounter);
                }
            }
        }
    }

    public class BinCounter
    {
        public Int64 RecNo { get; set; }

        public Int64 TestCounterNo { get; set; }

        public Int64 BinNo { get; set; }

        public int Count { get; set; }

        public BinCounter()
        {
            RecNo = 0;
            TestCounterNo = 0;
            BinNo = 0;
            Count = 0;
        }
    }
}
