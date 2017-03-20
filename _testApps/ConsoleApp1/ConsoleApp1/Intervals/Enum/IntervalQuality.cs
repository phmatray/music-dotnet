////using System.Collections.Generic;

////namespace ConsoleApp1.Intervals
////{
////    ////public class IntervalQualityRepository
////    ////{
////    ////    public List<IntervalQuality> GetAll()
////    ////    {
            
////    ////    }

////    ////    public List<IntervalQuality> GetBySemitones()
////    ////    {
            
////    ////    }
////    ////}


////    public sealed class IntervalQuality
////    {
////        private IntervalQuality(int semitones, string name)
////        {
////            Semitones = semitones;
////            Name = name;
////        }

////        public static IntervalQuality IntervalPerfectUnison { get; }
////            = new IntervalQuality(0, nameof(IntervalPerfectUnison));

////        public static IntervalQuality IntervalPerfectFourth { get; }
////            = new IntervalQuality(5, nameof(IntervalPerfectFourth));

////        public static IntervalQuality IntervalPerfectFifth { get; }
////            = new IntervalQuality(7, nameof(IntervalPerfectFifth));

////        public static IntervalQuality IntervalPerfectOctave { get; }
////            = new IntervalQuality(12, nameof(IntervalPerfectOctave));

////        public static IntervalQuality IntervalMajorSecond { get; }
////            = new IntervalQuality(2, nameof(IntervalMajorSecond));

////        public static IntervalQuality IntervalMajorThird { get; }
////            = new IntervalQuality(4, nameof(IntervalMajorThird));

////        public static IntervalQuality IntervalMajorSixth { get; }
////            = new IntervalQuality(9, nameof(IntervalMajorSixth));

////        public static IntervalQuality IntervalMajorSeventh { get; }
////            = new IntervalQuality(11, nameof(IntervalMajorSeventh));

////        public static IntervalQuality IntervalMinorSecond { get; }
////            = new IntervalQuality(1, nameof(IntervalMinorSecond));

////        public static IntervalQuality IntervalMinorThird { get; }
////            = new IntervalQuality(3, nameof(IntervalMinorThird));

////        public static IntervalQuality IntervalMinorSixth { get; }
////            = new IntervalQuality(8, nameof(IntervalMinorSixth));

////        public static IntervalQuality IntervalMinorSeventh { get; }
////            = new IntervalQuality(10, nameof(IntervalMinorSeventh));

////        public static IntervalQuality IntervalAugmentedUnison { get; }
////            = new IntervalQuality(1, nameof(IntervalAugmentedUnison));

////        public static IntervalQuality IntervalAugmentedSecond { get; }
////            = new IntervalQuality(3, nameof(IntervalAugmentedSecond));

////        public static IntervalQuality IntervalAugmentedThird { get; }
////            = new IntervalQuality(5, nameof(IntervalAugmentedThird));

////        public static IntervalQuality IntervalAugmentedFourth { get; }
////            = new IntervalQuality(6, nameof(IntervalAugmentedFourth));

////        public static IntervalQuality IntervalAugmentedFifth { get; }
////            = new IntervalQuality(8, nameof(IntervalAugmentedFifth));

////        public static IntervalQuality IntervalAugmentedSixth { get; }
////            = new IntervalQuality(10, nameof(IntervalAugmentedSixth));

////        public static IntervalQuality IntervalAugmentedSeventh { get; }
////            = new IntervalQuality(12, nameof(IntervalAugmentedSeventh));

////        public static IntervalQuality IntervalAugmentedOctave { get; }
////            = new IntervalQuality(13, nameof(IntervalAugmentedOctave));

////        public static IntervalQuality IntervalDiminishedSecond { get; }
////            = new IntervalQuality(0, nameof(IntervalDiminishedSecond));

////        public static IntervalQuality IntervalDiminishedThird { get; }
////            = new IntervalQuality(2, nameof(IntervalDiminishedThird));

////        public static IntervalQuality IntervalDiminishedFourth { get; }
////            = new IntervalQuality(4, nameof(IntervalDiminishedFourth));

////        public static IntervalQuality IntervalDiminishedFifth { get; }
////            = new IntervalQuality(6, nameof(IntervalDiminishedFifth));

////        public static IntervalQuality IntervalDiminishedSixth { get; }
////            = new IntervalQuality(7, nameof(IntervalDiminishedSixth));

////        public static IntervalQuality IntervalDiminishedSeventh { get; }
////            = new IntervalQuality(9, nameof(IntervalDiminishedSeventh));

////        public static IntervalQuality IntervalDiminishedOctave { get; }
////            = new IntervalQuality(11, nameof(IntervalDiminishedOctave));

////        public int Semitones { get; }

////        public string Name { get; }

////        public override string ToString()
////            => Name;
////    }
////}