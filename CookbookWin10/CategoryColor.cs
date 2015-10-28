﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace CookbookWin10
{
    class CategoryColor
    {
        public static int SPANISH = 0;
        public static int FRENCH = 1;

        public static SolidColorBrush[,] sets = {
            //Spanish
            { (new SolidColorBrush(Color.FromArgb(255, 214, 78, 32))), (new SolidColorBrush(Color.FromArgb(255, 255, 119, 8))), (new SolidColorBrush(Color.FromArgb(255, 255, 193, 8))), (new SolidColorBrush(Color.FromArgb(255, 247, 5, 5))) },
            //French
            { (new SolidColorBrush(Color.FromArgb(255, 58, 14, 232))), (new SolidColorBrush(Color.FromArgb(255, 149, 64, 201))), (new SolidColorBrush(Color.FromArgb(255, 209, 52, 0))), (new SolidColorBrush(Color.FromArgb(255, 227, 9, 9))) }
        };
    }
}
