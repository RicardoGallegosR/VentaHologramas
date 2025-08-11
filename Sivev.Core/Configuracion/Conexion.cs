using DotNetEnv;
using Microsoft.Data.SqlClient;

namespace Sivev.Core.Configuracion {
    public class Conexion {
        public Conexion() {
            //AppContext.SetSwitch("System.Net.SecurityProtocol.DisableSystemDefaultTlsVersions", true);
            //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            string baseDir = AppContext.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", ".."));
            string envPath = Path.Combine(projectRoot, ".env");
            Env.Load(envPath);
            if (!File.Exists(envPath))
                throw new FileNotFoundException($".env no encontrado en: {envPath}");

            Env.Load(envPath);
        }

        public string GetConnectionStringSIVEV() =>
            GetConnectionString("DB_SIVEV_SERVER", "DB_SIVEV_NAME", "DB_SIVEV_USER", "DB_SIVEV_PASS");

        public string GetConnectionStringMonitoreo() =>
            GetConnectionString("DB_MONITOREO_SERVER", "DB_MONITOREO_NAME", "DB_MONITOREO_USER", "DB_MONITOREO_PASS");

        private string GetConnectionString(string serverKey, string dbKey, string userKey, string passKey) {
            string server = Environment.GetEnvironmentVariable(serverKey);
            string database = Environment.GetEnvironmentVariable(dbKey);
            string user = Environment.GetEnvironmentVariable(userKey);
            string pass = Environment.GetEnvironmentVariable(passKey);

            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database) ||
                string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass)) {
                throw new InvalidOperationException($"Faltan variables de entorno: {serverKey}, {dbKey}, {userKey}, {passKey}");
            }

            return $"Data Source={server};Initial Catalog={database};User ID={user};Password={pass};TrustServerCertificate=True;";
        }

        public async Task<SqlConnection> GetConnectionConRolSIVEVAsync() {
            string connectionString = GetConnectionStringSIVEV() + ";Pooling=false"; // Asegura una conexión ad hoc
            string appRole = Environment.GetEnvironmentVariable("APP_ROLE_NAME");
            string appPass = Environment.GetEnvironmentVariable("APP_ROLE_PASSWORD");

            if (string.IsNullOrWhiteSpace(appRole) || string.IsNullOrWhiteSpace(appPass))
                throw new InvalidOperationException("Faltan las variables de entorno APP_ROLE_NAME o APP_ROLE_PASSWORD");

            var conn = new SqlConnection(connectionString);
            await conn.OpenAsync();

            try {
                using (var cmd = conn.CreateCommand()) {
                    cmd.CommandText = "EXEC sp_setapprole @rolename, @password";
                    cmd.Parameters.AddWithValue("@rolename", appRole);
                    cmd.Parameters.AddWithValue("@password", appPass);

                    await cmd.ExecuteNonQueryAsync();
                }
            } catch (SqlException ex) {
                Console.WriteLine($"❌ Error activando el Application Role: {ex.Message}");
                Console.WriteLine("⚠️ Verifica que la contraseña esté correcta, que el usuario tenga permiso para ejecutar sp_setapprole, y que MARS esté desactivado.");
                throw;
            }

            return conn;
        }

    }
}
