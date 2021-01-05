using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    class DisplayGrid
    {
        // Attributes
        private char[,] _board;
        private int _width;
        private int _height;
        private char _reset;

        // Constructors
        public DisplayGrid(int width, int height, char resetChar)
        {
            _width = width;
            _height = height;
            _reset = resetChar;
            _board = new char[10, 10];
            Reset();
        }

        // Properties
        public char[,] getGrid
        { get { return _board; }  }

        // Methods
        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void Reset()
        {
            for (int column = 0; column < _width; column++)
            {
                for (int row = 0; row < _height; row++)
                {
                    _board[column, row] = _reset;
                }
            }
        }

        public virtual void Display()
        {
            for (int row = 0; row < _height; row++)
            {
                for (int column = 0; column < _width; column++)
                {
                    Console.Write("{0} ", _board[column, row]);
                }
                Console.WriteLine();
            }
        }
    }
}
