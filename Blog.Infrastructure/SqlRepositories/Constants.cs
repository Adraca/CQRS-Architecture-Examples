namespace Blog.Infrastructure.SqlRepositories
{
    internal class Constants
    {
        //The Article StoredProcedures
        internal const string SPLatestArticles = "FindTopArticles";
        internal const string SPUpdateArticle = "UpdateArticle";
        internal const string SPGetArticle = "FindArticleById";
        internal const string SPGetAuthorArticles = "FindArticleByAuthor";
        internal const string SPDeleteArticle = "DeleteArticle";
        internal const string SPNewArticle = "AddArticle";

        //The Author StoredProcedure
        internal const string SPGetAuthor = "FindAuthorById";

        //The Comment StoredProcedures
        internal const string SPNewComment = "AddComment";
        internal const string SPGetComments = "FindCommentsByArticle";
    }
}
