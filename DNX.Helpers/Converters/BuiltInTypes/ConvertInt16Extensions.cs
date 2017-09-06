﻿using System;
using DNX.Helpers.Exceptions;

namespace DNX.Helpers.Converters.BuiltInTypes
{
    /// <summary>
    /// Class ConvertBoolExtensions.
    /// </summary>
    public static class ConvertInt16Extensions
    {
        /// <summary>
        /// Converts the string to a short
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>short</returns>
        /// <exception cref="DNX.Helpers.Exceptions.ConversionException">Unable to convert value to Type</exception>
        /// <remarks>Also available as an extension method</remarks>
        public static short ToInt16(this string text)
        {
            short result;

            if (!short.TryParse(text, out result))
            {
                throw new ConversionException(text, "Unable to convert value to Type", typeof(short));
            }

            return result;
        }

        /// <summary>
        /// Converts the string to a short, or returns the default value if the conversion fails
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>short</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static short ToInt16(this string text, short defaultValue)
        {
            try
            {
                var result = text.ToInt16();

                return result;
            }
            catch (ConversionException)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Determines if the string can be converted to a short or not
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><c>true</c> if the specified text is a #type; otherwise, <c>false</c>.</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static bool IsInt16(this string text)
        {
            try
            {
                text.ToInt16();

                return true;
            }
            catch (ConversionException)
            {
                return false;
            }
        }
    }
}
