using System;

namespace TestAppEventHandlerLampada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lampada = new Lampada();
            var interruptor = new Interruptor();
            
            interruptor.LigandoEventHandler += Interruptor_LigandoEventHandler;
            interruptor.DesligandoEventHandler += Interruptor_DesligandoEventHandler;
            
            interruptor.Ligar(lampada);
            Console.WriteLine("Lampada "+ lampada.Status);

            interruptor.Desligar(lampada);
            Console.WriteLine("Lampada " + lampada.Status);

            Console.ReadKey();
        }

        private static void Interruptor_LigandoEventHandler(object sender, InterruptorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void Interruptor_DesligandoEventHandler(object sender, InterruptorEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
