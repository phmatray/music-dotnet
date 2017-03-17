namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDroppedE
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "B", "E", "A", "D♭", "G♭");

        public override string Name { get; }
            = "Dropped E";
    }
}