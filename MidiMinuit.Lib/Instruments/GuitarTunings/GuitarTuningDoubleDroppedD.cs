namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDoubleDroppedD
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "A", "D", "G", "B", "D");

        public override string Name { get; }
            = "Double Dropped D";
    }
}