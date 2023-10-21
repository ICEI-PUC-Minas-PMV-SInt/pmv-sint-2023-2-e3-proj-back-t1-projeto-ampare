# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

## Plano de Testes - Projeto Ampare

**1. Objetivo dos Testes:**

O objetivo dos testes é garantir que o sistema do Projeto Ampare funcione conforme os requisitos estabelecidos, incluindo funcionalidades de login, cadastro, gerenciamento de dados, notificações, responsividade e integração entre atores (voluntários, ONGs e administrador do sistema).

**2. Escopo dos Testes:**

Os testes abrangem as funcionalidades do sistema relacionadas a três atores principais: Voluntários, ONGs e Administrador do Sistema.
Inclui testes de funcionalidades principais, requisitos não funcionais e interações entre atores.

**3. Recursos Necessários:**

- Hardware: Navegadores da web (Chrome, Firefox, Safari, Edge), dispositivos móveis (se aplicável).
- Software: Sistema do Projeto Ampare, ferramentas de automação de testes (opcional), planilhas de acompanhamento de testes.

## Casos de Teste

### CT-01: Teste de Login

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Login | Verificar se o sistema permite o login de voluntários, ONGs e administradores com sucesso. | - O sistema permite o login com as credenciais corretas. - O sistema exibe mensagens de erro apropriadas para credenciais inválidas.

### CT-02: Teste de Cadastro de Voluntário

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Cadastro de voluntário | Verificar se o sistema permite o cadastro de voluntários com sucesso. | - O sistema permite o cadastro com informações válidas. - Os dados do voluntário são armazenados corretamente no sistema.

### CT-03: Teste de Cadastro de ONG

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Cadastro de ONG | Verificar se o sistema permite o cadastro de ONGs com sucesso. | - O sistema permite o cadastro com informações válidas. - Os dados da ONG são armazenados corretamente no sistema.

### CT-04: Teste de Criação de Projeto/Evento pela ONG

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Gerenciamento de Projetos/Eventos | Verificar se o sistema permite que uma ONG crie projetos/eventos com sucesso. | - O sistema permite a criação de projetos/eventos com informações válidas. - Os projetos/eventos são armazenados corretamente no sistema.

### CT-05: Teste de Marcar Projeto como Urgente pela ONG

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Marcar Projeto como Urgente | Verificar se o sistema permite que uma ONG marque um projeto como urgente com sucesso. | - O sistema permite a marcação de projeto como urgente. - Os projetos marcados como urgentes são sinalizados corretamente no sistema.

### CT-06: Teste de Verificação de Notificações de Projetos Urgentes

| Requisitos Associados | Objetivo do Teste | Critérios de Êxito |
|----------------------|-------------------|-------------------|
| Notificações | Verificar se o sistema notifica os voluntários sobre projetos urgentes. | - O sistema exibe notificações para voluntários sobre projetos marcados como urgentes.

 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
