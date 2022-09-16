namespace BichoVirtual
{
  public class Pokemon
  {
    public List<Abilities>? abilities { get; set; }

    public string name { get; set; }
    public double weight { get; set; }
    public double height { get; set; }
  }

  public class Abilities
  {
    public Ability? ability { get; set; }
    public bool is_hidden { get; set; }
  }

  public class Ability
  {
    public string? name { get; set; }
    public string? url { get; set; }
  }
}

