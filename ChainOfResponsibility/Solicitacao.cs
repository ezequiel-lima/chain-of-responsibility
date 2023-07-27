namespace ChainOfResponsibility
{
    public class Solicitacao : ISolicitacao
    {
        public Solicitacao()
        {
            Proximo = new XML();
        }

        public ISolicitacao Proximo { get; set; }

        public string Response(Requisicao requisicao, Conta conta)
        {
            //ISolicitacao solicitacao = new XML();
            //ISolicitacao solicitacao2 = new CSV();
            //ISolicitacao solicitacao3 = new PORCENTO();

            //solicitacao.Proximo = solicitacao2;
            //solicitacao2.Proximo = solicitacao3;

            return Proximo.Response(requisicao, conta);
        }
    }
}
