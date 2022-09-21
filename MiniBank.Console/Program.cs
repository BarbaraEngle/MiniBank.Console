using MiniBank.Console.Dto;
using MSDataAccess;

namespace MiniBank.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Mini Bank");

            Account account = new Account();

            System.Console.WriteLine("Please enter your First Name");

            account.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("Please enter your Surname");

            account.Surname = System.Console.ReadLine();

            System.Console.WriteLine("Please enter your new Account No");

            account.AccountNo = System.Console.ReadLine();


            //Connect to the Sql Database and create a new record

            DataAccess da = new DataAccess(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MiniBank; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            da.CommandType = System.Data.CommandType.Text;
            da.CommandText = $"INSERT INTO Account " +
                $"(FirstName,Surname,AccountNo) " +
                $"VALUES ('{account.FirstName}', '{account.Surname}','{account.AccountNo}')";
           
            da.NonQuery();
        }
    }
}