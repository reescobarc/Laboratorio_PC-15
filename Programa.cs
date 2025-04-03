using System; 
namespace Proyecto_1_PabloEscobar_RosembergEscobar
{
class ProyectoLabPC
    {
        public static void Main(string[] args)
        {
            //aqui se hace el programa
            Console.WriteLine("¡Bienvenido, valiente viajero! Ante ti se extiende un mundo lleno de misterios y desafíos. Antes de comenzar tu gran aventura, necesito saber más sobre ti. ¿Cuál es tu nombre, héroe?");
            NombreUsuario();
        }
        //Datos base para el programa 
        //Datos de vida de los personajes 
        public PersonajesVida (int magoVida, int caballeroVida, int arqueraVida)
        {
            magoVida = 100; 
            caballeroVida = 70; 
            arqueraVida = 85; 
            return;
        }
        //Datos de daño de los personajes 
        public PersonajesPoder (int magoPoder, int caballeroPoder, int arqueraPoder)
        {
            magoPoder = 20; 
            caballeroPoder = 30; 
            arqueraPoder = 25; 
            return;
        }
        //Tabla de datos de los personajes
        public Personajes(string magoDatos, string caballeroDatos, string arqueraDatos)
        {
            
        }
        public SeleccionPersonaje(string mago, string caballero, string arquera)
        {
            
        }
        public NombreUsuario(string userName)
        {
            string userName = Console.ReadLine();
            Console.WriteLine($"Hola {userName}, comencemos el juego!")
        }
    }
}
