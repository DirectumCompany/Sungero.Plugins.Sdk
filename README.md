# Sungero.Plugins.Sdk

[![Build status](https://ci.appveyor.com/api/projects/status/ioo5oo79dl8b5fh9/branch/master?svg=true)](https://ci.appveyor.com/project/hahat-maker/sungero-plugins-sdk/branch/master)
[![NuGet](https://img.shields.io/nuget/v/sungero.plugins.sdk.svg)](https://www.nuget.org/packages/Sungero.Plugins.Sdk/)

SDK плагинов к системе DirectumRX.

#### Модуль **Cryptography**:
* **HashAlgorithmWrapper** Предоставляет удобные методы для доступа к алгоритму хэширования.
* **ICryptographyPlugin** Содержит контракт для создания плагина криптографии.
* **ISigner** Содержит контракт для создания класса подписания.
* **ICloudSignPlugin** Содержит контракт для создания облачного плагина криптографии.
* **ICryptographyPluginDataProvider** Содержит контракт поставщика данных для облачного плагина криптографии.

См. также [шаблон проекта плагина подписания](https://github.com/DirectumCompany/Sungero.Plugins.Templates).
