namespace StockApp.DataAccess
{

    public static class SqlServerContext
    {
        internal static string ConexaoSemBanco => @"server= CEPEAS21104038\SQLEXPRESS ; Integrated Security=True; User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
        internal static string ConexaoComBanco => @"Data Source= CEPEAS21104038\SQLEXPRESS ; Initial Catalog=StockApp;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
    }
    
}
