# Comparação das Áreas de Dois Triângulos

Ler as medidas dos lados de dois triângulos, considerando medidas válidas.

Em seguida:
- Calcular a área de cada triângulo
- Exibir os valores das áreas
- Informar qual triângulo possui a maior área

A área de um triângulo com lados `Side1`, `Side2` e `Side3` é calculada pela **fórmula de Heron**:

```bash
p = (Side1 + Side2 + Side3) / 2
area = RaizQ(p * (p - Side1) * (p - Side2) * (p - Side3))
```

# Estrutura:

```bash

|- Project/
   |- Img/
      |- Menu.png
      |- ProblemSolution.png
   |- Program.cs
   |- ProgramExamples.cs
   |- Project.csproj
   |- Project.sln
   |- README.md

```

# Detalhes Gerais

- **Versão:** 0.0.1
- **Conceito aplicado:** Solução Procedural

# Descrição da Versão

```bash

Primeira resolucao funcional do problema
em abordagem procedural.

A solucao realiza a leitura dos lados de
dois triangulos, calcula as areas pela
formula de Heron e informa qual possui a
maior area, mantendo a estrutura base do
template ja existente no projeto.

```

## Exemplo(s) de Execução

**Menu**

<img src="Img/Menu.png" alt="Menu" width="100%">

**Solução do Problema**

<img src="Img/ProblemSolution.png" alt="ProblemSolution" width="100%">