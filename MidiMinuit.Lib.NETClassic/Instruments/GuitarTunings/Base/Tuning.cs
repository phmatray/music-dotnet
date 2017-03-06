using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Instruments.GuitarTunings
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

        public static Tuning GetTuning(TuningTypeEnum tuningType = TuningTypeEnum.Standard)
        {
            switch (tuningType)
            {
                case TuningTypeEnum.Standard:
                    return new TuningStandard();
                case TuningTypeEnum.TuneDownHalfStep:
                    return new TuningTuneDownHalfStep();
                case TuningTypeEnum.TuneDownOneStep:
                    return new TuningTuneDownOneStep();
                case TuningTypeEnum.TuneDownTwoStep:
                    return new TuningTuneDownTwoStep();
                case TuningTypeEnum.DroppedD:
                    return new TuningDroppedD();
                case TuningTypeEnum.DroppedDVariant:
                    return new TuningDroppedDVariant();
                case TuningTypeEnum.DoubleDroppedD:
                    return new TuningDoubleDroppedD();
                case TuningTypeEnum.DroppedC:
                    return new TuningDroppedC();
                case TuningTypeEnum.DroppedE:
                    return new TuningDroppedE();
                case TuningTypeEnum.DroppedB:
                    return new TuningDroppedB();
                case TuningTypeEnum.Baritone:
                    return new TuningBaritone();
                case TuningTypeEnum.OpenC:
                    return new TuningOpenC();
                case TuningTypeEnum.OpenCm:
                    return new TuningOpenCm();
                case TuningTypeEnum.OpenC6:
                    return new TuningOpenC6();
                case TuningTypeEnum.OpenCM7:
                    return new TuningOpenCM7();
                case TuningTypeEnum.OpenD:
                    return new TuningOpenD();
                case TuningTypeEnum.OpenDm:
                    return new TuningOpenDm();
                case TuningTypeEnum.OpenD5:
                    return new TuningOpenD5();
                case TuningTypeEnum.OpenD6:
                    return new TuningOpenD6();
                case TuningTypeEnum.OpenDsus4:
                    return new TuningOpenDsus4();
                case TuningTypeEnum.OpenE:
                    return new TuningOpenE();
                case TuningTypeEnum.OpenEm:
                    return new TuningOpenEm();
                case TuningTypeEnum.OpenEsus11:
                    return new TuningOpenEsus11();
                case TuningTypeEnum.OpenF:
                    return new TuningOpenF();
                case TuningTypeEnum.OpenG:
                    return new TuningOpenG();
                case TuningTypeEnum.OpenGm:
                    return new TuningOpenGm();
                case TuningTypeEnum.OpenGsus4:
                    return new TuningOpenGsus4();
                case TuningTypeEnum.OpenG6:
                    return new TuningOpenG6();
                case TuningTypeEnum.OpenA:
                    return new TuningOpenA();
                case TuningTypeEnum.OpenAm:
                    return new TuningOpenAm();
                case TuningTypeEnum.DobroOpenG:
                    return new TuningDobroOpenG();
                case TuningTypeEnum.Nashville:
                    return new TuningNashville();
                case TuningTypeEnum.LuteOrVihuela:
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