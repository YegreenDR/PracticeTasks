internal class Flat
{
    public string Name;
    public double Weight;
    public const double Coeff = 1.25;
    public Flat(string name, double weight, double square)
    {
        Name = name;
        Weight = weight;    
        
    }
    public virtual double CalculateCost()
    {
        return Coeff * Weight;
    }
    public override string ToString()
    {
        return $"{Name}; {Weight}";
    }
}
internal class FieldArea : Flat
{
    
    public FieldArea(string name, double cost, double square) : base(name,cost,square)
        { }
    public override double CalculateCost()
    {
        double baseCost = base.CalculateCost();
        return baseCost + baseCost * Coeff;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Flat flat = new Flat("Простой", 15, 5);
        FieldArea fieldArea = new FieldArea("Поле", 15, 5);
        Console.WriteLine($"Вид картофеля: {flat};Цена за кг.: {flat.CalculateCost()}");
        Console.WriteLine($"Площадь поля: {fieldArea}; Урожай картофеля: {fieldArea.CalculateCost()}");
    } 
}