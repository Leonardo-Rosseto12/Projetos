using System.Net.Mail;

namespace caixa_eletronico_POO;
public class Cliente
{
    private int Id { get; set; }
    public string Nome { get; set; }
    private string Endereco { get; set; }

    private string Chave { get; set; }

    //---------------------------------------------------------------------------

    public Cliente(int id, string nome, string endereco, string chave)
    {
        Id = id;
        Nome = nome;
        Endereco = endereco;
        Chave = chave;

    }
    //---------------------------------------------------------------------------
    public bool Autenticar(int numero, string senha)
    {
        return Id == numero && Chave == senha;
    }
    //---------------------------------------------------------------------------
    public bool AlterarSenha(string novaSenha, string senhaAtual)
    {
        if(senhaAtual == novaSenha)
            return false;

        if(novaSenha.Length < 4)
            return false;

        if(senhaAtual != Chave)
            return false;  

        Chave = novaSenha;
        return true;
    }
}
