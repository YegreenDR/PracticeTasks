namespace GameLib
{
    public class Game
    {
        private string Name;
        private string Genre;
        public Game(string name, string genre)
        {
            Genre = genre;
            Name = name;
        }
        public void Info(Action<string> action)
        {
            action($"Game - {this.Name} in genre - {this.Genre}");
        }

    }
}