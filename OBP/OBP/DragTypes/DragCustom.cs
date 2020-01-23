using System;
using System.Collections.Generic;
using System.Text;

namespace OBP.DragTypes
{
    class DragCustom : iDragType
    {

        public float dragCoefficient { get; set; }
        public float frontalArea { get; set; }

        public float GetDragCoefficientArea()
        {
            return dragCoefficient * frontalArea;
        }
    }
}
