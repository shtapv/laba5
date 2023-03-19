using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaPaint.Models
{
    public class PaintBaseFigure
    {

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private int strokeThickness;
        public int StrokeThickness
        {
            get => strokeThickness;
            set => strokeThickness = value;
        }
        private Color stroke;
        public Color Stroke
        {
            get => stroke;
            set => stroke = value;
        }
        /*
        private string startPoint;
        public string StartPoint
        {
            get => startPoint;
            set => startPoint = value;
        }

        private string endPoint;
        public string EndPoint
        {
            get => endPoint;
            set => endPoint = value;
        }
        private string points;
        public string Points
        {
            get => points;
            set => points = value;
        }

        private Color fill;
        public Color Fill
        {
            get => fill;
            set => fill = value;
        }
        private int canvasLeft;
        public int CanvasLeft
        {
            get => canvasLeft;
            set => canvasLeft = value;
        }
        private int canvasTop;
        public int CanvasTop
        {
            get => canvasTop;
            set => canvasTop = value;
        }
        private string data;
        public string Data
        {
            get => data;
            set => data = value;
        }
        */
        public PaintBaseFigure()
        {
            this.stroke = Colors.Red;
            /*
            this.fill = Colors.Red;
            data = "";
            points = "";
            startPoint = "";
            endPoint = "";
            */
            name = "";
            strokeThickness = 1;
        }
    }
}
