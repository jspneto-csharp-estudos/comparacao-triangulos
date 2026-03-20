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

- **Versão**: 0.7.2
- **Conceito aplicado:** Refatoração de Código

## Descrição da Versão

```bash

Refatoracao dos metodos de verificacao e validacao.

Todos os metodos que utilizavam controle de fluxo para
verificar propriedades ou validar atributos foram
atualizados para usar operadores ternarios ou
retornar diretamente o resultado da operacao logica.

Um nome que seja apenas uma sequencia de tres espacos
em branco passa a ser considerado invalido.

O construtor de Triangle passa a usar um operador
ternario para aplicar um nome valido.

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