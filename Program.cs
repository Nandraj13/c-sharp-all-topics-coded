class A{
    public int age=12;
    public void dipslay()
    {
        Console.WriteLine("this is class A");
    }
}
class B:A{
    static void Main(string[] args)
    {
        B b=new B();
        Console.WriteLine(b.age);
        b.dipslay();
    }
}