namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.snakeBox2 = new Snake.Models.SnakeBox();
            this.snakeBox1 = new Snake.Models.SnakeBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.snakeBox2);
            this.panel1.Controls.Add(this.snakeBox1);
            this.panel1.Location = new System.Drawing.Point(303, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 262);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // snakeBox2
            // 
            this.snakeBox2.Enabled = false;
            this.snakeBox2.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.snakeBox2.FlatAppearance.BorderSize = 5;
            this.snakeBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.snakeBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snakeBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeBox2.ForeColor = System.Drawing.Color.LawnGreen;
            this.snakeBox2.Location = new System.Drawing.Point(153, 58);
            this.snakeBox2.Name = "snakeBox2";
            this.snakeBox2.Size = new System.Drawing.Size(50, 144);
            this.snakeBox2.TabIndex = 0;
            this.snakeBox2.UseVisualStyleBackColor = true;
            // 
            // snakeBox1
            // 
            this.snakeBox1.Enabled = false;
            this.snakeBox1.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.snakeBox1.FlatAppearance.BorderSize = 5;
            this.snakeBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.snakeBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snakeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.snakeBox1.Location = new System.Drawing.Point(86, 58);
            this.snakeBox1.Name = "snakeBox1";
            this.snakeBox1.Size = new System.Drawing.Size(50, 144);
            this.snakeBox1.TabIndex = 0;
            this.snakeBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Models.SnakeBox snakeBox1;
        private Models.SnakeBox snakeBox2;
        private System.Windows.Forms.Panel panel1;
    }
}