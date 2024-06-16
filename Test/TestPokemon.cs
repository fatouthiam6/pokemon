using Xunit;
using POKEMONFATOUTHIAMDIOUMSN2;


    public class TestPokemon
    {
        [Fact]
        public void TestInitialValues()
        {
            // Arrange
            Pokemon pokemon = new Pokemon("Pikachu", 100, 30);

            // Assert
            Assert.Equal("Pikachu", pokemon.Nom);
            Assert.Equal(100, pokemon.HP);
            Assert.Equal(30, pokemon.Atk);
        }

        [Fact]
        public void TestIsDead()
        {
            // Arrange
            Pokemon pokemon = new Pokemon("Pikachu", 0, 30);

            // Act
            bool isDead = pokemon.IsDead();

            // Assert
            Assert.True(isDead);
        }

        [Fact]
        public void TestAttaque()
        {
            // Arrange
            Pokemon attaquant = new Pokemon("Pikachu", 100, 30);
            Pokemon cible = new Pokemon("Bulbasaur", 100, 20);

            // Act
            attaquant.Attaque(cible);

            // Assert
            Assert.Equal(70, cible.HP); // Vérifie que les points de vie de la cible ont été réduits après l'attaque
        }
    }

