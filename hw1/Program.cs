﻿

void EvenCount(int n)
{
    int even=0,odd=0,digit=0,sum=0;
    for(int i=n;i>0;i/=10)
    {
        if(i%10%2==0)
        {
            even++;
        }
    }
        System.Console.WriteLine($"Even: {even}");
     for(int i=n;i>0;i/=10)
    {
        if(i%10%2!=0)
        {
            odd++;
        }
    }
        System.Console.WriteLine($"Odd: {odd}");
    for(int i=n;i>0;i/=10)
    {
            digit++;
    }
        System.Console.WriteLine($"Digit: {digit}");
    for(int i=n;i>0;i/=10)
    {
            sum+=i%10;
    }
        System.Console.WriteLine($"Sum: {sum}");
}
EvenCount(12345);