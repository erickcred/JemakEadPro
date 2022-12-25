using System;

namespace JemakEadPro.Models
{
    public class Andamento
    {
        public Andamento()
        {
            DataInicio = DateTime.Now;
        }

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Curso Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public bool VideoIniciado(bool iniciado, bool pause, double progresso)
        {
            bool status = false;

            foreach (var video in Curso.Videos)
            {
                if (iniciado != true)
                    status = true;

                // video.Iniciado = status;
                VideoProgresso(video.Id, pause, progresso);
            }

            return status;
        }

        public string VideoProgresso(int id, bool puse, double progresso)
        {
            string final = "";    
            foreach (var video in Curso.Videos)
            {
                if (video.Id == id)
                {
                    video.Progresso = Convert.ToString(progresso);
                }

                if (progresso == Convert.ToDouble(video.Duracao))
                {
                    video.Finalizado = true;
                }

                final = video.Progresso;
            }

            return final;
        }

        public bool Finalizado(bool finalizado)
        {
            if (finalizado)
                return true;
            return false;
        }
    }
}