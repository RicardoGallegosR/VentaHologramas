using Sivev.Core.Configuracion;
using System.Diagnostics;

using Sivev.Core.Utilidades.Log;
using Sivev.Core.RegEdit;

namespace Sivev.Core.Venta.VentaRapida {
    public class VentaHologramasIni : IDisposable {
        private byte NivelDebugClase = 1;
        private Logger? log;
        private readonly RegWin regWin = new RegWin();

        public bool VentaVerificentros() {
            if (regWin.NivelDebug >= NivelDebugClase && regWin.DebugActivo == 1) {
                log = new Logger("VentaHologramas");
                log.Log("VentaHologramasIni", nameof(VentaVerificentros), "Inicio de venta de hologramas");
            }

            bool ventaExitosa = false;
            regWin.OpcionMenuId = 801;
            log.Log("VentaHologramasIni", nameof(VentaVerificentros), "Verificando conexión al SQL");


            /*

            if (!ConexionBD.Abrir("VentaHologramasIni", out var sql, RegWin.CookieRol)) {
                Debugger.Procesa("Conexión SQL fallida");
                Errores.Mostrar("No ha sido posible abrir la base de datos SQL. Intente más tarde");
                return false;
            }

            Debugger.Procesa("Validando credenciales");

            if (Acceso.Validar()) {
                if (RegWin.AccesoId != Guid.Empty) {
                    Debugger.Procesa("Credencial válida. Iniciando proceso");
                    using var frm = new OrdenCompra();
                    frm.ShowDialog();
                    ventaExitosa = true;
                } else {
                    Debugger.Procesa("AccesoId inválido (GUID vacío)");
                    Errores.Mostrar("Error en SQL. AccesoId es inválido.");
                }
            } else {
                Debugger.Procesa("Credencial inválida o ingreso cancelado");
            }

            Finalizar();*/
            return ventaExitosa;
            
        }

        public void Dispose() {
            // Cierra conexiones, libera objetos si es necesario
        }

        private void Finalizar() {
            //Debugger.Procesa("Finalizando proceso");
            // limpieza u operaciones finales
        }
    }
}
