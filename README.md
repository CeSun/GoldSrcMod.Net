# Metahook.Net

无需虚拟机(coreclr或者mono)，借助.net9的nativeaot特性，使用c#为metahook开发原生插件

### 编译前提：
1. visual studio 2022 preview
2. .net9

### 编译：
```shell
dotnet publish .\Plugin\Plugin.csproj -c Release -r win-x86 -o ./build
```
编译后的dll在`build`目录下

### 调试
使用vs的附加调试即可，建议在init中适当加一些sleep，用来等待调试器附加到进程。
