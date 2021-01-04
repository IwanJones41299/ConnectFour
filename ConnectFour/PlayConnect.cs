using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    class PlayConnect
    {
        //Attributes
        static int _row = 6;
        static int _cols = 7;
        static char _resetChar = ('-');
        static DisplayGrid _board;

        //Constructors
        public PlayConnect()
        {

        }

        //Properties

        //Methods
        public static void PlayConnectFour(PlayerInfo mainPlayer)
        {
            bool win = true;
            Console.Clear();
            PlayerInfo playerTwo = new PlayerInfo("Player 2", 'O');
            _board = new DisplayGrid(_row, _cols, _resetChar);
            //_ConnectGrid.ShowGrid();
            do
            {

                //Player 1 Turn
                GetCounter(mainPlayer);
                _board.Display();
                //win = Check.CheckFour(_ConnectGrid, _ActivePlayer);


                //Player 2 Turn
                GetCounter(playerTwo);
                _board.Display();
                //win = Check.CheckFour(_ConnectGrid, playerTwo);

            } while (win != true);
        }

        static void GetCounter(PlayerInfo player)
        {
            int input;

            Console.WriteLine(player.getPlayername + " please enter a position");
            input = int.Parse(Console.ReadLine());

            if(input < 0 || input > 6)
            {
                do
                {
                    Console.WriteLine(player.getPlayername + " please enter a position");
                    input = int.Parse(Console.ReadLine());
                }
                while (input < 0 || input > 6);
            }

            CounterFall(input, player);
        }

        static void CounterFall(int colChoice, PlayerInfo player)
        {
            bool end = false;
            while(end != true)
            {
                for (int i = 6; i >= 1; i--)
                {
                    if (_board.getGrid[colChoice, i] != 'X' && _board.getGrid[colChoice, i] != 'O')
                    {
                        _board.getGrid[colChoice, i] = player.getPlayerchip;
                        end = true;
                        break;
                    }
                }
            }
        }
    }
}