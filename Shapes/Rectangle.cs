using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle
    {
        public int width;
        private readonly string id;
        public Color Color { get; } = Color.White;
        private Color fillColor = Color.Aqua;

        private string name { get; set; }

        public Point TopLeftRight {
            get;
                set;
            }

        //public int Height 

        public Rectangle()
        {
            this.Color = Color.White;
            this.name = "EMC Ninja";
        }

        public Rectangle(Color color)
        {
            this.Color = color;
        }

        private void Test()
        {
            string s = name;
        }
    }
}
