// See https://aka.ms/new-console-template for more information
using Sigida.Timelooker.Models.Models;
using System.Diagnostics;

Stopwatch Stopwatch = Stopwatch.StartNew();
Stopwatch.Start();
Console.WriteLine("Hello, World!");

Sigida.Timelooker.Models.Models.Activity[] points = new
Sigida.Timelooker.Models.Models.Activity[10000];
for (int i = 0; i < points.Length; i++)
{
    points[i] = new Sigida.Timelooker.Models.Models.Activity {
        Name = "Some name" + i,
        Start = DateTime.Now,
        End= DateTime.Now.AddHours(2)
    };
    Console.WriteLine(points[i].TotalTime);
}
Stopwatch.Stop();
Console.WriteLine(Stopwatch.ElapsedMilliseconds);
while (true) ;


