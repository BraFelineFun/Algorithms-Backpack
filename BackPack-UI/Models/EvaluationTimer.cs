using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    public class EvaluationTimer
    {
        Stopwatch stopWatch;
        public TimeSpan Time { get; set; }


        public EvaluationTimer()
        {
            stopWatch = new Stopwatch();
        }

        public void StartCount()
        {
            stopWatch.Start();
        }
        public void AddTime(TimeSpan t)
        {
            Time += t;
        }
        public EvaluationTimer StopCount()
        {
            stopWatch.Stop();
            Time = stopWatch.Elapsed;

            return this;
        }
        public override string ToString()
        {
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            Time.Hours, Time.Minutes, Time.Seconds,
            Time.Milliseconds);
            return elapsedTime;
        }
    }
}
