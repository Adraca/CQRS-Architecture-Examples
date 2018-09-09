# CQRS Architecture Examples

This repository contains multiple implementations of the same `API`. You can find more details about the `API` below.
All of this is based on various real-world `CQRS` applications and point of views.

## Branches

Each branches of this repository shows a different and gradual approch to `CQRS`:

The `Master branch` contains the most advanced version of the application and serves as a showcase for `CQRS` projects.

The `Basic branch` contains a simple separation of `Commands` and `Queries`.

## The API

The above branches all exposes the same `API`, you can find it [here](http://www.google.com).
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
