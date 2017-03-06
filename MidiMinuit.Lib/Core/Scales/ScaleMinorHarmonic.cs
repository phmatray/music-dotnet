using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleMinorHarmonic : ScaleBase
    {
        public NoteFondamental Fondamental { get; set; }

        public NoteSecondMajor SecondMajor { get; set; }

        public NoteThirdMinor ThirdMinor { get; set; }

        public NoteFourthPerfect FourthPerfect { get; set; }

        public NoteFifthPerfect FifthPerfect { get; set; }

        public NoteSixthMinor SixthMinor { get; set; }

        public NoteSeventhMajor SeventhMajor { get; set; }

        public ScaleMinorHarmonic(Note key)
            : base(ScaleTypeEnum.MinorHarmonic)
        {
            // gamme mineure harmonique : T 2M 3m 4j 5j 6m 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMinor = i.SixthMinor;
            SeventhMajor = i.SeventhMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMajor
            };

        public override string Name
            => $"Minor Harmonic";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeMixolydian : ScaleBase
    {
        public ScaleModeMixolydian(Note key)
            : base(ScaleTypeEnum.ModeMixolydian)
        {
            // mode mixolydien : T 2M 3M 4j 5j 6M 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Mixolydian";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeLydian : ScaleBase
    {
        public ScaleModeLydian(Note key)
            : base(ScaleTypeEnum.ModeLydian)
        {
            // mode lydien : T 2M 3M #11 5j 6M 7M ???
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                EleventhAugmented,
                FifthPerfect,
                SixthMajor,
                SeventhMajor
            };

        public override string Name
            => $"Mode Lydian";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeLydianB7 : ScaleBase
    {
        public ScaleModeLydianB7(Note key)
            : base(ScaleTypeEnum.ModeLydianB7)
        {
            // mode lydien b7 : T 2M 3M #11 5j 6M 7m ???
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                EleventhAugmented,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Lydian b7";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScalePentatonicMajor : ScaleBase
    {
        public ScalePentatonicMajor(Note key)
            : base(ScaleTypeEnum.PentatonicMajor)
        {
            // gamme pentatonique majeure : T 2M 3M 5j 6M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FifthPerfect,
                SixthMajor
            };

        public override string Name
            => $"Pentatonic Major";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScalePentatonicMinor : ScaleBase
    {
        public ScalePentatonicMinor(Note key)
            : base(ScaleTypeEnum.PentatonicMinor)
        {
            // gamme pentatonique mineure : T 3m 4j 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name
            => $"Pentatonic Minor";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleBlues : ScaleBase
    {
        public ScaleBlues(Note key)
            : base(ScaleTypeEnum.Blues)
        {
            // gamme blues : T 3m 4j b5 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name
            => $"Blues";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModePhrygian : ScaleBase
    {
        public ScaleModePhrygian(Note key)
            : base(ScaleTypeEnum.ModePhrygian)
        {
            // mode phrygien : T 2m 3m 4j 5j 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Phrygian";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeLocrian : ScaleBase
    {
        public ScaleModeLocrian(Note key)
            : base(ScaleTypeEnum.ModeLocrian)
        {
            // mode locrien : T 2m 3m 4j b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Locrian";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeLocrianBec2 : ScaleBase
    {
        public ScaleModeLocrianBec2(Note key)
            : base(ScaleTypeEnum.ModeLocrianBec2)
        {
            // mode locrien béc2 : T 2M 3m 4j b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Locrian Bec2";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeMixolydianB2B6 : ScaleBase
    {
        public ScaleModeMixolydianB2B6(Note key)
            : base(ScaleTypeEnum.ModeMixolydianB2B6)
        {
            // mode mixolydienb2b6 : T 2m 3M 4j 5j 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Mixolydian b2b6";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeAltered : ScaleBase
    {
        public ScaleModeAltered(Note key)
            : base(ScaleTypeEnum.ModeAltered)
        {
            // mode altéré : T 2m 3m 3M b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                ThirdMajor,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Altered";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeLydianAdded : ScaleBase
    {
        public ScaleModeLydianAdded(Note key)
            : base(ScaleTypeEnum.ModeLydianAdded)
        {
            // mode lydien augmenté : T 2M 3M #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                EleventhAugmented,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name
            => $"Mode Lydian Added";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeDiminishedReverse : ScaleBase
    {
        public ScaleModeDiminishedReverse(Note key)
            : base(ScaleTypeEnum.ModeDiminishedReverse)
        {
            // mode diminué inversé : T 2m 3m 3M b5 5j 6M 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                ThirdMajor,
                FifthDiminished,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Diminished Reverse";

        public override string ToString()
        {
            return Name;
        }
    }

    public class ScaleModeDiminished : ScaleBase
    {
        public ScaleModeDiminished(Note key)
            : base(ScaleTypeEnum.ModeDiminished)
        {
            // mode diminué : T 2M 3m 4j #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                EleventhAugmented,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name
            => $"Mode Diminished";

        public override string ToString()
        {
            return Name;
        }
    }
}