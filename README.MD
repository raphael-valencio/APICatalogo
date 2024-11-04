# API Catalogo

Este é o repositório para o projeto API Catalogo. Esta API fornece funcionalidades para gerenciar um catálogo de produtos.

## Funcionalidades

- Listar produtos
- Adicionar novos produtos
- Atualizar informações de produtos existentes
- Remover produtos

## Tecnologias Utilizadas

- .NET Core
- Entity Framework Core
- MariaDB (via Docker)

## Como Executar o Projeto

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/APICatalogo.git
    ```
2. Navegue até o diretório do projeto:
    ```bash
    cd APICatalogo
    ```
3. Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```
4. Execute o Docker Compose para iniciar o banco de dados:
    ```bash
    docker-compose up -d
    ```
5. Atualize o banco de dados:
    ```bash
    dotnet ef database update
    ```
6. Execute a aplicação:
    ```bash
    dotnet run
    ```

## Endpoints

- `GET /api/produtos` - Lista todos os produtos
- `GET /api/produtos/{id}` - Obtém um produto pelo ID
- `POST /api/produtos` - Adiciona um novo produto
- `PUT /api/produtos/{id}` - Atualiza um produto existente
- `DELETE /api/produtos/{id}` - Remove um produto

## Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature:
    ```bash
    git checkout -b minha-feature
    ```
3. Commit suas mudanças:
    ```bash
    git commit -m 'Minha nova feature'
    ```
4. Envie para o repositório remoto:
    ```bash
    git push origin minha-feature
    ```
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
