using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ulee.Threading;

namespace IsSoft.Sec.LedChecker
{
    public class InvalidThread : UlThread
    {
        private long prevTicks;
        private long invalidTicks;

        public event EventHandler InvalidControls = null;
        protected void OnInvalidControls()
        {
            if (InvalidControls != null)
            {
                InvalidControls(null, null);
            }
        }

        public InvalidThread(long ticks = 250) : base(false)
        {
            this.invalidTicks = ticks;
            prevTicks = 0;
        }

        protected override void Execute()
        {
            prevTicks = ElapsedMilliseconds;
            OnInvalidControls();

            while (Terminated == false)
            {
                if (IsTimeoutMilliseconds(prevTicks, invalidTicks) == true)
                {
                    prevTicks += invalidTicks;
                    OnInvalidControls();
                }

                Yield();
            }
        }
    }
}
