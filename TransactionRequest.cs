namespace WebHookExampleB
{
    public class TransactionRequest
    {
        public string CuentaOrigen { get; set; }

        public string CuentaDestino { get; set; }
        public DateTime Date { get; set; }

        public string CallBackURL { get; set; }

    }
}
