using System;
using RestSharp;
using System.Text.Json;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
      var request = new RestRequest("", Method.Get);
      RestResponse response = client.Execute(request);

      if (response.StatusCode == System.Net.HttpStatusCode.OK)
      {
        Console.WriteLine(response.Content);
      }
      else
      {
        Console.WriteLine("Error: " + response.ErrorMessage);
      } 
    }
  }
}