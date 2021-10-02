using System;
using System.Collections.Generic;

namespace backend_challenge.Data
{
    public class Projeto
    {
        public int id_projeto { get; set; }
        public string nome { get; set; }
        public string data_criacao { get; set; }
        public string data_termino { get; set; }

        public int gerenteId { get; set; }
        public List<Membro> Membros { get; set;}

        
    }
}