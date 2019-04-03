using System;

namespace Exercise2
{
    public class Rectangle : IComparable
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Rectangle rectangle = obj as Rectangle;
            if (rectangle != null)
            {
                if (width * height > rectangle.width * rectangle.height)
                {
                    return 1;
                }
                else if (width * height == rectangle.width * rectangle.height)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                throw new ArgumentException("The obj is not a rectangle!");
            }
        }

        public override string ToString()
        {
            return  "Width: " + width + " Height :" + height; 
        }

    }
}
