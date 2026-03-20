# Planner

Десктопный планировщик задач для Windows на WinForms (.NET Framework 4.7.2).

![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Framework](https://img.shields.io/badge/.NET-4.7.2-purple)
![Language](https://img.shields.io/badge/C%23-WinForms-green)

## Возможности

- **Создание задач** — название, описание, дедлайн (дата + время)
- **Статусы задач** — не начата, в работе, выполнена, просрочена
- **Автопросрочка** — задача автоматически помечается просроченной когда время выходит
- **Напоминания** — можно привязать к задаче одно или несколько уведомлений на конкретное время
- **Умная сортировка** — задачи в работе всегда наверху, остальные по дедлайну
- **Трей** — приложение сворачивается в системный трей, не закрывается
- **VK-уведомления** — опциональная интеграция с VK, шлёт сообщения в личку при просрочке или срабатывании напоминания
- **Сохранение** — все задачи хранятся локально в JSON

## Скриншоты

> _Добавь скриншоты сюда_

## Установка

1. Скачай архив из [Releases](../../releases) и распакуй в любую папку
2. Запусти `planner.exe`

Требования: Windows 7+, [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

## Сборка из исходников

```
git clone https://github.com/mmk0420/Planner.git
```

Открой `planner.sln` в Visual Studio 2022, собери в конфигурации Release.

## Стек

| | |
|---|---|
| Язык | C# |
| UI | WinForms |
| Фреймворк | .NET Framework 4.7.2 |
| Сериализация | Newtonsoft.Json |
| Уведомления | Tulpep.NotificationWindow |
| VK API | VkNet |

## Лицензия

MIT
