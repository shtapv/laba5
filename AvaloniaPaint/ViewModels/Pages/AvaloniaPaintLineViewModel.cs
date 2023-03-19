using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Media;
using AvaloniaPaint.Models;
using ReactiveUI;
using SkiaSharp;

namespace AvaloniaPaint.ViewModels.Pages
{
    public class AvaloniaPaintLineViewModel : PaintShape
    {
        public override string ViewName => "Прямая линия";

        private string name;
        public string Name
        {
            get => name;
            set
            {
                this.RaiseAndSetIfChanged(ref name, value);
            }
        }
        private Point startPoint;
        public Point StartPoint
        {
            get => startPoint;
            set
            {
                this.RaiseAndSetIfChanged(ref startPoint, value);
            }
        }
        private Point endPoint;
        public Point EndPoint
        {
            get => endPoint;
            set
            {
                this.RaiseAndSetIfChanged(ref endPoint, value);
            }
        }
        private int strokeThickness;
        public int StrokeThickness
        {
            get => strokeThickness;
            set
            {
                this.RaiseAndSetIfChanged(ref strokeThickness, value);
            }
        }
        private ISolidColorBrush selectedColor;
        public ISolidColorBrush SelectedColor
        {
            get => selectedColor;
            set
            {
                this.RaiseAndSetIfChanged(ref selectedColor, value);
            }
        }

        private ObservableCollection<ISolidColorBrush> fillColors;

        public ObservableCollection<ISolidColorBrush> FillColors
        {
            get => fillColors;
            set
            {
                this.RaiseAndSetIfChanged(ref fillColors, value);
            }
        }
        public AvaloniaPaintLineViewModel()
        {
            Name = "";
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
            StrokeThickness = 1;
            selectedColor = new SolidColorBrush(Colors.White);

            var brushes = typeof(Brushes).GetProperties().Select(brush => (ISolidColorBrush)brush.GetValue(brush));
            fillColors = new ObservableCollection<ISolidColorBrush>(brushes);
        }

        public override PaintBaseFigure? GetShape()
        {
            if(Name!="")
                if (StartPoint.Y != 0 || StartPoint.X != 0 || EndPoint.X != 0 || EndPoint.Y != 0)
                    return new PaintLine()
                    {
                        Name = Name,
                        StartPoint = StartPoint,
                        EndPoint = EndPoint,
                        Stroke = SelectedColor.Color,
                        StrokeThickness = StrokeThickness
                    };
            return null;
        }
        public override Unit ClearShape()
        {
            Name = "";
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
            SelectedColor = new SolidColorBrush(Colors.White);
            StrokeThickness = 1;
            return Unit.Default;
        }
    }
}
