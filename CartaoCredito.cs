public class CartaoCredito : TituloFinanceiro, INotificavel
{
    public int Parcelas {get;set;}
    public CartaoCredito(string cliente, double voriginal, int parcelas) :base(cliente, voriginal, 0){
        Parcelas = parcelas;
    }
    
    public override double CalcularValorFinal()
    {
        double emissao = ValorOriginal * 0.035;
        double valorFinal = ValorOriginal + emissao;
        if(Parcelas > 1)
        {
            double taxaparcela = ValorOriginal*(Parcelas*0.01);
            valorFinal += taxaparcela;
        }
        return valorFinal;
    }
     public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando notificação confirmação de cobrança para {Cliente}");
    }

    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"Quantidade de parcelas: {Parcelas}");
        Console.WriteLine($"Valor final: {CalcularValorFinal():F2}");
    }
   
}