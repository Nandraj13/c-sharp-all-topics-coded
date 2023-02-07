//takes 26.87 seconds for inserting 3 million passwords in database(SQL server)
//takes 56.87 seconds for inserting 3 million passwords in database(MYSQL server)
//neccessary changes were made

using MySql.Data.MySqlClient;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
class Practice_session_2
{
    public static IConfigurationRoot conf = new ConfigurationBuilder().AddJsonFile("C:\\Users\\Nandraj Maru\\source\\repos\\prac2\\prac2\\jsconfig1.json").Build();
    public static string MyConnection2 = conf["constringsql"];
    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
    public static string validcharacters = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?";
    public static Random random = new Random();
    public static Stopwatch sw = new Stopwatch();
    public static int globalcount;
    public static int numoftasks;

    public static string generate_passwords()
    {
        string ch = string.Empty;
       
        for (int j = 0; j < 20; j++)
        {
            ch = ch + validcharacters[random.Next(0, validcharacters.Length)];
        }
        return ch;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of password you want to generate:");
        globalcount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the number of tasks:");
        numoftasks = Convert.ToInt32(Console.ReadLine());
        globalcount = globalcount / numoftasks;
        Console.WriteLine("each task will generate and insert {0} passwords in database", globalcount);
        //generate_passwords()
        List<Task> t = new List<Task>();
        for (int i = 0; i < numoftasks; i++)
        {
            t.Add(task());
        }
        sw.Start();
        foreach (Task i in t)
        {
            i.Start();
        }
        Task.WaitAll(t.ToArray());
        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }
    public static Task task()
    {
        SqlConnection MyConn2 = new SqlConnection(MyConnection2);
        int count = globalcount;
        MyConn2.Open();
        SqlCommand SqlCommand1 = new SqlCommand();
        SqlCommand1.Connection = MyConn2;
        Task taski1 = new Task(() =>
        {

            for (int j = 0; j < count; j++)
            {
                try
                {
                    SqlCommand1.Parameters.Clear();
                    SqlCommand1.CommandText = "insert into passwords (password) values (@pass)";
                    SqlCommand1.Parameters.AddWithValue("@pass",generate_passwords());
                    SqlCommand1.CommandType = System.Data.CommandType.Text;
                    SqlCommand1.ExecuteNonQuery();
                   
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        Console.WriteLine("skipping duplicate password..");
                        count++;
                    }
                  
                }

            }
            MyConn2.Close();
        });
        return taski1;
    }
}
        
