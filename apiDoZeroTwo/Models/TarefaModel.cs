using apiDoZeroTwo.Enums;

namespace apidozerotwo.models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTarefa Status { get; set; }

    }
}
