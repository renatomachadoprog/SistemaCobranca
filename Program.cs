Boleto boleto1 = new Boleto("Renato BOLETO",500, 0);
CartaoCredito cartao1 = new CartaoCredito("renato CARTAO", 700, 2);
Pix pix1 = new Pix("Renato PIX", 500);

List<TituloFinanceiro> cobrancas = new List<TituloFinanceiro>();

cobrancas.Add(new Boleto("Renato boletadas",600, 0)) ;
cobrancas.Add(new CartaoCredito("Renato creditadas",600,2));
cobrancas.Add(new Pix("Renato pix",600));

foreach (TituloFinanceiro cobranca in cobrancas)
{
    cobranca.ExibirResumo();
    if(cobranca is INotificavel notificavel)
    {
        notificavel.EnviarNotificacao();
    }
}