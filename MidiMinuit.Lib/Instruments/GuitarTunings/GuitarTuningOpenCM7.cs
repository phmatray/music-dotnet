namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenCM7
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("C", "G", "E", "G", "B", "E");

        public override string Name { get; }
            = "Open CM7";
    }
}