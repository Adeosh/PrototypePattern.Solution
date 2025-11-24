using PrototypePattern.Domain.Abstractions;

namespace PrototypePattern.Domain.Entities
{
    public class Olympian : Deity, IMyCloneable<Olympian>
    {
        /// <summary> Символ или атрибут олимпийского бога. </summary>
        public string Symbol { get; set; }

        /// <summary> Уровень влияния на Олимпе (0-10). </summary>
        public int OlympusRank { get; set; }

        /// <summary> Инициализирует новый экземпляр. </summary>
        public Olympian(string name, string domain, int powerLevel, string symbol, int olympusRank) 
            : base(name, domain, powerLevel)
        {
            Symbol = symbol;
            OlympusRank = olympusRank;
        }

        /// <summary> Конструктор копирования с вызовом родительского конструктора. </summary>
        protected Olympian(Olympian other) : base(other)
        {
            Symbol = other.Symbol;
            OlympusRank = other.OlympusRank;
        }

        /// <summary> Создает нетипизированную копию. </summary>
        public override Deity Clone()
        {
            return new Olympian(this);
        }

        /// <summary> Создает типизированную копию. </summary>
        Olympian IMyCloneable<Olympian>.Clone()
        {
            return new Olympian(this);
        }

        /// <summary> Возвращает описание. </summary>
        public override string GetDescription()
        {
            return base.GetDescription() +
                   $"\n  Символ: {Symbol}\n" +
                   $"  Уровень влияния: {OlympusRank}";
        }
    }
}
