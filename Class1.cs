using System;

namespace TDD3
{
    public sealed class World
    {
        private World() { }

        private static World _instance;

        public int Day { get; set; }
        public double Latitude { get; set; }
        public string City { get; set; }

        public static World GetInstance()
        {
            if (_instance == null)
            {
                _instance = new World();
            }
            return _instance;
        }

        public string DetermineSeason()
        {
            if (Day < 1 || Day > 366)
            {
                throw new ArgumentOutOfRangeException(nameof(Day), "Day must be between 1 and 366.");
            }

            if (Latitude >= 0)
            {
                if (Day >= 80 && Day < 172) return "Spring";
                if (Day >= 172 && Day < 265) return "Summer";
                if (Day >= 265 && Day < 355) return "Autumn";
                return "Winter";
            }
            else
            {
                if (Day >= 80 && Day < 172) return "Autumn";
                if (Day >= 172 && Day < 265) return "Winter";
                if (Day >= 265 && Day < 355) return "Spring";
                return "Summer";
            }
        }

        public void PrintInfo()
        {
            string season = DetermineSeason();
            Console.WriteLine($"City: {City}, Latitude: {Latitude}, Day: {Day}, Season: {season}");
        }
    }

}
