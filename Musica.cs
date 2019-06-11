

namespace Catalogo{
/*Para archivos de música, el cantante y 
la duración (en segundos). */
    public class Musica : Articulo {

        public string cantante;
        public double duracion;

        public Musica(string cantante, double duracion, string nombre, int codigo, string categoria, double tamaño) 
            : base(nombre, codigo, categoria, tamaño){

                this.cantante = cantante;
                this.duracion = duracion;

        }

    public void Play(){

    }

     public void RetrieveInformation(){

     }

    }
}