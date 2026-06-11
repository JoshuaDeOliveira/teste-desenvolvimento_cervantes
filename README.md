# Sistema de Agendamento de Salas - Coworking

Este repositório contém a solução para o **Teste de Desenvolvimento 1 para a Cervantes Tecnologia**, que consiste em um sistema desktop para gerenciamento e agendamento de salas de coworking. 

## 📋 Requisitos do Sistema

### 1. Cadastro de Salas
* Permite o registro de salas para o coworking.
* Cada sala deve possuir um Nome obrigatório e que não se repita no sistema.

### 2. Cadastro de Agendamentos
* Permite reservar uma sala informando:
  * A sala desejada (vínculo obrigatório).
  * Data e hora de início.
  * Data e hora de fim.

## ⚙️ Regras de Negócio e Validações (Camada de Banco de Dados)

O sistema foi projetado para que o banco de dados barre qualquer operação que infrija as seguintes regras:
* **Campos Obrigatórios:** Todos os dados de salas e agendamentos devem ser preenchidos.
* **Unicidade:** O nome de uma sala deve ser único.
* **Consistência de Horário:** A data/hora final de um agendamento deve ser obrigatoriamente maior que a data/hora inicial.
* **Bloqueio de Sobreposição:** Não é permitida a reserva de uma mesma sala em horários que se sobreponham.
* **Integridade Referencial:** Não é permitida a exclusão de uma sala que possua agendamentos futuros programados.

## 🗄️ Auditoria e Logs

O banco de dados conta com um mecanismo automático de auditoria. Todas as operações de escrita (`INSERT`, `UPDATE` e `DELETE`) realizadas nas tabelas principais são registradas em uma tabela de log contendo:
* O nome da tabela modificada.
* O tipo da operação realizada.
* A data e hora exata do ocorrido.

---

## 📁 Estrutura do Repositório

* `/src` - Código-fonte da aplicação desktop.
* `/database` - Scripts de criação do banco de dados, tabelas, restrições e mecanismos de auditoria.