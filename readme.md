# CQRS Architecture Examples

This repository contains multiple implementations of the same `API`. You can find more details about the `API` in the [The API](https://github.com/Adraca/CQRS-Architecture-Examples#blog-api) part below.

All of this is based on various real-world `CQRS` applications and point of views (and Greg Young's work).

## Branches

Each branches of this repository shows a different and gradual approach to `CQRS`:

The [Master branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/master) contains the most advanced version of the application and serves as a showcase for `CQRS` projects.

**Currently on Master:**

- The example API with all routes, without Command/Query separation yet, come back later
- Next step: separating source files in multiple projects for the sake of readability and SOLID.

The [Basic-Core branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/basic-core) contains the API working without any traces of the CQRS or DDD patterns.

This is a first version only used for future references and comparison. Here, all source files are parts of the same project with only a simple folder separation.

The [Basic-CQRS branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/basic-cqrs) will contains a simple separation of `Commands` and `Queries`.


## The API

The above branches all exposes the same `API`, you can find it [here](https://github.com/Adraca/CQRS-Architecture-Examples/blob/master/swagger.yaml) or directly on the `API` after launching it at [http://localhost:yourport/swagger](http://localhost:yourport/swagger). This is a simplified view of the exposed methods:

### _Blog API_

- /articles (Add, Update, View, Delete, View Last 5, View all from Author)
- /authors (View)
- /comments (Add, View all from Article)

### _Objects_

- Article (Id, Title, Content, CreationDate, AuthorId)
- Comment (Id, Content, CreationDate, AuthorName, ArticleId)
- Author (Id, Name, RegisterDate)

## Additionnal Notes

This is work in progress for now, check back later!

Tools used during the development:

- [Swagger.io](swagger.io) and it's [Editor](https://editor.swagger.io) for the [Documentation](https://github.com/Adraca/CQRS-Architecture-Examples/blob/master/swagger.yaml).
- [Swashbuckles](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) for the .Net Core implementation of Swagger.
- [Dapper](https://github.com/StackExchange/Dapper) for the SQL mapping.

Source for some Pattern Ideas:

- [Microsoft eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers) which contains multiple examples of crud-based and DDD-based WebAPI in .Net Core.
