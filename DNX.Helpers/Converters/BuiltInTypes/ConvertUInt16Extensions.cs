﻿using System;
using DNX.Helpers.Exceptions;

namespace DNX.Helpers.Converters.BuiltInTypes
{
    /// <summary>
    /// Class ConvertBoolExtensions.
    /// </summary>
    public static class ConvertUInt16Extensions
    {
        /// <summary>
        /// Converts the string to a ushort
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>ushort</returns>
        /// <exception cref="DNX.Helpers.Exceptions.ConversionException">Unable to convert value to Type</exception>
        /// <remarks>Also available as an extension method</remarks>
        public static ushort ToUInt16(this string text)
        {
            ushort result;

            if (!ushort.TryParse(text, out result))
            {
                throw new ConversionException(text, "Unable to convert value to Type", typeof(ushort));
            }

            return result;
        }

        /// <summary>
        /// Converts the string to a ushort, or returns the default value if the conversion fails
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>ushort</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static ushort ToUInt16(this string text, ushort defaultValue)
        {
            try
            {
                var result = text.ToUInt16();

                return result;
            }
            catch (ConversionException)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Determines if the string can be converted to a ushort or not
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><c>true</c> if the specified text is a #type; otherwise, <c>false</c>.</returns>
        /// <remarks>Also available as an extension method</remarks>
        public static bool IsUInt16(this string text)
        {
            try
            {
                text.ToUInt16();

                return true;
            }
            catch (ConversionException)
            {
                return false;
            }
        }
    }
}
