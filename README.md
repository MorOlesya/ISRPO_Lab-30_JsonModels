## Автор

**ФИО:** Морозова О. С.

**Группа:** ИСП-231

**Дата:** 24.04.2026

## Маршруты

| Метод | Маршруты                      |
| ----- | ----------------------------- |
| GET   | /api/heroes                   |
| GET   | /api/heroes?universe=Marvel   |
| GET   | /api/heroes?universe=DC       |
| GET   | /api/heroes/{id}              |
| GET   | /api/heroes/demo              |
| GET   | /api/heroes/serialize         |
| GET   | /api/heroes/search?name=текст |

## Таблица атрибутов JSON

| Атрибут / настройка            | Что делает              | Пример                       |
| ------------------------------ | ----------------------- | ---------------------------- |
| [JsonPropertyName("name")]     | Задаёт имя поля в JSON  | "name" вместо "Name"         |
| [JsonIgnore]                   | Поле не попадает в JSON | Пароли, внутренние поля      |
| PropertyNamingPolicy.CamelCase | Все поля в camelCase    | "realName" вместо "RealName" |
| JsonStringEnumConverter        | Enum как строка         | "Marvel" вместо 0            |
| WriteIndented = true           | JSON с отступами        | Для удобства при разработке  |

## Главные выводы

1. Сериализация преобразует C#-объект в строку JSON и десериализация берёт JSON-строку serialized и создаёт из неё новый объект
2. [JsonIgnore] — исключает поле из сериализации. Например, можно использовать @JsonIgnore для полей, которые не должны включаться в JSON-ответ.
3. enum лучше сериализовывать строкой, а не числом, потому что:
    * "universe": "DC" понятнее чем "universe": 0.
4. После настройки CamelCase в ответе стало:
    * RealName → realName
    * PowerLevel → powerLevel.