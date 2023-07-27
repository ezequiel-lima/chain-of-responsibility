namespace ChainOfResponsibility
{
    public interface ISolicitacao
    {
        public string Response(Requisicao requisicao, Conta conta);
        public ISolicitacao Proximo { get; set; }
    }
}
