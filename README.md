# GoldSrcMod.Net

无需虚拟机(coreclr或者mono)，借助.net9的nativeaot特性，使用c#GoldSrc引擎游戏开发客户端(Metahook插件)或者服务端(Amxmodx模块)Mod

项目里各各SDK的命名以及使用方式尽量保持和c++原版一致，减少学习成本，所以代码中会有大量的“不安全(unsafe)”代码。

### 项目状态
Metahook插件: 可用，但是HLSDK不完善，需要自己补充，欢迎PR
AmxModX模块：不可用，正在消极开发中（amxmodx的模块需要写的代码实在是太多了！）

### 平台支持：
    仅限Windows，因为metahook只支持windows

### 编译：
#### 准备环境
1. [可选] 安装visual studio 2022，并安装.net9工作负载
2. 如果不使用visual studio开发，可直接安装.net9 sdk: https://dotnet.microsoft.com/zh-cn/download/dotnet/9.0

#### Metahook插件编译：

```shell
dotnet publish .\Source\Metahook.Plugin\Metahook.Plugin.csproj -c Release -r win-x86 -o ./build
```
