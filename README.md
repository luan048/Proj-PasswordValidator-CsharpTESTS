## Programa para verificação de Caracteres de senhas com testes
- Essa programa serve para registar os passos para utilizar o Xunit para testes em programas C#

## Comandos para configurar o ambiente para rodar os testes

- Inicializar estrutura do projeto

```bash
$ dotnet new xunit -n <NomeProjeto>
```

```bash
$ dotnet new classLib -n <NomeLib>
```

- Necessário entrar no projeto e adicionar a referência a lib
```bash
$ cd <NomeProjeto>
```

```bash
$ git add reference <CaminhoLib>
```

- Rode os testes
```bash
$ dotnet test
```

### Não é necessário (nesses casos) um arquivo Main para rodar
