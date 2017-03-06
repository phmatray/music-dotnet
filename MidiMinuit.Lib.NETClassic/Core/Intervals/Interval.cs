using System;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class Interval
    {
        public Interval(
            Note fondamental,
            Note secondMinor,
            Note secondMajor,
            Note secondAugmented,
            Note thirdMinor,
            Note thirdMajor,
            Note fourthPerfect,
            Note fourthAugmented,
            Note fifthDiminished,
            Note fifthPerfect,
            Note fifthAugmented,
            Note sixthMinor,
            Note sixthMajor,
            Note seventhDiminished,
            Note seventhMinor,
            Note seventhMajor,
            Note seventhAugmented)
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

            Fondamental = fondamental as NoteFondamental;
            SecondMinor = secondMinor as NoteSecondMinor;
            SecondMajor = secondMajor as NoteSecondMajor;
            SecondAugmented = secondAugmented as NoteSecondAugmented;
            ThirdMinor = thirdMinor as NoteThirdMinor;
            ThirdMajor = thirdMajor as NoteThirdMajor;
            FourthPerfect = fourthPerfect as NoteFourthPerfect;
            FourthAugmented = fourthAugmented as NoteFourthAugmented;
            FifthDiminished = fifthDiminished as NoteFifthDiminished;
            FifthPerfect = fifthPerfect as NoteFifthPerfect;
            FifthAugmented = fifthAugmented as NoteFifthAugmented;
            SixthMinor = sixthMinor as NoteSixthMinor;
            SixthMajor = sixthMajor as NoteSixthMajor;
            SeventhDiminished = seventhDiminished as NoteSeventhDiminished;
            SeventhMinor = seventhMinor as NoteSeventhMinor;
            SeventhMajor = seventhMajor as NoteSeventhMajor;
            SeventhAugmented = seventhAugmented as NoteSeventhAugmented;
            NinthMinor = secondMinor as NoteNinthMinor;
            NinthMajor = secondMajor as NoteNinthMajor;
            NinthAugmented = secondAugmented as NoteNinthAugmented;
            EleventhPerfect = fourthPerfect as NoteEleventhPerfect;
            EleventhAugmented = fourthAugmented as NoteEleventhAugmented;
            ThirteenthMinor = sixthMinor as NoteThirteenthMinor;
            ThirteenthMajor = sixthMajor as NoteThirteenthMajor;
        }

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

            Fondamental = new NoteFondamental(fondamental);
            SecondMinor = new NoteSecondMinor(secondMinor);
            SecondMajor = new NoteSecondMajor(secondMajor);
            SecondAugmented = new NoteSecondAugmented(secondAugmented);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FourthPerfect = new NoteFourthPerfect(fourthPerfect);
            FourthAugmented = new NoteFourthAugmented(fourthAugmented);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            FifthAugmented = new NoteFifthAugmented(fifthAugmented);
            SixthMinor = new NoteSixthMinor(sixthMinor);
            SixthMajor = new NoteSixthMajor(sixthMajor);
            SeventhDiminished = new NoteSeventhDiminished(seventhDiminished);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
            SeventhMajor = new NoteSeventhMajor(seventhMajor);
            SeventhAugmented = new NoteSeventhAugmented(seventhAugmented);
            NinthMinor = new NoteNinthMinor(secondMinor);
            NinthMajor = new NoteNinthMajor(secondMajor);
            NinthAugmented = new NoteNinthAugmented(secondAugmented);
            EleventhPerfect = new NoteEleventhPerfect(fourthPerfect);
            EleventhAugmented = new NoteEleventhAugmented(fourthAugmented);
            ThirteenthMinor = new NoteThirteenthMinor(sixthMinor);
            ThirteenthMajor = new NoteThirteenthMajor(sixthMajor);
        }

        public NoteFondamental Fondamental { get; private set; }

        public NoteSecondMinor SecondMinor { get; private set; }

        public NoteSecondMajor SecondMajor { get; private set; }

        public NoteSecondAugmented SecondAugmented { get; private set; }

        public NoteThirdMinor ThirdMinor { get; private set; }

        public NoteThirdMajor ThirdMajor { get; private set; }

        public NoteFourthPerfect FourthPerfect { get; private set; }

        public NoteFourthAugmented FourthAugmented { get; private set; }

        public NoteFifthDiminished FifthDiminished { get; private set; }

        public NoteFifthPerfect FifthPerfect { get; private set; }

        public NoteFifthAugmented FifthAugmented { get; private set; }

        public NoteSixthMinor SixthMinor { get; private set; }

        public NoteSixthMajor SixthMajor { get; private set; }

        public NoteSeventhDiminished SeventhDiminished { get; private set; }

        public NoteSeventhMinor SeventhMinor { get; private set; }

        public NoteSeventhMajor SeventhMajor { get; private set; }

        public NoteSeventhAugmented SeventhAugmented { get; private set; }

        public NoteNinthMinor NinthMinor { get; private set; }

        public NoteNinthMajor NinthMajor { get; private set; }

        public NoteNinthAugmented NinthAugmented { get; private set; }

        public NoteEleventhPerfect EleventhPerfect { get; private set; }

        public NoteEleventhAugmented EleventhAugmented { get; private set; }

        public NoteThirteenthMinor ThirteenthMinor { get; private set; }

        public NoteThirteenthMajor ThirteenthMajor { get; private set; }
    }
}