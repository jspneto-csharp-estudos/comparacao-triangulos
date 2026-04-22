# Comparação das Áreas de Dois Triângulos

Projeto de estudo em C# para calcular a área de dois triângulos a partir das medidas de seus lados, utilizando a fórmula de Heron, e comparar os resultados para identificar qual possui a maior área.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Implementação procedural

## Enunciado

Ler as medidas dos lados de dois triângulos (X e Y), considerando medidas válidas.

Em seguida:
- Calcular a área de cada triângulo
- Exibir os valores das áreas
- Informar qual triângulo possui a maior área

A área de um triângulo com lados `a`, `b` e `c` é calculada pela **fórmula de Heron**:

```bash
p = (a + b + c) / 2
area = RaizQ(p * (p - a) * (p - b) * (p - c))
```

## Diagrama de Classes

<img src="Images/ClassDiagram.png" alt="ClassDiagram" width="100%">

## Evolução

- [**v0.0.1**][1] — Implementação procedural da comparação das áreas de triângulos

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto-csharp-estudos/comparacao-triangulos/tree/v0.0.1/Project "v0.0.1"
