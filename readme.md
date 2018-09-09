# CQRS Architecture Examples

This repository contains multiple implementations of the same `API`. You can find more details about the `API` in the [The API](https://github.com/Adraca/CQRS-Architecture-Examples#blog-api) part below.

All of this is based on various real-world `CQRS` applications and point of views (and Greg Young's work).

## Branches

Each branches of this repository shows a different and gradual approch to `CQRS`:

The [Master branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/master) contains the most advanced version of the application and serves as a showcase for `CQRS` projects.

Currently on Master:

- Just an empty API, come back later

The [Basic branch](https://github.com/Adraca/CQRS-Architecture-Examples/tree/basic) will contains a simple separation of `Commands` and `Queries`.

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
