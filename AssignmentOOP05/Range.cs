using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
            }

            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(int))
            {
                return Convert.ToInt32(Maximum) - Convert.ToInt32(Minimum);
            }
            else if (typeof(T) == typeof(double))
            {
                return Convert.ToDouble(Maximum) - Convert.ToDouble(Minimum);
            }
            else if (typeof(T) == typeof(decimal))
            {
                return Convert.ToDecimal(Maximum) - Convert.ToDecimal(Minimum);
            }
            else
            {
                throw new NotSupportedException("Length calculation is not supported for the type provided.");
            }
        }
    }
}
