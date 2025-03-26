# Robô Tupiniquim I 🤖

## Demonstração

![](https://i.imgur.com/4Q74Znu.gif)

## Introdução

A **Agência Espacial Brasileira (AEB)** está planejando uma expedição a Marte e, como parte do projeto, enviará uma nave espacial **Tupiniquim I** equipada com um robô explorador. Esse robô será responsável por analisar a superfície do planeta vermelho, coletando informações através de sua movimentação em uma área delimitada.

## Sobre o Sistema

A área de exploração é um **grid retangular**, e o robô pode se movimentar dentro dele seguindo coordenadas **X** e **Y**, além de uma orientação representada por uma das direções cardeais:

- **N** = Norte
- **S** = Sul
- **L** = Leste
- **O** = Oeste

## Movimentação

O robô recebe comandos na forma de **strings**, contendo as letras:

- **E** → Vira 90° para a esquerda (sem sair do lugar).
- **D** → Vira 90° para a direita (sem sair do lugar).
- **M** → Move-se uma unidade na direção atual.

Exemplo: Se o robô estiver em `(0 0 N)` e receber o comando `M`, ele avançará para `(0 1 N)`.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project RoboTupiniquim.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./RoboTupiniquim.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
RoboTupiniquim.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
