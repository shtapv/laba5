using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AvaloniaPaint.Models;

namespace AvaloniaPaint.Models.Serializer
{
    public class XMLSaver : IShapeSaver
    {
        public void Save(IEnumerable<PaintBaseFigure> figures, string path)
        {
            var figureTree=new XElement("FiguresTree");
            foreach (IEnumerable<PaintBaseFigure> figure in figures)
            {
                if(figure is PaintLine) {
                    var tmpfigure = figure as PaintLine;
                    if(tmpfigure != null) {
                        figureTree = new XElement("Line",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("StartPoint", tmpfigure.StartPoint),
                            new XElement("EndPoint", tmpfigure.EndPoint)
                        );
                        figureTree.Add(path);
                    }
                }
            }
            figureTree.Save(path);
        }
    }
}
