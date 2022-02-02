public class People
{
    public int Age { get; set; }
    public string? Name { get; set; }
    public string? Document { get; set; }

    public People Clone()
    {
      
      return new People()
      {
        Document = this.Document,
        Age = this.Age,
        Name = this.Name

      };
    }
}
