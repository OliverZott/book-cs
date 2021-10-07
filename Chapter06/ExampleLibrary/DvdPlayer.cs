using static System.Console;

namespace ExampleLibrary
{
    public class DvdPlayer : IPlayable
    {
        public void Play()
        {
            WriteLine("DVD is playing.");
        }

        public void Pause()
        {
            WriteLine("DVD is pausing.");
        }
    }
}