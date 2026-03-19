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

- **Versão**: 0.6
- **Conceito aplicado:** Encapsulamento

## Descrição da Versão

```bash

Evolucao do modelo da classe Triangle
com aplicacao de encapsulamento.

Os atributos passam a ser privados e
expostos por meio de properties,
permitindo controle de acesso e
validacao no setter do Name.

Os lados tornam-se somente leitura,
garantindo maior consistencia do objeto
apos a instanciacao.

```

## Exemplo(s) de Execução

<img src="Img/Menu.png" alt="Menu" width="936">

(Solução do Problema)

<img src="Img/ProblemSolution.png" alt="ProblemSolution" width="936">

(Exemplo de Override)

<img src="Img/Override.png" alt="Override" width="936">

(Exemplo de Overload)

<img src="Img/Overload.png" alt="Overload" width="936">

(Exemplo de Encapsulamento)

<img src="Img/Encapsulation.png" alt="Encapsulation" width="936">