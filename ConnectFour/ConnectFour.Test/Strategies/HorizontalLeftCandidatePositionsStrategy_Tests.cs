﻿using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;
using ConnectFour.Strategy;
using FluentAssertions;
using Xunit;

namespace ConnectFour.Test.Strategies
{
    public class HorizontalLeftCandidatePositionsStrategy_Tests
    {
        public static IEnumerable<object[]> GetPoints()
        {
            yield return new object[]
            {
                new Point(5, 1),
                new List<Point>()
                {
                    new Point(5,1),
                    new Point(4,1),
                    new Point(3,1),
                    new Point(2,1)
                }
            };

            yield return new object[]
            {
                new Point(4, 1),
                new List<Point>()
                {
                    new Point(4,1),
                    new Point(3,1),
                    new Point(2,1),
                    new Point(1,1)
                }
            };

            yield return new object[]
            {
                new Point(3, 1),
                new List<Point>()
                {
                    new Point(3,1),
                    new Point(2,1),
                    new Point(1,1),
                    new Point(0,1)
                }
            };

            yield return new object[]
            {
                new Point(2, 1),
                new List<Point>()
            };

            yield return new object[]
            {
                new Point(1, 1),
                new List<Point>()
            };

            yield return new object[]
            {
                new Point(0, 1),
                new List<Point>()
            };
        }

        [Theory]
        [MemberData(nameof(GetPoints))]
        public void GetCandidates_WhenCalled_ShouldReturnExpectedValues(Point currentPosition, List<Point> expectedResult)
        {
            var sut = new HorizontalLeftCandidatePositionsStrategy(6, 6);

            var candidates = sut.GetCandidates(currentPosition);
            candidates.Should().BeEquivalentTo(expectedResult);
        }
    }
}