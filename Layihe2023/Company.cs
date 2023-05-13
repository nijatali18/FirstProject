namespace Layihe2023;

public  class Company : IEquatable<Company>, IdIntarface
{
    public int Id { get; }
    public string Name { get; set; }
    static int counter = 0;
    public Company()
    {
        counter++;
        this.Id = counter;
    }
   
 

    public bool Equals(Company? other)
    {
        throw new NotImplementedException();
    }
}


