using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebirdSql.Data.FirebirdClient;

namespace IsSoft.Sec.LedChecker
{
    public class CounterArgs : EventArgs
    {
        public CounterArgs(TestCounter counter)
        {
            Counter = counter;
        }

        public TestCounter Counter { get; set; }
    }

    public class TestContext
    {
        public RecipeObject Recipe { get; private set; }

        public TestValue Value { get; private set; }

        public TestCounter Counter { get; private set; }

        private TestHeadDataSet testHeadSet;

        private TestDataDataSet testDataSet;

        private TestCounterDataSet testCounterSet;

        private BinCounterDataSet binCounterSet;

        public TestContext()
        {
            Recipe = new RecipeObject();
            Value = new TestValue();
            Counter = new TestCounter();

            testHeadSet = new TestHeadDataSet(AppRes.DB.Connect, null, null);
            testDataSet = new TestDataDataSet(AppRes.DB.Connect, null, null);
            testCounterSet = new TestCounterDataSet(AppRes.DB.Connect, null, null);
            binCounterSet = new BinCounterDataSet(AppRes.DB.Connect, null, null);
        }

        public void Load(Int64 recipeNo)
        {
            Value.Clear();

            // Is recipe changed?
            if (Recipe.Load(recipeNo) == true)
            {
                Counter.Clear();
                testCounterSet.Select(recipeNo, Value.StartTime.ToString("yyyy-MM-dd"));

                if (testCounterSet.Empty == true)
                {
                    for (int i=0; i<Recipe.Bin.Count; i++)
                    {
                        BinCounter binCounter = new BinCounter();
                        binCounter.RecNo = 0;
                        binCounter.BinNo = Recipe.Bin[i + 1].RecNo;
                        binCounter.Count = 0;

                        Counter.Bins.Add(Recipe.Bin[i + 1].Name, binCounter);
                    }
                }
                else
                {
                    testCounterSet.Fetch();
                    Counter.RecNo = testCounterSet.RecNo;
                    Counter.Total = testCounterSet.TotalCount;
                    Counter.Ok = testCounterSet.OkCount;
                    Counter.Ng = testCounterSet.NgCount;

                    binCounterSet.Select(Counter.RecNo);

                    for (int i = 0; i < binCounterSet.RowCount; i++)
                    {
                        binCounterSet.Fetch(i);
                        BinCounter binCounter = new BinCounter();
                        binCounter.RecNo = binCounterSet.RecNo;
                        binCounter.BinNo = binCounterSet.BinNo;
                        binCounter.Count = binCounterSet.Count;

                        Counter.Bins.Add(Recipe.Bin[i + 1].Name, binCounter);
                    }
                }
            }
        }

        public void Save()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                InsertCounter(trans);
                InsertTestData(trans);
                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertCounter(FbTransaction trans)
        {
            testCounterSet.RecipeNo = Recipe.RecNo;
            testCounterSet.TestDate = Value.StartTime.ToString("yyyy-MM-dd");
            testCounterSet.TotalCount = Counter.Total;
            testCounterSet.OkCount = Counter.Ok;
            testCounterSet.NgCount = Counter.Ng;

            if (Counter.RecNo == 0)
            {
                Counter.RecNo = AppRes.DB.GetGenNo("GN_TESTCOUNTER");
                testCounterSet.RecNo = Counter.RecNo;
                testCounterSet.Insert(trans);

                foreach (var bin in Counter.Bins)
                {
                    bin.Value.RecNo = AppRes.DB.GetGenNo("GN_BINCOUNTER");
                    binCounterSet.RecNo = bin.Value.RecNo;
                    binCounterSet.TestCounterNo = Counter.RecNo;
                    binCounterSet.BinNo = bin.Value.BinNo;
                    binCounterSet.Count = bin.Value.Count;
                    binCounterSet.Insert(trans);
                }
            }
            else
            {
                testCounterSet.RecNo = Counter.RecNo;
                testCounterSet.Update(trans);

                foreach (var bin in Counter.Bins)
                {
                    binCounterSet.RecNo = bin.Value.RecNo;
                    binCounterSet.TestCounterNo = Counter.RecNo;
                    binCounterSet.BinNo = bin.Value.BinNo;
                    binCounterSet.Count = bin.Value.Count;
                    binCounterSet.Update(trans);
                }
            }
        }

