using System;

namespace exercise_03
{
    class Program
    {
    Console.WriteLine("Once up on a time" + "\n" +
    "I was falling in love + "\n" + "Now I'm only falling apart);
        
    }

    internal struct NewStruct
    {
        [NullableAttribute(1)]
        public object Item1;
        [NullableAttribute(1)]
        public object Item2;

        public NewStruct(object item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
                   System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item1, Item2);
        }

        public void Deconstruct(out object item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }