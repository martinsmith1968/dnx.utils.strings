﻿using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertUInt16ExtensionsTests
    {
        [TestCaseSource(typeof(ConvertUInt16ExtensionsTestsSource), "IsUInt16")]
        public bool Test_IsUInt16(string text)
        {
            var result = text.IsUInt16();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt16ExtensionsTestsSource), "ToUInt16")]
        public ushort Test_ToUInt16(string text)
        {
            var result = text.ToUInt16();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt16ExtensionsTestsSource), "ToUInt16Throws")]
        public bool Test_ToUInt16_Throws(string text)
        {
            try
            {
                text.ToUInt16();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertUInt16ExtensionsTestsSource), "ToUInt16WithDefault")]
        public ushort Test_ToUInt16_with_default(string text, ushort defaultValue)
        {
            var result = text.ToUInt16(defaultValue);

            return result;
        }
    }
}
