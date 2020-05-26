using System;
using System.Diagnostics;

namespace Coutaq
{
    public class EasyTimer
    {
        TimeSpan ts;
        Stopwatch stopwatch;
        public EasyTimer()
        {
            stopwatch = new Stopwatch();
        }
        public void Start()
        {
            stopwatch.Restart();
        }
        public void End(String infoText)
        {
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine(infoText + " " + ts.Seconds + ":" + ts.Milliseconds);
        }
        public void End()
        {
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine(ts.Seconds + ":" + ts.Milliseconds);
        }
        public String Time()
        {
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            return ts.Seconds + ":" + ts.Milliseconds;
        }
        public String Time(String infoText)
        {
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            return infoText + " " + ts.Seconds + ":" + ts.Milliseconds;
        }
    }
}
