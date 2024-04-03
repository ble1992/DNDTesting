using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;

namespace D_DTesting.Domain.Model.Objects
{
    public class Tile
    {
        public Tile()
        {
            FeetPerTile = 5;
            IsOccupied = false;
            Occupant = null;
        }

        public TerrainType Terrain { get; set; }
        public bool IsOccupied { get; set; }
        public IInteractableObject? Occupant { get; set; }
        public int FeetPerTile { get; set; }

        public void SetOccupant(IInteractableObject occupant)
        {
            IsOccupied = true;
            Occupant = occupant;
        }

        public void RemoveOccupant()
        {
            IsOccupied = false;
            Occupant = null;
        }
    }
}
