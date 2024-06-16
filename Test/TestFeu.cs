using Xunit;
using POKEMONFATOUTHIAMDIOUMSN2;



    public class TestFeu
    {
        [Fact]
        public void TestInitialValues()
        {
            // Arrange
            PokemonFeu pokemon = new PokemonFeu("Charmander", 100, 30);

            // Assert
            Assert.Equal("Charmander", pokemon.Nom);
            Assert.Equal(100, pokemon.HP);
            Assert.Equal(30, pokemon.Atk);
        }

        [Fact]
        public void TestIsDead()
        {
            // Arrange
            PokemonFeu pokemon = new PokemonFeu("Charmander", 0, 30);

            // Act
            bool isDead = pokemon.IsDead();

            // Assert
            Assert.True(isDead);
        }

        // Ajoutez d'autres tests au besoin
    }

