using System.Linq;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core
{
    public partial class StepName
    {
        public static implicit operator StepNameAlias(StepName stepName)
            => stepName.Alias;

        public static implicit operator StepName(StepNameAlias alias)
            => Create(alias);

        public static implicit operator StepName(string name)
            => MusicContext.StepNames
                .Single(x => x.Name == name || x.NameLatin == name);

        public static implicit operator StepName(int stepNumber)
            => MusicContext.StepNames
                .Single(x => x.StepNumber == stepNumber);
    }
}