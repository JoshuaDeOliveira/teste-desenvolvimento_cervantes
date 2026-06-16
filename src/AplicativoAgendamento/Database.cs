using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Windows.Forms;


namespace AplicativoAgendamento
{
    public class Database
    {
        public NpgsqlConnection Conectar()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string DadosConectar = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(DadosConectar))
            {
                MessageBox.Show("A string de conexão não foi encontrada. Verifique o arquivo appsettings.json.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new InvalidOperationException("String de conexão ausente.");
            }

            return new NpgsqlConnection(DadosConectar);
        }   
    }
}
