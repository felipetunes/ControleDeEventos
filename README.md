![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge)

<h1 align="center"> CONTROLE DE EVENTOS </h1>

* [Índice](#índice)
* [Funcionalidades e Demonstração da Aplicação](#funcionalidades-e-demonstração-da-aplicação)
* [Tecnologias Utilizadas](#tecnologias-utilizadas)
* [Acesso ao Projeto](#acesso-ao-projeto)
* [Conclusão](#conclusão)

# Índice
  O objetivo principal desta aplicação é praticar o desenvolvimento em MVC utilizando o ASP.NET Core.
A proposta é criar uma página que concentre todas as informações da página principal, semelhante a outros sites que vendem ingressos.
Além disso, a aplicação deve contar com um gerenciador que possa ser acessado somente por usuários autorizados, oferecendo ferramentas para controle do site.
Algumas funcionalidades que não foram prioritárias para a fase atual do projeto ainda não foram incorporadas, podendo ser atualizadas posteriormente.

# Funcionalidades e demonstração da aplicação
### Páginas
#### Página Inicial
- É um ambiente aberto ao público, onde é possível visualizar todas as informações disponíveis.
São apresentados três carrosséis que direcionam o usuário para mais informações sobre cada evento e a venda de ingressos.
Inspirado no menu da Netflix, foi utilizado a biblioteca Slick.js para oferecer uma experiência visual agradável e interativa.
O primeiro carrossel exibe promoções e os eventos mais procurados pelo público. Já o segundo carrossel destaca os eventos mais próximos,
ordenados por data, e o terceiro mostra os eventos mais próximos por localização. Além de um campo de busca por nome ou data.
![paginainicialnova](https://github.com/felipetunes/ControleDeEventos/assets/44438287/f17077fe-cc70-45b4-9efe-1c92bf41c0e1)

#### Detalhes
- Quando clicado em um card do Carrosel na Página Inicial, é exibida a página que contém todas as informações sobre o evento escolhido.

#### Login
- No topo da tela, à direita, há um botão escrito "Entrar", a foto do usuário se estiver logado.
Ao clicar nesta imagem sem estar logado, o usuário será redirecionado para a página de Login, que inclui um formulário com campos para inserir seu login e senha.
Além disso, existe a opção de redefinir a senha recebendo uma nova senha por e-mail, caso a anterior tenha sido perdida. É importante destacar que existem validações e descriptografia da senha no banco de dados. Após a autenticação correta, o usuário terá acesso a todas as áreas restritas e permissões associadas à sua conta.
![log](https://github.com/felipetunes/ControleDeEventos/assets/44438287/fed5daa8-d142-4a17-85bb-0f0a64d8a69d)

#### Eventos
A seção de Eventos é o local onde você pode gerenciar todas as informações sobre os eventos.
É possível criar, editar ou excluir um evento com facilidade. Ao criar ou editar um evento, é importante preencher um formulário completo com todas as
informações relevantes, tais como o nome do evento, a localização, a data e uma imagem que será exibida nos carrosséis da página inicial.
![even](https://github.com/felipetunes/ControleDeEventos/assets/44438287/695a4e9b-5284-459b-a998-d84472286fda)


#### Usuários
- Já a seção de Usuários é responsável por gerenciar todas as informações sobre os usuários cadastrados. É possível criar, editar ou excluir um usuário com facilidade.
Para isso, é preciso preencher um formulário completo com informações como nome, e-mail, login, foto, perfil (para controlar as autorizações) e senha,
principalmente para novos usuários. Com essas informações em mãos, você poderá controlar melhor o acesso e as permissões dentro do seu site.
![use](https://github.com/felipetunes/ControleDeEventos/assets/44438287/6be2e4af-f174-4d8b-bd6a-6188716fab1a)


# Tecnologias Utilizadas
#### Entity Framework
 - Para a persistência de dados, foi utilizado o Entity Framework no ASP.NET Core em MVC, que permite o mapeamento objeto relacional (ORM) dos nossos modelos de domínio
com os objetos do banco de dados.

#### Bootstrap e jQuery
 - O layout foi criado utilizando o framework Bootstrap para facilitar a responsividade da aplicação e agilizar o desenvolvimento,
além do uso do jQuery para manipulação de elementos da página dinamicamente, como o Carrossel feito com o Slick.js.

# Conclusão
  O objetivo do sistema é fornecer uma plataforma intuitiva e eficiente para gerenciar eventos, shows e espetáculos, permitindo que os usuários possam criar,
editar e excluir eventos, além de ter acesso a relatórios e vendas realizadas. Tudo isso utilizando tecnologias modernas como o ASP.NET Core, Entity Framework,
Bootstrap e jQuery.
