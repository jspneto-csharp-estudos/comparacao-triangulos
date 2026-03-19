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

- **Versão**: 0.5
- **Conceito aplicado:** Sobrecarga (Overload)

## Descrição da Versão

```bash

Introduz o conceito de sobrecarga.

Permite a criacao de um triangulo
informando apenas o nome, utilizando
valores padrao para os lados e
delegando a construcao ao construtor
principal por meio de encadeamento.

```

## Exemplo(s) de Execução

<img src="Img/Menu.png" alt="Menu" width="936">

(Solução do Problema)

<img src="Img/ProblemSolution.png" alt="ProblemSolution" width="936">

(Exemplo de Override)

<img src="Img/Override.png" alt="Override" width="936">

(Exemplo de Overload)

<img src="Img/Overload.png" alt="Overload" width="936">