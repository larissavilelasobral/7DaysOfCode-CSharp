using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace BichoVirtual
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string nome = "bulbasaur";
      var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{nome}");
      var request = new RestRequest("", Method.Get);
      RestResponse response = client.Execute(request);

      if (response.StatusCode == System.Net.HttpStatusCode.OK)
      {
        var pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);
        Console.WriteLine($"Nome: {pokemon.name}");
        Console.WriteLine($"Altura: {pokemon.height}");
        Console.WriteLine($"Largura: {pokemon.weight}");
      }
      else
      {
        Console.WriteLine("Error: " + response.ErrorMessage);
      } 
    }
  }
}