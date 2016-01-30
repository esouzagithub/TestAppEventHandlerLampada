using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppEventHandlerLampada
{
    public class InterruptorEventArgs : EventArgs
    {
        public Lampada Lampada { get; }

        public InterruptorEventArgs(Lampada lampada)
        {
            Lampada = lampada;
        }
    }
    public class Interruptor : IInterruptor
    {
        public event EventHandler<InterruptorEventArgs> LigandoEventHandler;
        public event EventHandler<InterruptorEventArgs> DesligandoEventHandler;
        public void Ligar(Lampada lampada)
        {
            lampada.Status = Status.Ligado;
            OnLigandoEventHandler(new InterruptorEventArgs(lampada));
        }

        public void Desligar(Lampada lampada)
        {
            lampada.Status = Status.Desligado;
            OnDesligandoEventHandler(new InterruptorEventArgs(lampada));
        }

        protected virtual void OnLigandoEventHandler(InterruptorEventArgs e)
        {
            LigandoEventHandler?.Invoke(this, e);
        }

        protected virtual void OnDesligandoEventHandler(InterruptorEventArgs e)
        {
            DesligandoEventHandler?.Invoke(this, e);
        }
    }
}
