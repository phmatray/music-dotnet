namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningDobroOpenG
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("G", "B", "D", "G", "B", "D");

        public override string Name { get; }
            = "Dobro Open G";
    }
}