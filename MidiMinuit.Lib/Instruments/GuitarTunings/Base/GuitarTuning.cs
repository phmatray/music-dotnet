namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Core.Notes;

    public abstract class GuitarTuning
    {
        /// <summary>
        ///     Gets the tuning type of the Guitar Tuning.
        /// </summary>
        public abstract GuitarTuningType TuningType { get; }

        /// <summary>
        ///     Gets the tuning category of the Guitar Tuning.
        /// </summary>
        public abstract GuitarTuningCategory Category { get; }

        /// <summary>
        ///     Gets name of the Guitar Tuning.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        ///     Gets tuning of the Guitar Tuning.
        /// </summary>
        public abstract string Tuning { get; }

        /// <summary>
        ///     Gets description of the Guitar Tuning.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        ///     Gets strings of the Guitar Tuning.
        /// </summary>
        public abstract List<GuitarString> Strings { get; }

        /// <summary>
        ///     Gets notes of the Guitar Tuning.
        /// </summary>
        public List<Note> Notes
            => Strings.Select(x => x.Note).ToList();

        public string Intervals
        {
            get { throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            var notes = Notes
                .Select(note => note.ToString())
                .Aggregate((current, next) => $"{current} {next}");

            return $"{Name} ({notes})";
        }

        public abstract GuitarTuning Clone();
    }
}