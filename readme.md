### Lógica para implementação do empréstimo:

- A pessoa que vai emprestar CRIA O registro
- Coloca os dados da pessoa que vai receber, coloca o email da pessoa
- A API recebe essa requisição e a armazena
- Um serviço interno da API checa se existe um usuário para aquele email
  - Caso NÃO:
    Deixa armazenado em um fila para checagens futuras
  - Caso SIM:
    A pessoa que recebe o item pode aceitar ou rejeitar o empréstimo no seu dashboard
