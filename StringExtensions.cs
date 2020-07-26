using System;

namespace Augmentations
{
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is neither null or an System.String.Empty string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Parses a string into an Enum
        /// </summary>
        /// <typeparam name="T">The type of the Enum</typeparam>
        /// <param name="value">String value to parse</param>
        /// <param name="ignorecase">Ignore the case of the string being parsed</param>
        /// <returns>The Enum corresponding to the stringExtensions</returns>
        public static T ToEnum<T>(this string value, bool ignorecase)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value");
            }

            value = value.Trim();

            if (value.Length == 0)
            {
                throw new ArgumentNullException("Must specify valid information for parsing in the string.", "value");
            }

            Type t = typeof(T);
            if (!t.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", "T");
            }

            return (T)Enum.Parse(t, value, ignorecase);
        }
    }
}
