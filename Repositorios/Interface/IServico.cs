namespace atividade_api_web.Repositorios.Interface
{
    public interface IServico<T>
    {
        List<T> listarTodos();
        void mostrarPorId(int id);
        void alterarPorId(int id);
        void deletarPorId(int id);
    }
}
