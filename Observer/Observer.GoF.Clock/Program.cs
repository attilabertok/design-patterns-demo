using Observer.GoF.Clock.Timekeeping;
using Observer.GoF.Clock.Timekeeping.Clocks;

namespace Observer.GoF.Clock
{
    public static class Program
    {
        public static void Main()
        {
            var timer = new ClockTimer();
            var analogueClock = new AnalogueClock(timer);
            var digitalClock = new DigitalClock(timer);

            Console.ReadLine();
        }
    }
}
