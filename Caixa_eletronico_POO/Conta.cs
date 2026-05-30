namespace caixa_eletronico_POO;
public class Conta
{
    public decimal Saldo { get; private set; }
    private string TipoConta { get; set; }
    private Cliente Titular { get; set; }
    //---------------------------------------------------------------------------
    public Conta(decimal saldoInicial, String tipoConta, Cliente titular)
    {
        Saldo = saldoInicial;
        TipoConta = tipoConta;
        this.Titular = titular;
    }
    //---------------------------------------------------------------------------
    public decimal ConsultarSaldo()
    {
        return Saldo;
    }
    //---------------------------------------------------------------------------
    public bool Sacar(decimal valor)
    {
        if (valor > Saldo || valor <= 0)
            return false;

        Saldo -= valor;
        return true;
    }
    //---------------------------------------------------------------------------
    public bool Depositar(decimal valor)
    {
        if (valor <= 0)
            return false;

        Saldo += valor;
        return true;
    }
}

