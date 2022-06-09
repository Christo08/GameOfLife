using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Board board;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset(bool randomize = true)
        {
            board = new Board(background.Width, background.Height, (int)SizeNumder.Value);
            if (randomize)
                board.Randomize((double)DensityNud.Value / 100);
            Render();
        }
        private void Reset(string startingPattern)
        {
            string[] lines = startingPattern.Split('\n');
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;

            Reset(randomize: false);

            for (int y = 0; y < lines.Length; y++)
                for (int x = 0; x < lines[y].Length; x++)
                    board.Cells[x + xOffset, y + yOffset].isAlive = lines[y].Substring(x, 1) == "X";

            Render();
        }
        private void Render()
        {
            using (var bitmap = new Bitmap(board.Width, board.Height))
            using (var graphics = Graphics.FromImage(bitmap))
            using (var brush = new SolidBrush(rectangelsColor.BackColor))
            {
                graphics.Clear(ColorTranslator.FromHtml("#2f3539"));

                var cellSize = (GridCheckbox.Checked && board.CellSize > 1) ?
                                new Size(board.CellSize - 1, board.CellSize - 1) :
                                new Size(board.CellSize, board.CellSize);

                for (int x = 0; x < board.Columns; x++) 
                {
                    for (int y = 0; y < board.Rows; y++)
                    {
                        var cell = board.Cells[x, y];
                        if (cell.isAlive) {
                            var cellLocation = new Point(x * board.CellSize, y * board.CellSize);
                            var cellReactangles = new Rectangle(cellLocation, cellSize);
                            graphics.FillRectangle(brush, cellReactangles);
                        }
                    }
                }

                background.Image?.Dispose();
                background.Image = (Bitmap)bitmap.Clone();
            }
        }

        private void rectangelsColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                rectangelsColor.BackColor = colorPicker.Color;
            }
        }

        private void ResetButton_Clicked(object sender, EventArgs eventArgs)
        {
            Reset();
        }
        private void Background_SizeChanged(object sender, EventArgs eventArgs)
        {
            Reset();
        }
        private void SizeNumber_ValueChanged(object sender, EventArgs eventArgs)
        {
            Reset();
        }
        private void DensityNumber_ValueChanged(object sender, EventArgs eventArgs)
        {
            Reset();
        }
        private void RunCheckbox_CheckedChanged(object sender, EventArgs eventArgs)
        {
            timer1.Enabled = true;
        }
        private void DelayNumder_ValueChanged(object sender, EventArgs eventArgs)
        {
            timer1.Interval = (int)DelayNumber.Value;
        }
        private void Timer1_Tick(object sender, EventArgs eventArgs)
        {
            board.numberOfLivingCells = 0;
            board.life();
            Render();
            Console.WriteLine(board.numberOfLivingCells);
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string selectedItem = TypesCombobox.Items[TypesCombobox.SelectedIndex].ToString();
            string complexRow = "";
            switch (selectedItem)
            {
                case "Beacon":
                    complexRow ="XX--\n" +
                                "XX--\n" +
                                "--XX\n" +
                                "--XX";
                    break;
                case "Blinker":
                    complexRow = "XXX";
                    break;
                case "Custom":                
                    complexRow ="-X----X---X-XXX---XXXXX---X---\n" +
                                "-X-----X-X--X--X----X----X-X--\n" +
                                "-X------X---X---X---X---XXXXX-\n" +
                                "-X------X---X--X----X---X---X-\n" +
                                "-XXXX---X---XXX---XXXXX-X---X-";
                    break;
                case "Glider":
                    complexRow = "-X-\n" +
                                 "--X\n" +
                                 "XXX";
                    break;
                case "Gosper glider gun":
                    complexRow ="-------------------------X----------\n" +
                                "----------------------XXXX----X-----\n" +
                                "-------------X-------XXXX-----X-----\n" +
                                "------------X-X------X--X---------XX\n" +
                                "-----------X---XX----XXXX---------XX\n" +
                                "XX---------X---XX-----XXXX----------\n" +
                                "XX---------X---XX--------X----------\n" +
                                "------------X-X---------------------\n" +
                                "-------------X----------------------";
                    break;
                case "Simkin glider gun":
                    complexRow = "XX-----XX------------------------\n" +
                                 "XX-----XX------------------------\n" +
                                 "---------------------------------\n" +
                                 "----XX---------------------------\n" +
                                 "----XX---------------------------\n" +
                                 "---------------------------------\n" +
                                 "---------------------------------\n" +
                                 "---------------------------------\n" +
                                 "---------------------------------\n" +
                                 "----------------------XX-XX------\n" +
                                 "---------------------X-----X-----\n" +
                                 "---------------------X------X--XX\n" +
                                 "---------------------XXX---X-----\n" +
                                 "--------------------------X------\n" +
                                 "---------------------------------\n" +
                                 "--------------------XX-----------\n" +
                                 "--------------------X------------\n" +
                                 "---------------------XXX---------\n" +
                                 "-----------------------X---------";
                    break;
                case "Row":
                    complexRow = "XXXXXXXX-XXXXX---XXX------XXXXXXX-XXXXX";
                    break;
                case "LWSS":
                    complexRow ="-XXXX\n" +
                                "X---X\n" +
                                "----X\n" +
                                "X--X-";
                    break;
                case "HWSS":
                    complexRow = "-XXXXXX\n" +
                                "X-----X\n" +
                                "------X\n" +
                                "X----X-\n" +
                                "--XX---";
                    break;
                case "MWSS":
                    complexRow ="-XXXXX\n" +
                                "X----X\n" +
                                "-----X\n" +
                                "X---X-\n" +
                                "--X---";
                    break;
                case "Toad":
                    complexRow = "-XXX\n"+
                                 "XXX-";
                    break;
                case "Penta":
                    complexRow = "XXX\n" +
                                 "X-X\n" +
                                 "XXX\n" +
                                 "XXX\n" +
                                 "XXX\n" +
                                 "XXX\n" +
                                 "X-X\n" +
                                 "XXX";
                    break;
                case "Pulsar":
                    complexRow ="--XXX---XXX--\n" +
                                "-------------\n" +
                                "X----X-X----X\n" +
                                "X----X-X----X\n" +
                                "X----X-X----X\n" +
                                "--XXX---XXX--\n" +
                                "-------------\n" +
                                "--XXX---XXX--\n" +
                                "X----X-X----X\n" +
                                "X----X-X----X\n" +
                                "X----X-X----X\n" +
                                "-------------\n" +
                                "--XXX---XXX--";
                    break;
                default:
                    complexRow = "";
                    break;
            }
            if (complexRow != "")
                Reset(complexRow);
            else
                Reset();
        }

    }
}
