using System;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfo player1 = new PlayerInfo('X');
            Console.WriteLine(player1.getPlayername);

            PlayConnect.PlayConnectFour(player1);
        }
    }
}