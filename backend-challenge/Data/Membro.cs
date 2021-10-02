using System.Collections.Generic;

namespace backend_challenge.Data
{
    public class Membro
    {
        public int id_empregado { get; set; }
        public int id_projeto { get; set; }
        
        public List<Projeto> Projetos { get; set;}
        public List<Empregado> Empregados { get; set; }
        
    }
}