using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Scales.Enum;

namespace MidiMinuit.Lib.Chords.Core.Scales.Base
{
    public abstract class Scale
    {
        protected Scale(ScaleType type, ScaleMode mode)
        {
            Type = type;
            Mode = mode;
        }

        public List<Note> Notes { get; protected set; }

        public ScaleType Type { get; protected set; }

        public ScaleMode Mode { get; protected set; }

        public Note Key => Notes.First();
    }
}