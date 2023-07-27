namespace ChainOfResponsibility
{
    public class XML : ISolicitacao
    {
        public ISolicitacao Proximo { get; set; }

        public XML()
        {
            Proximo = new CSV();
        }

        public string Response(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == EFormato.XML)
            {
                return $"{conta.Titular} {conta.Saldo} {requisicao.Formato}";
            }

            return Proximo.Response(requisicao, conta);
        }
    }
}
