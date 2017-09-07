﻿using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertUInt64ExtensionsTests
    {
        [TestCaseSource(typeof(ConvertUInt64ExtensionsTestsSource), "IsUInt64")]
        public bool Test_IsUInt64(string text)
        {
            var result = text.IsUInt64();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt64ExtensionsTestsSource), "ToUInt64")]
        public ulong Test_ToUInt64(string text)
        {
            var result = text.ToUInt64();

            return result;
        }

        [TestCaseSource(typeof(ConvertUInt64ExtensionsTestsSource), "ToUInt64Throws")]
        public bool Test_ToUInt64_Throws(string text)
        {
            try
            {
                text.ToUInt64();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertUInt64ExtensionsTestsSource), "ToUInt64WithDefault")]
        public ulong Test_ToUInt64_with_default(string text, ulong defaultValue)
        {
            var result = text.ToUInt64(defaultValue);

            return result;
        }
    }
}