namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenG6
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "G", "D", "G", "B", "E");

        public override string Name { get; }
            = "Open G6";
    }
}