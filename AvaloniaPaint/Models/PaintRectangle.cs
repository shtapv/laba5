﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Media;
using SkiaSharp;

namespace AvaloniaPaint.Models
{
    public class PaintRectangle : PaintBaseFigure
    {
        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }
        private int width;
        public int Width 
        {
            get => width;
            set => width = value;
        }
        private Point startPoint;
        public Point StartPoint
        {
            get => startPoint;
            set => startPoint = value;
        }

        private Color fillColor;
        public Color FillColor
        {
            get => fillColor;
            set => fillColor = value;
        }
    }
}
