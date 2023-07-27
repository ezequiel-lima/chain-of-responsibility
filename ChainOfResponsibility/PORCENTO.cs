namespace ChainOfResponsibility
{
    public class PORCENTO : ISolicitacao
    {
        public ISolicitacao Proximo { get; set; }

        public PORCENTO()
        {
            Proximo = null;
        }

        public string Response(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == EFormato.PORCENTO)
            {
                return $"{conta.Titular} {conta.Saldo} {requisicao.Formato}";
            }

            return "Não foi possivel encontrar uma resposta";
        }
    }
}
