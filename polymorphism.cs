/*class Animal{
     public virtual void display()
    {
        Console.WriteLine("this is animal method");
    }
}
class Pet: Animal{
    public override void display()
    {
        
        Console.WriteLine("this is pet method");
    }
    static void Main(string[] args)
    {
        Pet p=new Pet();
        p.display();
        Animal a=new Animal();
        a.display();
    }
}

//abstract class exmple

abstract class Megaanimal{
   public abstract void disp();
}
class Smallpet: Megaanimal{
    public override void disp()
    {
        Console.WriteLine("hello your method is implemented here");
    }
    static void Main(string[] agrs){
        Smallpet s=new Smallpet();
        s.disp();
    }
}

//interface 

interface Animal {
   public abstract void disp();

}
class Pet: Animal{
     public void disp(){
        Console.WriteLine("this is implemented");
    }
    static void Main(string[] args)
    {
        Pet p=new Pet();
        p.disp();
    }
}

//multiple interfaces
interface dog{
    public abstract void doggy();
}
interface monkey{
    public abstract void monkey();
}
class Display: dog,monkey{
    public void doggy(){
        Console.WriteLine("this is a dogggy");
    }

    public void monkey()
    {
        Console.WriteLine("this is a monkey");
    }
    static void Main(){
        Display d=new Display();
        d.doggy();
        d.monkey();
    }
}*/

//enum
class Enumdemo{
    enum Level{
        medium,low,high
    }
    static void Main(string[] args){
        Level x=Level.medium;
        Console.WriteLine(x);
    }
}
