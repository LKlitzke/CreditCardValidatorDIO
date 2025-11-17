[Leia em Português](./README.pt-BR.md) | [Read in English](./README.md)

# Validador de Bandeira de Cartão de Crédito

![.NET](https://img.shields.io/badge/.NET-8-blue.svg)
![C#](https://img.shields.io/badge/C%23-12-green.svg)
![License](https://img.shields.io/badge/License-MIT-yellow.svg)

Uma aplicação de console simples e robusta, construída com .NET 8 e C# 12, para identificar a bandeira de um cartão de crédito com base no seu número. O projeto segue os princípios do Clean Code, separando as responsabilidades para facilitar a manutenção e a extensibilidade.

Este projeto foi desenvolvido como parte de um desafio proposto pela plataforma de aprendizado **[Digital Innovation One (DIO)](https://www.dio.me/)**. O objetivo é recriar ou aprimorar o projeto original, aplicando os conceitos aprendidos e utilizando o GitHub Copilot para acelerar o desenvolvimento.

## 🚀 Funcionalidades

-   **Identificação de Bandeira**: Identifica as principais bandeiras de cartão de crédito a partir do número fornecido.
-   **Uso de Regex**: Utiliza expressões regulares compiladas para uma correspondência de padrões eficiente e precisa.
-   **Arquitetura Limpa**: A lógica de validação é desacoplada da interface do usuário, tornando o código fácil de ler e testar.
-   **Interface de Console Interativa**: Uma interface de console simples e em loop permite múltiplas validações sem reiniciar a aplicação.
-   **Normalização de Entrada**: Limpa automaticamente a entrada do usuário, removendo espaços e caracteres não numéricos antes da validação.

## 💳 Bandeiras Suportadas

O validador pode identificar as seguintes bandeiras de cartão de crédito:

-   American Express
-   Aura
-   Diners Club
-   Discover
-   EnRoute
-   HiperCard
-   JCB
-   MasterCard
-   Visa
-   Voyager

## 🛠️ Tecnologias Utilizadas

-   **.NET 8**: O framework base para a aplicação.
-   **C# 12**: A linguagem de programação utilizada para construir a lógica.
-   **Expressões Regulares**: Para definir e corresponder aos padrões dos números de cartão.

## ⚙️ Como Executar

1.  Clone o repositório:
    ```bash
    git clone https://github.com/LKlitzke/CreditCardValidatorDIO.git
    ```
2.  Navegue até o diretório do projeto:
    ```bash
    cd CreditCardValidatorDIO
    ```
3.  Execute a aplicação usando a CLI do .NET:
    ```bash
    dotnet run
    ```
4.  Digite o número de um cartão de crédito quando solicitado e pressione Enter. A aplicação exibirá a bandeira identificada.

## 🏗️ Estrutura do Código

-   `Program.cs`: Contém o ponto de entrada principal da aplicação e o loop de interação com o usuário. É responsável por lidar com a entrada e saída do console.
-   `CardUtils/`: Um namespace dedicado para a lógica principal de validação.
    -   `CreditCardValidator.cs`: Uma classe estática que orquestra o processo de validação. Contém uma lista de bandeiras suportadas e o método principal `IdentifyBrand`.
    -   `CardBrand.cs`: Uma classe que representa uma única bandeira de cartão de crédito, contendo seu nome e o padrão de regex usado para validação. Este design torna simples adicionar novas bandeiras sem modificar a lógica de validação principal.