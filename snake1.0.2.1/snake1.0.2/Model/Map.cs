using System;
using System.Collections.Generic;
using System.Text;

namespace snake1._0._2.Model
{
    class Map
    {
        private System.Drawing.Point topLeft;
        private System.Drawing.Point bottomRight;

        public static int defaultMapHeight = 400;
        public static int defaultMapWidth = 600;

        public System.Drawing.Point TopLeft
        {
            get { return this.topLeft; }
        }
        public System.Drawing.Point BottomRight
        {
            get { return this.bottomRight; }
        }
        
        public Map()
        {
            topLeft = new System.Drawing.Point(0,0);
            bottomRight = new System.Drawing.Point(defaultMapWidth, defaultMapHeight);
        }
        
        public Map(System.Windows.Forms.Panel FormPanel)
        {
            topLeft = new System.Drawing.Point(FormPanel.Bounds.X,FormPanel.Bounds.Y);
            bottomRight = new System.Drawing.Point(FormPanel.Bounds.X + FormPanel.Bounds.Width, FormPanel.Bounds.Y + FormPanel.Bounds.Height);
        }

        public void UpdateMap(System.Windows.Forms.Panel FormPanel)
        {
            topLeft =  new System.Drawing.Point(FormPanel.Bounds.X,FormPanel.Bounds.Y);
            bottomRight = new System.Drawing.Point(FormPanel.Bounds.X + FormPanel.Bounds.Width, FormPanel.Bounds.Y + FormPanel.Bounds.Height);
        }
    }
}
