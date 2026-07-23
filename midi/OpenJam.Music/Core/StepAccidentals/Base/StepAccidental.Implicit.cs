using System.Linq;
using OpenJam.Music.Tools;

namespace OpenJam.Music.Core
{
    public partial class StepAccidental
    {
        public static implicit operator StepAccidentalAlias(StepAccidental accidental)
            => accidental.Alias;

        public static implicit operator StepAccidental(StepAccidentalAlias alias)
            => Create(alias);

        public static implicit operator StepAccidental(int accidentalValue)
            => MusicContext.StepAccidentals
                .Single(x => x.Value == accidentalValue);

        public static implicit operator StepAccidental(string symbol)
            => MusicContext.StepAccidentals
                .Single(x => x.SignUnicode == symbol || x.SignAscii == symbol);
    }
}