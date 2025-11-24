using PrototypePattern.Domain.Abstractions;

namespace PrototypePattern.Domain.Entities
{
    public class Deity : IMyCloneable<Deity>, ICloneable
    {
        /// <summary> Имя божества </summary>
        public string Name { get; set; }

        /// <summary> Сфера влияния </summary>
        public string Domain { get; set; }

        /// <summary> Уровень божественной силы (0-100) </summary>
        public int PowerLevel { get; set; }

        /// <summary> Инициализирует новый экземпляр. </summary>
        public Deity(string name, string domain, int powerLevel)
        {
            Name = name;
            Domain = domain;
            PowerLevel = powerLevel;
        }

        /// <summary> Конструктор копирования для создания клона божества. </summary>
        protected Deity(Deity other)
        {
            Name = other.Name;
            Domain = other.Domain;
            PowerLevel = other.PowerLevel;
        }

        /// <summary> Создает типизированную копию божества. </summary>
        public virtual Deity Clone()
        {
            return new Deity(this);
        }

        /// <summary> Реализация стандартного интерфейса ICloneable. </summary>
        object ICloneable.Clone()
        {
            return Clone();
        }

        /// <summary> Возвращает описание. </summary>
        public virtual string GetDescription()
        {
            return $"[{GetType().Name}] {Name}\n" +
                   $"  Сфера влияния: {Domain}\n" +
                   $"  Уровень божественной силы: {PowerLevel}";
        }
    }
}
