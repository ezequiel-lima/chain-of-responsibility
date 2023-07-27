namespace ChainOfResponsibility
{
    public class CSV : ISolicitacao
    {
        public ISolicitacao Proximo { get; set; }

        public CSV()
        {
            Proximo = new PORCENTO();
        }

        public string Response(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == EFormato.CSV)
            {
                return $"{conta.Titular} {conta.Saldo} {requisicao.Formato}";
            }

            return Proximo.Response(requisicao, conta);
        }
    }
}
