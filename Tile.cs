using System.Windows.Forms;
using System;

namespace MathTrix
{
    internal class Tile : Button
    {
        // This is the absolute same as a normal button, except for the Enum and Int16, and calculate.

        public Tile(UInt16 columns, UInt16 rows, UInt16 x, UInt16 y)
        {
            Random rand = new Random();

            UInt16 from = (UInt16)(columns / 4);
            UInt16 to = (UInt16)(columns * rows / 4);

            _x = x;
            _y = y;

            _number = (UInt16)rand.Next(from, to);

            switch(rand.Next(0, 3))
            {
                case 0:
                    _equasion = EquasionList.Add;
                    break;
                case 1:
                    _equasion = EquasionList.Remove;
                    break;
                case 2:
                    _equasion = EquasionList.Multiply;
                    break;
                case 3:
                    if (_number != 0)
                        _equasion = EquasionList.Divide;
                    else
                        _equasion = EquasionList.Multiply;
                    break;
            }
        }

        public enum EquasionList
        {
            Add = 0,
            Remove = 1,
            Multiply = 2,
            Divide = 3
        }

        public char Equasion
        {
            get
            {
                char[] types = { '+', '-', '*', '/'};
                return types[(Byte)_equasion];
            }
        }

        private EquasionList _equasion;

        public UInt16 Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        private UInt16 _number;

        public UInt16 X
        {
            get
            {
                return _x;
            }
        }

        private UInt16 _x;

        public UInt16 Y
        {
            get
            {
                return _y;
            }
        }

        private UInt16 _y;

        public void Calculate(ref Int32 score)
        {
            switch (_equasion)
            {
                case EquasionList.Add:
                    score += _number;
                    break;
                case EquasionList.Remove:
                    score -= _number;
                    break;
                case EquasionList.Multiply:
                    score *= _number;
                    break;
                case EquasionList.Divide:
                    score /= _number;
                    break;
            }
        }

        public Int32 BotCalculate(Int32 score)
        {
            switch (_equasion)
            {
                case EquasionList.Add:
                    return score + _number;
                case EquasionList.Remove:
                    return score - _number;
                case EquasionList.Multiply:
                    return score * _number;
                case EquasionList.Divide:
                    return score / _number;
            }
            return -1;
        }
    }
}
