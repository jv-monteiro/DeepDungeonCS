
# Deep Dungeon Store

Projeto inspirado no meu [primeiro projeto de HTML/CSS](https://github.com/jv-monteiro/DeepDungeon-Store). 
Nessa nova versão eu busquei aplicar conceitos de backend utilizando ASP.Net Core e Entity framework Core.


## Instalação

Para executar o programa é necessário possuir o Visual Studio/.NET SDK instalado e configurar a string de conexão no arquivo "appsttings.json" 


### 1- Conexão com o banco de dados:

        Em "Data Source" coloque o nome da sua maquina mostrado no SQLServer e o programa 
        irá criar automaticamente o banco de dados e as tabelas.
![](https://i.imgur.com/uTCfOhk.png)


### 2-  Rodando a aplicação:
        Inicie a aplicação clicando no botão "play" do Visual Studio
        
![](https://i.imgur.com/m5zc1hO.png)

## Funcionalidades

- Cadastrar e Remover produtos(Conexão com banco de dados SQLServer)
- Lista de produtos
- Filtro de produtos por categoria
- Carrinho de compras
- Campo de login


Cadastrar e remover produtos:
        
        Infelizmente ainda é necessário utilizar o Migrations disponibilizado pelo Entity Framework para cadastrar
        e deletar produtos. Entretanto eles serão salvos no banco de dados normalmente.

### 1. Lista de produtos

        Página com todos os produtos listados podem ser adicionados ao carrinho.
![](https://i.imgur.com/JsicKyr.png)

### 2. Filtro de produtos

        É possivel filtrar produtos por suas categorias. O menu puxa todas as categorias
        no banco de dados,lista elas,e relaciona com a categoria do produto.
![](https://i.imgur.com/FFHXJAD.png)

### 3. Carrinho de compras

        Página de carrinho de compras. Ele possui uma tabela própria no banco de dados e 
        é possivel adicionar e remover produtos.
![](https://i.imgur.com/AP0n68N.png)

### 4.Campo de login

        Campo de login funcional. Ele usa o sistema de login implementado pelo próprio ASP.Net
![](https://i.imgur.com/NZtUsE9.png)



