namespace ChainOfResponsibility
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
