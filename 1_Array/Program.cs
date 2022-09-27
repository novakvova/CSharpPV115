
#region Звичайний масив

//int n = 5;
//int[] marks=new int[n];
//Random rand=new Random();
//for (int i = 0; i < n; i++)
//{
//    marks[i]= rand.Next(1,10);
//}

//foreach (var item in marks)
//{
//    Console.Write($"{item}\t");
//}

#endregion

#region Двохмірні масиви
//int n=3, m=3;

//int[,] array2D = new int[n,m];

//Random random = new Random();

//Console.WriteLine("Двох мірний масив");
//for (int i = 0; i < n; i++)
//	for (int j = 0; j < m; j++)
//	{
//		array2D[i,j]=random.Next(18,30);
//	}

//for (int i = 0; i < n; i++)
//{
//	for (int j = 0; j < m; j++)
//	{
//		Console.Write($"{array2D[i,j]}\t");
//	}
//	Console.WriteLine();
//}
#endregion

#region Зубчаті масиви

//int n = 5;
//int[][] mas = new int[5][]; 

//Random r = new Random();
//for (int i = 0; i < n; i++)
//{
//    int size = r.Next(3, 10); //розмір зуба
//    mas[i]= new int[size];
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = r.Next(18, 40);
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write($"{mas[i][j]}\t");
//    }
//    Console.WriteLine();
//}

#endregion

#region Array - exmaple

//int[] ints = { 34, 12, 1, 34 };

//foreach (var item in ints)
//{
//    Console.Write($"{item}\t");
//}

//Console.WriteLine();
//Array.Sort(ints); //Array.Reverse();

//Console.WriteLine("Відсортований масив");
//foreach (var item in ints)
//{
//    Console.Write($"{item}\t");
//}

#endregion

#region Array - type object

using _1_Array;
using System.Net.Http.Headers;

Dog[] dogs = { 
    new Dog() { Name="Марта", Breed= "Лайка" },
    new Dog() { Name="Шарик", Breed= "Дворняга" },
    new Dog() { Name="Дурко", Breed= "Хаскі" },
};

Console.WriteLine("Готель для собак");
foreach (var item in dogs)
{
    Console.WriteLine(item);
}

Array.Sort(dogs, new DogComparer());
//Array.Reverse(dogs);

Console.WriteLine("Сотрований список");
foreach (var item in dogs)
{
    Console.WriteLine(item);
}



#endregion