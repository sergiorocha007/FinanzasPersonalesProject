using ControlFinanzas.Entity.Entidades;
using System.Text.Json;

namespace ControlFinanzas.DAL.Common
{
    public class ConfiguracionDal
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "configuracion.json");

        public bool ExisteConfiguracion()
        {
            return File.Exists(rutaArchivo);
        }

        public bool Guardar(ConexionEntity config)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo)!);

                string json = JsonSerializer.Serialize(config,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(rutaArchivo, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ConexionEntity? Obtener()
        {
            if (!File.Exists(rutaArchivo))
                return null;

            try
            {
                string json = File.ReadAllText(rutaArchivo);
                return JsonSerializer.Deserialize<ConexionEntity>(json);
            }
            catch
            {
                return null;
            }
        }
    }
}
