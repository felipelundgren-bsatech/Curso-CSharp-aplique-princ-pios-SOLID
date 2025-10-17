
namespace Alura.Adopet.Console.Comandos;

internal interface IComandoFactory
{
    IComando? CriarComando (string[] argumentos);
}
