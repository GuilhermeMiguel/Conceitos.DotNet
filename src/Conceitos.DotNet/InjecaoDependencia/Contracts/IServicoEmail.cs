namespace Conceitos.DotNet.InjecaoDependencia.Services
{
    public interface IServicoEmail
    {
         void EnviaEmail(string email, string titulo, string mensagem);
    }
}