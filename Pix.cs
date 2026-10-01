public class Pix : TituloFinanceiro
{   
    public Pix (string cliente, double voriginal) : base (cliente, voriginal,0){}
    public override double CalcularValorFinal()
    {
        double valorFinal = ValorOriginal * 0.95;
        return valorFinal;
    }

    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"R${CalcularValorFinal():F2}");
    }
}