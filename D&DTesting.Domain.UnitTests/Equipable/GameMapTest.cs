using D_DTesting.Domain.UnitTests.Models;

namespace D_DTesting.Domain.UnitTests.Equipable
{
    public class GameMapTest
    {
        private readonly GameMap _gameMap = TestModels.TestGameMap;
        private readonly PlayableCharacter _pc = TestModels.PCTest;

        [Test]
        public void GameMapShouldNotBeNull()
        {
            Assert.NotNull(_gameMap);
        }

        [Test]
        public void GameMapPropertyIsIInteractableObject()
        {
            Assert.IsTrue(_gameMap.Tiles[0,0].Occupant is null);
        }

        [Test]
        public void GameMapHeightShouldBeGreaterThanZero()
        {
            Assert.Greater(_gameMap.Height, 0);
        }

        [Test]
        public void GameMapWidthShouldBeGreaterThanZero()
        {
            Assert.Greater(_gameMap.Width, 0);
        }

        [Test]
        public void GameMapShouldHaveOnePlayer()
        {
            _gameMap.Interactables.Add(_pc);
            Assert.IsTrue(_gameMap.Interactables.Contains(_pc));
        }

        [Test]
        public void GameMapTileShouldBeOccupied()
        {
            _gameMap.Interactables.Add(_pc);
            _gameMap.Tiles[0,0].SetOccupant(_pc);
            Assert.IsTrue(_gameMap.Tiles[0,0].Occupant is PlayableCharacter);
        }
    }
}
