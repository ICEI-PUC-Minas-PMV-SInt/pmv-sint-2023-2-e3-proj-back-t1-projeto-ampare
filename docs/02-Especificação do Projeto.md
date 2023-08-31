# Especificações do Projeto

O detalhamento do projeto foi realizado a partir da análise de pesquisas e notícias sobre o tópico. Foram utilizados estudos que traçam um perfil acurado dos voluntários no Brasil, tais como a Pesquisa Voluntariado no Brasil de 2021 realizada pelo Datafolha Instituto de Pesquisa e IDIS – Instituto para o Desenvolvimento do Investimento Social.

Tendo como base essa análise, o projeto utilizou a ferramenta das personas para descrever usuários hipotéticos dos produtos a serem construídos. As personas retratam características marcantes do público-alvo, materializando características reais de modo a apoiar a definição das histórias de usuário e dos requisitos da ferramenta.

## Personas

<img src="./img/persona_Fabio.png" width="150">

**Nome**: Fábio Oliveira
**Idade**: 35
**Estado civil:** Casado
**Localidade**: São José dos Campos/SP
**Formação**: Administração
**Ocupação**: Analista Administrativo em uma Administradora de Condomínios
**Renda média mensal**: R$ 5 mil
**Mini-bio**: É casado e tem um filho de 7 anos de idade. Bacharel em Administração, trabalha como Analista Administrativo e tem um salário de R$ 5 mil reais por mês. Se considera uma pessoa espiritualizada, mas não segue nenhuma religião específica.
**Motivações e frustrações:** É um amante dos animais e se preocupa com causas ambientais e sociais. Ele acredita que somente com a participação e comprometimento de toda a sociedade haverá uma mudança real no país. Já fez trabalhos voluntários e doações para instituições do terceiro setor no passado, mas devido à falta de tempo não está conseguindo ajudar como gostaria.
**Hobbies**: Atualmente pratica exercícios esporadicamente, mas procura se alimentar bem para que seja um bom exemplo para seu filho. Sua rotina é agitada durante a semana, mas busca reservar seus finais de semana para ficar com a família e reunir amigos em casa. Gosta de manter-se informado e para isso assiste telejornais e acompanha notícias pela internet.  
**Tecnologia**: Utiliza as redes sociais (Instagram) para lazer apenas e para comunicar-se com os amigos e familiares. Porém a rede de comunicação Whatsapp utiliza com grande frequência tanto no âmbito pessoal, como para resolver problemas profissionais. Possui um perfil no Linkedin que não atualiza nem acessa com frequência. Possui um celular da Motorola, com sistema operacional Android.

<img src="./img/persona_Monica.png" width="150">

**Nome**: Mônica Costa
**Idade**: 53
**Estado civil:** Casada
**Localidade**: Salvador/BA
**Formação**: Pedagogia
**Ocupação**: Aposentada
**Renda média mensal**: R$ 3,5 mil
**Mini-bio**: É casada e tem um filho de 27 anos e uma filha de 25 anos de idade, ambos já têm suas próprias famílias e casas. Trabalhou como servidora da rede pública educacional de sua cidade e se aposentou recentemente. É católica e frequenta grupos da igreja, onde faz trabalhos voluntários semanais de distribuição de quentinhas para a população carente da paróquia do seu bairro.
**Motivações e frustrações:** Desde que se aposentou procura algum tipo de hobby ou distração, algo para ocupar seu tempo de maneira prazerosa, mas também que possa ser útil.
**Hobbies**: Pratica atividade física pelo menos três vezes por semana. Não gosta de assistir noticiários, pois acha que as notícias são sempre ruins e tristes.  
**Tecnologia**: Usa Facebook e Instagram principalmente para acompanhar os acontecimentos e olhar como estão amigos e familiares, comunica-se com a família e com seus amigos principalmente pelo Whatsapp, no qual também participa do grupo da paróquia onde as ações e eventos são organizados. Possui um iPhone da Apple.

