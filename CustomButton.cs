using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CinemaWF
{
    class CustomButton : Button
    {
        private Color defaultBackColor = Color.Aqua;
        private bool isDragging = false;
        private Point dragStartDiffrenceWithCursor;

        public CustomButton(int x = 0, int y = 0)
        {

            this.Width = 100;
            this.Height = 100;
            this.BackColor = defaultBackColor;

            if (x != 0 || 0 != y)
            {
                this.Left = x;
                this.Top = y;
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            this.BackColor = Color.White;

            isDragging = true;
            dragStartDiffrenceWithCursor = new Point(Cursor.Position.X - this.Left, Cursor.Position.Y - this.Top);

            base.OnMouseDown(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (isDragging)
            {
                this.Left = (Cursor.Position.X - dragStartDiffrenceWithCursor.X);
                this.Top = (Cursor.Position.Y - dragStartDiffrenceWithCursor.Y);
            }

            base.OnMouseMove(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.BackColor = defaultBackColor;

            isDragging = false;

            base.OnMouseUp(mevent);
        }
    }
}
