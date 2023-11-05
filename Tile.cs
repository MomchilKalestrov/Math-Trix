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
            Byte eq = Convert.ToByte(rand.Next(0, 3));
            _operation = (OperationList) eq;
            if (_number == 0 && eq == 3)
                 _operation = OperationList.Multiply;
        }

        public enum OperationList
        {
            Add = 0,
            Remove = 1,
            Multiply = 2,
            Divide = 3
        }

        public char Operation
        {
            get
            {
                char[] types = { '+', '-', '*', '/'};
                return types[(Byte)_operation];
            }
        }

        private OperationList _operation;

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
            switch (_operation)
            {
                case OperationList.Add:
                    score += _number;
                    break;
                case OperationList.Remove:
                    score -= _number;
                    break;
                case OperationList.Multiply:
                    score *= _number;
                    break;
                case OperationList.Divide:
                    score /= _number;
                    break;
            }
        }

        public Int32 BotCalculate(Int32 score)
        {
            switch (_operation)
            {
                case OperationList.Add:
                    return score + _number;
                case OperationList.Remove:
                    return score - _number;
                case OperationList.Multiply:
                    return score * _number;
                case OperationList.Divide:
                    return score / _number;
            }
            return -1;
        }
    }
}
