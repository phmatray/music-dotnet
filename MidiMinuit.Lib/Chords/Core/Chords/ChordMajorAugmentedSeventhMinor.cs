using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMajorAugmentedSeventhMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthAugmented FifthAugmented { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMajorAugmentedSeventhMinor(Note fondamental, Note thirdMajor, Note fifthAugmented, Note seventhMinor)
            : base(ChordQuality.MajorAugmentedSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthAugmented = new NoteFifthAugmented(fifthAugmented);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th #: {FifthAugmented}, 7th min: {SeventhMinor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}aug7";
        }
    }
}