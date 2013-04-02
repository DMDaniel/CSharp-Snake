using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace snake1._0._2.View
{
    public partial class SnakePiecesView : Control
    {
        public SnakePiecesView()
        {
            InitializeComponent();
            this.Visible = true;
            this.BackColor = Color.Green;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "SnakePieceView";
            this.Size = new System.Drawing.Size(10, 10);;
            this.Text = "SnakePieceView";
        }

        public SnakePiecesView(System.Drawing.Point Location)
        {
            InitializeComponent();
            this.Visible = true;
            this.BackColor = Color.Green;
            this.Location = Location;
            this.Name = "SnakePieceView";
            this.Size = new System.Drawing.Size(10, 10); ;
            this.Text = "SnakePieceView";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
