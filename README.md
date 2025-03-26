🛠️ Tecnologias Utilizadas
*Backend

.NET 8 – Framework robusto para desenvolvimento de APIs eficientes.

Entity Framework Core – ORM para acesso e gerenciamento de dados no SQL Server.

SQL Server – Banco de dados relacional para armazenamento de dados estruturados.

Redis – Cache distribuído para melhorar desempenho em operações frequentes.

AutoMapper – Mapeamento automático entre objetos para simplificar transformações de dados.

Domain-Driven Design (DDD) – Arquitetura focada em domínio para melhor organização e clareza do código.



*Frontend

Angular – Framework para construção de interfaces dinâmicas e responsivas.

TypeScript – Superset tipado do JavaScript para maior segurança no desenvolvimento.

JavaScript – Linguagem base para interatividade e lógica no frontend.



⚙️ Configuração do Ambiente
Pré-requisitos
.NET 8 SDK

SQL Server (ou Docker com imagem do SQL Server)

Node.js (v18+)

Redis (ou Docker com imagem do Redis)

Angular CLI

Executando o Projeto
Backend (.NET)

sh
Copy
cd src/Backend
dotnet restore
dotnet run
Configure a connection string no appsettings.json.

Execute as migrations do EF Core:

sh
Copy
dotnet ef database update
Frontend (Angular)

sh
Copy
cd src/Frontend
npm install
ng serve
Acesse http://localhost:4200 no navegador.

Redis (Cache)

Certifique-se de que o Redis está rodando (padrão: localhost:6379).


🔧 Padrões e Boas Práticas
DDD (Domain-Driven Design) – Separação clara entre domínio, aplicação e infraestrutura.

CQRS (opcional) – Segregação de leitura e escrita quando aplicável.

Repository Pattern – Abstraction de acesso a dados.

Clean Code – Nomenclatura clara e funções coesas.
