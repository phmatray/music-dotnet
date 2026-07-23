using System;
using System.Text.RegularExpressions;

namespace OpenJam.Music.Core
{
    public partial class Pitch
    {
        public static implicit operator Pitch(PitchAlias alias)
            => Create(alias);

        public static implicit operator Pitch(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?[0-8]?$").IsMatch(s))
            {
                throw new ArgumentException("incorrect format");
            }

            var regexNote = new Regex("^[A-Ga-g]$");
            var regexAlter = new Regex("^[b♭#♯]$");
            var regexOctave = new Regex("^[0-8]$");

            string name = string.Empty;
            string accidental = string.Empty;
            string octaveNumber = string.Empty;

            foreach (char c in s)
            {
                if (name == string.Empty)
                {
                    if (regexNote.IsMatch(c.ToString()))
                    {
                        name += char.ToUpper(c).ToString();
                    }
                }
                else
                {
                    if (regexAlter.IsMatch(c.ToString()))
                    {
                        accidental += c.ToString();
                    }
                    else if (regexOctave.IsMatch(c.ToString()))
                    {
                        octaveNumber += c.ToString();
                    }
                }
            }

            var octaveNumberParsed = Convert.ToInt32(octaveNumber);

            return new Pitch
            {
                Name = name,
                Accidental = accidental,
                Octave = octaveNumberParsed
            };
        }
    }
}