namespace MidiMinuit.Lib.Core.Intervals
{
    using System;
    using Notes;

    public class Interval
    {
        ////public Interval(
        ////    Note fondamental,
        ////    Note secondMinor,
        ////    Note secondMajor,
        ////    Note secondAugmented,
        ////    Note thirdMinor,
        ////    Note thirdMajor,
        ////    Note fourthPerfect,
        ////    Note fourthAugmented,
        ////    Note fifthDiminished,
        ////    Note fifthPerfect,
        ////    Note fifthAugmented,
        ////    Note sixthMinor,
        ////    Note sixthMajor,
        ////    Note seventhDiminished,
        ////    Note seventhMinor,
        ////    Note seventhMajor,
        ////    Note seventhAugmented)
        ////{
        ////    if (fondamental == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fondamental));
        ////    }

        ////    if (secondMinor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(secondMinor));
        ////    }

        ////    if (secondMajor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(secondMajor));
        ////    }

        ////    if (secondAugmented == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(secondAugmented));
        ////    }

        ////    if (thirdMinor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(thirdMinor));
        ////    }

        ////    if (thirdMajor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(thirdMajor));
        ////    }

        ////    if (fourthPerfect == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fourthPerfect));
        ////    }

        ////    if (fourthAugmented == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fourthAugmented));
        ////    }

        ////    if (fifthDiminished == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fifthDiminished));
        ////    }

        ////    if (fifthPerfect == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fifthPerfect));
        ////    }

        ////    if (fifthAugmented == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(fifthAugmented));
        ////    }

        ////    if (sixthMinor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(sixthMinor));
        ////    }

        ////    if (sixthMajor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(sixthMajor));
        ////    }

        ////    if (seventhDiminished == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(seventhDiminished));
        ////    }

        ////    if (seventhMinor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(seventhMinor));
        ////    }

        ////    if (seventhMajor == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(seventhMajor));
        ////    }

        ////    if (seventhAugmented == null)
        ////    {
        ////        throw new ArgumentNullException(nameof(seventhAugmented));
        ////    }

        ////    Fondamental = fondamental as IntervalPerfectUnison;
        ////    SecondMinor = secondMinor as IntervalMinorSecond;
        ////    SecondMajor = secondMajor as IntervalMajorSecond;
        ////    SecondAugmented = secondAugmented as IntervalAugmentedSecond;
        ////    ThirdMinor = thirdMinor as IntervalMinorThird;
        ////    ThirdMajor = thirdMajor as IntervalMajorThird;
        ////    FourthPerfect = fourthPerfect as IntervalPerfectFourth;
        ////    FourthAugmented = fourthAugmented as IntervalAugmentedFourth;
        ////    FifthDiminished = fifthDiminished as IntervalDiminishedFifth;
        ////    FifthPerfect = fifthPerfect as IntervalPerfectFifth;
        ////    FifthAugmented = fifthAugmented as IntervalAugmentedFifth;
        ////    SixthMinor = sixthMinor as IntervalMinorSixth;
        ////    SixthMajor = sixthMajor as IntervalMajorSixth;
        ////    SeventhDiminished = seventhDiminished as IntervalDiminishedSeventh;
        ////    SeventhMinor = seventhMinor as IntervalMinorSeventh;
        ////    SeventhMajor = seventhMajor as IntervalMajorSeventh;
        ////    SeventhAugmented = seventhAugmented as IntervalAugmentedSeventh;
        ////    NinthMinor = secondMinor as IntervalMinorNinth;
        ////    NinthMajor = secondMajor as IntervalMajorNinth;
        ////    NinthAugmented = secondAugmented as IntervalAugmentedNinth;
        ////    EleventhPerfect = fourthPerfect as IntervalPerfectEleventh;
        ////    EleventhAugmented = fourthAugmented as IntervalAugmentedEleventh;
        ////    ThirteenthMinor = sixthMinor as IntervalMinorThirteenth;
        ////    ThirteenthMajor = sixthMajor as IntervalMajorThirteenth;
        ////}

        public Interval(
            string fondamental,
            string secondMinor,
            string secondMajor,
            string secondAugmented,
            string thirdMinor,
            string thirdMajor,
            string fourthPerfect,
            string fourthAugmented,
            string fifthDiminished,
            string fifthPerfect,
            string fifthAugmented,
            string sixthMinor,
            string sixthMajor,
            string seventhDiminished,
            string seventhMinor,
            string seventhMajor,
            string seventhAugmented)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            if (secondMinor == null)
            {
                throw new ArgumentNullException(nameof(secondMinor));
            }

            if (secondMajor == null)
            {
                throw new ArgumentNullException(nameof(secondMajor));
            }

            if (secondAugmented == null)
            {
                throw new ArgumentNullException(nameof(secondAugmented));
            }

            if (thirdMinor == null)
            {
                throw new ArgumentNullException(nameof(thirdMinor));
            }

            if (thirdMajor == null)
            {
                throw new ArgumentNullException(nameof(thirdMajor));
            }

            if (fourthPerfect == null)
            {
                throw new ArgumentNullException(nameof(fourthPerfect));
            }

            if (fourthAugmented == null)
            {
                throw new ArgumentNullException(nameof(fourthAugmented));
            }

            if (fifthDiminished == null)
            {
                throw new ArgumentNullException(nameof(fifthDiminished));
            }

