# CardGameLibrary

Biblioteca de classes genérica desenvolvida em C# para modelar características comuns de jogos de cartas.

## Objetivo

Criar uma estrutura reutilizável para jogos de cartas utilizando conceitos de orientação a objetos e generics.

## Estrutura do Projeto

O projeto foi desenvolvido como uma Class Library (.NET 8) contendo as seguintes classes:

- Card<TSuit, TValue>
- Player<TCard>
- Hand<TCard>
- Deck<TCard>
- Round<TPlayer>
- Game<TPlayer>

## Funcionalidades

### Card
Representa uma carta genérica contendo:
- Naipe
- Valor

### Deck
Representa um baralho contendo:
- Adicionar cartas
- Embaralhar
- Comprar cartas

### Hand
Representa a mão do jogador:
- Adicionar cartas
- Remover cartas

### Player
Representa um jogador:
- Nome
- Mão de cartas

### Round
Representa uma rodada do jogo.

### Game
Representa um jogo contendo jogadores.

## Tecnologias Utilizadas

- C#
- .NET 8
- Programação Orientada a Objetos
- Generics

## Como Executar

1. Abra a solução no Visual Studio ou VS Code
2. Execute:

```bash
dotnet build
```

## Integrantes

- Gustavo Teixeira - rm 557876
- Gabriel Dias - rm 556830
- Gabriel Galerani - rm 557421
- Pedro Paulo - rm 554880
- Leonardo Taschin - rm 554583
