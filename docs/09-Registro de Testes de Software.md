# Registro de Testes de Software

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-01 |
| **Objetivo do Teste** | Verificar se o sistema permite o cadastro de voluntários com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que um voluntário insere informações válidas <br> QUANDO ele solicita o cadastro <br> ENTÃO o sistema deve armazenar corretamente os dados do voluntário |
| **Prioridade** | Alta |
| **Resultado Esperado** | Cadastro de voluntário realizado com sucesso. |
| **Resultado Obtido** | O cadastro de voluntário foi realizado com sucesso, e os dados foram armazenados corretamente no sistema. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-02 |
| **Objetivo do Teste** | Verificar se o sistema permite o login de voluntários, ONGs e administradores com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que um usuário insere credenciais corretas <br> QUANDO ele tenta fazer login <br> ENTÃO o sistema deve permitir o acesso <br> <br> DADO que um usuário insere credenciais incorretas <br> QUANDO ele tenta fazer login <br> ENTÃO o sistema deve exibir uma mensagem de erro apropriada |
| **Prioridade** | Alta |
| **Resultado Esperado** | Login realizado com sucesso e tratamento adequado para credenciais incorretas. |
| **Resultado Obtido** | O login foi realizado com sucesso para credenciais corretas, e o sistema exibiu mensagens de erro apropriadas para credenciais incorretas. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-03 |
| **Objetivo do Teste** | Verificar se o sistema permite o cadastro de ONGs com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que uma ONG insere informações válidas <br> QUANDO ela solicita o cadastro <br> ENTÃO o sistema deve armazenar corretamente os dados da ONG |
| **Prioridade** | Alta |
| **Resultado Esperado** | Cadastro de ONG realizado com sucesso. |
| **Resultado Obtido** | O cadastro de ONG foi realizado com sucesso, e os dados foram armazenados corretamente no sistema. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-04 |
| **Objetivo do Teste** | Verificar se o sistema permite o login de voluntários, ONGs e administradores com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que um usuário ONG insere credenciais corretas <br> QUANDO ela tenta fazer login <br> ENTÃO o sistema deve permitir o acesso <br> <br> DADO que um usuário ONG insere credenciais incorretas <br> QUANDO ela tenta fazer login <br> ENTÃO o sistema deve exibir uma mensagem de erro apropriada |
| **Prioridade** | Alta |
| **Resultado Esperado** | Login de ONG realizado com sucesso e tratamento adequado para credenciais incorretas. |
| **Resultado Obtido** | O login de ONG foi realizado com sucesso para credenciais corretas, e o sistema exibiu mensagens de erro apropriadas para credenciais incorretas. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-05 |
| **Objetivo do Teste** | Verificar se o sistema permite que uma ONG crie projetos/eventos com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que uma ONG insere informações válidas para um novo projeto <br> QUANDO ela solicita a criação <br> ENTÃO o sistema deve armazenar corretamente os dados do projeto |
| **Prioridade** | Alta |
| **Resultado Esperado** | Criação de projeto pela ONG realizada com sucesso. |
| **Resultado Obtido** | A criação de projeto pela ONG foi realizada com sucesso, e os dados foram armazenados corretamente no sistema. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-06 |
| **Objetivo do Teste** | Verificar se o sistema permite que uma ONG marque um projeto como urgente com sucesso. |
| **Critério de Aceite em Gherkin** | DADO que uma ONG seleciona um projeto e marca como ativo <br> ENTÃO o sistema deve sinalizar corretamente o projeto como ativo |
| **Prioridade** | Alta |
| **Resultado Esperado** | Marcação de projeto como ativo realizada com sucesso. |
| **Resultado Obtido** | A marcação de projeto como ativo pela ONG foi realizada com sucesso, e o sistema sinalizou corretamente o projeto como ativo. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-07 |
| **Objetivo do Teste** | Verificar se o sistema permite o voluntário se inscrever em projetos. |
| **Critério de Aceite em Gherkin** | DADO que um voluntário seleciona um projeto e solicita inscrição <br> ENTÃO o sistema deve permitir a inscrição do voluntário no projeto <br> <br> E DADO que um voluntário já inscrito tenta se inscrever novamente <br> ENTÃO o sistema deve permitir apenas uma inscrição por voluntário |
| **Prioridade** | Alta |
| **Resultado Esperado** | Inscrição de voluntário em projetos realizada com sucesso, com tratamento adequado para tentativa de inscrição duplicada. |
| **Resultado Obtido** | A inscrição de voluntário em projetos foi realizada com sucesso, e o sistema permitiu apenas uma inscrição por voluntário. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-08 |
| **Objetivo do Teste** | Verificar se o sistema permite usuários fazerem logout. |
| **Critério de Aceite em Gherkin** | DADO que um usuário está logado <br> QUANDO ele solicita o logout <br> ENTÃO o sistema deve encerrar a sessão do usuário |
| **Prioridade** | Alta |
| **Resultado Esperado** | Logout de usuário realizado com sucesso. |
| **Resultado Obtido** | O logout de usuário foi realizado com sucesso, e o sistema encerrou a sessão do usuário. |
| **Status** | Passou (X) Falhou ( ) |

| **Tipo de Teste** | Funcional |
| ------------------ | ---------- |
| **ID do Teste** | CT-09 |
| **Objetivo do Teste** | Verificar se o sistema permite usuários resetarem a senha. |
| **Critério de Aceite em Gherkin** | DADO que um usuário esqueceu a senha <br> QUANDO ele solicita o reenvio <br> ENTÃO o sistema deve exibir um link para redefinir a senha |
| **Prioridade** | Alta |
| **Resultado Esperado** | Exibição do link para redefinir a senha realizada com sucesso. |
| **Resultado Obtido** | A exibição do link para redefinir a senha falhou, pois não há link disponível para solicitar o reenvio de senha. |
| **Status** | Passou ( ) Falhou (X) |
