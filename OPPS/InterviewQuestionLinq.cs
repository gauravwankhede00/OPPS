using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace OPPS
{
    class InterviewQuestionLinq
    {
        const double Pi = 3.14;
        readonly string read_Only;
        static string sta_tic;

        public InterviewQuestionLinq()
        {
            read_Only = "readOnly";
            //Pi = 1;
            read_Only = "new Value";
            sta_tic = "static new ";
        }

        static string abc(string a) { return a; }
        static string abc(string a, string b = null) { return a; }

        public string Decrypt(string cipherText)
        {

        private static readonly TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        private const string key = "b14ca5898a4e4133bbce2ea2315a1916";

        string ciphertext = $"EYUMmecaluJyVTxJmMskV7QgbJ4Ce8GmYQ3Xo6xzr2avQOebzxXA79MvhWGkHUEMo9WThtJJKn6TDOI7jF1IlJBM6LxOHgBnYSep/LncwS2ReczdFExk8V/jucmFlSK6r/m75h0zdogo16zCMZTYoe3oRA/dxzx5obU/szv1IQA=";


        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);
     using Aes aes = Aes.Create();
     aes.Key = Encoding.UTF8.GetBytes(key);
     aes.IV = iv;
     ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
     using MemoryStream memoryStream = new (buffer);
     using CryptoStream cryptoStream = new (memoryStream, decryptor, CryptoStreamMode.Read);
     using StreamReader streamReader = new (cryptoStream);
     return streamReader.ReadToEnd();
 }
static void Main()
{
    string input = "Hello World from C#";
    //Output: "C# from World Hello"
    var reverseArray = input.Split(' ').Reverse().ToArray();

    var output = string.Join(" ", reverseArray);

    string sb = "";
    for (int i = reverseArray.Length - 1; i >= 0; i--)
    {
        sb += reverseArray[i] + " ";
    }
    Console.WriteLine(sb);




    ///abc("abc");
    //var a = new Check();
    //a.A();
    //BABA.StaticMethod();

    //InterviewQuestionLinq interviewQuestionLinq = new InterviewQuestionLinq();
    //interviewQuestionLinq.read_Only = "aaa";


    //1) var a = SortData();
    //2) DisposeVSFinally();
    //(int sum, int mul, int[] array) = TupleExample(2, 5);


    //var result = YeildExample();
    //if (result.Contains(4))
    //{
    //    Console.WriteLine("Found 4");
    //}
    //ListToDictonaryWithLengthCount();
    //FindHowManyACharPresent();
    //Vovels();
    //ParentChild();

    //SingletonExample();
    //FindMisingNumber();
    //ImmutableClass();
    //Console.WriteLine(Param(1, 2, 4, 6, 8, 9));
    Console.ReadLine();
}

static int Add(int a, int b) => a + b;


static (int sum, int multiplication, int[] array) TupleExample(int a, int b)
{
    int[] array = new int[] { 2, 6, 5, 1, 8, 3, 4 };
    return (a + b, a * b, array);
}

static int Param(params int[] list)
{
    int i = 0;
    foreach (var item in list)
    {
        i += item;
    }
    return i;
}
static int[] SortData()
{
    int[] array = new int[] { 2, 6, 5, 1, 8, 3, 4 };

    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j]) // 6 < 2 //  5 < 2 ,  1  < 2< array[i] > array[j]
            {
                int a = array[j];
                array[j] = array[i];
                array[i] = a;
            }
        }

    }

    return array;
}

static void DisposeVSFinally()
{
    //StreamReader reader = null;
    //try
    //{
    //    reader = new StreamReader("C:\\DEV\\3.txt");
    //    Console.WriteLine(reader.ReadToEnd());
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine("Error: " + ex.Message);
    //}
    //finally
    //{
    //    // Ensuring the file is closed even if an exception occurs
    //    if (reader != null)
    //    {
    //        reader.Close();
    //        Console.WriteLine("File closed.");
    //    }
    //}

    try
    {
        //StreamReader is implement the Dispose Method  when using block executed, It called Dispose Method.
        using (StreamReader reader = new StreamReader("C:\\DEV\\3.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        } // Automatically calls Dispose() here
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}

static string palindrome(string str) //string a = "madam"; //121 //racecar
{
    StringBuilder stringBuilder = new StringBuilder();
    for (int i = str.Length - 1; i >= 0; i--)
    {
        stringBuilder.Append(str[i]);
    }
    return stringBuilder.ToString();
}

static void ListToDictonaryWithLengthCount()
{
    List<string> List = new List<string>() { "Gaurav", "Dhruvi", "Komal" };

    var dist = List.Select(s => s).ToDictionary(s => new { s, s.Length });


}

static void ParentChild()
{
    Parent parent = new Child();
    parent.Display();
}

static void SingletonExample()
{
    var instance1 = Singleton.GetInstance();
    var instance2 = Singleton.GetInstance();
    if (instance1 == instance2)
    {
        Console.WriteLine("Same instance");
    }
    else
    {
        Console.WriteLine("Different instance");
    }
}

static void FindHowManyACharPresent()
{
    string str = "Gaurav";
    char[] chars = { 'a' };

    Console.WriteLine(str.ToCharArray().Where(w => !chars.Contains(w)).Count());
}

static void Vovels()
{
    string[] str = { "Gaurav", "Komal", "Dhruvi" };
    HashSet<char> list = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    List<int> result = str.Select(s => s.ToCharArray().Where(w => list.Contains(w)).Count()).ToList();

}

static IEnumerable<int> YeildExample()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if (i == 4)
        {
            yield return i;
        }
    }
}

//Find mising Number
static void FindMisingNumber()
{
    List<int> number = new List<int>() { 1, 2, 5, 4, 6, 8 };

    List<int> range = Enumerable.Range(1, 8).ToList();

    List<int> missingNumber = range.Except(number).ToList();

    Console.WriteLine(string.Join(",", missingNumber));
    //missingNumber.ForEach(Console.WriteLine);
    Console.ReadLine();
}

static void ImmutableClass()
{
    Employee employee = new Employee(100, "Gaurav");
    Console.WriteLine(employee.Name);
    //employee.Name = string.Empty;
}

//immutable Class
class Employee
{
    public string Name { get; }
    public int Id { get; }
    public Employee(int id, string name)
    {
        Name = name;
        Id = id;
    }
}
    }

    class Parent
{
    public virtual void Display() => Console.WriteLine("Parent");

}
class Child : Parent
{
    public virtual void Display() => Console.WriteLine("Child");
}

sealed class Singleton
{
    private Singleton() { }
    private static Singleton instance;

    private static readonly object locker = new object();

    public static Singleton GetInstance()
    {
        if (instance != null)
        {
            return instance;
        }
        else
        {
            lock (locker)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

class BABA
{
    public static void StaticMethod()
    {
        BABA baba = new BABA();
        baba.House();

        Me me = new Me();
        me.Paisa();
        me.Share();

        baba = me;

        baba.Paisa();
        baba.House();
    }
    public BABA()
    {
        Console.WriteLine("BABA Constructor");
    }
    public virtual void House()
    {
        Console.WriteLine("BABA House");
    }
    public void Paisa()
    {
        Console.WriteLine("Paisa");
    }
}

class Me : BABA
{

    public Me()
    {
        Console.WriteLine("Me Constructor");
    }
    public override void House()
    {
        Console.WriteLine("Me House");
    }
    public void Share()
    {
        Console.WriteLine("Share");
    }
}

class Check
{
    void A()
    {
        Console.Write("1");
    }
}
}
