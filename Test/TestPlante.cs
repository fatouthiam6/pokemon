using Xunit;
using POKEMONFATOUTHIAMDIOUMSN2;



    public class TestPlante
    {
        [Fact]
        public void TestInitialValues()
        {
            // Arrange
            PokemonPlante pokemon = new PokemonPlante("Bulbasaur", 100, 30);

            // Assert
            Assert.Equal("Bulbasaur", pokemon.Nom);
            Assert.Equal(100, pokemon.HP);
            Assert.Equal(30, pokemon.Atk);
        }

        [Fact]
        public void TestIsDead()
        {
            // Arrange
            PokemonPlante pokemon = new PokemonPlante("Bulbasaur", 0, 30);

            // Act
            bool isDead = pokemon.IsDead();

            // Assert
            Assert.True(isDead);
        }

        // Ajoutez d'autres tests au besoin
    }

