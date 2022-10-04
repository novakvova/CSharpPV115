// See https://aka.ms/new-console-template for more information
using _5_.OOP_Glava_6;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
string str = "He2llo9";
int count =  str.CountDigital();
Console.WriteLine("Count digital {0}", count);
Object p = new Worker("Іван Васильович", "Столяр");

//if(p is Worker)
//{
//    var w = p as Worker;
//}
if (p is Worker w)
{
}

WorkerService workerService = new WorkerService();
workerService.Add((Worker)p);
try
{
    var worker = workerService[2];
    worker.Show();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//str.