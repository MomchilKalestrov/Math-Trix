using System;
using System.Windows.Forms;
using System.Drawing;

namespace MathTrix
{
    public partial class Window : Form
    {
        // Board data.
        private UInt16 _columns = 4;
        private UInt16 _rows = 4;

        private UInt16 _btnWidth;
        private UInt16 _btnHeight;

        // Player data.
        private Boolean _turn = true;
        private UInt16 _p1X = 0;
        private UInt16 _p1Y = 0;
        private Int32 _p1Score = 0;
        private Color _p1Backcolour = Color.White;
        private Color _p1Forecolour = Color.Black;

        private UInt16 _p2X = 0;
        private UInt16 _p2Y = 0;
        private Int32 _p2Score = 0;
        private Color _p2Backcolour = Color.White;
        private Color _p2Forecolour = Color.Black;

        // Bot data.
        private Int32 _max = Int32.MinValue;
        private Int32 _maxX = -1;
        private Int32 _maxY = -1;
        private Boolean _botOpponent = false;

        // Misc
        private Boolean _boardGenerated = false;
        private Tile[,] _tiles;

        public Window()
        {
            InitializeComponent();
        }

        // Resizes all buttons so that they fit the whole playable area.
        private void ResizeWindow(object sender, EventArgs e)
        {
            if (!_boardGenerated)
                return;

            _btnWidth = (UInt16)(mainContainer.Panel2.Width / _columns);
            _btnHeight = (UInt16)(mainContainer.Panel2.Height / _rows);

            for (int i = 0; i < _columns; i++)
                for (int j = 0; j < _rows; j++)
                {
                    _tiles[i, j].Size = new Size(_btnWidth, _btnHeight);
                    _tiles[i, j].Location = new Point(_btnWidth * i, _btnHeight * j);
                    _tiles[i, j].Font = new Font("Segoe UI", Math.Min(_btnWidth, _btnHeight) / 4);
                }
        }

        // Generates a board with the given paramaters from the "customize" Form.
        private void GenerateBoard(object sender, EventArgs e)
        {
            // Gets the user given paramaters from the "customize" Form.
            Customize customize = new Customize();
            if (customize.ShowDialog() == DialogResult.OK)
            {
                _columns = customize.Columns;
                _rows = customize.Rows;

                _p1Backcolour = customize.P1Colour;
                _p1Forecolour = customize.P1FontColour;

                _p2Backcolour = customize.P2Colour;
                _p2Forecolour = customize.P2FontColour;

                _botOpponent = customize.AIOpponent;
            }

            // Checks if there's already a board and removes it if true.
            if (_boardGenerated)
                DisposeBoard();

            _boardGenerated = true;

            // Calculates the button dimentions.
            _btnWidth = (UInt16)(mainContainer.Panel2.Width / _columns);
            _btnHeight = (UInt16)(mainContainer.Panel2.Height / _rows);

            // Creates an instance of an array of the "Tile" Control. It is used as a playing field/ board.
            _tiles = new Tile[_columns, _rows];

            // Sets the default paramaters for the tiles.
            for (UInt16 i = 0; i < _columns; i++)
                for (UInt16 j = 0; j < _rows; j++)
                {
                    _tiles[i, j] = new Tile(_columns, _rows, i, j);
                    _tiles[i, j].Size = new Size(_btnWidth, _btnHeight);
                    _tiles[i, j].Location = new Point(_btnWidth * i, _btnHeight * j);
                    _tiles[i, j].Click += new EventHandler(ButtonClicked);
                    _tiles[i, j].Text = $"{_tiles[i, j].Operation} {_tiles[i, j].Number}";
                    _tiles[i, j].Font = new Font("Segoe UI", Math.Min(_btnWidth, _btnHeight) / 4);
                    mainContainer.Panel2.Controls.Add(_tiles[i, j]);
                }

            // Sets the player's starting locations.
            p1ScoreLabel.Text = "P1: 0";
            _p1X = 0;
            _p1Y = 0;
            _tiles[_p1X, _p1Y].Enabled = false;
            _tiles[_p1X, _p1Y].Text = "P1";
            _p1Score = 0;
            _tiles[_p1X, _p1Y].ForeColor = _p1Forecolour;
            _tiles[_p1X, _p1Y].BackColor = _p1Backcolour;
            
            p2ScoreLabel.Text = "P2: 0";
            _p2X = Convert.ToUInt16(_tiles.GetLength(0) - 1);
            _p2Y = Convert.ToUInt16(_tiles.GetLength(1) - 1);
            _tiles[_p2X, _p2Y].Enabled = false;
            _tiles[_p2X, _p2Y].Text = "P2";
            _p2Score = 0;
            _tiles[_p2X, _p2Y].ForeColor = _p2Forecolour;
            _tiles[_p2X, _p2Y].BackColor = _p2Backcolour;

            _turn = true;
        }

