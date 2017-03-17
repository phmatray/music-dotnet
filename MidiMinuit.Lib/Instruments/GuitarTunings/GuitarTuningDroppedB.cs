namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDroppedB
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("B", "G♭", "B", "E", "A♭", "D♭");

        public override string Name { get; }
            = "Dropped B";
    }
}