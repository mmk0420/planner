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

<details>
  <summary>Главный экран &nbsp;</summary>
  <br>
  <img src="https://github.com/user-attachments/assets/3ae57706-629a-45bc-ba1d-333be0294da3" width="280"/>
</details>

<details>
  <summary>Задачи &nbsp;</summary>
  <br>
  <table><tr>
    <td><img src="https://github.com/user-attachments/assets/be22f423-dcd5-4e83-8f02-c6a8cf6cb8a4" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/6d5f785e-e0fa-429d-a7cf-b97bb8098f73" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/d008a827-557d-42b1-bd9b-aa6f3f6ec1a9" width="280"/></td>
  </tr></table>
</details>

<details>
  <summary>Манипулирование задачами &nbsp;</summary>
  <br>
  <table><tr>
    <td><img src="https://github.com/user-attachments/assets/49f3d2ff-80bb-4c0f-9a24-ec0b3c2267a4" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/d1a566cf-9543-4e89-b39d-8179f813c80f" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/9e49039b-8516-45c4-9456-6b5fc48e8211" width="280"/></td>
  </tr></table>
</details>

<details>
  <summary>Уведомления &nbsp;</summary>
  <br>
  <table><tr>
    <td><img src="https://github.com/user-attachments/assets/922de17f-748d-400e-bf0e-b19cc8efb3c0" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/82024454-e128-40bd-aa29-c7e43ff1b048" width="280"/></td>
    <td><img src="https://github.com/user-attachments/assets/78b9c941-3fe7-4fe6-8f56-74721df50a5d" width="280"/></td>
  </tr></table>
</details>

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


