namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningBaritone
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("B", "E", "A", "D", "G♭", "B");

        public override string Name { get; }
            = "Baritone";
    }
}