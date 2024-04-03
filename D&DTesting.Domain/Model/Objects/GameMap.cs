using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Objects
{
    public class GameMap
    {
        public GameMap(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[width, height];
            Interactables = new List<IInteractableObject>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Tiles[i, j] = new Tile();
                }
            }
        }

        public Tile[,] Tiles { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IList<IInteractableObject> Interactables { get; set; }
    }
}
