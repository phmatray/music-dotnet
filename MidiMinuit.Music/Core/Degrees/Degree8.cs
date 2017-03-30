using MidiMinuit.Music.Core.NoteNames;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Degrees
{
    public class Degree8 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.VIII;

        public override string DiatonicFunction { get; }
            = "Tonic (octave)";

        public override string CorrespondingModeMajorKey { get; }
            = "Ionian";

        public override string CorrespondingModeMinorKey { get; }
            = "Aeolian";

        public override string Meaning { get; }
            = "Tonal center, note of final resolution";

        public override string Function { get; }
            = "octave";

        public override Pitch PitchInCMajor { get; }
            = new Pitch(new NoteNameC());

        public override Pitch PitchInCMinor { get; }
            = new Pitch(new NoteNameC());

        public override string ToString()
            => Alias.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}