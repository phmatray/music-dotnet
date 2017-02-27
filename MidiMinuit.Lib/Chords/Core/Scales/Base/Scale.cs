using System.Collections.Generic;
using System.Linq;
using GuitarChords.Lib.Notes;
using GuitarChords.Lib.Scales.Enum;

namespace GuitarChords.Lib.Scales
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