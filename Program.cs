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
        
        Methods m=new Methods();//open methods file in this repository to access this class
        m.disp();
        Cons c= new Cons();//open constructors file in this repository to access this class
        c.dispagain();
        
        Accesss a=new Accesss();//open accessmodifiers file in this repository to access this class
        Console.WriteLine(a.name);

        Overloading o=new Overloading();//open overloading file in this repository to access this class
        o.m1(2,3);
        o.m1(2.3D,3.4D);
    }
}
