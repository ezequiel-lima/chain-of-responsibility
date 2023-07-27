namespace ChainOfResponsibility
{
    public class Requisicao
    {
        public EFormato Formato { get; private set; }

        public Requisicao(EFormato formato)
        {
            Formato = formato;
        }
    }
}
