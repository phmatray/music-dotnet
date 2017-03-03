using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Lib.Core.Chords;
using MidiMinuit.Lib.Core.Notes;
using MidiMinuit.Lib.Tools;

namespace MidiMinuit.Lib.Core.Scales
{
    /*
     * Une gamme est l'application d'un mode. Par exemple la gamme de Sol majeur est l'application du mode majeur avec Sol comme note  fondamentale (Sol La Si Do Re Mi Fa#).
     *
     * Modes naturels / harmoniques / mélodiques
     *
     * gamme majeure aka mode Ionien
     * gamme mineure aka aeolien
     *
     * Parmi les 7 « modes naturels » il y a trois gammes majeures et quatre gammes mineures parmi lesquelles une gamme diminuée ( mode locrien ),
     *
     * Le mode «mixolydien b9/b13» (phrygien dominant), qui a des sonorité arabes, n’a rien à voir avec son altère ego naturel (le mode mixolydien), qui a des sonorités bluesy.
     *
     * intervalle d'une seconde augmentée (#9) qui est le même que celui de la tierce mineure (b3)
     *
     * Chaque degré a une fonction :
     * Le Ier degré a fonction de tonique
     * Le IIeme degré a fonction de sus-tonique
     * Le IIIeme degré a fonction de médiante
     * Le IVeme degré a fonction de sous-dominante
     * Le Veme degré a fonction de dominante
     * Le VIeme degré a fonction de sus-dominante
     * Le VIIeme degré a fonction de note sensible
    */


    public class ScaleMajor
    {
        public ScaleMajor(Note key)
        {
            var i = key.GetInterval();

            // gamme majeure : T 2M 3M 4j 5j 6M 7M
            this.Notes = new List<NoteQuality>
            {
                i.Fondamental,
                i.SecondMajor,
                i.ThirdMajor,
                i.FourthPerfect,
                i.FifthPerfect,
                i.SixthMajor,
                i.SeventhMajor
            };
        }

        public string Name => "Major";

        public List<NoteQuality> Notes { get; private set; }

        public ScaleTypeEnum ScaleType => ScaleTypeEnum.Major;

        public ChordBase GetChord(NoteQuality note1, NoteQuality note2, NoteQuality note3)
        {
            //if (note1 is NoteFondamental)
            //    return 

            return null;
        }
    }













