using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAppEventHandlerLampada
{
    public class Lampada
    {
        public Status Status { get; set; }

        public void OnLigando(object source, InterruptorEventArgs args)
        {
            Thread.Sleep(1000);
            Status = args.Lampada.Status;
        }

        public void OnDesligando(object source, InterruptorEventArgs args)
        {
            Thread.Sleep(1000);
            Status = args.Lampada.Status;
        }
    }
}
