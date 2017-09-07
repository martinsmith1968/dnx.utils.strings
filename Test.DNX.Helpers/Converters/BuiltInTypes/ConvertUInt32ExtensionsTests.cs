﻿using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertUInt32ExtensionsTests
    {
        [TestCaseSource(typeof(ConvertUInt32ExtensionsTestsSource), "IsUInt32")]
        public bool Test_IsUInt32(string text)
        {
            var result = text.IsUInt32();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt32ExtensionsTestsSource), "ToUInt32")]
        public uint Test_ToUInt32(string text)
        {
            var result = text.ToUInt32();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt32ExtensionsTestsSource), "ToUInt32Throws")]
        public bool Test_ToUInt32_Throws(string text)
        {
            try
            {
                text.ToUInt32();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertUInt32ExtensionsTestsSource), "ToUInt32WithDefault")]
        public uint Test_ToUInt32_with_default(string text, uint defaultValue)
        {
            var result = text.ToUInt32(defaultValue);

            return result;
        }
    }
}
