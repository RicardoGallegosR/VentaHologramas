//using Microsoft.Data.SqlClient;
//using System.Data;



/*
class Program {
    static async Task Main() {
        string connStr = "Server=192.168.16.8;Initial Catalog=SIVEV;User ID=SivevAppRG;Password=mx8!5%kFieNzJru4KU$5LpoN7!c7ST;TrustServerCertificate=True;Pooling=false";

        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();

        // Activar primer rol
        byte[] cookie = await SetRoleAsync(conn, "RollSivev", "53CE7B6E-1426-403A-857E-A890BB63BFE6");

        // Obtener clave y función del rol real
        var (claveRol, funcionRol) = await GetClaveYFuncionRolAsync(conn);
        string reversa = Reversa(claveRol);

        // Desactivar rol inicial
        await UnsetRoleAsync(conn, cookie);

        // Activar rol real con contraseña invertida
        byte[] finalCookie = await SetRoleAsync(conn, funcionRol, reversa);

        // Probar acceso con el rol final
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT TOP 1 * FROM Sivev.Certificados.Certificados";
        using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync()) {
            Console.WriteLine($"✅ Acceso correcto con rol final '{funcionRol}', CertificadoId: {reader["CertificadoId"]}");
        }
    }

    public static async Task<byte[]> SetRoleAsync(SqlConnection conn, string roleName, string password) {
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "EXEC sp_setapprole @rolename, @password, @fCreateCookie = 1, @cookie = @cookie OUTPUT;";
        cmd.Parameters.AddWithValue("@rolename", roleName);
        cmd.Parameters.AddWithValue("@password", password);

        var cookieParam = new SqlParameter("@cookie", SqlDbType.VarBinary, 8000) {
            Direction = ParameterDirection.Output
        };
        cmd.Parameters.Add(cookieParam);

        await cmd.ExecuteNonQueryAsync();

        if (cookieParam.Value is byte[] cookie)
            return cookie;

        throw new Exception("No se obtuvo la cookie del Application Role.");
    }

    public static async Task UnsetRoleAsync(SqlConnection conn, byte[] cookie) {
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "EXEC sp_unsetapprole @cookie;";
        cmd.Parameters.Add("@cookie", SqlDbType.VarBinary, 8000).Value = cookie;
        await cmd.ExecuteNonQueryAsync();
    }

    public static async Task<(string claveRol, string funcionRol)> GetClaveYFuncionRolAsync(SqlConnection conn) {
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "EXEC SpAppRollClaveGet @sqlError OUTPUT, @mensajeId OUTPUT, @resultado OUTPUT, @claveRol OUTPUT, @funcionRol OUTPUT";

        cmd.Parameters.Add("@sqlError", SqlDbType.Int).Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@mensajeId", SqlDbType.Int).Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@resultado", SqlDbType.SmallInt).Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@claveRol", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@funcionRol", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

        await cmd.ExecuteNonQueryAsync();

        int resultado = (short)cmd.Parameters["@resultado"].Value;
        if (resultado != 0)
            throw new Exception("No se lograron obtener los datos del rol de la aplicación");

        string claveRol = (string)cmd.Parameters["@claveRol"].Value;
        string funcionRol = (string)cmd.Parameters["@funcionRol"].Value;
        return (claveRol, funcionRol);
    }

    public static string Reversa(string input) =>
        new string(input.Reverse().ToArray());
}
*/

using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;
using Sivev.Core.PDF.VentaHolograma.Venta;
//using Sivev.Core.PDF.VentaHologramas.Comisa;
using System;
using System.Collections.Generic;
using System.IO;


namespace TestPDF {
    public sealed class ArialFontResolver : IFontResolver {
        private static readonly string FontsPath = @"C:\Windows\Fonts";

        public byte[] GetFont(string faceName) {
            // Devuelve los bytes del archivo .ttf correspondiente
            return faceName switch {
                "Arial#Regular" => File.ReadAllBytes(Path.Combine(FontsPath, "arial.ttf")),
                "Arial#Bold" => File.ReadAllBytes(Path.Combine(FontsPath, "arialbd.ttf")),
                "Arial#Italic" => File.ReadAllBytes(Path.Combine(FontsPath, "ariali.ttf")),
                "Arial#BoldItalic" => File.ReadAllBytes(Path.Combine(FontsPath, "arialbi.ttf")),
                _ => null
            };
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic) {
            // Redirige cualquier familia (incluida "Courier New") a Arial
            var style = (isBold, isItalic) switch
        {
            (false, false) => "Regular",
            (true,  false) => "Bold",
            (false, true ) => "Italic",
            (true,  true ) => "BoldItalic"
        };
            return new FontResolverInfo($"Arial#{style}");
        }
    }
    static class FontsBootstrap {
        private static bool _init;
        public static void Init() {
            if (_init) return;
            GlobalFontSettings.FontResolver = new ArialFontResolver(); // << aquí
            _init = true;
        }
    }

    internal class Program {
        

        static void Main(string[] args) {
            // ==== Datos de prueba ====
            var cv = new CentroVerificacion {
                Remision = 5123,
                FechaRemision = DateTime.Now,
                Direccion = "Av. Siempre Viva #123, CDMX",
                Centro = "CV-01",
                RazonSocial = "Verificentros del Centro S.A. de C.V.",
                RFC = "VCC010203ABC",
                CentroVerificacionName = "Centro de Verificación CV-01"
            };

            var lineas = new List<LineaCapturaItem> {
                new LineaCapturaItem {
                    Cantidad = 10,
                    Concepto = "Hologramas Tipo 1",
                    FolioInicial = 1001,
                    FolioFinal = 1010,
                    Precio = 50.0m
                },
                new LineaCapturaItem {
                    Cantidad = 5,
                    Concepto = "Hologramas Tipo 2",
                    FolioInicial = 2001,
                    FolioFinal = 2005,
                    Precio = 75.0m
                }
            };



            // ==== Crear documento y generar PDF ====
            FontsBootstrap.Init();

            var doc = new Document();
            var venta = new VentaHolograma(cv, lineas);
            
            venta.BuildPdf(doc);

            var renderer = new PdfDocumentRenderer(unicode: true) { Document = doc };
            renderer.RenderDocument();

            string downloadsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );
            string outputPath = Path.Combine(downloadsPath, "OrdenCompra_Test2.pdf");
            renderer.PdfDocument.Save(outputPath);

        }
       
    }
}