        // Gets called when a Tile in the board is pressed.
        private void ButtonClicked(object sender, EventArgs e)
        {
            // Sets the current Tile as a variable named "tile" for easier readability.
            Tile tile = (Tile)sender;

            // Checks for available cells to move into and ends the game if there aren't any.
            if (!CheckForCells())
            {
                EndGame(sender, e);
                return;
            }

            if (_turn)
            {
                // Gets the length between the player's location and the current Tile location.
                UInt16 xDiff = Convert.ToUInt16(Math.Abs(_p1X - tile.X));
                UInt16 yDiff = Convert.ToUInt16(Math.Abs(_p1Y - tile.Y));

                // Checks if the player's Tile is next to the current Tile and if the current Tile hasn't been used.
                if (xDiff <= 1 && yDiff <= 1 && tile.Enabled)
                {
                    // Sets the old player's Tile to indicate it has been used.
                    _tiles[_p1X, _p1Y].Text = "X";
                    _tiles[_p1X, _p1Y].Enabled = false;
                    _p1X = tile.X;
                    _p1Y = tile.Y;

                    // Sets the player's Tile to the current Tile.
                    _tiles[_p1X, _p1Y].Text = "P1";
                    _tiles[_p1X, _p1Y].Enabled = false;
                    _tiles[_p1X, _p1Y].ForeColor = _p1Forecolour;
                    _tiles[_p1X, _p1Y].BackColor = _p1Backcolour;

                    // Calculates the score and updates the label that shows it.
                    tile.Calculate(ref _p1Score);
                    p1ScoreLabel.Text = "P1: " + _p1Score;

                    _turn = !_turn;
                }

                // When the player has moved into a cell and he is playing against a bot, the AI will select a Tile and move into it.
                if (_botOpponent)
                {
                    Point bestTile = GetBestOutcome();
                    _tiles[bestTile.X, bestTile.Y].PerformClick();
                }
            }
            else
            {
                // Gets the length between the player's location and the current Tile location.
                UInt16 xDiff = Convert.ToUInt16(Math.Abs(_p2X - tile.X));
                UInt16 yDiff = Convert.ToUInt16(Math.Abs(_p2Y - tile.Y));

                // Checks if the player's Tile is next to the current Tile and if the current Tile hasn't been used.
                if (xDiff <= 1 && yDiff <= 1 && tile.Enabled)
                {
                    // Sets the old player's Tile to indicate it has been used.
                    _tiles[_p2X, _p2Y].Text = "X";
                    _tiles[_p2X, _p2Y].Enabled = false;
                    _p2X = tile.X;
                    _p2Y = tile.Y;

                    // Sets the player's Tile to the current Tile.
                    _tiles[_p2X, _p2Y].Text = "P2";
                    _tiles[_p2X, _p2Y].Enabled = false;
                    _tiles[_p2X, _p2Y].ForeColor = _p2Forecolour;
                    _tiles[_p2X, _p2Y].BackColor = _p2Backcolour;

                    // Calculates the score and updates the label that shows it.
                    tile.Calculate(ref _p2Score);
                    p2ScoreLabel.Text = "P2: " + _p2Score;

                    _turn = !_turn;
                }
            }
        }
    }
}