        private void InsertTestData(FbTransaction trans)
        {
            testHeadSet.RecNo = AppRes.DB.GetGenNo("GN_TESTHEAD");
            testHeadSet.RecipeNo = Recipe.RecNo;
            testHeadSet.BinNo = Value.BinNo;
            testHeadSet.Type = Value.Type;
            testHeadSet.StartTime = Value.StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            testHeadSet.ElapsedTime = Value.ElapsedTime.ToString("HH:mm:ss.fff");
            testHeadSet.Insert(trans);

            foreach (ReportProcedureValue reportValue in Value.ReportProcedures)
            {
                testDataSet.RecNo = AppRes.DB.GetGenNo("GN_TESTDATA");
                testDataSet.TestHeadNo = testHeadSet.RecNo;
                testDataSet.TestWorkNo = reportValue.WorkNo;
                testDataSet.RankRowNo = reportValue.RankRowNo;
                testDataSet.Decision = reportValue.Decision;
                testDataSet.X_Value = reportValue.X;
                testDataSet.Y_Value = reportValue.Y;
                testDataSet.Raw = reportValue.Raw;
                testDataSet.Insert(trans);
            }
        }
    }

    public class TestValue
    {
        public Int64 BinNo { get; set; }

        public EWorkType Type { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan ElapsedTime { get; set; }

        public List<TestProcedureValue> TestProcedures { get; set; }

        public List<ReportProcedureValue> ReportProcedures { get; set; }

        public TestValue()
        {
            TestProcedures = new List<TestProcedureValue>();
            ReportProcedures = new List<ReportProcedureValue>();
            Clear();
        }

        public void Clear()
        {
            BinNo = 0;
            Type = EWorkType.Full;
            StartTime = DateTime.Now;
            ElapsedTime = TimeSpan.Zero;
            TestProcedures.Clear();
            ReportProcedures.Clear();
        }
    }

    public class TestProcedureValue : MeasuredValueObject
    {
        public Dictionary<string, double[]> Raws { get; set; }

        public TestProcedureValue() : base()
        {
            Raws = new Dictionary<string, double[]>();
        }

        public override void Clear()
        {
            base.Clear();
            Raws.Clear();
        }
    }

    public class ReportProcedureValue : MeasuredValueObject
    {
        public Int64 RankRowNo { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double[] Raw { get; set; }

        public ReportProcedureValue() : base()
        {
            Raw = null;
        }

        public override void Clear()
        {
            base.Clear();
            RankRowNo = 0;
            X = double.NaN;
            Y = double.NaN;
            Raw = null;
        }
    }

    public class MeasuredValueObject
    {
        public Int64 WorkNo { get; set; }

        public ETestDecision Decision { get; set; }

        public MeasuredValueObject()
        {
            Clear();
        }

        public virtual void Clear()
        {
            WorkNo = 0;
            Decision = ETestDecision.Nt;
        }
    }

    public class TestCounter
    {
        public Int64 RecNo { get; set; }

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

        public Dictionary<string, BinCounter> Bins { get; set; }

        public TestCounter()
        {
            Bins = new Dictionary<string, BinCounter>();
            Clear();
        }

        public void Clear()
        {
            RecNo = 0;
            Total = 0;
            Ok = 0;
            Ng = 0;
            Bins.Clear();
        }
    }

    public class BinCounter
    {
        public Int64 RecNo { get; set; }

        public Int64 BinNo { get; set; }

        public int Count { get; set; }

        public BinCounter()
        {
            RecNo = 0;
            BinNo = 0;
            Count = 0;
        }
    }
}
