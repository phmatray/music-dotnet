using System.Linq;
using MidiMinuit.Music.Tmp;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core.StepAccidentals
{
    public partial class StepAccidental
    {
        public static implicit operator NoteAccidentalAlias(StepAccidental accidental)
            => accidental.Alias;

        public static implicit operator StepAccidental(NoteAccidentalAlias alias)
            => Create(alias);

        public static implicit operator StepAccidental(int accidentalValue)
            => MusicContext.StepAccidentals
                .Single(x => x.Value == accidentalValue);

        public static implicit operator StepAccidental(string symbol)
            => MusicContext.StepAccidentals
                .Single(x => x.SignUnicode == symbol || x.SignAscii == symbol);
    }
}