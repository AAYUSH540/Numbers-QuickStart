using System;

Integer();
Double();
Decimal();
Area();

void Decimal()
{
Console.WriteLine("");
Console.WriteLine("-----------------");
Console.WriteLine("*Decimal*");
Console.WriteLine("-----------------");
WorkWithDecimal();
}

void Integer()
{
Console.WriteLine("-----------------");
Console.WriteLine("*Integer*");
Console.WriteLine("-----------------");
WorkWithIntegers();
OrderPresedence();
MaxMin();
}

void Double()
{
Console.WriteLine("");
Console.WriteLine("-----------------");
Console.WriteLine("*Double*");
Console.WriteLine("-----------------");
WorkWithDouble();
}

void Area()
{
Console.WriteLine("");
Console.WriteLine("-----------------");
Console.WriteLine("*Area*");
Console.WriteLine("-----------------");
double rad = 2.5;
CalculatingArea(rad);
}

void WorkWithIntegers()
{
Console.WriteLine("WorkWithIntegers");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);
}


void OrderPresedence()
{
Console.WriteLine("");
Console.WriteLine("OrderPresedence");
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);
}

void MaxMin()
{
Console.WriteLine("");
Console.WriteLine("MaxMin");
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"reminder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
}

void WorkWithDouble()
{
Console.WriteLine("WorkWithDouble");
double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

Console.WriteLine("");
Console.WriteLine("MaxMin");
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");
}


void WorkWithDecimal()
{
Console.WriteLine("WorkWithDecimal");
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

Console.WriteLine("");
Console.WriteLine("MaxMin");
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

}

void CalculatingArea(double rad)
{
double area = Math.PI*rad*rad;
Console.WriteLine($"The Area is {area}");
}


