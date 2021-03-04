using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyWorld
{

    public partial class Form1 : Form
    {
        private int currentGen = 0;
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows, cols;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            currentGen = 0;
            Text = $"Generation = {currentGen}";
            nuResolution.Enabled = false;
            nuDensity.Enabled = false;
            resolution = (int)nuResolution.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            field = new bool[cols, rows];

            /*Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nuDensity.Value) == 0;
                }
            }*/



            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }


        private void NextGen()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 2)
                        newField[x, y] = true;
                    else if (hasLife && (neighboursCount < 1 || neighboursCount > 2))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];

                    if (hasLife)
                        graphics.FillRectangle(Brushes.Green, x * resolution, y * resolution, resolution, resolution);
                }
            }
            field = newField; 
            pictureBox1.Refresh();
            Text = $"Generation = {++currentGen}";
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;    
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isSelfChecking)
                        count++;

                }
            }
            return count;
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            nuResolution.Enabled = true;
            nuDensity.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if(e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    field[x, y] = true;

            }   

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    field[x, y] = false;
            }
        }

        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Generation = {currentGen}";
        }

        private void bDisease_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    field[x, y] = random.Next((int)nuDensity.Value) == 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
