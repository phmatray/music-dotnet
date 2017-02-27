using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Tunings.Enum;

namespace MidiMinuit.Lib.Chords.Core.Tunings.Base
{
    public abstract class Tuning
    {
        protected Tuning(List<Note> tuning)
        {
            Notes = new ReadOnlyCollection<Note>(tuning);
        }

        protected Tuning(params Note[] tuning)
        {
            Notes = new ReadOnlyCollection<Note>(tuning);
        }

        protected Tuning(params string[] tuning)
        {
            var notes = tuning
                .Select((n, i) => new Note(tuning[i]))
                .ToArray();

            Notes = new ReadOnlyCollection<Note>(notes);
        }

        public ReadOnlyCollection<Note> Notes { get; }

        public static Tuning GetTuning(TuningType tuningType = TuningType.Standard)
        {
            switch (tuningType)
            {
                case TuningType.Standard:
                    return new TuningStandard();
                case TuningType.TuneDownHalfStep:
                    return new TuningTuneDownHalfStep();
                case TuningType.TuneDownOneStep:
                    return new TuningTuneDownOneStep();
                case TuningType.TuneDownTwoStep:
                    return new TuningTuneDownTwoStep();
                case TuningType.DroppedD:
                    return new TuningDroppedD();
                case TuningType.DroppedDVariant:
                    return new TuningDroppedDVariant();
                case TuningType.DoubleDroppedD:
                    return new TuningDoubleDroppedD();
                case TuningType.DroppedC:
                    return new TuningDroppedC();
                case TuningType.DroppedE:
                    return new TuningDroppedE();
                case TuningType.DroppedB:
                    return new TuningDroppedB();
                case TuningType.Baritone:
                    return new TuningBaritone();
                case TuningType.OpenC:
                    return new TuningOpenC();
                case TuningType.OpenCm:
                    return new TuningOpenCm();
                case TuningType.OpenC6:
                    return new TuningOpenC6();
                case TuningType.OpenCM7:
                    return new TuningOpenCM7();
                case TuningType.OpenD:
                    return new TuningOpenD();
                case TuningType.OpenDm:
                    return new TuningOpenDm();
                case TuningType.OpenD5:
                    return new TuningOpenD5();
                case TuningType.OpenD6:
                    return new TuningOpenD6();
                case TuningType.OpenDsus4:
                    return new TuningOpenDsus4();
                case TuningType.OpenE:
                    return new TuningOpenE();
                case TuningType.OpenEm:
                    return new TuningOpenEm();
                case TuningType.OpenEsus11:
                    return new TuningOpenEsus11();
                case TuningType.OpenF:
                    return new TuningOpenF();
                case TuningType.OpenG:
                    return new TuningOpenG();
                case TuningType.OpenGm:
                    return new TuningOpenGm();
                case TuningType.OpenGsus4:
                    return new TuningOpenGsus4();
                case TuningType.OpenG6:
                    return new TuningOpenG6();
                case TuningType.OpenA:
                    return new TuningOpenA();
                case TuningType.OpenAm:
                    return new TuningOpenAm();
                case TuningType.DobroOpenG:
                    return new TuningDobroOpenG();
                case TuningType.Nashville:
                    return new TuningNashville();
                case TuningType.LuteOrVihuela:
                    return new TuningLuteOrVihuela();
                default:
                    throw new ArgumentOutOfRangeException(nameof(tuningType));
            }
        }

        public abstract string GetName();

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var note in Notes)
            {
                sb.Append(note + " ");
            }

            var notes = sb.ToString().Trim();
            var result = $"{GetName()} ({notes})";

            return result;
        }

        // public List<Cord> GetCords()
        // {
        //    return Notes
        //        .Select(note => new Cord(note))
        //        .ToList();
        // }
    }
}