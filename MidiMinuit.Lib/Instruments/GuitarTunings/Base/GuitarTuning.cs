namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Core.Notes;

    public abstract class GuitarTuning
    {
        protected GuitarTuning(List<Note> tuning)
        {
            Notes = new ReadOnlyCollection<Note>(tuning);
        }

        protected GuitarTuning(params Note[] tuning)
        {
            Notes = new ReadOnlyCollection<Note>(tuning);
        }

        protected GuitarTuning(params string[] tuning)
        {
            var notes = tuning
                .Select((n, i) => new Note(tuning[i]))
                .ToArray();

            Notes = new ReadOnlyCollection<Note>(notes);
        }

        public ReadOnlyCollection<Note> Notes { get; }

        public static GuitarTuning GetTuning(GuitarTuningType tuningType = GuitarTuningType.Standard)
        {
            switch (tuningType)
            {
                case GuitarTuningType.Standard:
                    return new TuningStandard();
                case GuitarTuningType.TuneDownHalfStep:
                    return new TuningTuneDownHalfStep();
                case GuitarTuningType.TuneDownOneStep:
                    return new TuningTuneDownOneStep();
                case GuitarTuningType.TuneDownTwoStep:
                    return new TuningTuneDownTwoStep();
                case GuitarTuningType.DroppedD:
                    return new TuningDroppedD();
                case GuitarTuningType.DroppedDVariant:
                    return new TuningDroppedDVariant();
                case GuitarTuningType.DoubleDroppedD:
                    return new TuningDoubleDroppedD();
                case GuitarTuningType.DroppedC:
                    return new TuningDroppedC();
                case GuitarTuningType.DroppedE:
                    return new TuningDroppedE();
                case GuitarTuningType.DroppedB:
                    return new TuningDroppedB();
                case GuitarTuningType.Baritone:
                    return new TuningBaritone();
                case GuitarTuningType.OpenC:
                    return new TuningOpenC();
                case GuitarTuningType.OpenCm:
                    return new TuningOpenCm();
                case GuitarTuningType.OpenC6:
                    return new TuningOpenC6();
                case GuitarTuningType.OpenCM7:
                    return new TuningOpenCM7();
                case GuitarTuningType.OpenD:
                    return new TuningOpenD();
                case GuitarTuningType.OpenDm:
                    return new TuningOpenDm();
                case GuitarTuningType.OpenD5:
                    return new TuningOpenD5();
                case GuitarTuningType.OpenD6:
                    return new TuningOpenD6();
                case GuitarTuningType.OpenDsus4:
                    return new TuningOpenDsus4();
                case GuitarTuningType.OpenE:
                    return new TuningOpenE();
                case GuitarTuningType.OpenEm:
                    return new TuningOpenEm();
                case GuitarTuningType.OpenEsus11:
                    return new TuningOpenEsus11();
                case GuitarTuningType.OpenF:
                    return new TuningOpenF();
                case GuitarTuningType.OpenG:
                    return new TuningOpenG();
                case GuitarTuningType.OpenGm:
                    return new TuningOpenGm();
                case GuitarTuningType.OpenGsus4:
                    return new TuningOpenGsus4();
                case GuitarTuningType.OpenG6:
                    return new TuningOpenG6();
                case GuitarTuningType.OpenA:
                    return new TuningOpenA();
                case GuitarTuningType.OpenAm:
                    return new TuningOpenAm();
                case GuitarTuningType.DobroOpenG:
                    return new TuningDobroOpenG();
                case GuitarTuningType.Nashville:
                    return new TuningNashville();
                case GuitarTuningType.LuteOrVihuela:
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