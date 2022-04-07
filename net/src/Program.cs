using System;

var counter = 0;
var countLenght = Environment.GetEnvironmentVariable("COUNT_LENGHT");
int iterations = Convert.ToInt16(countLenght);

while (iterations == -1 || counter < iterations)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}
