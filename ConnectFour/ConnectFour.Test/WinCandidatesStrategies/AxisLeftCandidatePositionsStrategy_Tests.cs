﻿using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinLogic.WinCandidatesStrategies;
using FluentAssertions;
using Xunit;

namespace ConnectFour.Test.WinCandidatesStrategies
{
    public class AxisLeftCandidatePositionsStrategy_Tests
    {
        public static IEnumerable<object[]> GetPoints()
        {
            yield return new object[]
            {
                new Point(5, 1),
                new List<Point>()
                {
                    new Point(5,1),
                    new Point(4,2),
                    new Point(3,3),
                    new Point(2,4)
                }
            };

            yield return new object[]
            {
                new Point(4, 1),
                new List<Point>()
                {
                    new Point(4,1),
                    new Point(3,2),
                    new Point(2,3),
                    new Point(1,4)
                }
            };

            yield return new object[]
            {
                new Point(3, 1),
                new List<Point>()
                {
                    new Point(3,1),
                    new Point(2,2),
                    new Point(1,3),
                    new Point(0,4)
                }
            };

            yield return new object[]
            {
                new Point(4, 2),
                new List<Point>()
                {
                    new Point(4,2),
                    new Point(3,3),
                    new Point(2,4),
                    new Point(1,5)
                }
            };

            yield return new object[]
            {
                new Point(2, 1),
                default
            };

            yield return new object[]
            {
                new Point(1, 1),
                default
            };

            yield return new object[]
            {
                new Point(0, 1),
                default
            };

            yield return new object[]
            {
                new Point(5, 5),
                default
            };

            yield return new object[]
            {
                new Point(4, 4),
                default
            };

            yield return new object[]
            {
                new Point(3, 3),
                default
            };
        }

        [Theory]
        [MemberData(nameof(GetPoints))]
        public void GetCandidates_WhenCalled_ShouldReturnExpectedValues(Point currentPosition, List<Point> expectedResult)
        {
            var sut = new AxisLeftCandidatePositionsStrategy(6, 6);

            var candidates = sut.GetCandidates(currentPosition);
            candidates.Should().BeEquivalentTo(expectedResult);
        }
    }
}
