﻿using DNX.Helpers.Converters.BuiltInTypes;
using DNX.Helpers.Exceptions;
using NUnit.Framework;
using Test.DNX.Helpers.Converters.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Converters.BuiltInTypes
{
    [TestFixture]
    public class ConvertSingleExtensionsTests
    {
        [TestCaseSource(typeof(ConvertSingleExtensionsTestsSource), "IsSingle")]
        public bool Test_IsSingle(string text)
        {
            var result = text.IsSingle();

            return result;
        }

        [TestCaseSource(typeof(ConvertSingleExtensionsTestsSource), "ToSingle")]
        public float Test_ToSingle(string text)
        {
            var result = text.ToSingle();

            return result;
        }

        [TestCaseSource(typeof(ConvertSingleExtensionsTestsSource), "ToSingleThrows")]
        public bool Test_ToSingle_Throws(string text)
        {
            try
            {
                text.ToSingle();
            }
            catch (ConversionException ex)
            {
                Assert.AreEqual(text, ex.Value);

                return false;
            }

            return true;
        }

        [TestCaseSource(typeof(ConvertSingleExtensionsTestsSource), "ToSingleWithDefault")]
        public float Test_ToSingle_with_default(string text, float defaultValue)
        {
            var result = text.ToSingle(defaultValue);

            return result;
        }
    }
}
