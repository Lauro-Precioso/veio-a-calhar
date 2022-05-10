namespace VeioACalhar.Models;

public abstract class Pessoa : Entidade
{
    public string? Nome { get; init; }

    public string? Observacoes { get; init; }

    public string? PIX { get; init; }

    public string? Email { get; init; }

    public IEnumerable<Endereco>? Enderecos { get; init; }

    public IEnumerable<Telefone>? Telefones { get; init; }
}
