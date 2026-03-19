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

- **Versão**: 0.2
- **Conceito aplicado:** Classes e Métodos

## Descrição da Versão

```bash

Evolucao do modelo procedural para
orientacao a objetos.

A classe Triangule passa a concentrar
os atributos dos lados e o metodo
de calculo da area utilizando a
formula de Heron.

O programa principal agora instancia
objetos e delega o calculo a classe,
iniciando o processo de modelagem
de entidades.

```

## Exemplo(s) de Execução

<img src="Img/Menu.png" alt="Menu" width="936">

(Solução do Problema)

<img src="Img/ProblemSolution.png" alt="ProblemSolution" width="936">