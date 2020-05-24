using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Skyhop.GribParser
{
    public abstract class TableValue : IComparable
    {
        public int Value { get; private set; }
        public string Description { get; private set; }

        protected TableValue(int value, string description)
        {
            Value = value;
            Description = description;
        }

        public override string ToString() => Description;

        public static IEnumerable<T> GetAll<T>() where T : TableValue
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as TableValue;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => Value.CompareTo(((TableValue)other).Value);

        // Other utility methods ...
    }
}
