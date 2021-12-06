﻿namespace Fluxera.Guard.UnitTests
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class AgainstOutOfRangeTests
	{
		[Test]
		[TestCaseSource(nameof(InRangeTestCases))]
		public void ShouldDoNothingWhenInRange(IComparable input, IComparable from, IComparable to)
		{
			Guard.Against.OutOfRange(Convert.ToByte(input), nameof(input), Convert.ToByte(from), Convert.ToByte(to));
			Guard.Against.OutOfRange(Convert.ToInt16(input), nameof(input), Convert.ToInt16(from), Convert.ToInt16(to));
			Guard.Against.OutOfRange(Convert.ToInt32(input), nameof(input), Convert.ToInt32(from), Convert.ToInt32(to));
			Guard.Against.OutOfRange(Convert.ToInt64(input), nameof(input), Convert.ToInt64(from), Convert.ToInt64(to));
			Guard.Against.OutOfRange(Convert.ToDecimal(input), nameof(input), Convert.ToDecimal(from), Convert.ToDecimal(to));
			Guard.Against.OutOfRange(Convert.ToSingle(input), nameof(input), Convert.ToSingle(from), Convert.ToSingle(to));
			Guard.Against.OutOfRange(Convert.ToDouble(input), nameof(input), Convert.ToDouble(from), Convert.ToDouble(to));
			Guard.Against.OutOfRange(TimeSpan.FromSeconds(Convert.ToInt32(input)), nameof(input), TimeSpan.FromSeconds(Convert.ToDouble(from)), TimeSpan.FromSeconds(Convert.ToDouble(to)));
		}

		[Test]
		[TestCaseSource(nameof(OutOfRangeTestCases))]
		public void ShouldThrowWhenOutOfRange(IComparable input, IComparable from, IComparable to)
		{
			((Action)(() => Guard.Against.OutOfRange(Convert.ToByte(input), nameof(input), Convert.ToByte(from), Convert.ToByte(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToInt16(input), nameof(input), Convert.ToInt16(from), Convert.ToInt16(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToInt32(input), nameof(input), Convert.ToInt32(from), Convert.ToInt32(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToInt64(input), nameof(input), Convert.ToInt64(from), Convert.ToInt64(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToDecimal(input), nameof(input), Convert.ToDecimal(from), Convert.ToDecimal(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToSingle(input), nameof(input), Convert.ToSingle(from), Convert.ToSingle(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(Convert.ToDouble(input), nameof(input), Convert.ToDouble(from), Convert.ToDouble(to)))).Should().Throw<ArgumentOutOfRangeException>();
			((Action)(() => Guard.Against.OutOfRange(TimeSpan.FromSeconds(Convert.ToInt32(input)), nameof(input), TimeSpan.FromSeconds(Convert.ToDouble(from)), TimeSpan.FromSeconds(Convert.ToDouble(to))))).Should().Throw<ArgumentOutOfRangeException>();
		}

		[Test]
		public void ShouldThrowWhenRangeIsWrong()
		{
			Action action = () => Guard.Against.OutOfRange(2, "int", 3, 1);
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		[TestCaseSource(nameof(InRangeTestCases))]
		public void ShouldReturnInputOnSuccess(int input, int from, int to)
		{
			Guard.Against.OutOfRange(input, nameof(input), from, to).Should().Be(input);
		}

		[Test]
		public void ShouldDoNothingWhenDateTimeInRange()
		{
			DateTime input = DateTime.Now;
			DateTime from = input.AddSeconds(-30);
			DateTime to = input.AddSeconds(30);

			Guard.Against.OutOfRange(input, nameof(input), from, to);
		}
	
		[Test]
		public void ShouldThrowWhenDateTimeOutOfRange()
		{
			DateTime input = DateTime.Now;
			DateTime from = input.AddSeconds(30);
			DateTime to = input.AddSeconds(60);

			Action action = () => Guard.Against.OutOfRange(input, nameof(input), from, to);
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldDoNothingWhenEnumInRange()
		{
			Guard.Against.OutOfRange(TestEnum.Two, "enum");
			Guard.Against.OutOfRange<TestEnum>(1, "enum");
		}

		[Test]
		public void ShouldThrowWhenEnumOutOfRange()
		{
			Action action1 = () => Guard.Against.OutOfRange((TestEnum)999, "enum");
			action1.Should().Throw<InvalidEnumArgumentException>();

			Action action2 = () => Guard.Against.OutOfRange<TestEnum>(999, "enum");
			action2.Should().Throw<InvalidEnumArgumentException>();
		}

		private static readonly IEnumerable<object[]> InRangeTestCases = new List<object[]>
		{
			new object[] { 1, 1, 1 },
			new object[] { 1, 1, 3 },
			new object[] { 2, 1, 3 },
			new object[] { 3, 1, 3 },
		};

		private static readonly IEnumerable<object[]> OutOfRangeTestCases = new List<object[]>
		{
			new object[] { 1, 2, 4 },
			new object[] { 0, 1, 3 },
			new object[] { 4, 1, 3 },
		};
	}
}
