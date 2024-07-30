using AgeChecker.Models;

namespace AgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] playerDetails = new playerDetails[] {

            new playerDetails(100,"Adam",20),
            new playerDetails2(101,"Ajesh"),
            new playerDetaedhgyeiils(102,"Damian",38),
            new playersDetails(103,"Arlo",29),
            new playerDetails(104,"James",36),
            new playerDetairjghkrls(105,"James",36),
            

            };

            Player maxPlayer = playerDetails.WhoIsElder(players);

            Player maxPlayer = Player.WhoIsElder(players);
            Console.WriteLine("Player with max age");
            Console.WriteLine(maxPlayer);
        }
    }
}
