namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenC6
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("C", "G", "C", "G", "A", "E");

        public override string Name { get; }
            = "Open C6";
    }
}