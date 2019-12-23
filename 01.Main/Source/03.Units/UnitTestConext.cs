using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSoft.Sec.LedChecker
{
    public class TestContext
    {
        public Int64 RecipeNo { get; set; }

        public TestContext()
        {
        }
    }

    public class TestHead
    {
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
        public Int64 TestHeadNo { get; set; }

        public Int64 TestWorkNo { get; set; }

        public Int64 RankRowNo { get; set; }

        public ETestDecision Decision { get; set; }

        public double XValue { get; set; }

        public double YValue { get; set; }

        public TestData()
        {
            TestHeadNo = 0;
            TestWorkNo = 0;
            RankRowNo = 0;
            Decision = ETestDecision.Nt;
            XValue = double.NaN;
            YValue = double.NaN;
        }
    }

    public class TestRawData
    {
        public Int64 TestDataNo { get; set; }



        public TestRawData()
        {

        }
    }

    public class TestCounter
    {
        public Int64 RecNo { get; set; }

        public int TotalCount { get; set; }

        public int OkCount { get; set; }

        public int NgCount { get; set; }

        public double Ratio
        {
            get
            {
                double ret = 0;

                if (TotalCount > 0)
                {
                    ret = ((double)OkCount / (double)TotalCount) * 100.0;
                }

                return ret;
            }
        }

        private TestCounterDataSet testCounterSet;

        public TestCounter()
        {
            testCounterSet = new TestCounterDataSet(AppRes.DB.Connect, null, null);
        }
    }
}
