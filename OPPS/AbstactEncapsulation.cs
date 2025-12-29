using System;

namespace OPPS.AbstactEncapsulation
{
    class AbstactEncapsulation
    {
        static void Main()
        {
            User internalUser = new InternalUser("Alice", "EMP101");
            internalUser.Login();
            internalUser.Access();
            //internalUser.GetEmployeeId();

            User externalUser = new ExternalUser("Bob", "CUST202");
            externalUser.Login();
            externalUser.Access();
            //externalUser.GetCustomerId();
        }
    }

    // 🧩 Abstraction: common user interface
    public abstract class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Login()
        {
            Console.WriteLine($"{Name} has logged in.");
        }

        // Abstract method - behavior depends on user type
        public abstract void Access();
    }

    // 👨‍💼 InternalUser: uses encapsulated private field
    public class InternalUser : User
    {
        private string employeeId; // 🛡️ Encapsulated

        public InternalUser(string name, string id) : base(name)
        {
            employeeId = id;
        }

        public string GetEmployeeId() => employeeId;

        public override void Access()
        {
            Console.WriteLine($"{Name} can access internal dashboard.");
        }
    }

    // 🌐 ExternalUser: uses encapsulated private field
    public class ExternalUser : User
    {
        private string customerId; // 🛡️ Encapsulated

        public ExternalUser(string name, string id) : base(name)
        {
            customerId = id;
        }

        public string GetCustomerId() => customerId;

        public override void Access()
        {
            Console.WriteLine($"{Name} can access public pages only.");
        }
    }

}
