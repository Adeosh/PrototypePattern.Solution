using PrototypePattern.Domain.Abstractions;
using PrototypePattern.Domain.Entities;

namespace PrototypePattern.Tests
{
    public class DeityCloneTests
    {
        [Fact]
        public void WarGod_Clone_ShouldCreateIndependentCopy()
        {
            // Arrange
            var original = new WarGod(
                "Арес",
                "Война",
                85,
                "Меч",
                7,
                "Агрессивная",
                95,
                1000
            );

            // Act
            var clone = ((IMyCloneable<WarGod>)original).Clone();
            clone.Name = "Арей";
            clone.BattleRage = 100;

            // Assert
            Assert.NotEqual(original.Name, clone.Name);
            Assert.NotEqual(original.BattleRage, clone.BattleRage);
            Assert.Equal(original.WarfareStyle, clone.WarfareStyle);
            Assert.Equal(original.VictoriesCount, clone.VictoriesCount);
        }

        [Fact]
        public void WisdomGoddess_Clone_ShouldCopyAllProperties()
        {
            // Arrange
            var original = new WisdomGoddess(
                "Афина",
                "Мудрость",
                92,
                "Сова",
                3,
                98,
                "Философия",
                5000
            );

            // Act
            var clone = ((IMyCloneable<WisdomGoddess>)original).Clone();

            // Assert
            Assert.Equal(original.Name, clone.Name);
            Assert.Equal(original.PowerLevel, clone.PowerLevel);
            Assert.Equal(original.WisdomLevel, clone.WisdomLevel);
            Assert.Equal(original.KnowledgeDomain, clone.KnowledgeDomain);
            Assert.Equal(original.ProtectedMortals, clone.ProtectedMortals);
        }

        [Fact]
        public void Olympian_Clone_ShouldWorkWithBaseClass()
        {
            // Arrange
            var original = new Olympian(
                "Зевс",
                "Небо",
                100,
                "Молния",
                1
            );

            // Act
            var clone = ((IMyCloneable<Olympian>)original).Clone();
            clone.Symbol = "Туча";

            // Assert
            Assert.NotEqual(original.Symbol, clone.Symbol);
            Assert.Equal(original.Name, clone.Name);
            Assert.Equal(original.OlympusRank, clone.OlympusRank);
        }
    }
}
