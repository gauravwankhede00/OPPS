using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace OPPS
{
    class Program
    {

        static void Main(string[] args)
        {
           // Human h = new Human();

            

            #region Encapsulation
            //Student student = new Student();
          
            //student.Age = -1;
            //student.Mark = -0001;
            #endregion
            


            // var input = "Gif";
            // Console.WriteLine(input.ToAppendSignature());
            //LINQ.Start();


            //Student student = new Student();
            //student.Age = -1;

            //Generic<int> generic = new Generic<int>();
            //generic.Add(1,2);

            //Generic generic = new Generic();
            //generic.Add<string>("a", "1");




            Console.ReadLine();
        }
    }
    #region LINQ
    static class LINQ
    {
        static List<User> list = new List<User>{
        new User{ Age=5, City="Mumbai", Gender="Male", Id=1, Name="Amit"},
           new User{ Age=6, City="Pune", Gender="Male", Id=2, Name="Jorge"},
              new User{ Age=7, City="Pune", Gender="Female", Id=3, Name="Pintoo"},
                 new User{ Age=8, City="Goa", Gender="Male", Id=4, Name="Jigar"},
                    new User{ Age=9, City="Surat", Gender="Female", Id=5, Name="Tinku"}
        };
        internal static void Start()
        {
            //var result = list.Where(w => w.City == "Pune").ToList();
            var result = from user in list
                         where user.City == "Pune"
                         select user;
            Console.WriteLine(result.Count());
        }
    }
    #endregion
    #region Generic
    public class Generic<T>
    {
        public void Add(T a, T b)
        {
            // Console.WriteLine(a.Equals(b)); 
            Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b));
        }

    }

    public class Generic
    {
        public void Add<T>(string test, T a)
        {
            Console.WriteLine(a);

        }
    }
    #endregion
    #region ConcurrentCollection
    public static class ConcurrentCollection
    {


        static ConcurrentDictionary<int, int> dist = new ConcurrentDictionary<int, int>();
        static void Add()
        {
            for (int i = 0; i < 100; i++)
            {
                dist.TryAdd(i, i);

                Console.WriteLine(i + "\t p1 \t" + i);
                Thread.Sleep(2000);
            }
        }

        static void Add2()
        {
            for (int i = 0; i < 100; i++)
            {
                dist.TryAdd(i, i);

                Console.WriteLine(i + "\t p2 \t" + i);
                Thread.Sleep(2000);
            }
        }

        static void Start()
        {
            Thread p1 = new Thread(Add);
            Thread p2 = new Thread(Add2);
            p1.Start();
            p2.Start();
        }
    }
    #endregion
    #region ExtensionMethod
    static class ExtensionMethod
    {
        public static string ToAppendSignature(this string input)
        {
            return string.Concat(input, "\n Thanks,\nGaurav");
        }

    }

    #endregion
   
    class User
    {

        public int Id { get; set; }
        protected int id { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }
        public int Age { get; set; }

    }

   
}
