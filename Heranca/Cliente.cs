public class Cliente : Pessoa 
{ 
    public int Conta;

    public Cliente()
    {    
    }

    public void DefinirConta(int c)
    {
        this.Conta = c;
    }
    public void ImprimirCliente()
    {
        ImprimirPessoa();
        Console.WriteLine($"Conta: {this.Conta}");
    }
}
