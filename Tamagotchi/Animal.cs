namespace BichoVirtual
{
  public class Animal
  {
    private int index;
    private string nome;
    private double altura;
    private double largura;

    public Animal(int Index, string Nome, double Altura, double Largura)
    {
      this.index = Index;
      this.nome = Nome;
      this.altura = Altura;
      this.largura = Largura;
    }

    public void ExibirDados()
    {
      Console.WriteLine($" ---------------------- \n [{this.index}] - Nome do animal: {this.nome}");
    }
  }
}