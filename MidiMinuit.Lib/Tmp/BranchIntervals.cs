using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Tmp
{
    public class IntervalTmp
    {
        public static IntervalTmp CreateInterval(Note note1, Note note2)
        {
            
        }


        private readonly Note _note1;
        private readonly Note _note2;

        public IntervalTmp(Note note1, Note note2)
        {
            _note1 = note1;
            _note2 = note2;
        }

        public void Inverse1()
        {
        }

        public void Inverse2()
        {
        }
    }

    public enum IntervalQualityEnumTmp
    {
        Perfect,
        Major,
        Minor,
        Augmented,
        Diminished
    }

    public enum IntervalNumberEnumTmp
    {
        Unison,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Octave
    }
}