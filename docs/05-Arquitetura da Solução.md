# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>
O sistema será um WebApp e contará com uma interface gráfica (frontend) criada a partir de framework, acessível por meio de link web em navegadores padrão, já o backend da aplicação será desenvolvido na linguagem C#.
O padrão de projeto arquitetural a ser utilizado será o MVC (Model View Controler), que consiste em uma camada de interação com o usuário (View), uma camada de controle (controller) e uma camada de manipulação de dados (Model).
A modelagem de dados do sistema será realizada utilizando-se a Linguagem de Modelagem Unificada (UML) para o diagrama de classe e o diagrama de casos de uso.
Os componentes do projeto arquitetural foram definidos a partir dos requisitos não funcionais e da infraestrutura da aplicação do Projeto Ampare, são eles: 
- ONG: organizações que poderão fazer um cadastro na aplicação e incluir projetos que estejam abertos e / ou precisando de ajuda;
- Voluntário: serão capazes de se cadastrar na aplicação e se candidatarem a projetos que desejem ajudar;
- Projeto: são as ações que necessitam de ajuda no momento e serão cadastrados pelas ONGs;
- Componentes de infraestrutura da aplicação (Banco de Dados, Servidor Web, Repositório de código fonte).
Será utilizado o GitHub Pages como ambiente de hospedagem da aplicação do Projeto Ampare. O Github Pages permite integração com repositório do projeto no Github, facilitando assim o fluxo de publicações da aplicação. Mais detalhes sobre esse processo estão na página de [Instruções do GitHub Pages](https://pages.github.com/)

![Arquitetura da Solução](/docs/img/mvc.png)

## Diagrama de Classes

O Diagrama de classes mostrado na Figura abaixo, mapeia a estrutura da aplicação baseado nas suas classes com seus atributos e métodos respectivos, bem como as relações entre as classes existentes. A ferramenta para elaboração deste diagrama foi o [LucidChart](https://www.lucidchart.com/pages/pt), podendo ser acessado em: [Link Diagrama de classes Ampare.](https://lucid.app/lucidchart/971486c1-1ee6-4143-b049-1456c293d444/edit?viewport_loc=-2001%2C-3299%2C3107%2C1478%2C0_0&invitationId=inv_39bea3de-29b8-435e-849f-bddcafe1e8a0)


![Diagrama de Classes](/docs/img/diagrama-de-classes-ampare.png)


## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
