using static Bogus.DataSets.Name;

namespace _10_AnonimObject_Linq
{
    internal class User
    {
        public int Id { get; private set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Avatar { get; internal set; }
        public string UserName { get; internal set; }
        public string Email { get; internal set; }
        public string SomethingUnique { get; internal set; }
        public Guid CartId { get; internal set; }
        public string FullName { get; internal set; }

        public User(int id, string phone)
        {
            Id= id;
            Phone= phone;
        }
        public override string ToString()
        {
            return @$"
  Id: {Id}
  Gender: {Gender.GetType().Name}
  Phone: {Phone}
  FirstName: {FirstName}
  LastName: {LastName}
  Avatar: {Avatar}
  UserName: {UserName}
  Email: {Email}
  SomethingUnique: {SomethingUnique}
  CartId: {CartId}
  FullName: {FullName}
                    ";
        }
    }
}