# Sungero.Plugins.Sdk

[![Publish](https://github.com/DirectumCompany/Sungero.Plugins.Sdk/actions/workflows/release.yml/badge.svg)](https://github.com/DirectumCompany/Sungero.Plugins.Sdk/actions/workflows/release.yml)
[![NuGet](https://img.shields.io/nuget/v/sungero.plugins.sdk.svg)](https://www.nuget.org/packages/Sungero.Plugins.Sdk/)

SDK плагинов к платформе Sungero.

#### Модуль **Cryptography**:
* **HashAlgorithmWrapper** Предоставляет удобные методы для доступа к алгоритму хэширования.
* **ICryptographyPlugin** Содержит контракт для создания плагина криптографии.
* **ISimpleCryptographyPlugin** Содержит контракт для создания упрощённого плагина криптографии (который работает с телом документа вместо хэша).
* **ISigner** Содержит контракт для создания класса подписания.
* **ICloudSignPlugin** Содержит контракт для создания облачного плагина криптографии.
* **ICloudBatchSignPlugin** Содержит контракт для создания облачного плагина криптографии, поддерживающего пакетное подписание.
* **ICryptographyPluginDataProvider** Содержит контракт поставщика данных для облачного плагина криптографии.

См. также [шаблон проекта плагина подписания](https://github.com/DirectumCompany/Sungero.Plugins.Templates).
