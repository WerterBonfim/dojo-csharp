using FluentAssertions;

namespace Werter.Dojo.Testes.Desafio01;

public class GerenciamentoDeTarefasTestes
{
    [Fact]
    public void DeveriaAdicionarUmaTarefaComSucesso()
    {
        // Arrage
        var gerenciador = new GerenciadorDeTarefas();
        
        // Act
        gerenciador.AdicionarTarefa("Limpar a mesa antes de trabalhar");
        
        // Assert

        gerenciador.QuantidadeDeTarefas
            .Should()
            .Be(1);

    }
}

public class GerenciadorDeTarefas
{
    private readonly List<string> _tarefas = Enumerable.Empty<string>().ToList();

    public int QuantidadeDeTarefas => _tarefas.Count;

    public void AdicionarTarefa(string descricaoTarefa)
    {
        _tarefas.Add(descricaoTarefa);
    }
}