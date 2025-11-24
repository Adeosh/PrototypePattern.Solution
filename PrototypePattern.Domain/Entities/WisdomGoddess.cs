using PrototypePattern.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Domain.Entities
{
    public class WisdomGoddess : Olympian, IMyCloneable<WisdomGoddess>
    {
        /// <summary> Уровень мудрости (0-100). </summary>
        public int WisdomLevel { get; set; }

        /// <summary> Область знаний (философия, наука, искусство и т.д.) </summary>
        public string KnowledgeDomain { get; set; }

        /// <summary> Количество смертных, которым было даровано покровительство. </summary>
        public int ProtectedMortals { get; set; }

        /// <summary> Инициализирует новый экземпляр. </summary>
        public WisdomGoddess(string name, string domain, int powerLevel, string symbol, int olympusRank, int wisdomLevel, string knowledgeDomain, int protectedMortals) 
            : base(name, domain, powerLevel, symbol, olympusRank)
        {
            WisdomLevel = wisdomLevel;
            KnowledgeDomain = knowledgeDomain;
            ProtectedMortals = protectedMortals;
        }

        /// <summary> Конструктор копирования с вызовом родительского конструктора. </summary>
        protected WisdomGoddess(WisdomGoddess other) : base(other)
        {
            WisdomLevel = other.WisdomLevel;
            KnowledgeDomain = other.KnowledgeDomain;
            ProtectedMortals = other.ProtectedMortals;
        }

        /// <summary> Создает нетипизированную копию. </summary>
        public override Deity Clone()
        {
            return new WisdomGoddess(this);
        }

        /// <summary> Создает типизированную копию. </summary>
        WisdomGoddess IMyCloneable<WisdomGoddess>.Clone()
        {
            return new WisdomGoddess(this);
        }

        /// <summary> Возвращает описание. </summary>
        public override string GetDescription()
        {
            return base.GetDescription() +
                   $"\n  Уровень мудрости: {WisdomLevel}\n" +
                   $"  Область знаний: {KnowledgeDomain}\n" +
                   $"  Количество смертных, которым было даровано покровительство: {ProtectedMortals}";
        }
    }
}
