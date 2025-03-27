# Robô Tupiniquim I 🤖

## Demonstração

![](https://i.imgur.com/4Q74Znu.gif)

## Introdução

Um jogo para simular um robô da **Agência Espacial Brasileira (AEB)** em solo do planeta Marte.

## Funcionalidades

- **Definição da Área de Exploração**: O sistema recebe as coordenadas do canto superior direito da área a ser explorada. O canto inferior esquerdo é fixo em (0,0).
- **Entrada de Comandos**: Os comandos são enviados em duas partes: a posição inicial do robô e uma sequência de instruções para sua movimentação.
- **Execução Sequencial**: Cada robô executa seus comandos de forma ordenada. O próximo robô só inicia suas ações após o anterior concluir sua exploração.

### Sobre o Sistema

A área de exploração é um **grid retangular**, e o robô pode se movimentar dentro dele seguindo coordenadas **X** e **Y**, além de uma orientação representada por uma das direções cardeais:

- **N** = Norte
- **S** = Sul
- **L** = Leste
- **O** = Oeste

### Movimentação

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
