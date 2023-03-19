using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Media;
using AvaloniaPaint.Models;
using ReactiveUI;

namespace AvaloniaPaint.ViewModels.Pages
{
    public class AvaloniaPaintPathViewModel : PaintShape
    {
        public override string ViewName => "Составная фигура";

        private string name;
        public string Name
        {
            get => name;
            set
            {
                this.RaiseAndSetIfChanged(ref name, value);
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
        private ISolidColorBrush selectedFillColor;
        public ISolidColorBrush SelectedFillColor
        {
            get => selectedFillColor;
            set
            {
                this.RaiseAndSetIfChanged(ref selectedFillColor, value);
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
        private string data;
        public string Data
        {
            get => data;
            set
            {
                this.RaiseAndSetIfChanged(ref data, value);
            }
        }
        
        public AvaloniaPaintPathViewModel()
        {
            Name = "";
            StrokeThickness = 1;
            selectedColor = new SolidColorBrush(Colors.White);
            selectedFillColor = new SolidColorBrush(Colors.White);
            Data = "";

            var brushes = typeof(Brushes).GetProperties().Select(brush => (ISolidColorBrush)brush.GetValue(brush));
            fillColors = new ObservableCollection<ISolidColorBrush>(brushes);
        }
        public override Unit ClearShape()
        {
            Name = "";
            Data = "";
            SelectedColor = new SolidColorBrush(Colors.White);
            SelectedFillColor = new SolidColorBrush(Colors.White);
            StrokeThickness = 1;
            return Unit.Default;
        }

        public override PaintBaseFigure GetShape()
        {
            if (Name != "")
                if (Data!="")
                    return new PaintPath()
                    {
                        Name = Name,
                        Stroke = SelectedColor.Color,
                        FillColor = SelectedFillColor.Color,
                        StrokeThickness = StrokeThickness,
                        Data = Data,
                    };
            return null;
        }
    }
}
