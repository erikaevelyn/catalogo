using System;

namespace Catalogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Pelicula[] peliculas = new Pelicula[4];
            Pelicula pelicula1 = new Pelicula("Pablo Alba","Leonardo Di Caprio","Penelope Cruz",
            "Matrix",1,"Ficcion",105.5D);
            peliculas[0]=pelicula1;

            Pelicula pelicula2 = new Pelicula("Alicia Moreau","Brad Pitt","Angelina Jolie",
            "Sr. y Sra. Smith",2,"Drama",101.5D);
            peliculas[1]=pelicula2;

            Pelicula pelicula3 = new Pelicula("Sofia Loren","Robert De Niro","Jenifer Aniston",
            "Friends",3,"Comedia",96.5D);
            peliculas[2]=pelicula3;

            Pelicula pelicula4 = new Pelicula("Gustavo Yanquelevich","Guillermo Francella","Eugenia Suarez",
            "Corazon de Leon",4,"Tragicomedia",85.5D);
            peliculas[3]=pelicula4;


            Musica[] musicas = new Musica[4];
            Musica musica1 = new Musica("Lali Esposito", 355, "Sin querer", 5, "Pop", 8.6D);
            musicas[0]=musica1;

            Musica musica2 = new Musica("Dua Lipa", 159, "New Rules", 6, "Pop", 10.6D);
            musicas[1]=musica2;

            Musica musica3 = new Musica("Calvin Harris", 659, "Promises", 7, "Electronica", 21.6D);
            musicas[2]=musica3;

            Musica musica4 = new Musica("Camila Cabello", 458, "Havana", 8, "Pop", 8.6D);
            musicas[3]=musica4;

            Programa[] programas = new Programa[4];
            Programa programa1 = new Programa("Adobe Premiere", 9, "Edicion de video", 103.9D);
            programas[0]=programa1;

            Programa programa2 = new Programa("Adobe Photoshop", 10, "Edicion de fotos", 655.9D);
            programas[1]=programa2;

            Programa programa3 = new Programa("Corel Draw", 11, "Disenio grafico", 5236.9D);
            programas[2]=programa3;

            Programa programa4 = new Programa("Microsoft Word", 12, "Edicion de texto", 215.9D);
            programas[3]=programa4;



            Console.WriteLine("Las peliculas registradas son:");
            
            for(int i=0; i<peliculas.Length; i++){
                Console.WriteLine($"Codigo: {peliculas[i].codigo} - {peliculas[i].nombre} dirigida por {peliculas[i].director}");
                
            }

            Console.WriteLine("Las canciones registradas son:");
            
            for(int i=0; i<musicas.Length; i++){
                Console.WriteLine($"Codigo: {musicas[i].codigo} - {musicas[i].nombre} de {musicas[i].cantante}");
                
            }

            Console.WriteLine("Los programas registrados son:");
            
            for(int i=0; i<programas.Length; i++){
                Console.WriteLine($"Codigo: {programas[i].codigo} - {programas[i].nombre}");
                
            }
        }
    }
}
