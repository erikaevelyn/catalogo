namespace Catalogo{

/*Catalogar
Cree el diagrama de clases y luego, utilizando Visual Studio, un proyecto y las clases correspondientes 
para una utilidad de catálogo:
● Podrá almacenar información sobre archivos de música, películas y programas de computadora.
● Para cada artículo, debe almacenar: nombre, código, categoría y tamaño. Para las películas también 
debe contar con el director, el actor principal y la actriz principal. Para archivos de música, el cantante y 
la duración (en segundos).
● Para música y películas debe tener un método "Play" (no implementado todavía) y también un método 
"RetrieveInformation", que se conectará (en una versión posterior) a un servidor de Internet para obtener 
información al respecto.
Use la herencia si es necesario. En "Principal", crea matrices de cada tipo de objeto.
 */

 public abstract class Articulo{

     public string nombre;
     public int codigo;

     public string categoria;

     public double tamaño;

     public Articulo(string nombre, int codigo, string categoria, double tamaño){
         this.nombre = nombre;
         this.codigo = codigo;
         this.categoria = categoria;
         this.tamaño = tamaño;
     }


 }
}