using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore
{
    public static List<Hero> Heroes { get; } = new()
    {
        new Hero
        {
            Id = 1,
            Name = "Человек-паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new() {"Паутина", "Лазание по стенам", "паучье чутьё"},
            Weapon = new() {Name = "Паутинострел", IsRanged = true},
            InternalNotes = "Любимый герой редактора"
        },
new Hero
        {
            Id = 2,
            Name = "Бэтмен",
            RealName = "Брюс Уэйн",
            Universe = Universe.DC,
            PowerLevel = 70,
            Powers = new() {"Интеллект", "Боевые искусства", "Технологии"},
            Weapon = new() {Name = "Бэтаранг", IsRanged = true},
            InternalNotes = "Без суперсил, только деньги и упорство"
        },
new Hero
        {
            Id = 3,
            Name = "Железный человек",
            RealName = "Тони старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"Броня", "Полёт", "Лазеры"},
            Weapon = new() {Name = "Кост Марк 50", IsRanged = true},
            InternalNotes = "Я - Железный человек"
        },
new Hero
        {
            Id = 4,
            Name = "Грут",
            RealName = "Грут",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() {"Регенерация", "Управление деревом", "Суперсила"},
            Weapon = new() {Name = "Ветви", IsRanged = false},
            InternalNotes = "Я есть Грут"
        },
new Hero
        {
            Id = 5,
            Name = "Тор",
            RealName = "Тор Одинсон",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new() {"Молния", "Полёт", "Суперсила", "Бессмертие"},
            Weapon = new() {Name = "Мьёльнир", IsRanged = false},
            InternalNotes = "Бог грома"
        },
new Hero
        {
            Id = 6,
            Name = "Росомаха",
            RealName = "Логан",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"Регенерация", "Когти", "Суперсила", "Замедленное старение"},
            Weapon = new() {Name = "Адамантиевые когти", IsRanged = false},
            InternalNotes = "Лучший у меня есть"
        },
new Hero
        {
            Id = 7,
            Name = "Дэдпул",
            RealName = "Уэйд Уилсен",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() {"Регенерация", "Владение оружием", "Болтовня"},
            Weapon = new() {Name = "Катаны и пистолет", IsRanged = true},
            InternalNotes = "Разрушает четвёртую стену"
        },
    };
}