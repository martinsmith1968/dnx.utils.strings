// Code generated by a Template
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNX.Helpers.Maths.BuiltInTypes
{
    /// <summary>
    /// Class MathsDoubleExtensions.
    /// </summary>
    public static class MathsDoubleExtensions
    {
        /// <summary>
        /// Determines whether the specified value is inclusively between min and max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns><c>true</c> if the specified minimum is between min and max; otherwise, <c>false</c>.</returns>
        public static bool IsBetween(this double value, double min, double max)
        {
            return value.IsBetween(min, max, IsBetweenBoundsType.Inclusive);
        }

        /// <summary>
        /// Determines whether the specified value is between min and max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="boundsType">Control boundary checking.</param>
        /// <returns><c>true</c> if the specified minimum is between; otherwise, <c>false</c>.</returns>
        public static bool IsBetween(this double value, double min, double max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, false, boundsType);
        }

        /// <summary>
        /// Determines whether the specified value is inclusively between the smaller of min and max and the larger of min and max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns><c>true</c> if the specified minimum is between min and max; otherwise, <c>false</c>.</returns>
        public static bool IsBetweenEither(this double value, double min, double max)
        {
            return value.IsBetweenEither(min, max, IsBetweenBoundsType.Inclusive);
        }

        /// <summary>
        /// Determines whether the specified value is between the smaller of min and max and the larger of min and max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="boundsType">Control boundary checking.</param>
        /// <returns><c>true</c> if [is between either] [the specified minimum]; otherwise, <c>false</c>.</returns>
        public static bool IsBetweenEither(this double value, double min, double max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, true, boundsType);
        }

        /// <summary>
        /// Determines whether the specified value is between min and max with full control over bounds checking.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="allowEitherOrder">if set to <c>true</c> allow min/max in either order.</param>
        /// <param name="boundsType">Control boundary checking.</param>
        /// <returns><c>true</c> if the specified minimum is between min and max; otherwise, <c>false</c>.</returns>
        public static bool IsBetween(this double value, double min, double max, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            var lowerBound = GetLowerBound(min, max, allowEitherOrder);
            var upperBound = GetUpperBound(min, max, allowEitherOrder);

            switch (boundsType)
            {
                case IsBetweenBoundsType.IncludeLowerAndUpper:
                    return (value >= lowerBound) && (value <= upperBound);

                case IsBetweenBoundsType.ExcludeLowerAndUpper:
                    return (value > lowerBound) && (value < upperBound);

                case IsBetweenBoundsType.IncludeLowerExcludeUpper:
                    return (value >= lowerBound) && (value < upperBound);

                case IsBetweenBoundsType.ExcludeLowerIncludeUpper:
                    return (value > lowerBound) && (value <= upperBound);

                default:
                    return false;
            }
        }

        /// <summary>
        /// Gets the lower bound.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="allowEitherOrder">if set to <c>true</c> allow min/max in either order</param>
        /// <returns>double</returns>
        public static double GetLowerBound(double min, double max, bool allowEitherOrder)
        {
            return allowEitherOrder
                ? min < max
                    ? min
                    : max
                : min;
        }

        /// <summary>
        /// Gets the upper bound.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="allowEitherOrder">if set to <c>true</c> allow min/max in either order</param>
        /// <returns>double</returns>
        public static double GetUpperBound(double min, double max, bool allowEitherOrder)
        {
            return allowEitherOrder
                ? max > min
                    ? max
                    : min
                : max;
        }
            }
}
