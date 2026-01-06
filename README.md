# 🚀 Desafios de Lógica em C#

Este repositório contém uma série de exercícios práticos desenvolvidos para o aprendizado da linguagem **C#** e da plataforma **.NET**. O objetivo principal foi exercitar conceitos fundamentais de programação, como tipos de dados, estruturas de repetição, condicionais, manipulação de strings e expressões regulares (Regex).

> **Nota de Aprendizado:** Este projeto faz parte dos meus estudos iniciais em C#. Ele foca em lógica de programação e organização básica de código em classes auxiliares, demonstrando a evolução de algoritmos manuais para soluções mais otimizadas.

---

## 🛠️ Funcionalidades Implementadas

O projeto está estruturado em uma classe de utilitários (`AuxiliarFunctions`) que centraliza as seguintes lógicas:

1.  **Boas-vindas Personalizada:** Interação básica com o usuário para exibição de nome e sobrenome.
2.  **Operações Matemáticas:** Cálculo de soma, subtração, multiplicação, divisão (com verificação de divisor zero) e média entre dois números.
3.  **Contador de Caracteres:** Medição do comprimento de strings de forma dinâmica.
4.  **Validador de Placas (Padrão Nacional):**
    * **Padrão Antigo (até 2018):** Validação lógica utilizando laços de repetição `for` e verificação de tipos `char`.
    * **Padrão Mercosul:** Validação moderna e concisa utilizando **Expressões Regulares (Regex)**.
5.  **Formatador de Datas:** Exibição da data e hora atual em quatro formatos distintos (completo, simplificado, apenas hora e data por extenso).

---

## 💻 Tecnologias Utilizadas

* **Linguagem:** C#
* **Plataforma:** .NET 10
* **Paradigma:** Orientação a Objetos (Métodos Estáticos e Encapsulamento)

---

## 📂 Estrutura do Projeto

* `Program.cs`: Ponto de entrada da aplicação contendo um menu interativo `switch-case` para navegação entre os desafios.
* `Utils/AuxiliarFunctions.cs`: Classe estática que encapsula as regras de negócio, promovendo a reutilização de código e separação de responsabilidades.



---

## 🚀 Como executar

1. Certifique-se de ter o SDK do .NET 10 instalado em sua máquina.
2. Clone este repositório:
   ```bash
   git clone [https://github.com/GabrielCae/DesafiosCSharp.git](https://github.com/GabrielCae/DesafiosCSharp.git)

3. Navegue até a pasta do projeto:
   ```bash
   cd DesafiosCSharp

4. Execute o programa:
   ```bash
   dotnet run


---
### 🧑‍💻 Autor

Desenvolvido por Gabriel Caetano como parte do portfólio de estudos em desenvolvimento de software.