using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "exemplo@exemplo.com.br", "Joe");
        Cliente cliente2 = new Cliente(02, "William Hent", "857.032.950-42", "william@exemplo.com.br", "Madruga");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "857.032.950-39", "ada@exemplo.com.br", "Bug");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "857.032.430-41", "linus@exemplo.com.br", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "857.000.950-41", "hopper@exemplo.com.br", "Loboc");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet S/A", "14.182.102/0001-00", "c-sharper@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt dog", "14.182.102/0001-57", "ctrl@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bootspet INC", "14.182.102/0001-38", "boostpet@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Dogs", "14.182.102/0001-09", "tikdog@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "14.182.102/0001-37", "bifinho@pet.org");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
