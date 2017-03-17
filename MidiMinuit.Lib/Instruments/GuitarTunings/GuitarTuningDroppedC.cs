namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDroppedC
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("C", "G", "C", "F", "A", "D");

        public override string Name { get; }
            = "Dropped C";
    }
}