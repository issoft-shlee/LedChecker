﻿using System;
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
                PostMessage(AppRes.WM_TEST_NORMAL_TERMINATED);
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
