namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using System.Linq;
    using Core.Notes;
    using MidiMinuit.Lib.Instruments.GuitarTunings.Enum;

    public abstract class GuitarTuning
    {
        /// <summary>
        /// Gets notes of the Guitar Tuning.
        /// </summary>
        public abstract List<Note> Notes { get; }

        /// <summary>
        /// Gets name of the Guitar Tuning.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets category of the Guitar Tuning.
        /// </summary>
        public abstract GuitarTuningCategory Category { get; }

        public override string ToString()
        {
            var notes = Notes
                .Select(note => note.ToString())
                .Aggregate((current, next) => $"{current} {next}");

            return $"{Name} ({notes})";
        }
    }
}