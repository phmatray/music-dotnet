namespace MidiMinuit.Lib.Core.Intervals
{
    public enum IntervalSpanning
    {
        /*
         * A simple interval is an interval spanning at most one octave (see Main intervals above).
         * Intervals spanning more than one octave are called compound intervals, as they can be
         * obtained by adding one or more octaves to a simple interval (see below for details).
         */

        Simple,
        Compound
    }
}