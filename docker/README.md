# Установка и запуск

## Требования

- Docker
- Docker Compose >= 3.4

## Подготовка

- Установите Docker:
  - Windows/Linux: [Docker Desktop](https://www.docker.com/products/docker-desktop/)
  - MacOS: `brew install docker && brew install docker-compose`

## Сборка и запуск

- Запустите скрипт (сборка + запуск контейнеров): `./run.sh`
  - на Windows используйте [WSL (Windows Subsystem for Linux)](https://learn.microsoft.com/ru-ru/windows/wsl/install)
  - при необходимости можно отдельно запустить сборку: `./build.sh`

## Остановка

Используйте скрипты:

- остановка всех контейнеров): `./stop.sh`
- остановка всех контейнеров и удаление образов: `./remove.sh`

## pgAdmin

Откройте pgAdmin в браузере по адресу: <http://localhost:15432/> (ссылка может открыться не сразу — контейнерам надо время на запуск).

1. Вводим:
   - Логин: `admin@example.com`
   - Пароль: `admin`
1. Нажимаем "Add new server"
1. На вкладке "General" указываем любое название в поле "Name" (например, `db`)
1. На вкладке "Connections" вводим следующие параметры:
   | Параметр             | Значение         |
   | -------------------- | ---------------- |
   | Host name/address    | `postgres`       |
   | Port                 | `5432`           |
   | Maintanence database | `auctions-stats` |
   | Username             | `admin`          |
   | Password             | <пароль>         |

1. Нажимаем "Save"
