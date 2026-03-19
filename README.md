# Comparação das Áreas de Dois Triângulos

Projeto de estudo em C# com o objetivo de **calcular e comparar a área de dois triângulos** a partir das medidas de seus lados, utilizando a **fórmula de Heron**.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Implementação procedural (quando solicitado)
- Classes, métodos e sobrescrita (override)
- Métodos e classes estáticas (quando aplicável)
- Construtores e sobrecarcaga (overload)
- Encapsulamento, properties e auto-properties (quando aplicável)
- Tipos nulos, enumeração e composição (quando aplicável)

## Enunciado

Ler as medidas dos lados de dois triângulos, considerando medidas válidas.

Em seguida:
- Calcular a área de cada triângulo
- Exibir os valores das áreas
- Informar qual triângulo possui a maior área

A área de um triângulo com lados `S1`, `S2` e `S3` é calculada pela **fórmula de Heron**:

```bash
p = (S1 + S2 + S3) / 2
area = RaizQ(p * (p - S1) * (p - S2) * (p - S3))
```

## Estrutura

```bash
|- Project/
   |- Img/
      |- Menu.png
      |- ProblemSolution.png
   |- Src/
      |- Triangle.cs
   |- Program.cs
   |- ProgramExamples.cs
   |- Project.csproj
   |- Project.sln
   |- README.md
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução

- [**v0.1**][1] — Solução procedural
- [**v0.2**][2] — Introdução da classe Triangle

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto-csharp-estudos/comparacao-triangulos/tree/v0.1/Project "v0.1"
[2]: https://github.com/jspneto-csharp-estudos/comparacao-triangulos/tree/v0.2/Project "v0.2"