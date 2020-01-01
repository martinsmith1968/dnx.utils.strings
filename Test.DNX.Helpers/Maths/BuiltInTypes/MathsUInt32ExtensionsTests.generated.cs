// Code generated by a Template
using System;
using DNX.Helpers.Maths;
using DNX.Helpers.Maths.BuiltInTypes;
using NUnit.Framework;
using Test.DNX.Helpers.Maths.BuiltInTypes.TestsDataSource;

namespace Test.DNX.Helpers.Maths.BuiltInTypes
{
    [TestFixture]
    public class MathsUInt32ExtensionsTests
    {
        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "IsBetween_Default")]
        public bool IsBetween_Default(uint value, uint min, uint max)
        {
            return value.IsBetween(min, max);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "IsBetween_BoundsType")]
        public bool IsBetween_BoundsType(uint value, uint min, uint max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "IsBetweenEither_Default")]
        public bool IsBetweenEither_Default(uint value, uint min, uint max)
        {
            return value.IsBetweenEither(min, max);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "IsBetweenEither_BoundsType")]
        public bool IsBetweenEither_BoundsType(uint value, uint min, uint max, IsBetweenBoundsType boundsType)
        {
            return value.IsBetweenEither(min, max, boundsType);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "IsBetween")]
        public bool IsBetween(uint value, uint min, uint max, bool allowEitherOrder, IsBetweenBoundsType boundsType)
        {
            return value.IsBetween(min, max, allowEitherOrder, boundsType);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "GetLowerBound")]
        public uint GetLowerBound(uint min, uint max, bool allowEitherOrder)
        {
            return MathsUInt32Extensions.GetLowerBound(min, max, allowEitherOrder);
        }

        [TestCaseSource(typeof(MathsUInt32ExtensionsTestsSource), "GetUpperBound")]
        public uint GetUpperBound(uint min, uint max, bool allowEitherOrder)
        {
            return MathsUInt32Extensions.GetUpperBound(min, max, allowEitherOrder);
        }
    }
}
