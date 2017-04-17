namespace MidiMinuit.Music.Core
{
    public abstract class IntervalCompound
        : Interval
    {
        protected IntervalCompound()
        {
        }

        protected IntervalCompound(Pitch startingPitch)
            : base(startingPitch)
        {
            StartingPitch = startingPitch;
        }

        public override Interval InverseOctaveUp()
        {
            var startingPitch = new Pitch(EndingPitch);
            //startingPitch.Accidental = startingPitch.Accidental.Value * -1;

            var endingPitch = new Pitch(StartingPitch);
            endingPitch.Octave++;
            endingPitch.Octave++;

            return Create(startingPitch, endingPitch);
        }

        public override Interval InverseOctaveDown()
        {
            var startingPitch = new Pitch(EndingPitch);
            //startingPitch.Accidental = startingPitch.Accidental.Value * -1;
            startingPitch.Octave--;
            startingPitch.Octave--;

            var endingPitch = new Pitch(StartingPitch);

            return Create(startingPitch, endingPitch);
        }

        public Interval InverseOctaveMiddle()
        {
            var startingPitch = new Pitch(EndingPitch);
            //startingPitch.Accidental = startingPitch.Accidental.Value * -1;
            startingPitch.Octave--;

            var endingPitch = new Pitch(StartingPitch);
            endingPitch.Octave++;

            return Create(startingPitch, endingPitch);
        }

        public Interval ToSimple()
        {
            var startingPitch = new Pitch(StartingPitch);

            var endingPitch = new Pitch(EndingPitch);
            endingPitch.Octave--;

            return Create(startingPitch, endingPitch);
        }
    }
}