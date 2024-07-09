﻿namespace Fluxera.Guards
{
	using System;
#if NET7_0_OR_GREATER
	using System.Numerics;
#endif
	using System.Runtime.CompilerServices;
	using JetBrains.Annotations;
	using static ExceptionHelpers;

	/// <summary>
	///     Contains common numeric guard extensions methods.
	/// </summary>
	[PublicAPI]
	public static class GuardAgainstNegativeExtensions
	{
#if NET7_0_OR_GREATER
		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static T Negative<T>(this IGuard guard, T input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null) where T : INumber<T>
		{
			ArgumentNullException.ThrowIfNull(guard);

			if(T.IsNegative(input))
			{
				throw CreateArgumentException(parameterName, message ?? "Value cannot be negative.");
			}

			return input;
		}
#endif

#if NET6_0
		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static byte Negative(this IGuard guard, byte input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static short Negative(this IGuard guard, short input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static int Negative(this IGuard guard, int input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static long Negative(this IGuard guard, long input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static decimal Negative(this IGuard guard, decimal input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static float Negative(this IGuard guard, float input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static double Negative(this IGuard guard, double input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			return Negative(input, parameterName, message);
		}

		/// <summary>
		///     Checks if the input is negative.
		/// </summary>
		private static T Negative<T>(T input, string parameterName, string message = null)
			where T : struct, IComparable, IComparable<T>
		{
			if(input.CompareTo(default) < 0)
			{
				throw CreateArgumentException(parameterName, message ?? "Value cannot be negative.");
			}

			return input;
		}
#endif

		/// <summary>
		///     Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is negative.
		/// </summary>
		/// <param name="guard">The extension endpoint.</param>
		/// <param name="input">The value of the input.</param>
		/// <param name="parameterName">The name of the input parameter.</param>
		/// <param name="message">The optional custom error message.</param>
		/// <returns>The <paramref name="input" />, if the checks were successful.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="input" /> is negative.</exception>
		public static TimeSpan Negative(this IGuard guard, TimeSpan input, [InvokerParameterName] [CallerArgumentExpression(nameof(input))] string parameterName = null, string message = null)
		{
			ArgumentNullException.ThrowIfNull(guard);

			if(input < TimeSpan.Zero)
			{
				throw CreateArgumentException(parameterName, message ?? "Value cannot be negative.");
			}

			return input;
		}
	}
}
