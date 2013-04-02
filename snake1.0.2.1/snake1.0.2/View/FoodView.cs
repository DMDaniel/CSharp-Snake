using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace snake1._0._2.View
{
    public partial class FoodView : Control
    {
        public FoodView()
        {
            InitializeComponent();
            this.Visible = true;
            this.BackColor = Color.Red;
            //this.Location = new System.Drawing.Point(50, 50);
            this.Name = "SnakeFoodView";
            this.Size = new System.Drawing.Size(10, 10);;
            this.Text = "SnakeFoodView";
        }
        public FoodView(System.Drawing.Point Location)
        {
            InitializeComponent();
            this.Visible = true;
            this.BackColor = Color.Red;
            this.Location = Location;
            this.Name = "SnakeFoodView";
            this.Size = new System.Drawing.Size(10, 10);;
            this.Text = "SnakeFoodView";
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
