namespace madly_DAL.DataSettings
{
    public static class ConnectionStrings
    {
        //TODO: Criar login específico para a aplicação no BD, não usar usuário SA
        public static string SqlServer
            => "Server=localhost,1433; Initial Catalog=Madly; User ID=madly; Password=P@$$word";

        public static string SqlServerDocker
            => "Server=madly_db,1433; Initial Catalog=Madly; User ID=SA; Password=123@mudar"; 

    }
}