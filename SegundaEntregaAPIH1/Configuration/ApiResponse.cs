namespace Aluno.Configuration
{
    public class ApiResponse<T>
    {
        public bool Sucesso { get; set; }

        public T Data { get; set; }

        public string Messangem { get; set; }

    }
}
