using CinemaWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaWF
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Point direction;
        //List<SnakeBox> boxes;
        int boxWidth;
        int timeCounter = -1;
        Food food;
        SnakeBox firstBox;

        public Form1()
        {
            InitializeComponent();

            boxWidth = 15;
            direction = new Point(1, 0);//x, y
            startPoint = new Point(210, 150);

            firstBox = new SnakeBox(startPoint);
            firstBox.Name = "firstBox";
            this.Controls.Add(firstBox);

            timer1.Interval = 30;
            timer1.Start();


            food = new Food(new Point(-100, -100));
            ReSpawnFood();

            this.Controls.Add(food);

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeCounter++;

            if (timeCounter % 2 == 1)
            {
                firstBox.BackColor = Color.Chartreuse;
                firstBox.FlatAppearance.BorderColor = Color.Chartreuse;
                return;
            }
            else
            {
                firstBox.BackColor = Color.Black;
                firstBox.FlatAppearance.BorderColor = Color.Black;
            }

            var boxes = this.Controls.Cast<Control>().Where(x => x.GetType().Name.Equals("SnakeBox")).ToList();

            //creating second and third box 
            if (timeCounter == 0 || timeCounter == 2)
                this.Controls.Add(new SnakeBox(startPoint));

            //box movement
            var beforeBoxPos = new Point(firstBox.Location.X, firstBox.Location.Y);
            firstBox.Location = GetNextStep(firstBox.Location);

            for (int i = 1; i < boxes.Count; i++)
            {
                var posClone = new Point(boxes[i].Location.X, boxes[i].Location.Y);
                boxes[i].Location = beforeBoxPos;
                beforeBoxPos = posClone;
            }

            //eating food
            if (firstBox.Location == food.Location)
            {
                this.Controls.Add(new SnakeBox(firstBox.Location));
                ReSpawnFood();
            }

            //losing
            if (boxes.Count(x => x.Location == firstBox.Location) > 1)
            {
                timer1.Stop();
                MessageBox.Show(":( o-<-<");
                Application.Exit();
            }
        }


        private Point GetNextStep(Point position, bool forOppositeDirection = false)
        {
            Point nextPos = position;

            if (direction.X != 0)
                nextPos.X += (direction.X * boxWidth * (forOppositeDirection ? -1 : 1));
            if (direction.Y != 0)
                nextPos.Y += (direction.Y * boxWidth * (forOppositeDirection ? -1 : 1));

            if (nextPos.X >= this.Width)
                nextPos.X = 0;
            if (nextPos.Y >= this.Height)
                nextPos.Y = 0;
            if (nextPos.X < 0)
                nextPos.X = this.Width;
            if (nextPos.Y < 0)
                nextPos.Y = this.Height;

            return nextPos;
        }

        private void ReSpawnFood()
        {
            Random rnd = new Random();
            Point pos = new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
            pos.X = pos.X - (pos.X % boxWidth);
            pos.Y = pos.Y - (pos.Y % boxWidth);

            food.Location = pos;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                direction = direction.Y == 1 ? direction : new Point(0, -1);
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                direction = direction.Y == -1 ? direction : new Point(0, 1);
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                direction = direction.X == 1 ? direction : new Point(-1, 0);
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                direction = direction.X == -1 ? direction : new Point(1, 0);

            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = !timer1.Enabled;
                panel1.Visible = !timer1.Enabled;
            }

            Timer1_Tick(null, null);
        }
    }
}
