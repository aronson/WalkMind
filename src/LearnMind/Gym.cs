namespace LearnMind
{

    public class GymParameters
    {
        public string Name { get; }
        public Save Save { get; }
    }
    /// <summary>
    /// A gym describes the starting conditions for an AI's attempt to pass a test as well as the goal state.
    /// </summary>
    public class Gym
    {
        private readonly string _name;
        public Gym(string name)
        {
            _name = name;
        }
    }
}