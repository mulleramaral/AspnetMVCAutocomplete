using System.Data.Entity;

namespace AutocompleteAspNetMvc.Models
{
    public class ClientesContext : DbContext
    {
        public ClientesContext():base("DbAutocomplete")
        {
            Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}