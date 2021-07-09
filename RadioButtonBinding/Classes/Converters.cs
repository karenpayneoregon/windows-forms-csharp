using System;
using System.Linq.Expressions;

namespace RadioButtonBinding.Classes
{
    public static class EnumConverter<TEnum> where TEnum : struct, IConvertible
    {
        public static readonly Func<long, TEnum> Convert = GenerateConverter();

        public static Func<long, TEnum> GenerateConverter()
        {
            var parameter = Expression.Parameter(typeof(long));

            var dynamicMethod = Expression
                .Lambda<Func<long, TEnum>>(
                    Expression.Convert(parameter, typeof(TEnum)), parameter);

            return dynamicMethod.Compile();
        }
    }
}
