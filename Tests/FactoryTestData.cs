using Core;
using System.Collections.Generic;

namespace Tests;

internal class FactoryTestData
{
    public static IEnumerable<object[]> RectangularTrianglePoints =>
        new List<object[]>
        {
                new object[] { new[] { new Point(1, 2), new Point(1, 1), new Point(2, 1) }},
                new object[] { new[] { new Point(1, 1), new Point(1, 2), new Point(2, 2) }},
        };

    public static IEnumerable<object[]> ImpossibleTrianglePoints =>
        new List<object[]>
        {
                new object[] { new[] { new Point(1, 2), new Point(1, 2), new Point(2, 1) }},
                new object[] { new[] { new Point(1, 1), new Point(1, 1), new Point(2, 2) }},
        };


    public static IEnumerable<object[]> BasicTrianglePoints =>
        new List<object[]>
        {
               new object[] { new[] { new Point(0, 0), new Point(1, 12), new Point(0, 2) }},
        };
}

