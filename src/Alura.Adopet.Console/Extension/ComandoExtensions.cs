
using System.Reflection;
using Alura.Adopet.Console.Atributos;
using Alura.Adopet.Console.Comandos;
namespace Alura.Adopet.Console.Extension;

public static class ComandoExtensions
{
    public static Type? GetTipoComando(this Assembly assembly,string instrucao)
    {
        return assembly
            .GetTypes()
            .Where(t => !t.IsInterface && t.IsAssignableTo(typeof(IComando)))
            .FirstOrDefault(t => t.GetCustomAttributes<DocComandoAttribute>()
            .Any(d => d.Instrucao.Equals(instrucao)));
    }
}
