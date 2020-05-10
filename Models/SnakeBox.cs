using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaWF.Models
{
    class SnakeBox : Button
    {
        public SnakeBox()
        {
            this.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = true;
            this.Enabled = false;
        }

        public SnakeBox(Point position, int width = 15)
        {
            this.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Location = new System.Drawing.Point(position.X, position.Y);
            this.Size = new System.Drawing.Size(width, width);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = true;
            this.Enabled = false;
        }
    }

    class Food : Button
    {
        public Food(Point pos)
        {

            this.BackColor = System.Drawing.Color.Chartreuse;
            this.Enabled = false;
            this.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Location = pos;
            this.Name = "snakeBox3";
            this.Size = new System.Drawing.Size(15, 15);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = false;
        }
    }
}
