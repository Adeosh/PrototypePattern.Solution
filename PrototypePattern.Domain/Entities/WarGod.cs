using PrototypePattern.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Domain.Entities
{
    public class WarGod : Olympian, IMyCloneable<WarGod>
    {
        /// <summary> Тип военной тактики (агрессивная, стратегическая и т.д.). </summary>
        public string WarfareStyle { get; set; }

        /// <summary> Уровень боевой ярости (0-100). </summary>
        public int BattleRage { get; set; }

        /// <summary> Количество побед в сражениях. </summary>
        public int VictoriesCount { get; set; }

        /// <summary> Инициализирует новый экземпляр. </summary>
        public WarGod(string name, string domain, int powerLevel, string symbol, int olympusRank, string warfareStyle, int battleRage, int victoriesCount) 
            : base(name, domain, powerLevel, symbol, olympusRank)
        {
            WarfareStyle = warfareStyle;
            BattleRage = battleRage;
            VictoriesCount = victoriesCount;
        }

        /// <summary> Конструктор копирования с вызовом родительского конструктора. </summary>
        protected WarGod(WarGod other) : base(other)
        {
            WarfareStyle = other.WarfareStyle;
            BattleRage = other.BattleRage;
            VictoriesCount = other.VictoriesCount;
        }

        /// <summary> Создает нетипизированную копию. </summary>
        public override Deity Clone()
        {
            return new WarGod(this);
        }

        /// <summary> Создает типизированную копию. </summary>
        WarGod IMyCloneable<WarGod>.Clone()
        {
            return new WarGod(this);
        }

        /// <summary> Возвращает описание. </summary>
        public override string GetDescription()
        {
            return base.GetDescription() +
                   $"\n  Тип военной тактики: {WarfareStyle}\n" +
                   $"  Уровень боевой ярости: {BattleRage}\n" +
                   $"  Количество побед: {VictoriesCount}";
        }
    }
}
