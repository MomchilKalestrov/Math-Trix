using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrix
{
    public partial class Customize : Form
    {
        public UInt16 Columns = 4;
        public UInt16 Rows = 4;

        public Boolean AIOpponent;

        public Color P1Colour = Color.White;
        public Color P1FontColour = Color.Black;
        public Color P2Colour = Color.White;
        public Color P2FontColour = Color.Black;

        public Customize()
        {
            InitializeComponent();
        }

        // Sends the data for the board back to the main window.
        private void returnData(object sender, EventArgs e)
        {
            Columns = Convert.ToUInt16(xNumericUpDown.Value);
            Rows = Convert.ToUInt16(yNumericUpDown.Value);
            AIOpponent = botOpponentCheckBox.Checked;
            Console.WriteLine(AIOpponent ? "An opponent so soon? Well, if it is your will I shall play...." : "");
            DialogResult = DialogResult.OK;
            Close();
        }

        // Sets the background colour for P1's tiles.
        private void p1PickColourButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                P1Colour = colorDialog.Color;

            Byte invR = Convert.ToByte(255 - P1Colour.R);
            Byte invG = Convert.ToByte(255 - P1Colour.G);
            Byte invB = Convert.ToByte(255 - P1Colour.B);

            if ((invR + invG + invB) / 3 < 127)
                P1FontColour = Color.White;
            else
                P1FontColour = Color.Black;

            p1ColourPreview.BackColor = P1Colour;
        }

        // Sets the background colour for P2's tiles.
        private void p2PickColourButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                P2Colour = colorDialog.Color;

            Byte invR = Convert.ToByte(255 - P2Colour.R);
            Byte invG = Convert.ToByte(255 - P2Colour.G);
            Byte invB = Convert.ToByte(255 - P2Colour.B);

            if ((invR + invG + invB) / 3 < 127)
                P2FontColour = Color.White;
            else
                P2FontColour = Color.Black;

            p2ColourPreview.BackColor = P2Colour;
        }
    }
}
