﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace MathTrix
{
    public partial class Window
    {
        // Gets the best outcome for the 2nd player. The method is used as an AI opponent.
        private Point GetBestOutcome()
        {
            Console.WriteLine("A thick fog is covering my view. I can only see so far...");

            _maxX = Convert.ToUInt16(Math.Abs(_p2X - 1));
            _maxY = Convert.ToUInt16(Math.Abs(_p2Y - 1));

            for (int i = _p2X - 1; i < _p2X + 2; i++)
                for (int j = _p2Y - 1; j < _p2Y + 2; j++)
                    try
                    {
                        if (i == _p2X && j == _p2Y)
                            continue;

                        Console.WriteLine($"{i} {j} {_tiles[i, j].BotCalculate(_p2Score)}");

                        if (_max <= _tiles[i, j].BotCalculate(_p2Score) && _tiles[i, j].Enabled)
                        {
                            _maxX = Convert.ToUInt16(i);
                            _maxY = Convert.ToUInt16(j);
                            _max = _tiles[i, j].BotCalculate(_p2Score);
                        }
                    }
                    catch { }

            Console.WriteLine("The fog has cleared. I can see further now...");

            return new Point(_maxX, _maxY);
        }

        // Disposes of the board.
        private void DisposeBoard()
        {
            for (int i = 0; i < _columns; i++)
                for (int j = 0; j < _rows; j++)
                    _tiles[i, j].Dispose();
            _boardGenerated = false;
            GC.Collect();
        }

        // Checks if there are any available cells to move into.
        private Boolean CheckForCells()
        {
            Tile tile = _turn ? _tiles[_p1X, _p1Y] : _tiles[_p2X, _p2Y];
            try
            {
                if (_tiles[tile.X + 1, tile.Y + 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X - 1, tile.Y + 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X + 1, tile.Y - 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X - 1, tile.Y - 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X, tile.Y + 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X, tile.Y - 1].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X + 1, tile.Y].Enabled)
                    return true;
            }
            catch { }

            try
            {
                if (_tiles[tile.X - 1, tile.Y].Enabled)
                    return true;
            }
            catch { }

            return false;
        }

        // Ends the game and declares a winner.
        private void EndGame(object sender, EventArgs e)
        {
            if (_p1Score < _p2Score)
                MessageBox.Show($"P2 wins with {_p2Score} points.");
            else if (_p2Score < _p1Score)
                MessageBox.Show($"P1 wins with {_p1Score} points.");
            else
                MessageBox.Show("The game ends with a draw.");

            DisposeBoard();
            GenerateBoard(sender, e);
        }
    }
}
