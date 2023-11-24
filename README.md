# csharp-authentication-jwt-api
Authentication api written in c# .Net 7

~~~mermaid
graph TD
    subgraph Client
    User --> Register
    User --> Login
    User --> Logout
    end

    subgraph Controllers
    AuthController --> AuthService
    end

    subgraph Services
    AuthService --> UserRepository
    end

    subgraph Models
    User
    User --> UserRepository
    end

    subgraph Database
    UserRepository --> EntityFramework
    end

    subgraph JWT
    AuthService --> JWTTokenGeneration
    end

    style AuthController fill:#333,stroke:#770,stroke-width:4px
    style AuthService fill:#333,stroke:#770,stroke-width:4px
    style UserRepository fill:#333,stroke:#770,stroke-width:4px
    style User fill:#333,stroke:#770,stroke-width:4px
    style EntityFramework fill:#333,stroke:#770,stroke-width:4px
    style JWT fill:#333,stroke:#770,stroke-width:4px
    style Client fill:#333,stroke:#770,stroke-width:2px
    style Controllers fill:#333,stroke:#770,stroke-width:2px
    style Models fill:#333,stroke:#770,stroke-width:2px
    style Database fill:#333,stroke:#770,stroke-width:2px
    style Services fill:#333,stroke:#770,stroke-width:2px
~~~

## misc 

- pending