    public static class IntervalHelper
    {
        public static List<NoteQuality> GetScale(Note key, ScaleTypeEnum scaleType)
        {
            var i = key.GetInterval();

            if (scaleType == ScaleTypeEnum.Major)
            {
                // gamme majeure : T 2M 3M 4j 5j 6M 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.MinorMelodic)
            {
                // gamme mineure mélodique : T 2M 3m 4j 5j 6M 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.MinorHarmonic)
            {
                // gamme mineure harmonique : T 2M 3m 4j 5j 6m 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMinor,
                    i.SeventhMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.MinorNaturalEolian)
            {
                // gamme mineure naturelle (mode éolien) : T 2M 3m 4j 5j 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeDorian)
            {
                // mode dorien : T 2M 3m 4j 5j 6M 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeMixolydian)
            {
                // mode mixolydien : T 2M 3M 4j 5j 6M 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeLydian) // ?
            {
                // mode lydien : T 2M 3M #11 5j 6M 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.EleventhAugmented,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeLydianB7) // ?
            {
                // mode lydien b7 : T 2M 3M #11 5j 6M 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.EleventhAugmented,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.PentatonicMajor)
            {
                // gamme pentatonique majeure : T 2M 3M 5j 6M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.FifthPerfect,
                    i.SixthMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.PentatonicMinor)
            {
                // gamme pentatonique mineure : T 3m 4j 5j 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.Blues)
            {
                // gamme blues : T 3m 4j b5 5j 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthDiminished,
                    i.FifthPerfect,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModePhrygian)
            {
                // mode phrygien : T 2m 3m 4j 5j 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMinor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeLocrian)
            {
                // mode locrien : T 2m 3m 4j b5 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMinor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthDiminished,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeLocrianBec2)
            {
                // mode locrien béc2 : T 2M 3m 4j b5 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.FifthDiminished,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeMixolydianB2B6)
            {
                // mode mixolydienb2b6 : T 2m 3M 4j 5j 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMinor,
                    i.ThirdMajor,
                    i.FourthPerfect,
                    i.FifthPerfect,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeAltered)
            {
                // mode altéré : T 2m 3m 3M b5 6m 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMinor,
                    i.ThirdMinor,
                    i.ThirdMajor,
                    i.FifthDiminished,
                    i.SixthMinor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeLydianAdded) // ?
            {
                // mode lydien augmenté : T 2M 3M #11 #5 6M 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMajor,
                    i.EleventhAugmented,
                    i.FifthAugmented,
                    i.SixthMajor,
                    i.SeventhMajor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeDiminishedReverse)
            {
                // mode diminué inversé : T 2m 3m 3M b5 5j 6M 7m
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMinor,
                    i.ThirdMinor,
                    i.ThirdMajor,
                    i.FifthDiminished,
                    i.FifthPerfect,
                    i.SixthMajor,
                    i.SeventhMinor
                };
            }
            else if (scaleType == ScaleTypeEnum.ModeDiminished) // ?
            {
                // mode diminué : T 2M 3m 4j #11 #5 6M 7M
                return new List<NoteQuality>
                {
                    i.Fondamental,
                    i.SecondMajor,
                    i.ThirdMinor,
                    i.FourthPerfect,
                    i.EleventhAugmented,
                    i.FifthAugmented,
                    i.SixthMajor,
                    i.SeventhMajor
                };
            }

            return null;
        }
    }

    ////public class Toto
    ////{
    ////    public Toto()
    ////    {
    ////        List<Note> scaleMode = new Scale7AscendingMelodicMinor().Modes[Scale7AscendingMelodicMinorMode.Mode0_Larian];
    ////        List<Chord> chords = GenerateChords(scaleMode);
    ////        List<ChordPosition> chordPositions = GenerateChordPositions(chords[0], new Tunings.TuningStandard());
    ////    }
    ////}

    public abstract class Scale
    {
        public string Name { get; protected set; }

        public int Imperfections { get; protected set; }

        public List<int> Intervals { get; protected set; }

        public string ModeSuffix { get; protected set; }

        public Note Key { get; protected set; }

        // max interval
        public int Leap
            => Intervals.Max();
    }

    public abstract class Scale7 : Scale
    {
        protected Scale7()
        {
            ModeSuffix = "-ian";
        }
    }

    public class Scale7Major
        : Scale7
    {
        public Scale7Major(Note key = null)
        {
            Key = key ?? new Note(NoteNameEnum.C);
            Name = "Major";
            Imperfections = 3;
            Intervals = new List<int> { 2, 2, 1, 2, 2, 2, 1 };

            var notes = new List<Note>
            {
                Key,
                Key + 2,
                Key + 4,
                Key + 6,
                Key + 8,
                Key + 9,
                Key + 11
            };

            Modes = System.Enum
                .GetValues(typeof(Scale7MajorMode))
                .Cast<Scale7MajorMode>()
                .ToDictionary(
                    x => x,
                    x => notes.ShiftLeft((int)x));
        }

        public Dictionary<Scale7MajorMode, List<Note>> Modes { get; private set; }
    }

    public enum Scale7MajorMode
    {
        Mode4_Ionian = 0,
        Mode5_Dorian = 1,
        Mode6_Phrygian = 2,
        Mode0_Lydian = 3,
        Mode1_Mixolydian = 4,
        Mode2_Aeolian = 5,
        Mode3_Locrian = 6
    }

    public class Scale7AscendingMelodicMinor
        : Scale7
    {
        public Scale7AscendingMelodicMinor(Note key = null)
        {
            Key = key ?? new Note(NoteNameEnum.C);
            Name = "Ascending Melodic Minor";
            Imperfections = 3;
            Intervals = new List<int> { 2, 2, 2, 2, 1, 2, 1 };

            var notes = new List<Note>
            {
                Key,
                Key + 2,
                Key + 4,
                Key + 6,
                Key + 8,
                Key + 9,
                Key + 11
            };

            Modes = System.Enum
                .GetValues(typeof(Scale7AscendingMelodicMinorMode))
                .Cast<Scale7AscendingMelodicMinorMode>()
                .ToDictionary(
                    x => x,
                    x => notes.ShiftLeft((int)x));
        }

        public Dictionary<Scale7AscendingMelodicMinorMode, List<Note>> Modes { get; private set; }
    }

    public enum Scale7AscendingMelodicMinorMode
    {
        Mode0_Larian = 0,
        Mode1_Lythian = 1,
        Mode2_Stydian = 2,
        Mode3_Lorian = 3,
        Mode4_Ionadian = 4,
        Mode5_Bocrian = 5,
        Mode6_Mixolythian = 6
    }
}




//using System.Collections.Generic;
//using System.Linq;
//using Windows.Devices.Bluetooth.Advertisement;
//using MidiMinuit.Lib.Chords.Core.Notes.Base;
//using MidiMinuit.Lib.Chords.Core.Scales.Enum;

//namespace MidiMinuit.Lib.Chords.Core.Scales.Base
//{
//    public class Mode
//    {
//        public string Name { get; set; } = "Ionian";

//        public string Aka { get; set; } = "major";
//        public int Imperfection { get; set; }
//    }




//    public abstract class Scale
//    {
//        protected Scale(int degree, int numberOfScales, int numberOfUniqueModes)
//        {
//            Degree = degree;
//            NumberOfScales = numberOfScales;
//            NumberOfUniqueModes = numberOfUniqueModes;
//        }

//        public int Degree { get; }

//        public int NumberOfScales { get; }

//        public int NumberOfUniqueModes { get; }
//    }

//    public abstract class Scale3Notes : Scale
//    {
//        protected Scale3Notes()
//            : base(3, 1, 1)
//        {
//            var modeNames = new List<string>()
//            {
//                "Minoric"
//            };
//        }


//        public class Child
//        {
//            public int Leap { get; set; }
//            public string Mode { get; set; }
//        }
//    }

//    public abstract class Scale4Notes : Scale
//    {
//        protected Scale4Notes()
//            : base(4, 9, 31)
//        {
//            var modeNames = new List<string>()
//            {
//"Aeolic            ",
//"Aeoloric          ",
//"Aeraphic          ",
//"Aerathic          ",
//"Byptic            ",
//"Dadic             ",
//"Dalic             ",
//"Doric             ",
//"Dygic             ",
//"Epathic           ",
//"Epogic            ",
//"Eporic            ",
//"Gonic             ",
//"Ionic             ",
//"Koptic            ",
//"Lanic             ",
//"Lonic             ",
//"Lothic            ",
//"Lydic             ",
//"Mixodoric         ",
//"Mixolyric         ",
//"Mynic             ",
//"Phratic           ",
//"Phrynic           ",
//"Pyrric            ",
//"Rothic            ",
//"Saric             ",
//"Stathic           ",
//"Thaptic           ",
//"Zoptic            ",
//"Zyphic            "
//            };
//        }
//    }

//    public abstract class Scale5Notes : Scale
//    {
//        protected Scale5Notes()
//            : base(5, 31, 155)
//        {
//            var modeNames = new List<string>()
//            {
//                "             Aeolacritonic",
//                "Aeolanitonic              ",
//                "Aeolapritonic             ",
//                "Aeoloditonic              ",
//                "Aeoloritonic              ",
//                "Aeolycritonic             ",
//                "Aeolyphritonic            ",
//                "Aeolyritonic              ",
//                "Aeolythitonic             ",
//                "Aeracritonic              ",
//                "Aeraphitonic              ",
//                "Aerathitonic              ",
//                "Aeritonic                 ",
//                "Aeronitonic               ",
//                "Aerophitonic              ",
//                "Aerylitonic               ",
//                "Aerynitonic               ",
//                "Banitonic                 ",
//                "Bocritonic                ",
//                "Bogitonic                 ",
//                "Bolitonic                 ",
//                "Bothitonic                ",
//                "Bycritonic                ",
//                "Bylitonic                 ",
//                "Byptitonic                ",
//                "Daditonic                 ",
//                "Dalitonic                 ",
//                "Danitonic                 ",
//                "Daptitonic                ",
//                "Daritonic                 ",
//                "Docritonic                ",
//                "Dogitonic                 ",
//                "Dolitonic                 ",
//                "Doptitonic                ",
//                "Dygitonic                 ",
//                "Dynitonic                 ",
//                "Dyptitonic                ",
//                "Dyritonic                 ",
//                "Epaditonic                ",
//                "Epathitonic               ",
//                "Epogitonic                ",
//                "Epygitonic                ",
//                "Epyritonic                ",
//                "Garitonic                 ",
//                "Gathitonic                ",
//                "Golitonic                 ",
//                "Gonitonic                 ",
//                "Goritonic                 ",
//                "Gothitonic                ",
//                "Gycritonic                ",
//                "Gylitonic                 ",
//                "Gyritonic                 ",
//                "Gythitonic                ",
//                "Ionacritonic              ",
//                "Ionaditonic               ",
//                "Ionagitonic               ",
//                "Ionalitonic               ",
//                "Ionaritonic               ",
//                "Ionitonic                 ",
//                "Ionoditonic               ",
//                "Ionothitonic              ",
//                "Ionycritonic              ",
//                "Ionyptitonic              ",
//                "Ionythitonic              ",
//                "Kagitonic                 ",
//                "Kanitonic                 ",
//                "Kataditonic               ",
//                "Katagitonic               ",
//                "Kataritonic               ",
//                "Katycritonic              ",
//                "Koditonic                 ",
//                "Koptitonic                ",
//                "Kygitonic                 ",
//                "Kyritonic                 ",
//                "Laditonic                 ",
//                "Lagitonic                 ",
//                "Lanitonic                 ",
//                "Laritonic                 ",
//                "Lonitonic                 ",
//                "Loptitonic                ",
//                "Loritonic                 ",
//                "Lothitonic                ",
//                "Lycritonic                ",
//                "Lyditonic                 ",
//                "Magitonic                 ",
//                "Mixitonic                 ",
//                "Mocritonic                ",
//                "Mogitonic                 ",
//                "Molitonic                 ",
//                "Mothitonic                ",
//                "Myditonic                 ",
//                "Mynitonic                 ",
//                "Mythitonic                ",
//                "Pagitonic                 ",
//                "Palitonic                 ",
//                "Paptitonic                ",
//                "Pathitonic                ",
//                "Pentatonic                ",
//                "Phraditonic               ",
//                "Phralitonic               ",
//                "Phratonic                 ",
//                "Phrolitonic               ",
//                "Phronitonic               ",
//                "Phropitonic               ",
//                "Phrothitonic              ",
//                "Phrynitonic               ",
//                "Phrythitonic              ",
//                "Poditonic                 ",
//                "Poritonic                 ",
//                "Pynitonic                 ",
//                "Pyritonic                 ",
//                "Raditonic                 ",
//                "Ragitonic                 ",
//                "Ranitonic                 ",
//                "Rocritonic                ",
//                "Rolitonic                 ",
//                "Rothitonic                ",
//                "Ryphitonic                ",
//                "Saritonic                 ",
//                "Sogitonic                 ",
//                "Soptitonic                ",
//                "Staditonic                ",
//                "Staptitonic               ",
//                "Stathitonic               ",
//                "Stolitonic                ",
//                "Stonitonic                ",
//                "Stothitonic               ",
//                "Styditonic                ",
//                "Sylitonic                 ",
//                "Syptitonic                ",
//                "Thacritonic               ",
//                "Thalitonic                ",
//                "Thaptitonic               ",
//                "Thocritonic               ",
//                "Thoditonic                ",
//                "Tholitonic                ",
//                "Thonitonic                ",
//                "Thoptitonic               ",
//                "Thyritonic                ",
//                "Zacritonic                ",
//                "Zagitonic                 ",
//                "Zalitonic                 ",
//                "Zanitonic                 ",
//                "Zaptitonic                ",
//                "Zaritonic                 ",
//                "Zathitonic                ",
//                "Zoditonic                 ",
//                "Zogitonic                 ",
//                "Zolitonic                 ",
//                "Zoptitonic                ",
//                "Zothitonic                ",
//                "Zyditonic                 ",
//                "Zylitonic                 ",
//                "Zynitonic                 ",
//                "Zythitonic                "
//            };
//        }
//    }

//    public abstract class Scale6Notes : Scale
//    {
//        protected Scale6Notes()
//            : base(6, 59, 336)
//        {
//            var modeNames = new List<string>()
//            {

//            }
//        }
//    }

//    public abstract class Scale7Notes : Scale
//    {
//        protected Scale7Notes()
//            : base(7, 59, 413)
//        {
//        }
//    }

//    public abstract class Scale8Notes : Scale
//    {
//        protected Scale8Notes()
//            : base(8, 42, 322)
//        {
//        }
//    }

//    public abstract class Scale9Notes : Scale
//    {
//        protected Scale9Notes()
//            : base(9, 19, 165)
//        {
//        }
//    }

//    public abstract class Scale10Notes : Scale
//    {
//        protected Scale10Notes()
//            : base(10, 6, 55)
//        {
//        }
//    }

//    public abstract class Scale11Notes : Scale
//    {
//        protected Scale11Notes()
//            : base(11, 1, 11)
//        {
//        }
//    }

//    public abstract class Scale12Notes : Scale
//    {
//        protected Scale12Notes()
//            : base(12, 1, 1)
//        {
//        }
//    }

//    //public abstract class Scale
//    //{
//    //    protected Scale(ScaleType type, ScaleMode mode)
//    //    {
//    //        Type = type;
//    //        Mode = mode;
//    //    }

//    //    public List<Note> Notes { get; protected set; }

//    //    public ScaleType Type { get; protected set; }

//    //    public ScaleMode Mode { get; protected set; }

//    //    public Note Key => Notes.First();
//    //}
//}