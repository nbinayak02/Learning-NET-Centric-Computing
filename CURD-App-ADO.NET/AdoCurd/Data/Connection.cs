namespace AdoCurd.Data
{
    public class Connection
    {
        //class for configuring connection string
        protected readonly string _connectionstring;

        public Connection(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("DefaultConnection") ??
                throw new ArgumentNullException(nameof(configuration), "COnnection string cannot be initialized");
        }
    }
}
