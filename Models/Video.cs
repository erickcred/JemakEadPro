namespace JemakEadPro.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ProjetoId { get; set; }
        public string VideoId { get; set; }
        public string Url { get; set; }
        public int Ordem { get; set; }
        public string Duracao { get; set; }
        public string Progresso { get; set; }
        public bool Finalizado { get; set; }

        public Curso Curso { get; set; }
    }
}