<img src="./img/persona_Luisa.jpg" width="150">

**Nome**: Luisa Rocha
**Idade**: 29
**Estado civil:** Solteira
**Localidade**: São Paulo/SP
**Formação**: Psicologia
**Ocupação**: Analista de Recrutamento em uma ONG multinacional voltada ao meio ambiente
**Renda média mensal**: R$ 6 mil
**Mini-bio**: Nascida no interior de Minas Gerais, mudou-se com a família para São Paulo quando criança. Estudou em escola pública até o Ensino Médio, e cursou a graduação com financiamento estudantil em uma faculdade particular. Teve alguns empregos durante a faculdade e entrou na empresa atual há 4 anos, tendo sido promovida uma vez há um ano. Está noiva e começando a planejar o casamento. Mora sozinha na periferia da cidade, mas mantém contato próximo com os pais e a família. Seu trabalho é presencial, e leva cerca de 1h para chegar até o escritório de carro.
**Motivações e frustrações:** Gosta de seu trabalho, mas não é apaixonada pela causa. Trabalha em uma função burocrática e há cobrança por mais resultados. Enfrenta dificuldades para progredir na carreira e pensa em mudar de área constantemente.
**Hobbies**: É uma pessoa caseira, gosta de receber os amigos e preparar refeições com todos. Já desenhou por prazer, mas há tempos não o faz. Adora maratonar séries com o namorado e ficar com suas duas gatas em casa.
**Tecnologia**: Utiliza tecnologia desde a adolescência, passa bastante tempo no Instagram e abandonou o Facebook recentemente. Utiliza bastante o Linkedin para contatos profissionais, especialmente por conta de sua função. Sua principal ferramenta de comunicação é o Whatsapp. Possui um celular da Samsung com OS Android.

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

| EU COMO... `PERSONA`     | QUERO/PRECISO ... `FUNCIONALIDADE`                                                       | PARA ... `MOTIVO/VALOR`                             |
| ------------------------ | ---------------------------------------------------------------------------------------- | --------------------------------------------------- |
| Fábio [voluntário]       | Me cadastrar para receber informações sobre oportunidades de voluntariado                | Poder contribuir mais com a sociedade               |
| Mônica [voluntária]      | Ter mais informações sobre como apoiar organizações que atuam em situações de emergência | Ocupar meu tempo e ajudar pessoas                   |
| Luísa [funcionária ONG]  | Entrar em contato com potenciais voluntários                                             | Recrutá-los para apoiar em situações de crise       |
| Luísa [funcionária ONG]  | Disponibilizar mais informações sobre a atuação da minha ONG                             | Que mais pessoas conheçam o trabalho e se mobilizem |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                                                                                          | Prioridade |
| ------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------- |
| RF-001 | O sistema deve permitir a criação, edição, exclusão e visualização dos dados de voluntários, contendo informações básicas (nome, e-mail, telefone, endereço, interesses, etc.). | Alta       |
| RF-002 | O sistema deve permitir a criação, edição, exclusão e visualização do cadastro de ONGs                                                                                          | Alta       |
| RF-003 | O sistema deve permitir a criação, edição, exclusão e visualização do cadastro de eventos e oportunidades vinculados às ONGs                                                    | Alta       |

### Requisitos não Funcionais

| ID      | Descrição do Requisito                                            | Prioridade |
| ------- | ----------------------------------------------------------------- | ---------- |
| RNF-001 | O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA      |
| RNF-002 | Deve processar requisições do usuário em no máximo 3s             | BAIXA      |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

| ID    | Restrição                                                                                |
| ----- | ---------------------------------------------------------------------------------------- |
| RE-01 | O projeto deverá ser entregue até o final do semestre 2/2023                             |
| RE-02 | O projeto deverá ser codificado na linguagem C#, utilizando suas bibliotecas             |
| RE-03 | O grupo não pode subcontratar ou delegar o desenvolvimento do trabalho a partes externas |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
>
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
