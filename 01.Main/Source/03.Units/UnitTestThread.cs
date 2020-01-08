using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ulee.Threading;
using Ulee.DllImport.Win32;

namespace IsSoft.Sec.LedChecker
{
    public class TestThread : UlThread
    {
        private TestContext context;

        public TestThread(TestContext context) : base(false, true)
        {
            this.context = context;
        }

        protected override void Execute()
        {
            try
            {
                context.Value.Type = EWorkType.Normal;
                AppRes.TestLog[(int)ELogType.Note] = $"Begin {context.Value.Type.ToString()} Test";

                for (int i = 0; i < context.Recipe.Work.Tests.Count; i++)
                {
                    AppRes.TestLog[(int)ELogType.Note] = $"Test No : {i+1}";
                    context.OnInvalidTestIndex(i);

                    for (int j = 0; j < 20; j++)
                    {
                        for (int k = 0; k < context.Counter.Bins.Count; k++)
                        {
                            context.Counter.Ok++;
                            context.Counter.Total++;
                            context.Counter.Bins[k].Count++;
                        }

                        context.OnInvalidCounter();
                        Yield(50);
                    }
                }

                context.OnInvalidTestIndex();
                PostMessage(AppRes.WM_TEST_NORMAL_TERMINATED);

                AppRes.TestLog[(int)ELogType.Note] = $"End Test";
            }
            catch (UlThreadTerminatedException e)
            {
                PostMessage(AppRes.WM_TEST_NORMAL_TERMINATED, e.Code);
            }
        }

        private void PostMessage(int msg, int wParam = 0, int lParam = 0)
        {
            Win32.PostMessage(context.WndHandle, msg, (IntPtr)wParam, (IntPtr)lParam);
        }
    }
}
