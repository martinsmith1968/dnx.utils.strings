// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Maths.BuiltInTypes;
using NUnit.Framework;
using Test.DNX.Helpers.Maths.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Maths.BuiltInTypes
{
    [TestFixture]
    public class MathsFloatExtensionsTests
    {
        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "IsBetween_Default")]
        public bool IsBetween_Default(float value, float min, float max)
        {
            return value.IsBetween(min, max);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "IsBetween_BoundsType")]
        public bool IsBetween_BoundsType(float value, float min, float max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "IsBetweenEither_Default")]
        public bool IsBetweenEither_Default(float value, float min, float max)
        {
            return value.IsBetweenEither(min, max);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "IsBetweenEither_BoundsType")]
        public bool IsBetweenEither_BoundsType(float value, float min, float max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetweenEither(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "IsBetween")]
        public bool IsBetween(float value, float min, float max, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, allowEitherOrder, boundsType);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "GetLowerBound")]
        public float GetLowerBound(float min, float max, bool allowEitherOrder)
        {
            return MathsFloatExtensions.GetLowerBound(min, max, allowEitherOrder);
        }

        [TestCaseSource(typeof(MathsFloatExtensionsTestsSource), "GetUpperBound")]
        public float GetUpperBound(float min, float max, bool allowEitherOrder)
        {
            return MathsFloatExtensions.GetUpperBound(min, max, allowEitherOrder);
        }
    }
}
