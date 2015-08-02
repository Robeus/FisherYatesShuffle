using System;
using System.Collections.Generic;

namespace FisherYatesShuffle
{
	public static class FisherYatesShuffle
	{
		/// <summary>
		/// Random number generator
		/// </summary>
		private static Random random = new Random();

		/// <summary>
		/// Shuffles the collection items by the Fisher-Yates algorithm
		/// </summary>
		/// <typeparam name="T">Type of the IList</typeparam>
		/// <param name="collection">The collection for shuffle</param>
		public static void Shuffle<T>(this IList<T> collection)
		{
			int n = collection.Count;
			for (int i = n - 1; i > 1; i--)
			{
				int j = random.Next(i + 1);
				collection.Swap(i, j);
			}
		}

		/// <summary>
		/// Swaps the two items of the collection
		/// </summary>
		/// <typeparam name="T">Type of the IList</typeparam>
		/// <param name="collection">The collection for swap</param>
		/// <param name="indexA">The index of the first item</param>
		/// <param name="indexB">The index of the second item</param>
		public static void Swap<T>(this IList<T> collection, int indexA, int indexB)
		{
			T temp = collection[indexA];
			collection[indexA] = collection[indexB];
			collection[indexB] = temp;
		}
	}
}
