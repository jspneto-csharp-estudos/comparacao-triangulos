# Comparação das Áreas de Dois Triângulos

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

## Detalhes Gerais

- **Versão**: 0.2.1
- **Conceito aplicado:** Refatoração de Código

## Descrição da Versão

```bash

Refatoracao estrutural para melhorar a
organizacao do codigo.

Metodos de entrada e saida foram movidos
para classes dedicadas (TriangleInputs e
TriangleOutputs) dentro de Src/IO, e a
comparacao de areas foi centralizada em
TrianguleUtils, deixando o programa
principal mais enxuto e didatico.

```

## Exemplo(s) de Execução

<img src="Img/Menu.png" alt="Menu" width="936">

(Solução do Problema)

<img src="Img/ProblemSolution.png" alt="ProblemSolution" width="936">