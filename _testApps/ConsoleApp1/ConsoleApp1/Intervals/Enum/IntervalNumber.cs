using System;

namespace ConsoleApp1.Intervals
{
    public sealed class IntervalNumber
    {
        // voir https://en.wikipedia.org/wiki/Interval_(music)
        private IntervalNumber(int value, string name, string abbreviation)
        {
            Value = value;
            Name = name;
            Abbreviation = abbreviation;
        }

        public static IntervalNumber Unison { get; }
            = new IntervalNumber(1, nameof(Unison), "unison");

        public static IntervalNumber Second { get; }
            = new IntervalNumber(2, nameof(Second), "2nd");

        public static IntervalNumber Third { get; }
            = new IntervalNumber(3, nameof(Third), "3rd");

        public static IntervalNumber Fourth { get; }
            = new IntervalNumber(4, nameof(Fourth), "4th");

        public static IntervalNumber Fifth { get; }
            = new IntervalNumber(5, nameof(Fifth), "5th");

        public static IntervalNumber Sixth { get; }
            = new IntervalNumber(6, nameof(Sixth), "6th");

        public static IntervalNumber Seventh { get; }
            = new IntervalNumber(7, nameof(Seventh), "7th");

        public static IntervalNumber Octave { get; }
            = new IntervalNumber(8, nameof(Octave), "octave");

        public int Value { get; }

        public string Name { get; }

        public string Abbreviation { get; }

        public static IntervalNumber GetNumber(int number)
        {
            if (number < 0 || number > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            switch (number)
            {
                case 1:
                    return Unison;
                case 2:
                    return Second;
                case 3:
                    return Third;
                case 4:
                    return Fourth;
                case 5:
                    return Fifth;
                case 6:
                    return Sixth;
                case 7:
                    return Seventh;
                case 8:
                    return Octave;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static IntervalNumber Inverse(IntervalNumber number)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }

            switch (number.Value)
            {
                case 1:
                    return Unison;
                case 2:
                    return Seventh;
                case 3:
                    return Third;
                case 4:
                    return Fifth;
                case 5:
                    return Fourth;
                case 6:
                    return Third;
                case 7:
                    return Second;
                case 8:
                    return Octave;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
            => Name;
    }
}


