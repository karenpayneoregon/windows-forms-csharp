using System;

namespace ConfigurationMultipleEnvironments.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Convert a string value to an enum member with default value
        /// </summary>
        /// <typeparam name="TEnum">Enum to base conversion too</typeparam>
        /// <param name="enumValue">Valid enum member for TEnum</param>
        /// <param name="defaultValue">Default member value if conversion can not be performed</param>
        /// <returns></returns>
        public static TEnum ToEnum<TEnum>(this string enumValue, TEnum defaultValue) =>
            !Enum.IsDefined(typeof(TEnum), enumValue) ? defaultValue : (TEnum)Enum.Parse(typeof(TEnum), enumValue);
    }
}