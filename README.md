# Estudos dos Fundamentos C#

## Comandos CLI

**versao atual**
```
dotnet --version
```
**Lista SDKs instalados**
```
dotnet --list-sdks
```
**Lista Runtimes instalados**
```
dotnet --list-runtimes
```

Outros comandos disponíveis: [aka.ms/dotnet-cli](https://aka.ms/dotnet-cli) 

#
## Novo Projeto
**Lista modelos para novos projetos**
```
dotnet new list
```
**Lista opções do modelo**
```
dotnet new console -h
```
**Criando um novo projeto**
```
dotnet new console -o NovoProjeto
```

#
## Comandos do Projeto
**Restaura as dependências e as ferramentas de um projeto**
```
dotnet restore
```
**Compila o projeto e todas as suas dependências**
```
dotnet build
```
**Limpa as compilações anteriores**
```
dotnet clean
```
**Compila e executa o projeto**
```
dotnet run
```
