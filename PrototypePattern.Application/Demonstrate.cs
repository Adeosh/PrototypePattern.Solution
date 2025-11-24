using PrototypePattern.Domain.Abstractions;
using PrototypePattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Application
{
    public static class Demonstrate
    {
        public static void PrototypePattern()
        {
            // Создание оригинальных объектов
            var ares = CreateAres();
            var athena = CreateAthena();
            var zeus = CreateZeus();

            PrintSection("Оригинальные божества");
            PrintDeity(ares);
            PrintDeity(athena);
            PrintDeity(zeus);

            // Клонирование через IMyCloneable<T>
            PrintSection("Клонирование через IMyCloneable<T>");
            var aresClone = ((IMyCloneable<WarGod>)ares).Clone();
            var athenaClone = ((IMyCloneable<WisdomGoddess>)athena).Clone();
            var zeusClone = ((IMyCloneable<Olympian>)zeus).Clone();

            ModifyClones(aresClone, athenaClone, zeusClone);

            PrintDeity(aresClone);
            PrintDeity(athenaClone);
            PrintDeity(zeusClone);

            // Клонирование через ICloneable
            PrintSection("Клонирование через ICloneable");
            var aresClone2 = (WarGod)((ICloneable)ares).Clone();
            var athenaClone2 = (WisdomGoddess)((ICloneable)athena).Clone();
            var zeusClone2 = (Olympian)((ICloneable)zeus).Clone();

            aresClone2.Name = "Клон Ареса (ICloneable)";
            athenaClone2.Name = "Клон Афины (ICloneable)";
            zeusClone2.Name = "Клон Зевса (ICloneable)";

            PrintDeity(aresClone2);
            PrintDeity(athenaClone2);
            PrintDeity(zeusClone2);

            // Проверка независимости
            PrintSection("Проверка независимости объектов");
            Console.WriteLine($"Оригинальный Арес: {ares.Name}, Ярость: {ares.BattleRage}");
            Console.WriteLine($"Клон (IMyCloneable): {aresClone.Name}, Ярость: {aresClone.BattleRage}");
            Console.WriteLine($"Клон (ICloneable): {aresClone2.Name}, Ярость: {aresClone2.BattleRage}");
        }

        private static WarGod CreateAres()
        {
            return new WarGod(
                name: "Арес",
                domain: "Война и кровопролитие",
                powerLevel: 85,
                symbol: "Меч и копье",
                olympusRank: 7,
                warfareStyle: "Агрессивная",
                battleRage: 95,
                victoriesCount: 1247
            );
        }

        private static WisdomGoddess CreateAthena()
        {
            return new WisdomGoddess(
                name: "Афина",
                domain: "Мудрость и стратегия",
                powerLevel: 92,
                symbol: "Сова и эгида",
                olympusRank: 3,
                wisdomLevel: 98,
                knowledgeDomain: "Философия и военная стратегия",
                protectedMortals: 5432
            );
        }

        private static Olympian CreateZeus()
        {
            return new Olympian(
                name: "Зевс",
                domain: "Небо и гром",
                powerLevel: 100,
                symbol: "Молния",
                olympusRank: 1
            );
        }

        private static void ModifyClones(WarGod ares, WisdomGoddess athena, Olympian zeus)
        {
            ares.Name = "Клон Ареса (IMyCloneable)";
            ares.BattleRage = 100;

            athena.Name = "Клон Афины (IMyCloneable)";
            athena.WisdomLevel = 99;

            zeus.Name = "Клон Зевса (IMyCloneable)";
            zeus.PowerLevel = 95;
        }

        private static void PrintSection(string title)
        {
            Console.WriteLine($"\n--- {title} ---\n");
        }

        private static void PrintDeity(Deity deity)
        {
            Console.WriteLine(deity.GetDescription());
            Console.WriteLine();
        }
    }
}
