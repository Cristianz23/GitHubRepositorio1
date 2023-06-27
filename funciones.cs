using System;


namespace XMLComentario
{
/// <summary>
/// ESTA CLASE SIRVE PARA MOSTRAR NOMBRES.
/// </summary>
    public class Mensajes
    {

        /// <summary>
        /// ALMACENA EL NOMBRE DEL USUARIO.
        /// </summary>
        public string? nombre { get; set; }

        /// <summary>
        /// DEVUELVE EL NOMBRE DEL USAURIO
        /// </summary>
        /// <param name="nombre">GUARDA NOMBRE</param>
        /// <returns>Devuelve un string con el nombre del user</returns>
        public string MostrarRespueta(string x) {
            Console.WriteLine($"Tu nombre es: {x}");
            return $"Tu nombre es: {x}";
        }
    }
}