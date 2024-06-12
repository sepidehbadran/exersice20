// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter the first number :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter the second number :");
int num2 = Convert.ToInt32(Console.ReadLine());

int d1 = num1 / 10;
int d2 = num1 % 10;

int d3 = num2 / 10;
int d4 = num2 % 10;

int max = d1;
int Number = num1;

if (d2 > max) 
{
    max = d2;
    Number = num1;

}
if(d3> max)
{
    max = d3;
    Number = num2;
}

if(d4>max)
{
    max = d4;
    Number = num2;
}

Console.WriteLine("number :" + Number);

