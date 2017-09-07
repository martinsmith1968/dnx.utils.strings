﻿using System;
using DNX.Helpers.Exceptions;

namespace DNX.Helpers.Converters.BuiltInTypes
{
    /// <summary>
    /// Class ConvertBoolExtensions.
    /// </summary>
    public static class ConvertInt64Extensions
    {
        /// <summary>
        /// Converts the string to a long
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>long</returns>
        /// <exception cref="DNX.Helpers.Exceptions.ConversionException">Unable to convert value to Type</exception>
        /// <remarks>Also available as an extension method</remarks>
        public static long ToInt64(this string text)
        {
            long result;

            if (!long.TryParse(text, out result))
            {
                throw new ConversionException(text, "Unable to convert value to Type", typeof(long));
            }

            return result;
        }

        /// <summary>
        /// Converts the string to a long, or returns the default value if the conversion fails
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>long</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static long ToInt64(this string text, long defaultValue)
        {
            try
            {
                var result = text.ToInt64();

                return result;
            }
            catch (ConversionException)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Determines if the string can be converted to a long or not
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><c>true</c> if the specified text is a #type; otherwise, <c>false</c>.</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static bool IsInt64(this string text)
        {
            try
            {
                text.ToInt64();

                return true;
            }
            catch (ConversionException)
            {
                return false;
            }
        }
    }
}
