using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OPPS
{
    static class LogicalQuestions
    {
        //static LogicalQuestions()
        //{
        //    Pi = 3.14;
        //}

        //static double Pi;

       private static async Task Method1()
        {
            Console.WriteLine("Method1 Start");
            await Task.Delay(2000);  // Await suspends Method1 for 1 second
            Console.WriteLine("Method1 End");
        }

        private static async Task Method2()
        {
            Console.WriteLine("Method2 Start");
            await Task.Delay(2000);  // Also suspends Method2 for 1 second
            Console.WriteLine("Method2 End");
        }
        private static async Task<int> Method3()
        {
            Console.WriteLine("Method3 Start");
            await Task.Delay(2000);  // Also suspends Method2 for 1 second
            Console.WriteLine("Method3 End");
            return 1;
        }
        static async Task Main()
        {
            //await Method1();          // ← awaits completion
            var t = Method2();        // ← starts Method2, but doesn’t await yet
            //var a = await Method3();
            Console.WriteLine("After Method2 call");
            //await t;
            Console.WriteLine("Both Method Called");
            //var result = TupleExample(5, 6);
            // Console.WriteLine(result.sum); 

            //StringExamples();

            //IEnumerable<int> result = YeildExample();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //FindFirstNonRepeatingChar();
            //LongestWord();
            //InheritanceExample();
            //AnagramSecond("hello", "lleoh");
            //AnagramSecond("hello", "leeoh");
            //AnagramSecond("zglobant", "talgonb");
            //SortArray();
            //Anagram();
            //InterchangeValues();
            //Console.WriteLine(Palindrome());
            //var result = TupleExample(3, 4);
            //Console.WriteLine(@"Sum : {0}, Multiplication: {1}, Division : {2}, Array Count : {3}", result.sum, result.multiplication, result.division, result.array.Length);

            //var a = "gaurav".ToUpperCase("Wankhede");
            //Chunk();
            //SplitString();
            //Console.WriteLine(a);

            Console.ReadLine();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {

                if (number % i == 0)
                {
                    return false;

                }
               


            }

            return true;
        }

        private static void factorial(int number)
        {
            int factorial = 1;

            while (number > 0)
            {

                factorial = number * factorial;
                number--;

            }

            Console.WriteLine($"factorial  {factorial}");
           
        }

        private static void StringExamples()
        {
            string ss = "To “remove” an element, you must create a new array without that element".ToLower();

            string vovels = "aeiou";

            var splitString = ss.Split(new char[] { ' ' });

            var sss = splitString.GroupBy(s => s).Select(s => new { key = s.Key, count = s.Key.Count(c => vovels.Contains(c)) }).ToList();

            string bigSentence = "adsdsad bsdasdsa csdsadf fd dfd ef ffdfdfd gf hdfdsfsdfdsfdsf idfdsfds  jfdsfsdqwewq kqedqr3 a las maa nfc";
            var bigWord = bigSentence.Split(' ').OrderByDescending(s => s.Length).First();

            Func<string, int> func = (string s) =>
            {
                return s.Length;
            };

            int[] arr = new int[] { 2, 8, 1, 4, 3, 0, 2 };

            var resultArr = arr.GroupBy(s => s).Select(g => new
            {
                key = g.Key,
                count = g.Count()
            });


            char[] arrSt = new char[] { 'a', 'b', 'a', 'c', 'd', 'd' };


            var r = arrSt.GroupBy(g => g).Select(s => new { key = s.Key, count = s.Count() });


            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var a = arr[j];
                        arr[j] = arr[i];
                        arr[i] = a;
                    }
                }
            }


            Console.WriteLine(" second highest" + arr[arr.Length - 2]);

            var result = arr.OrderByDescending(s => s).Take(2);
            Console.WriteLine(result.OrderBy(s => s).First());
            string[] arrS = new string[] { "gaurav", "ramrao", "wankhede" };


            Console.WriteLine(arrS.OrderBy(func).First());

        }
        public static IEnumerable<int> YeildExample()
        {
            for (int i = 0; i < 10; i += 2)
            {
                yield return i;
                Console.WriteLine($"print {i}");
            }
        }

        private static void FindFirstNonRepeatingChar()
        {
            string name = "abcabcde";

            Dictionary<char, int> dist = new Dictionary<char, int>();

            var array = name.ToCharArray();

            foreach (var item in array)
            {

                if (dist.ContainsKey(item))
                {
                    dist[item] = dist[item] + 1;
                }
                else
                {
                    dist.Add(item, 1);
                }
            }
            var result = dist.Where(w => w.Value == 1).Select(s => s.Key);
            Console.WriteLine($"not repeat first char is {result}");
        }
        private static void LongestWord()
        {
            string line = "gaurav ramarao wankhede";

            string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string longword = "";
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        longword = words[0];

            //    }
            //    else
            //    {
            //        if (words[i].Length > longword.Length)
            //        {
            //            longword = words[i];
            //        }
            //    }
            //}

            longword = words.OrderByDescending(word => word.Length).FirstOrDefault();
            Console.WriteLine($"Lonest Word is {longword}");
        }
        private static void InheritanceExample()
        {
            //AA objA = new AA();  //>> A
            //objA.print();  //  print A

            //objA.printVir(); //>>print A virtual 

            AA objB = new BB(); //>> A 
                                // B
            objB.print();       //    print B
            objB.printVir();//print B virtual


            //BB objB2 = new BB(); //>> A
            //                    //   B
            //objB2.print();  //>>   print B
            //objB2.printVir(); //>> print B virtual
        }
        private static void ChunkLogic()
        {
            var batchSize = 100;

            List<int> rows = new List<int>();
            for (int i = 0; i < 501; i++)
            {
                rows.Add(i);
            }

            List<List<int>> persons = new List<List<int>>();
            for (int i = 0; i < rows.Count; i += batchSize)

            {
                persons.Add(rows.Skip(i).Take(100).ToList());
            }
        }
        private static void AnagramSecond(string a, string b)
        {
            string av = "ab".OrderBy(s => s).ToString();
            char[] charFirst = a.OrderBy(x => x).ToArray();
            char[] charSecond = b.OrderBy(x => x).ToArray();

            var stringFirst = new string(charFirst); var stringSecond = new string(charSecond);
            if (stringFirst == stringSecond)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not an Anagram");
            }

        }
        private static bool Anagram()
        {
            var charArray1 = "zglobant".ToCharArray();
            var charArray2 = "talgonb".ToCharArray();

            HashSet<char> charSet1 = new HashSet<char>();
            HashSet<char> charSet2 = new HashSet<char>();

            foreach (var item in charArray1)
            {
                charSet1.Add(item);
            }
            foreach (var item in charArray2)
            {
                charSet2.Add(item);
            }

            foreach (var item in charSet1)
            {
                if (!charSet2.Contains(item))
                {
                    return false;
                }
            }
            return true;

        }

        //Exchange Two integer variable value without using third variable.
        private static void InterchangeValues()
        {
            int a = 18;
            int b = 7;

            a = a + b; // a = 25
            b = a - b; // b = 18
            a = a - b; // a = 7

            Console.WriteLine($"a = {a}, b = {b}");

        }

        private static bool Palindrome()
        {
            string input = "dalad";
            var newa = "dalad".ToCharArray().Reverse().ToArray();

            string reverse = new string(input.Reverse().ToArray());

            if (input == reverse)
            {
                return true;
            }
            return false;

            string original = "level";//
            var array = original.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sb.Append(array[i]);
            }
            if (sb.ToString() == original)
            {
                Console.WriteLine("palindrom ");
            }
            else
            {
                Console.WriteLine(" not a palindrom ");
            }
            //----------------
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;

                }
                left++;
                right--;
            }
            return true;

        }

        private static (int sum, int multiplication, double division, int[] array) TupleExample(int a, int b)
        {
            return (a + b, a * b, a / b, new int[] { a, b });
        }

        private static string ToUpperCase(this string str, string surname)
        {
            string a = str + " " + surname;
            return a.ToUpper();
        }

        private static void SplitString()
        {
            string text = "The  The   color   of  my   car is   green     a";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }


        private static void SortArray()
        {
            string[] array = new string[] { "rajesh|51|32|asd", "nitin|71|27|asd", "test|11|30|asd" };
            //output = ["test|11|30|asd", "rajesh|51|32|asd", "nitin|71|27|asd"]

            var result = array.OrderBy(s => int.Parse(s.Split('|')[1]));
            Console.WriteLine(string.Join(",", result));

        }

        private static async void Chunk()
        {
            string filePath = @"C:\OPPS\OPPS\records.csv";   // Text file containing rows like: 1,John
            string connectionString = "Server=.;Database=TestDB;Trusted_Connection=True;";

            // 1. Read all rows from file
            var records = File.ReadLines(filePath)
                         .Skip(1) // skip header row "Id,Name"
                         .Select(line => line.Split(','))
                         .Select(parts => new Person
                         {
                             Id = int.Parse(parts[0]),
                             Name = parts[1]
                         })
                         .ToList();

            Console.WriteLine($"Total Rows in CSV: {records.Count}");

            // 2. Split into batches of 100
            int batchSize = 100;
            var batches = records
                .Select((row, index) => new { row, index })
                .GroupBy(x => x.index / batchSize)
                .Select(g => g.Select(x => x.row).ToList())
                .ToList();

            Console.WriteLine($"Total Batches: {batches.Count}");

            List<List<Person>> persons = new List<List<Person>>();
            for (int i = 0; i < records.Count; i += batchSize * i)
            {
                persons.Add(records.Take(batchSize).Skip(i * batchSize).ToList());
            }


            // 3. Process batches in parallel
            await Task.WhenAll(batches.Select(batch => Task.Run(() => InsertBatch(batch, connectionString))));



        }

        static void InsertBatch(List<Person> batch, string connectionString)
        {
            try
            {
                // Create DataTable schema
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));

                // Fill DataTable
                foreach (var person in batch)
                {
                    table.Rows.Add(person.Id, person.Name);
                }

                // Bulk insert into SQL Server
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "Employee"; // Your SQL Table
                        bulkCopy.BatchSize = 100;
                        bulkCopy.WriteToServer(table);
                    }
                }

                Console.WriteLine($"✅ Inserted batch of {batch.Count} rows (FirstId={batch.First().Id})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error inserting batch: {ex.Message}");
            }
        }

        static List<object> list = new List<object>();

        public static T Test<T>(T value)
        {
            return value;
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class AA
    {
        public AA()
        {
            Console.WriteLine("A");
        }

        public void print()
        {
            Console.WriteLine("print A");
        }
        public virtual void printVir()
        {
            Console.WriteLine("print A virtual");
        }
    }

    class BB : AA
    {
        public BB()
        {
            Console.WriteLine("B");
        }

        public new void print()
        {
            Console.WriteLine("print B");
        }
        public override void printVir()
        {
            Console.WriteLine("print B virtual");
        }
    }

    public class G<T> where T : class
    {
        public T Add(T value)
        {
            return value;
        }


        public T New(T value1, T value2)
        {

            return value1;
        }

    }

    public class TestNew
    {

        public static T Add<T>(T value)
        {
            return value;
        }
    }

    interface INotification
    {
        void Notify();
    }

    class SMS : INotification
    {
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    interface ITest1
    {
        void Test();
    }
    interface ITest2
    {
        void Test();
    }
    class MyClass : ITest1, ITest2
    {
        public void Test()
        {
            Console.WriteLine("Test Implemented");
        }
    }
    class MyClass2 : ITest1, ITest2
    {
        void ITest2.Test()
        {
            Console.WriteLine("ITest2 Test Implemented");
        }

        void ITest1.Test()
        {
            Console.WriteLine("ITest1 Test Implemented");
        }
    }

    class ParentClass
    {
        public void Add()
        {
            Console.WriteLine("add");
        }
    }

    class ChildClass : ParentClass 
    {

        public void Add()
        {
            Console.WriteLine("add");
        }
    }
}
