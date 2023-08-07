class Juego
{
    private string username{get;set;}
    private int puntajeActual{get;set;}
    private int cantidadPreguntasCorrectas{get;set;}
    private List<Pregunta> preguntas{get;set;}
    private List<Respuesta> respuestas{get;set;}

    public static void InicializarJuego()
    {
        string username = "";
        int puntajeActual = 0;
        int cantidadPreguntasCorrectas = 0;
    }
    public static List<Categoria> ListaCategorias()
    {
        return BD.ObtenerCategorias();
    } 
    public static List<Dificultad> ListaDificultades()
    {
        return BD.ObtenerDificultades();
    }
    public static void CargarPartida(string username, int IdDificultad, int IdCategoria)
    {
        List<Pregunta> preguntas = BD.ObtenerPreguntas(IdDificultad, IdCategoria);
        List<Respuesta> respuestas = BD.ObtenerRespuestas(preguntas);
    }
    public static void ObtenerProximaPregunta()
    {

    }
}