# 7DaysOfCode-CSharp

*Durante os 7 Days de C#, vamos voltar para os anos 90 e 2000 para que você construa uma versão moderna do Tamagotchi, o “bichinho virtual”. Para isso. você vai utilizar os conceitos mais importantes do C# e, para deixar ainda mais legal, vai consumir a API do Pokémon para dar vida aos seus bichinhos. Explicando melhor, você vai usar a API do Pokémon para buscar os pokémons que serão seus mascotes e implementar interações com eles através de comunicação com a API, utilizando o JSON obtido.*

## DIA 1

No primeiro dia, você irá iniciar uma aplicação back-end em C#, consumindo a API do Pokémon!. Você terá que desenvolver uma funcionalidade onde o jogador poderá acessar uma lista de opções de espécies de pokémons e visualizar suas características para facilitar sua escolha antes da adoção.

- [x] Criar o código C# que executará uma requisição HTTP do tipo GET.
- [x] Executar a requisição e pegar a resposta (o JSON).
- [x] Imprimir o resultado no console.

Adicione o NuGet Package Manager GUI

```text
Instalar extensão do vscode
```

Adicione a biblioteca:

```bash
dotnet add package RestSharp
```

- <https://restsharp.dev/intro.html#basic-usage>

`Ler atentamente as documentações.`

## DIA 2

Neste dia, você irá parsear a resposta obtida no primeiro dia para extrair as informações desse JSON e exibi-las de maneira organizada.

- [x] Crie uma classe que representa um mascote e coloque os atributos com o mesmo nome e tipo de dados dos campos retornados no JSON;

- [x] Converta o resultado da API neste objeto criado;

***json que vamos criar uma classe para serializar.***
```json
{
    "abilities": [
    {
      "ability": {
        "name": "overgrow",
        "url": "https://pokeapi.co/api/v2/ability/65/"
      },
      "is_hidden": false,
      "slot": 1
    }
  ]
}
```

**OBS:** `Para exibir as informações em listas, use laços de repetição. Outra sugestão é que vai ficar bem legal se você possibilitar que o usuário consiga ver todas espécies que desejar antes de realizar a adoção.`

## DIA 3

Hoje você vai trabalhar a saída de dados através da construção de um menu interativo, com opções e mensagens divertidas para o usuário.

- [x] Construir uma classe que será responsável pela exibição de todas as mensagens e leitura da resposta do usuário.

- [x] Dar boas vindas ao usuário, ler o nome da pessoa e dados que você achar relevante.

- [x] Exibir um menu que possibilite: “Adoção de mascotes”, “Ver mascotes adotados” e “Sair do Jogo”.

O que é esperado do menu de adoção?

- [x] Que o jogador possa escolher uma espécie e ver ou não suas características antes de adotá-lo.

- [x] Que o jogador possa ver detalhes sobre as espécies que desejar antes de fazer a escolha da adoção.
- [] Que caso o jogador goste das características do mascote, ele possa realizar a adoção do mesmo.

## DIA 4

Em C#, é comum organizar os projetos em 3 camadas utilizando o padrão MVC. Hoje você irá refatorar o seu sistema para ficar de acordo com esse padrão, com Model, View e Controller.

## DIA 5

O desafio deste dia é desenvolver interações do jogador com seus mascotes. Você irá lidar com atributos e poderá realmente brincar com seus pokémons.

## DIA 6

Hoje o assunto será um problema comum na vida de um desenvolvedor back-end: o mapeamento de propriedades de um objeto para outro. Você irá buscar na documentação de uma biblioteca a melhor maneira de fazer isso.

## DIA 7

O tratamento de erros de entradas de dados de usuários sempre foi, e ainda é, um grande problema na construção de um software. Neste dia o desafio é o tratamento de possíveis cenários de erros. Além disso, você poderá publicar a sua aplicação para que outras pessoas possam utilizá-la. Você vai fechar com chave de ouro!
_________________

Link: <https://7daysofcode.io/matricula/csharp>
