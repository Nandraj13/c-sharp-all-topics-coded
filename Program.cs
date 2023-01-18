class Car{
    string suv="scorpio";
    string sedan;
    static void Main(string[] args)
    {
        Car car=new Car();
        Car newcar=new Car();
        Carprop carp=new Carprop();
        car.sedan="altis";
        newcar.sedan="ciaz";
        Console.WriteLine(car.suv);
        Console.WriteLine(newcar.suv);
        Console.WriteLine(carp.color);
        Console.WriteLine(carp.tyre);
        Console.WriteLine(car.sedan);
        Console.WriteLine(newcar.sedan);
        
        Methods m=new Methods();
        m.disp();
        Cons c= new Cons();
        c.dispagain();
        
        Accesss a=new Accesss();
        Console.WriteLine(a.name);

        Overloading o=new Overloading();
        o.m1(2,3);
        o.m1(2.3D,3.4D);
    }
}