using _2_MethodEnumObjectType;

#region Enum
//Person p = new Person()
//{
//    Name = "Іван",
//    PersonType = PersonType.Pig,
//    Age = 18
//};

//Console.WriteLine(p);

#endregion

#region Struct 

//Apple red = new Apple();
//red.Name = "Червонощока";
//red.Type = "Антоновка";
int n=232;
//Apple p = null;
List<Person> people = new List<Person>();
people.Add(new Person()
{
    Name="Марина",
    Age=25,
    PersonType=PersonType.Soldier
});
people.Add(new Person()
{
    Name = "Максим",
    Age = 30,
    PersonType = PersonType.Citizen
});

foreach(var item in people)
{
    Console.WriteLine(item);
}
Person.UpdatePerson(i: -1, p: people[1]);

foreach(var item in people)
{
    Console.WriteLine(item);
}
Person papik = new Person();
Console.WriteLine(Person.GetCounter);
#endregion