namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenA
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "A", "E", "A", "D♭", "E");

        public override string Name { get; }
            = "Open A";
    }
}