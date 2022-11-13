using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    internal class EvaluationTimer
    {
        Stopwatch stopWatch;

        public EvaluationTimer()
        {
            stopWatch = new Stopwatch();
        }

        public void StartCount()
        {
            stopWatch.Start();
        }
        public string StopCount()
        {
            TimeSpan ts;

            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);

            return "Время выполнения = " + elapsedTime;
        }
    }
}
