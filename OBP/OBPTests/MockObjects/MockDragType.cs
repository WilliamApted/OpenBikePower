using OBP;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBPTests.MockObjects
{
    class MockDragType : iDragType
    {
        public float returnValue;

        public MockDragType(float returnValue)
        {
            this.returnValue = returnValue;
        }

        public float GetDragCoefficientArea()
        {
            return returnValue;
        }
    }
}
