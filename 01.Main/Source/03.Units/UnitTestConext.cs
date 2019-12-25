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

    public class MeasuredValue
    {
        public int Index { get; set; }

        public double[] Raw { get; set; }

        public double Maximum { get; private set; }

        public double Minimum { get; private set; }

        public double Average { get; private set; }

        public MeasuredValue()
        {
            Index = 0;
            Raw = null;
            Maximum = double.MinValue;
            Minimum = double.MaxValue;
            Average = double.NaN;
        }

        public void Calcurate(int start, int length)
        {
            if ((length < 1) || ((start+length) > Raw.Length))
            {
                throw new Exception("Arguments range over in MeasuredValue.Calcurate");
            }

            double total = 0;
            Maximum = double.MinValue;
            Minimum = double.MaxValue;

            for (int i=start; i<length; i++)
            {
                if (Raw[i] > Maximum) Maximum = Raw[i];
                if (Raw[i] < Minimum) Minimum = Raw[i];
                total += Raw[i];
            }

            Average = total / Raw.Length;
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

        public ETestDecision Decision { get; set; }

        public double XValue { get; set; }

        public double YValue { get; set; }

        public List<TestRawData> Raws { get; set; }

        public TestData()
        {
            RecNo = 0;
            TestHeadNo = 0;
            TestWorkNo = 0;
            RankRowNo = 0;
            Decision = ETestDecision.Nt;
            XValue = double.NaN;
            YValue = double.NaN;
            Raws = new List<TestRawData>();
        }
    }

    public class TestRawData
    {
        public Int64 RecNo { get; set; }

        public Int64 TestDataNo { get; set; }

        public int Index { get; set; }

        public double[] Raw { get; set; }

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

        private TestCounterDataSet testCounterSet;

        public TestCounter()
        {
            testCounterSet = new TestCounterDataSet(AppRes.DB.Connect, null, null);
        }
    }
}
