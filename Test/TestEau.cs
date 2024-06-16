using POKEMONFATOUTHIAMDIOUMSN2;
using Xunit;




    public class TestEau
    {
        [Fact]
        public void TestInitialValues()
        {
            // Arrange
            PokemonEau pokemon = new PokemonEau("Squirtle", 100, 30);

            // Assert
            Assert.Equal("Squirtle", pokemon.Nom);
            Assert.Equal(100, pokemon.HP);
            Assert.Equal(30, pokemon.Atk);
        }

        [Fact]
        public void TestIsDead()
        {
            // Arrange
            PokemonEau pokemon = new PokemonEau("Squirtle", 0, 30);

            // Act
            bool isDead = pokemon.IsDead();

            // Assert
            Assert.True(isDead);
        }

        // Ajoutez d'autres tests au besoin
    }

