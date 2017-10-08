using System;
using System.Collections.Generic;

namespace Valit
{
    public static class ValitRuleByteExtensions
    {
        public static IValitRule<TObject, byte> IsGreaterThan<TObject>(this IValitRule<TObject, byte> rule, byte value)  where TObject : class
            => rule.Satisfies(p =>  p > value);
         

        public static IValitRule<TObject, byte> IsLessThan<TObject>(this IValitRule<TObject, byte> rule, byte value)  where TObject : class
            => rule.Satisfies(p =>  p < value);
                  

        public static IValitRule<TObject, byte> IsEqualTo<TObject>(this IValitRule<TObject, byte> rule, byte value) where TObject : class
            => rule.Satisfies(p =>  p < value);

        public static IValitRule<TObject, byte> IsNonZero<TObject>(this IValitRule<TObject, byte> rule) where TObject : class
            => rule.Satisfies(p =>  Math.Sign(p) != 0);
    }
}