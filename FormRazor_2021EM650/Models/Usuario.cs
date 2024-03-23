using System;
using System.Collections.Generic;

namespace FormRazor_2021EM650.Models;

public partial class Usuario
{
    public int IdUsuarios { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Password { get; set; }

    public string? Genero { get; set; }

    public string? Direccion { get; set; }

    public string? Pasatiempos { get; set; }

    public string? Curso { get; set; }

    public string? Conocimientos { get; set; }
}
