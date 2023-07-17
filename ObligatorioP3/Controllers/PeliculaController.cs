using ObligatorioP3.datos;
using ObligatorioP3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ObligatorioP3.Controllers
{
    public class PeliculaController : Controller
    {
        public readonly aplicationDBContext? _aplicationDBContext;

        public PeliculaController(aplicationDBContext? context)
        {
            _aplicationDBContext = context;
        }
        [HttpGet] // eteiqueta para acceder alnavegador 
        public IActionResult Index() // metodo 
        {
            List<Peliculas>? listaPelicula = _aplicationDBContext?.Peliculas? // variable lista 
                .OrderBy(c => c.PeliculasId) // ordena por el id de pelicula 
                .ToList(); // lo lista 
            return View(listaPelicula); // devuelve la lista pelicla en una vista 
        }

        [HttpGet]
        public IActionResult Crear()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Peliculas pelicula) // Esta es la declaración de la acción del controlador llamada "Crear". La acción recibe un parámetro pelicula de tipo Peliculas,
                                                       // que se utilizará para recibir los datos enviados desde el formulario 
        {
            if (ModelState.IsValid) // Verifica si los datos recibidos en el parámetro son validos 
            {
                _aplicationDBContext?.Peliculas?.Add(pelicula); //Agrega el objeto pelicula a la tabla "Peliculas" en el contexto de base de datos. 
                _aplicationDBContext?.SaveChanges();//Guarda los cambios en la base de datos
                return RedirectToAction(nameof(Index)); //Si la película es válida y se ha guardado correctamente en la base de datos,
                                                        //redirecciona a la acción "Index" del controlador actual.
            }
            return View(); 
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return View();
            }
            var pelicula = _aplicationDBContext?.Peliculas?.FirstOrDefault(c => c.PeliculasId == id);// Utilizando el contexto de base de datos,
                                                                                                      // se busca una película en la tabla "Peliculas" cuyo PeliculasId coincida con el valor de id
            return View(pelicula);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Peliculas pelicula)
        {
            if (ModelState.IsValid)
            {
                _aplicationDBContext?.Peliculas?.Update(pelicula);//Si el modelo es válido,
                                                                  //esta línea actualiza los datos de la película en la base de datos utilizando el contexto de base de datos
                _aplicationDBContext?.SaveChanges(); //Después de realizar la actualización, esta línea guarda los cambios en la base de datos
                                                     //El método SaveChanges confirma la transacción y aplica los cambios a la base de datos.
                return RedirectToAction(nameof(Index));
            }
            return View(pelicula);
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            var pelicula = _aplicationDBContext?.Peliculas?.FirstOrDefault(c => c.PeliculasId == id);
            if (pelicula != null)
            {
                _aplicationDBContext?.Peliculas?.Remove(pelicula);// Si se encontró una película,
                                                                 // esta línea elimina la película de la base de datos utilizando el contexto de base de datos 
            }
            _aplicationDBContext?.SaveChanges(); // Después de eliminar la película (si se encontró una coincidencia), esta línea guarda los cambios en la base de datos.
                                                 // El método SaveChanges confirma la transacción y aplica los cambios a la base de datos.
            return RedirectToAction(nameof(Index)); //redirecciona al método Index 
        }
        [HttpPost]
        public IActionResult Buscar(string titulo)
        {
            List<Peliculas>? peliculasEncontradas = _aplicationDBContext?.Peliculas? // Se declara una variable local,Aquí se utiliza el contexto de base de datos para acceder a la tabla "Peliculas
                .Where(p => p.Titulo!.Contains(titulo)) // . El método Contains se utiliza para comprobar si el título contiene el texto proporcionado
                .ToList();

            return View("Index", peliculasEncontradas);
        }
        [HttpPost]
        public IActionResult BuscarGenero(string genero)
        {
            List<Peliculas>? GenerosEncontrados = _aplicationDBContext?.Peliculas? // Se utiliza elcontexio de la bas ede datos pafa acder a la  tabla 
                .FromSqlInterpolated($"select * from Peliculas where Genero_Pel={genero}") //Se realiza una consulta directa a la base de datos utilizando SQL crudo
                .ToList();

            return View("Index", GenerosEncontrados);
        }
    }
}
