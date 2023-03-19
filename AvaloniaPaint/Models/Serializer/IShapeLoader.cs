using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaPaint.Models;

namespace AvaloniaPaint.Models.Serializer
{
    public interface IShapeLoader
    {
        void Load(IEnumerable<PaintBaseFigure> figures, string path);
    }
}
