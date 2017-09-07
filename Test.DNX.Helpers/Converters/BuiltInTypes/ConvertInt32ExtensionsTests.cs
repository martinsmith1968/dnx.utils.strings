﻿using System;
using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertInt32ExtensionsTests
    {
        [TestCaseSource(typeof(ConvertInt32ExtensionsTestsSource), "IsInt32")]
        public bool Test_IsInt32(string text)
        {
            var result = text.IsInt32();

            return result;
        }

        [TestCaseSource(typeof(ConvertInt32ExtensionsTestsSource), "ToInt32")]
        public Int32 Test_ToInt32(string text)
        {
            var result = text.ToInt32();

            return result;
        }

        [TestCaseSource(typeof(ConvertInt32ExtensionsTestsSource), "ToInt32Throws")]
        public bool Test_ToInt32_Throws(string text)
        {
            try
            {
                text.ToInt32();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertInt32ExtensionsTestsSource), "ToInt32WithDefault")]
        public Int32 Test_ToInt32_with_default(string text, Int32 defaultValue)
        {
            var result = text.ToInt32(defaultValue);

            return result;
        }
    }
}