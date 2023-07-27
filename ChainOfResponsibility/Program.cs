using ChainOfResponsibility;

Conta conta = new Conta("Ezequiel Lima", 1250.50);
Requisicao requisicao = new Requisicao(EFormato.XML);
Requisicao requisicao2 = new Requisicao(EFormato.CSV);
Requisicao requisicao3 = new Requisicao(EFormato.PORCENTO);
Requisicao requisicao4 = new Requisicao(EFormato.SEMRESPOSTA);

ISolicitacao solicitacao = new Solicitacao();
string resultado = solicitacao.Response(requisicao4, conta);

Console.WriteLine(resultado);

Console.ReadLine();