namespace Libro.Core.Entidades
{
    public class Libro
    {
        public required string NameUsuario { get; set; }
        public required string NameAutor{ get; set; }
        public required string Genero { get; set; }
        public int Paginas { get; set; }
        public bool Importado { get; set; }
        public int Precio { get; set; }

    }
}
