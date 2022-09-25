using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace AvaliacaoLP3.ViewModels;

public class LojaViewModel 
{
    public int Id { get; set; }
    public int Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool Modelo { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, string nome, string descricao, string email, int piso, bool modelo)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Modelo = modelo;
        Email = email;
    }
}
