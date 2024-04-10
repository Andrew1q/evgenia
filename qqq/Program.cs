try
{
    IAnimal[] a = new IAnimal[2];
    a[0] = new Dolphin(100);
    a[1] = new Pinguin(10);
    a[0].Move();
    a[0].Print();
    a[1].Move();
    a[1].Print();
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
interface IAnimal
{
    void Move();
    void Print();
}
abstract class Animal : IAnimal
{
    public abstract void Move();
    public abstract void Print();
    protected uint weight;
}
abstract class Fish : Animal
{
}
abstract class Bird : Animal
{
}
abstract class Mammal : Animal
{
}
class Pinguin : Bird
{
    public Pinguin(uint weight)
    {
        this.weight = weight;

    }
    public override void Move()
    {
        Console.WriteLine("Пингвин идет");
    }
    public override void Print()
    {
        Console.WriteLine("Вес: " + weight + "кг");
    }
}
class Dolphin : Mammal
{
    public Dolphin(uint weight)
    {
        this.weight = weight;
    }
    public override void Move()
    {
        Console.WriteLine("Дельфин плывет");
    }
    public override void Print()
    {
        Console.WriteLine("Вес: " + weight + "кг");
    }
}