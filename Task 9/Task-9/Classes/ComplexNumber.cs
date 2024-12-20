using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class ComplexNumber
    {
        #region Attributes & Properties
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion

        #region Override * 
        public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) * (Right?.Real ?? 0) - (Left?.Imag ?? 0) * (Right?.Imag ?? 0),
                Imag = (Left?.Real ?? 0) * (Right?.Imag ?? 0) + (Left?.Imag ?? 0) * (Right?.Real ?? 0),
            };
        }
        #endregion
        
    }
}
