using static System.Console;

namespace ExampleLibrary
{
    public interface IPlayable
    {
        void Play();

        void Pause();

        // Default interface-implementation example.
        void Stop()
        {
            WriteLine("Default Stop implementation.");
        }
    }
}