            if (fifthPerfect == null)
            {
                throw new ArgumentNullException(nameof(fifthPerfect));
            }

            if (fifthAugmented == null)
            {
                throw new ArgumentNullException(nameof(fifthAugmented));
            }

            if (sixthMinor == null)
            {
                throw new ArgumentNullException(nameof(sixthMinor));
            }

            if (sixthMajor == null)
            {
                throw new ArgumentNullException(nameof(sixthMajor));
            }

            if (seventhDiminished == null)
            {
                throw new ArgumentNullException(nameof(seventhDiminished));
            }

            if (seventhMinor == null)
            {
                throw new ArgumentNullException(nameof(seventhMinor));
            }

            if (seventhMajor == null)
            {
                throw new ArgumentNullException(nameof(seventhMajor));
            }

            if (seventhAugmented == null)
            {
                throw new ArgumentNullException(nameof(seventhAugmented));
            }

            ////Fondamental = new IntervalPerfectUnison(fondamental);
            ////SecondMinor = new IntervalMinorSecond(secondMinor);
            ////SecondMajor = new IntervalMajorSecond(secondMajor);
            ////SecondAugmented = new IntervalAugmentedSecond(secondAugmented);
            ////ThirdMinor = new IntervalMinorThird(thirdMinor);
            ////ThirdMajor = new IntervalMajorThird(thirdMajor);
            ////FourthPerfect = new IntervalPerfectFourth(fourthPerfect);
            ////FourthAugmented = new IntervalAugmentedFourth(fourthAugmented);
            ////FifthDiminished = new IntervalDiminishedFifth(fifthDiminished);
            ////FifthPerfect = new IntervalPerfectFifth(fifthPerfect);
            ////FifthAugmented = new IntervalAugmentedFifth(fifthAugmented);
            ////SixthMinor = new IntervalMinorSixth(sixthMinor);
            ////SixthMajor = new IntervalMajorSixth(sixthMajor);
            ////SeventhDiminished = new IntervalDiminishedSeventh(seventhDiminished);
            ////SeventhMinor = new IntervalMinorSeventh(seventhMinor);
            ////SeventhMajor = new IntervalMajorSeventh(seventhMajor);
            ////SeventhAugmented = new IntervalAugmentedSeventh(seventhAugmented);
            ////NinthMinor = new IntervalMinorNinth(secondMinor);
            ////NinthMajor = new IntervalMajorNinth(secondMajor);
            ////NinthAugmented = new IntervalAugmentedNinth(secondAugmented);
            ////EleventhPerfect = new IntervalPerfectEleventh(fourthPerfect);
            ////EleventhAugmented = new IntervalAugmentedEleventh(fourthAugmented);
            ////ThirteenthMinor = new IntervalMinorThirteenth(sixthMinor);
            ////ThirteenthMajor = new IntervalMajorThirteenth(sixthMajor);

            Fondamental = new IntervalPerfectUnison();
            SecondMinor = new IntervalMinorSecond();
            SecondMajor = new IntervalMajorSecond();
            SecondAugmented = new IntervalAugmentedSecond();
            ThirdMinor = new IntervalMinorThird();
            ThirdMajor = new IntervalMajorThird();
            FourthPerfect = new IntervalPerfectFourth();
            FourthAugmented = new IntervalAugmentedFourth();
            FifthDiminished = new IntervalDiminishedFifth();
            FifthPerfect = new IntervalPerfectFifth();
            FifthAugmented = new IntervalAugmentedFifth();
            SixthMinor = new IntervalMinorSixth();
            SixthMajor = new IntervalMajorSixth();
            SeventhDiminished = new IntervalDiminishedSeventh();
            SeventhMinor = new IntervalMinorSeventh();
            SeventhMajor = new IntervalMajorSeventh();
            SeventhAugmented = new IntervalAugmentedSeventh();
            NinthMinor = new IntervalMinorNinth();
            NinthMajor = new IntervalMajorNinth();
            NinthAugmented = new IntervalAugmentedNinth();
            EleventhPerfect = new IntervalPerfectEleventh();
            EleventhAugmented = new IntervalAugmentedEleventh();
            ThirteenthMinor = new IntervalMinorThirteenth();
            ThirteenthMajor = new IntervalMajorThirteenth();
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMinorSecond SecondMinor { get; private set; }

        public IntervalMajorSecond SecondMajor { get; private set; }

        public IntervalAugmentedSecond SecondAugmented { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalAugmentedFourth FourthAugmented { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalAugmentedFifth FifthAugmented { get; private set; }

        public IntervalMinorSixth SixthMinor { get; private set; }

        public IntervalMajorSixth SixthMajor { get; private set; }

        public IntervalDiminishedSeventh SeventhDiminished { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public IntervalMajorSeventh SeventhMajor { get; private set; }

        public IntervalAugmentedSeventh SeventhAugmented { get; private set; }

        public IntervalMinorNinth NinthMinor { get; private set; }

        public IntervalMajorNinth NinthMajor { get; private set; }

        public IntervalAugmentedNinth NinthAugmented { get; private set; }

        public IntervalPerfectEleventh EleventhPerfect { get; private set; }

        public IntervalAugmentedEleventh EleventhAugmented { get; private set; }

        public IntervalMinorThirteenth ThirteenthMinor { get; private set; }

        public IntervalMajorThirteenth ThirteenthMajor { get; private set; }
    }
}