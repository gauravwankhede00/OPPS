using System.Threading.Tasks;

namespace OPPS
{
    class AsyncCodeOrNot
    {
        public static void Main(string[] args)
        {

            CallMethod();
        }

        public static async Task CallMethod()
        {
            var data = await GetData();
        }

        public static async Task<string> GetData()
        {

            return await Task.FromResult("gaurav");
        }

    }
}
