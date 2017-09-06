﻿using System;
using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertFloatExtensionsTests
    {
        [TestCaseSource(typeof(ConvertFloatExtensionsTestsSource), "IsFloat")]
        public bool Test_IsFloat(string text)
        {
            var result = text.IsFloat();

            return result;
        }

        [TestCaseSource(typeof(ConvertFloatExtensionsTestsSource), "ToFloat")]
        public float Test_ToFloat(string text)
        {
            var result = text.ToFloat();

            return result;
        }

        [TestCaseSource(typeof(ConvertFloatExtensionsTestsSource), "ToFloatThrows")]
        public bool Test_ToFloat_Throws(string text)
        {
            try
            {
                text.ToFloat();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertFloatExtensionsTestsSource), "ToFloatWithDefault")]
        public float Test_ToFloat_with_default(string text, float defaultValue)
        {
            var result = text.ToFloat(defaultValue);

            return result;
        }
    }
}
