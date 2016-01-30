namespace TestAppEventHandlerLampada
{
    public interface IInterruptor
    {
        void Ligar(Lampada lampada);
        void Desligar(Lampada lampada);
    }
}