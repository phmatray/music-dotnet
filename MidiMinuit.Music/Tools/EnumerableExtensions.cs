/* Author :
 * Philippe Matray (From CCrossHelper)
 *
 * Date :
 * 2014-01-23, 2015-02-01
 *
 * Link :
 * http://stackoverflow.com/questions/5807128/an-extension-method-on-ienumerable-needed-for-shuffling
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Tools
{
    internal static class EnumerableExtensions
    {
        /// <summary>
        ///     Distincts by.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <returns>The distinctby collection.</returns>
        internal static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            return source.Where(element => seenKeys.Add(keySelector(element)));
        }

        /// <summary>
        ///     Shuffles the specified source.
        /// </summary>
        /// <typeparam name="T">An object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>The collection shuffled.</returns>
        internal static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var randomGenerator = new Random();
            return source.Shuffle(randomGenerator);
        }

        /// <summary>
        ///     Shuffles the specified source.
        /// </summary>
        /// <typeparam name="T">An object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="randomGenerator">The random generator.</param>
        /// <exception cref="System.ArgumentNullException">
        ///     source
        ///     or
        ///     randomGenerator
        /// </exception>
        /// <returns>The shuffled collection.</returns>
        internal static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random randomGenerator)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (randomGenerator == null)
            {
                throw new ArgumentNullException(nameof(randomGenerator));
            }

            return source.ShuffleIterator(randomGenerator);
        }

        /// <summary>
        ///     Shifts a collection to the left.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="iteration">Number of iterations.</param>
        /// <exception cref="System.ArgumentNullException">source</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">iteration</exception>
        /// <returns>The collection.</returns>
        internal static List<T> ShiftLeft<T>(this IEnumerable<T> source, int iteration = 1)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iteration < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(iteration));
            }

            var result = new List<T>(source);
            for (var i = 0; i < iteration; i++)
            {
                var first = result.First();
                result.Remove(first);
                result.Add(first);
            }

            return result;
        }

        /// <summary>
        ///     Shifts a collection to the right.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="iteration">Number of iterations.</param>
        /// <returns>The collection.</returns>
        /// <exception cref="System.ArgumentNullException">source</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">iteration</exception>
        internal static List<T> ShiftRight<T>(this IEnumerable<T> source, int iteration = 1)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iteration < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(iteration));
            }

            var result = new List<T>(source);
            for (var i = 0; i < iteration; i++)
            {
                var last = result.Last();
                result.Remove(last);
                result.Insert(0, last);
            }

            return result;
        }

        /// <summary>
        ///     Shuffles the specified source and iterates it.
        /// </summary>
        /// <typeparam name="T">An object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="randomGenerator">The random generator.</param>
        /// <returns>The shuffled collection (yield return).</returns>
        private static IEnumerable<T> ShuffleIterator<T>(this IEnumerable<T> source, Random randomGenerator)
        {
            var buffer = source.ToList();

            for (var i = 0; i < buffer.Count; i++)
            {
                var j = randomGenerator.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}