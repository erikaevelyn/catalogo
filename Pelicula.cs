namespace Catalogo{

    /*Para las películas también 
debe contar con el director, el actor principal y la actriz principal. Para archivos de música, el cantante 
y la duración (en segundos).
● Para música y películas debe tener un método "Play" (no implementado todavía) y también un método 
"RetrieveInformation", que se conectará (en una versión posterior) a un servidor de 
Internet para obtener información al respecto. */

public class Pelicula : Articulo{

    public string director;
    public string actorPrincipal;

    public string actrizPrincipal;

    public Pelicula(string director, string actorPrincipal, string actrizPrincipal, string nombre,
    int codigo, string categoria, double tamaño) 
    : base(nombre, codigo, categoria, tamaño){

        this.director = director;
        this.actorPrincipal = actorPrincipal;
        this.actrizPrincipal = actrizPrincipal;
    }

    
    public void Play(){

    }

     public void RetrieveInformation(){

     }
}

}