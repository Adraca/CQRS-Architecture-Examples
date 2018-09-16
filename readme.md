# CQRS Architecture Examples

This repository contains multiple implementations of the same `API`. You can find more details about the `API` in the [The API](https://github.com/Adraca/CQRS-Architecture-Examples#blog-api) part below.

All of this is based on various real-world `CQRS` applications and point of views (and Greg Young's work).

## Branches

Each branches of this repository shows a different and gradual approch to `CQRS`:

The [Master branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/master) contains the most advanced version of the application and serves as a showcase for `CQRS` projects.

Currently on Master:

- The example API with all routes, without Command/Query separation yet, come back later

The [Basic-CQRS branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/basic-cqrs) will contains a simple separation of `Commands` and `Queries`.

The [Basic-Core branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/basic-core) will contains the API working without any traces of the CQRS pattern. It's a first version only used for futur references and comparison.

## The API

The above branches all exposes the same `API`, you can find it [here](https://github.com/Adraca/CQRS-Architecture-Examples/blob/master/swagger.yaml).

This is a simplified view of the exposed methods:

### Blog API

- /article (Add, Update, View, Delete, View Last 5, View all from Author)
- /author (View)
- /comment (Add, View all from Article)

### Objects

- Article (Id, Title, Content, CreationDate, AuthorId)
- Comment (Id, Content, CreationDate, AuthorName, ArticleId)
- Author (Id, Name, RegisterDate)

## Additionnal Notes

This is work in progress for now, check back later!

Tools used during the development:

- [Swagger.io](swagger.io) and it's [Editor](https://editor.swagger.io) for the [Documentation](https://github.com/Adraca/CQRS-Architecture-Examples/blob/master/swagger.yaml).
- [Swashbuckles](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) for the .Net Core implementation of Swagger.
- [Dapper](https://github.com/StackExchange/Dapper) for the Sql mapping.
