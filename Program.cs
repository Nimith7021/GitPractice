using AgeChecker.Models;

namespace AgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] playerDetails = new playerDetails[] {

            new playerDetails(100,"Adam",20),
            new playerDetails(101,"Ajesh"),
            new playerDetails(102,"Damian",38),
            new playerDetails(103,"Arlo",29),
            new playerDetails(104,"James",36),

            };

            Player maxPlayer = playerDetails.WhoIsElder(players);

            Console.WriteLine(maxPlayer);
        }
    }
}
