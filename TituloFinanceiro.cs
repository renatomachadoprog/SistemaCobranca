public abstract class TituloFinanceiro
{
    public string Cliente {get;set;}
    public double ValorOriginal {get; protected set;}

    public int DiasAtrasados {get; private set;}

    public TituloFinanceiro(string cliente, double voriginal, int diasatrasados)
    {
        Cliente = cliente;
        ValorOriginal = voriginal;
        DiasAtrasados = diasatrasados;
    }
    public void RegistrarAtraso(int dias)
    {
        DiasAtrasados += dias;
    }
    public abstract double CalcularValorFinal();

    public virtual void ExibirResumo()
    {
        Console.WriteLine($"Nome: {Cliente}");
        Console.WriteLine($"Valor Original: {ValorOriginal:F2}");
        Console.WriteLine($"Dias Atrasados: {DiasAtrasados}");
    }
}