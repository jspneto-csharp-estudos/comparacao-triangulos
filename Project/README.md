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

- **Versão**: 0.9
- **Conceito aplicado:** Composição

## Descrição da Versão

```bash

Introduz modelagem dos lados do triangulo
por meio de composicao entre objetos.

Foi criada a classe Segment, responsavel
por representar um lado do triangulo com
nome e comprimento validados.

A classe Triangle passa a compor tres
instancias de Segment, substituindo as
propriedades primitivas anteriormente usadas
para representar os lados.

O construtor e o setter de Name foram
adaptados para garantir consistencia entre
o nome do triangulo e os nomes dos segmentos,
recriando os lados sempre que o nome muda.

O metodo CreateTriangle foi atualizado
para validar o nome antes da construcao
do objeto e coletar as medidas dos lados
como strings, delegando a conversao para
um metodo auxiliar que suporta valores
nulos.

O exemplo de encapsulamento foi atualizado
para utilizar a nova representacao em texto
dos lados do triangulo.

Essa versao consolida o uso de composicao
no projeto e prepara o modelo para futuras
evolucoes do dominio geometrico.

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