namespace PrototypePattern.Domain.Abstractions
{
    /// <summary> Дженерик интерфейс для реализации паттерна Прототип с типобезопасностью. </summary>
    public interface IMyCloneable<T> where T : class
    {
        /// <summary> Создает копию текущего объекта. </summary>
        T Clone();
    }
}
