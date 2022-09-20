using Microsoft.AspNetCore.Mvc;
using AvaliacaoLP3.ViewModels;
using AvaliacaoLP3.Models;
using System.Diagnostics;
namespace AvaliacaoLP3.Controllers;

public class ShoppingController : Controllers;

public class ShoppingController : Controller
{
    private static List<LojasViewModel> lojas = new List<LojasViewModel> 
    {
        new LojasViewModel(32, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", true, "tenis@email.com"),
        new LojasViewModel(33, "piso 3", "Lembranças Já", "Vem comprar sua lembrança", true, "lemb@email.com"),
        new LojasViewModel(12, "piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", false, "sorvet@email.com"),
    };

    public IActionResult Admin()
    {
        return View();
    }

    public IActionResult Detalhes()
    {       
        return View();
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}