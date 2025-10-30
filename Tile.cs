using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MathTrix;

public class Tile : Button
{
    // This is the absolute same as a normal button, except for the Enum and Int16, and calculate.

    // Parameterless constructor needed for the WinForms designer
    public Tile()
    {
        // Provide safe defaults for design-time support
        _x = 0;
        _y = 0;
        _number = 1;
        _operation = OperationList.Add;
    }

    public Tile(ushort columns, ushort rows, ushort x, ushort y)
    {
        Random rand = new();

        ushort from = (ushort)(columns / 4);
        ushort to = (ushort)(columns * rows / 4);

        _x = x;
        _y = y;

        _number = (ushort)rand.Next(from, to);
        byte eq = Convert.ToByte(rand.Next(0, 3));
        _operation = (OperationList)eq;
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
            char[] types = ['+', '-', '*', '/'];
            return types[(byte)_operation];
        }
    }

    private OperationList _operation;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ushort Number
    {
        get => _number;
        set => _number = value;
    }

    private ushort _number;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ushort X
    {
        get => _x;
    }

    private ushort _x;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ushort Y
    {
        get => _y;
    }

    private ushort _y;

    public void Calculate(ref int score)
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

    public int BotCalculate(int score)
    {
        return _operation switch
        {
            OperationList.Add => score + _number,
            OperationList.Remove => score - _number,
            OperationList.Multiply => score * _number,
            OperationList.Divide => score / _number,
            _ => -1,
        };
    }
}
