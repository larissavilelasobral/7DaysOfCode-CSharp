using RestSharp;
using System.Text.Json;

namespace BichoVirtual
{
  public class Menu
  {
    // vazio? 

    public void BoasVindas()
    {
      Console.WriteLine("Bem Vindo ao Jogo!!!");
      Console.WriteLine("Qual o seu nome?");
      var nomeJogador = Console.ReadLine();

      Console.WriteLine($"Olá {nomeJogador}, esse é o nosso Menu de Seleção:");
      Console.WriteLine("[1] - Adoção de mascotes");
      Console.WriteLine("[2] - Ver mascotes adotados");
      Console.WriteLine("[3] - Sair do Jogo");
      int opcaoMenu = Convert.ToInt32(Console.ReadLine());

      List<int> animaisSelecionados = new List<int>();
      // utilizar switch case? 
      if (opcaoMenu == 1)
      {
        ExibirPokemons();
        int selecionado = Convert.ToInt32(Console.ReadLine());
        animaisSelecionados.Add(selecionado);
      }
      if (opcaoMenu == 2)
      {
        Console.WriteLine("lista de mascotes adotados");
      }
      if (opcaoMenu == 3)
      {
        Console.ReadKey();
        Console.Clear();
      }
    }

    public void ExibirPokemons()
    {
      var opcoesPokemons = new List<string> { "bulbasaur", "charmander", "charizard" };

      int index = 1;
      foreach (var pokemon in opcoesPokemons)
      { // uma requisição para cada mascote? 
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
        var request = new RestRequest("", Method.Get);
        RestResponse response = client.Execute(request);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          var pokemons = JsonSerializer.Deserialize<Pokemon>(response.Content);          
          Console.WriteLine(" ------------------------- ");
          Console.WriteLine($"[{index}] - Nome: {pokemons.name}");
          Console.WriteLine($"Altura: {pokemons.height}");
          Console.WriteLine($"Largura: {pokemons.weight}");
          Console.WriteLine(" ------------------------- ");
        }
        else
        {
          Console.WriteLine("Error: " + response.ErrorMessage);
        }
        index++;
      }
    }

    public void Pokedex(int pokemonSelecionado)
    {

    }
  }
}