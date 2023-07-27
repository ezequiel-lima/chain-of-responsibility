namespace ChainOfResponsibility
{
    public class SemResposta : ISolicitacao
    {
        public ISolicitacao Proximo { get; set; }

        public string Response(Requisicao requisicao, Conta conta)
        {
            return "";
        }
    }
}
