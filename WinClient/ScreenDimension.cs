using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinClient
{
    public class ScreenDimension
    {
        private string _title;
        private int _top;
        private int _left;
        private int _width;
        private int _height;
        private int _screenheight;
        private int _screenwidth;

        private ScreenDimension() { }

        public ScreenDimension(string t, int ti, int li, int wi, int hi)
        {
            WinTitle = t;
            TopInt = ti;
            LeftInt = li;
            WidthInt = wi;
            HeightInt = hi;
        }
        public string WinTitle { get { return _title; } set { _title = value; } }
        public int TopInt { get { return _top; } set { _top = value; } }
        public int LeftInt { get { return _left; } set { _left = value; } }
        public int WidthInt { get { return _width; } set { _width = value; } }
        public int HeightInt { get { return _height; } set { _height = value; } }
    }
}
