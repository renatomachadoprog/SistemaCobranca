public class Boleto : TituloFinanceiro, INotificavel{
    private const double emissao = 2.5;
    private const double jurosDiario = 0.001;
    private const double multa = 0.02;
    public Boleto(string cliente, double voriginal, int diasatrasados) : base (cliente, voriginal, diasatrasados){}
    public override double CalcularValorFinal()
    {
        double ValorFinal = ValorOriginal +emissao;
        if (DiasAtrasados>0){
            double juros = ValorOriginal*jurosDiario * DiasAtrasados;
            double taxa = ValorOriginal*multa;
            ValorFinal += juros + taxa;
        }
        return ValorFinal;
    }   
    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"Valor final: {CalcularValorFinal():F2}");
    }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando notificação de emissão para {Cliente}");
    }
}