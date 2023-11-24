# Programação de Funcionalidades

## Inicialização do projeto
O projeto utilizou o ASP.NET Core MVC, com o Entity Framework Core e Razor Engine. Para inicialização, foi utilizado o Visual Studio Community, com aplicação do template MVC.
A pasta /src/ampare-backend foi utilizada como repositório principal da aplicação. O commit correspondente a essa etapa é o [20ddb7d](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e3-proj-back-t1-projeto-ampare/commit/20ddb7d1e09d887cb80a9ea3526083e549a6a269).

![Estrutura pastas](/docs/img/estrutura-pastas-framework.png)

## Dependências e pacotes
Foram instalados os seguintes pacotes e dependências para execução do projeto:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Sqlserver
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
- BCrypt.Net-Next

![Gerenciador pacotes](/docs/img/gerenciador-pacotes.png)

Foi utilizado o gerenciador de pacotes NuGet, disponibilizado pelo próprio Visual Studio.

## Configuração do banco de dados
Após a inicialização do projeto, a primeira etapa foi configurar o banco de dados. Foram seguidos à risca os passos do [Microfundamento: Desenvolvimento Web Back-End](https://pucminas.instructure.com/courses/87841).
Foi criada a classe ApplicationDbContext para gerenciar o contexto do banco de dados. Esse contexto foi configurado no appsettings, com uma ConnectionString. Já em Program.cs, foi realizada a injeção de dependência do ApplicationDbContext. Por fim, foram configurados os DbSets das classes mapeadas inicialmente.
Program.cs:
![Program.cs](/docs/img/program.png)

ApplicationDbContext.cs:
![ApplicationDbContext.cs](/docs/img/applicationdbcontext.png)

## Criando os modelos
Foram criadas versões iniciais dos modelos mapeados - CadastroOng, CadastroVoluntario, Projeto e ProjetoVoluntario - contendo as especificação das tabelas que serão utilizadas. A cada alteração do modelo de dados, foi realizada a migration correspondente e atualização do banco.

Os modelos foram criados a partir do diagrama de classes do projeto, contendo os atributos ali previstos, com métodos básicos de get e set. Também foram feitos os relacionamentos com chaves estrangeiras, permitindo a integração entre as classes.
![Classes](/docs/img/classes.png)

## Criando os controllers e as views
Após a elaboração dos modelos, a criação dos controllers e das views foi feita de forma automatizada pelo framework. Isso acelerou bastante o trabalho no projeto, permitindo que o grupo focasse na implementação das funcionalidades. Após a criação, foram feitos ajustes estéticos, como a personalização de botões e do display dos campos.
![views](/docs/img/views.png)

Algumas controllers tiveram que ser manualmente alteradas, como para a adição dos métodos de login. Outros métodos tiveram que ser revistos, como o de edição de cadastros, que exigia o reset de senha para toda atualização. 
![edit-cadastro](/docs/img/edit-cadastro.png)

## Autenticação de usuários
Foi configurada a autenticação de usuários, a partir da classe Cadastro. Foi utilizado o Identity para gerenciar os usuários, e adicionados os métodos de login e logout. Também foi criado um controller para gerenciar os cadastros, com métodos de criação, edição e exclusão.
![login-metodo](/docs/img/login-metodo.png)

## Autorização de usuários
Foram criados perfis de usuário na classe Cadastro. Os cadastros específicos já recebem os respectivos perfis no momento de sua criação, e podem ser configurados posteriormente em outras páginas.
![perfil-enum](/docs/img/perfil-enum.png)

Exemplo da autorização do perfil de Administrador:
![perfil-admin](/docs/img/perfil-admin.png)

## Utilizando o github
Houve dificuldades no clone do projeto utilizando o github, pois o framework gerava arquivos locais instáveis. Foi necessário configurar o gitignore para não acompanhar esses arquivos e para permitir que o clone fosse concluído.

Também houve problemas com arquivos temporários do tipo Zone.Identifier, que impediam a clonagem do repositório. Isso foi resolvido com a exclusão desses arquivos, e adição desse formato no gitignore:
![Erro ZoneIdentifier](/docs/img/erro-github-1.png)

## Dificuldades e aprendizados
- Alguns membros do grupo trabalham em Linux, e não conseguiram configurar o Visual Studio corretamente, conforme apresentado no microfundamento. Isso atrasou e atrapalhou as entregas. Um dos integrantes, inclusive, utilizou uma máquina virtual com Windows instalado para conseguir trabalhar no projeto. 
- O clone do projeto no github estava apresentando erros. Após análise, foi necessário ignorar arquivos locais criados pelo framework para que funcionasse.
- A configuração das classes com herança e chaves estrangeiras trouxe complexidades para o desenvolvimento da aplicação.
- O grupo constatou a importância de trabalhar a especificação do projeto antes de iniciar o desenvolvimento. O tempo gasto nas discussões sobre o diagrama de classes e o modelo relacional foi muito bem aproveitado, e evitou que o grupo se perdesse no desenvolvimento.
- A autenticação de usuários foi trabalhosa, já que havia necessidade de integrar os dados com os cadastros. Ficou pendente a parte completa de autorização do sistema, que foi configurada apenas para o cadastro geral.



