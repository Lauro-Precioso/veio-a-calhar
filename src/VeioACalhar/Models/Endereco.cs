namespace VeioACalhar.Models;

public class Endereco : Entidade
{
    public string? Logradouro { get; init; }

    public int Numero { get; init; }

    public string? Bairro { get; init; }

    public string? Cidade { get; init; }

    public string? CEP { get; init; }

    public string? Observacoes { get; init; }
}