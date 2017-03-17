namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDroppedD
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "A", "D", "G", "B", "E");

        public override string Name { get; }
            = "Dropped D";
    }
}