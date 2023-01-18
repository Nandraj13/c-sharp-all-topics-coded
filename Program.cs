using System.Linq;
//datatypes demo
/*
int x=10;
int y=20;

string name="nandraj ";
string surename="maru";

char c='w';
double d=23.444d;

Console.WriteLine($"addition of variable: {x+y}");
Console.WriteLine($"my full name is: {name+surename}");
Console.WriteLine($"this is character value: {c}");
Console.WriteLine($"this is double: {d}");

//string functions

Console.WriteLine(name.ToUpper());
Console.WriteLine(name.StartsWith("n"));
Console.WriteLine(name.Substring(3));
Console.WriteLine(name.ToLower());

//string concatenation

Console.WriteLine("hello my name "+"is nandraj.");

//operators

Console.WriteLine(1>2);
Console.WriteLine(1<2);
Console.WriteLine(1==2);
Console.WriteLine(1>=2);
Console.WriteLine(1<=2);

//ternary operator

Console.WriteLine(1>2?"yess":"nooo");

//decision making statements

if(x>y){
    Console.WriteLine("x is greater than y");
}
else
{
    Console.WriteLine("x is less then y");
}

//loops

int i=3;
while(i > 0)
{
    Console.WriteLine(i);
    i--;
}
for(int j=0;j<=3;j++)
{
    Console.WriteLine(j);
}

//user input

Console.WriteLine($"please enter some text");
string userinput = Console.ReadLine();
Console.WriteLine($"you entered following text {userinput}");

//switchcase

string exp="a";
switch(exp)
{
    case "a":Console.WriteLine("exp has a");
            break;
    case "b":Console.WriteLine("exp has b");
            break;
    default:break;
}

//booleans

bool iscsharp= true;
bool isnotcsharp= false;
Console.WriteLine(iscsharp);
Console.WriteLine(isnotcsharp);

//shorthand ifelse
int x1=10;
string result=(x1>10)?"x is greater than 10":"x is less than 10";
Console.WriteLine(result);

//break and continue
int var=10;
while(var>1){
    if(var==5){
        Console.WriteLine($"break up with value {var}");
        break;
    }
    var--;
}

for(int x2=0;x2<10;x2++){
    if(x2==4){
        continue;
    }
    Console.WriteLine(x2);
}

//arrays
string[] cars={"swift","creta","mercedes"};
for(int carloop=0;carloop<cars.Length;carloop++)
{
    Console.WriteLine(cars[carloop]);
}

int[] mynum={1,2,3,4,};
for(int mynumloop=0;mynumloop<mynum.Length;mynumloop++)
{
    Console.WriteLine(mynum[mynumloop]);
}

string[] bikes=new string[4];
for(int bikelength=0;bikelength<bikes.Length;bikelength++)
{
    Console.WriteLine("enter a bike name");
    bikes[bikelength]=Console.ReadLine();
}
foreach(String bname in bikes){
    Console.WriteLine(bname);
}

//array methods
int[] arr={2,333,4,5,77,88,1};

Array.Sort(arr);

foreach(int element in arr)
{Console.WriteLine(element);};

Console.WriteLine(arr.Max());
Console.WriteLine(arr.Min());
*/

//2D array

int[,] aar2d={{1,2,3},{4,5,6}};
int[,] aar2d1=new int[3,3];
for(int q=0;q<aar2d1.GetLength(0);q++)
{
    for(int q1=0;q1<aar2d1.GetLength(1);q1++)
    {Console.ReadLine();}
}