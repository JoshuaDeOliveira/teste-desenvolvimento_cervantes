# Sistema de Agendamento de Salas - Coworking

Solução para o Teste de Desenvolvimento 1 da Cervantes Tecnologia. O sistema permite gerenciar salas de coworking e seus agendamentos através de uma aplicação desktop desenvolvida em C# com Windows Forms e PostgreSQL.

## O que o sistema faz

- Cadastro, edição e exclusão de salas
- Agendamento de salas com data e hora de início e fim
- Registro automático de todas as operações realizadas no banco

## Regras de negócio

Todas as validações estão implementadas exclusivamente no banco de dados:

- Nome da sala é obrigatório e não pode se repetir
- Data/hora de fim deve ser maior que a de início
- Não é permitido agendar uma sala em horário já ocupado
- Não é possível excluir uma sala com agendamentos futuros

## Pré-requisitos

- .NET 10
- PostgreSQL 14+
- Visual Studio 2022+

## Como rodar

1. Execute o script SQL localizado em `/database` no seu PostgreSQL
2. Dentro da pasta `/src/AplicativoAgendamento`, crie um arquivo `appsettings.json` com as suas credenciais:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Username=SEU_USUARIO;Password=SUA_SENHA;Database=SEU_BANCO"
  }
}
```

3. Abra o arquivo `AplicativoAgendamento.slnx` no Visual Studio e rode com **F5**

## Estrutura do repositório

- `/src` — código fonte da aplicação
- `/database` — script SQL de criação do banco