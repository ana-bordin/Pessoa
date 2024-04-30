namespace PessoaPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.setNome(Console.ReadLine());
            p.setIdade(int.Parse(Console.ReadLine()));

            Console.WriteLine(p.getNome());
            Console.WriteLine(p.getIdade());
        }
    }
}