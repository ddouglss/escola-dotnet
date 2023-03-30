using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escoladotnet_.Models;

namespace escoladotnet_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   //var - declaração da variável
        //new - operador de instanciação
        //Curso( ) - chamada ao Construtor da classe Curso
        //Construtor - construir o objeto na memória.
       
        var curso = new Curso(){ //
           //Mock (dados de teste - fictício)
           //Propriedades automáticas
           Id =1,
           Nome = "Introdução a programação",
           Titulo = "Primeiros passos na programação",
           Descricao = "Domine a programação com nosso curso completo - aprenda desde o básico até o avançado e desenvolva suas próprias aplicações com confiança!",
           Perfil ="estudantes e aprendizes no geral",
           PreRequisitos ="informática básica",
           Conteudo = "1-introdução 2-lógica 3-estruturas 4-vetores 5-funções 6-matrizes 7-estruturas de dados 8-registros",
           CargaHoraria = 40,
           PrazoMeses = 1

        };
         ViewData["curso"] = curso; //atribuir um objeto
         /* //string interpolada
         int ch =40;
        //Dicionário (ViewDataDictionary)
        ViewData["nome"] ="TI Essencial";
        ViewData["titulo"] ="Uma visão geral da TI"; 
        ViewData ["ch"] = $"Termos {ch} horas de imersão nos fundametos da TI";
        ViewData ["descricao"] ="Nesse curso você vai aprender os primeiros passos da tecnologia da informação, conhecer o hardware, software, redes, protocolos e conhecimentos básicos para depois mergulhar no mundo do desenvolvimento de software da Microsoft ";
       
       
           Para transporta dados de um controller para uma View 
           Podemos usar ViewData, Viewbag e TempData

           Competência ViewData 
           Competência Viewbag
           Competência TempData

        */
        return View();
    }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
