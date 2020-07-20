using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;

namespace MEFTest
{
    [Export(typeof(IDriver))]
    [ExportMetadata("name", "Driver1")]
    public class Driver1 : IDriver
    {
        List<Alarm> alarms = new List<Alarm>();

        public Driver1()
        {
            GenerateNewAlarms();

            Task t1 = Task.Factory.StartNew(() => SomeTask());
        }

        protected void SomeTask()
        {
            while (true)
            {
                Alarm alm = alarms[0];
                int i = int.Parse(alm.Description);
                alm.Description = (i + 1).ToString();
                Thread.Sleep(1000);
            }
        }

        List<Alarm> IDriver.GetActiveAlarms()
        {
            return alarms;
        }

        protected void GenerateNewAlarms()
        {
            DateTime d = DateTime.Now;
            Random r = new Random(d.Millisecond);
            int count = r.Next(1, 5);

            for (int i = 0; i < count; i++)
            {
                string tagName = "Tag" + d.Second + "_" + d.Millisecond;
                Alarm alm = new Alarm()
                {
                    Source = "Driver1",
                    Tag = tagName,
                    Name = "Name for " + tagName,
                    Description = d.Second.ToString()
                };
                alarms.Add(alm);
            }
        }

        bool IDriver.Load()
        {
            return true;
        }

        bool IDriver.Unload()
        {
            return true;
        }
    }
}
