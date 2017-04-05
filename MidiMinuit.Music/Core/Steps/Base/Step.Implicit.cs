using System;
using System.Text.RegularExpressions;

namespace MidiMinuit.Music.Core
{
    public partial class Step
    {
        public static implicit operator Step(StepAlias alias)
            => Create(alias);

        /// <summary>
        ///     Initializes a new instance of the <see cref="Step" /> class.
        /// </summary>
        /// <param name="s">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public static implicit operator Step(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?$").IsMatch(s))
            {
                throw new ArgumentException("incorrect format");
            }

            var regexNote = new Regex("^[A-Ga-g]$");
            var regexAlter = new Regex("^[b♭#♯]$");

            string stepName = string.Empty;
            string accidental = string.Empty;

            foreach (char c in s)
            {
                if (stepName == string.Empty)
                {
                    if (regexNote.IsMatch(c.ToString()))
                    {
                        stepName += char.ToUpper(c).ToString();
                    }
                }
                else
                {
                    if (regexAlter.IsMatch(c.ToString()))
                    {
                        accidental += c.ToString();
                    }
                }
            }

            return new Step { Name = stepName, Accidental = accidental };
        }
    }
}