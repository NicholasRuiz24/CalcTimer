//Code developed in class, 18 Sept 2023
using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        int n = 80000; //number of random numbers to generate
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        numbers = GenerateRandomNumbers(n);
       
        timer.Start();
        AddNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");
        float addTicks = (float)timer.ElapsedTicks;

        timer.Restart();
        MultiplyNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");
        float multTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + addTicks/multTicks);


        // int i;
        // for (i=0; i<n; ++i){
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1] + " " + numbers[i,2]);  

        // }
    }
  
    //Function to generate an array of random numbers
    static double[,] GenerateRandomNumbers(int count)
    {
        Random rand = new Random(); //instantiate random numbers
        double[,] num = new double[count,3]; //makes an array
        for(int i=0; i<count; ++i){
            num[i,0] = 100.0*rand.NextDouble();
            num[i,1] = 100.0*rand.NextDouble();
        }
        return num; //returns reference to array
    }

//Function that adds numbers in the 2D array
static void AddNumbers(double[,] numbers, int count)
{
    int i;
    for (i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] + numbers[i,1];
    }
}

static void MultiplyNumbers(double[,] numbers, int count)
{
    int i;
    for (i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] * numbers[i,1];
    }
}
}