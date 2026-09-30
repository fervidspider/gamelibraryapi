

namespace GameLibraryApi.Models{
    public class Game
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Edition { get; set; } = "Standard";
        public string Platform { get; set; } = "Not Specified";
        public bool IsOwnedPhysical { get; set; } = false;
        public bool IsOwnedDigital { get; set; } = false;
    }

}