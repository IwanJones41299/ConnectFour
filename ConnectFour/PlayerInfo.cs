using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    public class PlayerInfo
    {
        //Attributes
        private string _playerName;
        private char _playerChip;

        //Constructors
        public PlayerInfo(char playerChip)
        {
            _playerName = PlayerName();
            _playerChip = playerChip;
        }

        public PlayerInfo(string playerName, char playerChip)
        {
            _playerName = playerName;
            _playerChip = playerChip;
        }

        //Properties
        public string getPlayername
        {
            get { return _playerName;  }
        }

        public char getPlayerchip
        {
            get { return _playerChip; }
            set { _playerChip = value; }
        }


        //Methods
        public string PlayerName()
        {
            Console.WriteLine("Player... Please enter your username! ");
            return Console.ReadLine(); 
        }

        ////This method is simulating the game checking a db for usernames to see if the one being entered is in use
        //static void CheckDB(string player)
        //{
        //    string[] playernames = { "IwanJones", "RhysDavo", "Cie" };

        //    foreach (string user in playernames)
        //    {
        //        if(player == user)
        //        {
        //            Console.WriteLine("Please enter another username, this one is taken");
        //            CheckDB(Console.ReadLine());
        //        }
        //    }
        //    Console.WriteLine("Welcome " + player);
        //}
    }
}
