using Core;
using FluentAssertions;
using System;
using System.Linq;
using Triangles;
using Xunit;

namespace Tests
{
    public class UnitTest1 : IClassFixture<FactoryFixture>
    {

        FactoryFixture fixture;

        public UnitTest1(FactoryFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [MemberData(nameof(FactoryTestData.RectangularTrianglePoints), MemberType = typeof(FactoryTestData))]
        public void CreateInstance_WithRectangularTrianlgePoints_ReturnsRectangularTriangle(Point[] points)
        {

            var actual = fixture.Factory.CreateInstance(RgbColor.Red, points);

            actual.Should().BeOfType<RectangularLegoTriangle>();


        }


        [Theory]
        [MemberData(nameof(FactoryTestData.BasicTrianglePoints), MemberType = typeof(FactoryTestData))]

        public void CreateInstance_WithTrianlgePoints_ReturnsTriangle(Point[] points)
        {

            var actual = fixture.Factory.CreateInstance(RgbColor.Red, points);

            actual.Should().BeOfType<LegoTriangle>();


        }


        [Theory]
        [MemberData(nameof(FactoryTestData.RectangularTrianglePoints), MemberType = typeof(FactoryTestData))]
        public void CreateInstance_WithRectangularTrianlgePointsAndWrongColor_ThrowsWrongColorException(Point[] points)
        {

            FluentActions
                .Invoking(() => fixture.Factory.CreateInstance(RgbColor.White, points))
                .Should()
                .ThrowExactly<WrongColorException>();
       
        }

        [Fact]
        public void CreateInstance_WithNotSuitablePointCount_ThrowsShapeNotFoundException()
        {

            FluentActions
                .Invoking(() => fixture.Factory.CreateInstance(RgbColor.White, Enumerable.Repeat(new Point(0, 0), 7).ToArray()))
                .Should()
                .ThrowExactly<ShapeNotFoundException>();

        }


        [Theory]
        [MemberData(nameof(FactoryTestData.ImpossibleTrianglePoints), MemberType = typeof(FactoryTestData))]
        public void CreateInstance_WithImpossibleTrianglePoints_ThrowsArgumentException(Point[] points)
        {

            FluentActions
                .Invoking(() => fixture.Factory.CreateInstance(RgbColor.Red, points))
                .Should()
                .ThrowExactly<ArgumentException>();

        }






    }
}