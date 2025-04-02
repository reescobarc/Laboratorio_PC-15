using System; 
namespace Proyecto_1_PabloEscobar_RosembergEscobar
{
class ProyectoLabPC
    {
        public static void Main(string[] args)
        {
            //aqui se hace el programa 
        }
        //datos para el programa 
        //datos de vida de los personajes 
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
    }
}
