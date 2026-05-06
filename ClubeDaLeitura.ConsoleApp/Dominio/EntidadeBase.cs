using System.Security.Cryptography;

namespace ClubeDaLeitura.ConsoleApp.Dominio;

// classe abstrata = não pode ser instanciada
// só vai **definir** comportamentos e propriedades dentro do sistema
public abstract class EntidadeBase
{
    public string Id { get; set; } = string.Empty;

    public EntidadeBase()
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);
    }

    // definição abstrata
    public abstract string[] Validar(); //todas as filhas precisam validar, mas, cada um faz isso de maneira diferente
    public abstract void AtualizarRegistro(EntidadeBase entidadeAtualizada); //todas as filhas precisam validar, mas, cada um faz isso de maneira diferente
}