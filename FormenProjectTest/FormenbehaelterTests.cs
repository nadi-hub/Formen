using Formen;

namespace FormenProjectTest
{
    public class FormenbehaelterTests
    {
        [Fact]
        public void FuegeZweiRechteckeHinzu_Erfolgreich()
        {
            // Arrange
            var formenbehaelter = new Formenbehaelter();

            // Act
            formenbehaelter.AddiereFormen(new Rechteck());
            formenbehaelter.AddiereFormen(new Rechteck());

            // Assert
            Assert.NotNull(formenbehaelter.rechtecke[0]);
            Assert.NotNull(formenbehaelter.rechtecke[1]);
        }

        [Fact]
        public void FuegeEinDreieckHinzu_Erfolgreich()
        {
            // Arrange
            var formenbehaelter = new Formenbehaelter();

            // Act
            formenbehaelter.AddiereFormen(new Dreieck());

            // Assert
            Assert.NotNull(formenbehaelter.dreiecke[0]);
        }

        [Fact]
        public void FuegeZweiKreiseHinzu_Erfolgreich()
        {
            // Arrange
            var formenbehaelter = new Formenbehaelter();

            // Act
            formenbehaelter.AddiereFormen(new Kreis());
            formenbehaelter.AddiereFormen(new Kreis());

            // Assert
            Assert.NotNull(formenbehaelter.kreise[0]);
            Assert.NotNull(formenbehaelter.kreise[1]);
        }
    }
}