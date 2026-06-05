using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using atividade_cadastrar_aluno_uni9.Models;

namespace atividade_cadastrar_aluno_uni9.Controllers;

public class AlunoController : Controller
{
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View(new Aluno());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return View(aluno);
        }

        TempData["AlunoCadastrado"] = JsonSerializer.Serialize(aluno);
        return RedirectToAction(nameof(Confirmacao));
    }

    [HttpGet]
    public IActionResult Confirmacao()
    {
        var alunoJson = TempData["AlunoCadastrado"] as string;
        if (string.IsNullOrWhiteSpace(alunoJson))
        {
            return RedirectToAction(nameof(Cadastrar));
        }

        var aluno = JsonSerializer.Deserialize<Aluno>(alunoJson);
        if (aluno is null)
        {
            return RedirectToAction(nameof(Cadastrar));
        }

        return View(aluno);
    }
}
