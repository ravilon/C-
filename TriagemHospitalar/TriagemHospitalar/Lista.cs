using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriagemHospitalar
{
    internal class Lista
    {
        public Lista()
        {
            this.IniciarLista();
        }

        // Cria uma lista de pacientes

        private List<Pacient> pacients; 

        public List<Pacient> Pacientes       
        {
            get { return pacients; }
        }

        private void IniciarLista() 
        { 
            this.pacients = new List<Pacient>(); 
        } 

        // Método
        // Listar pacientes

        public void ListPacients()
        {
            for (int i = 0; i < this.pacients.Count; i++)
            {
                
                Pacient p = this.Pacientes[i];
                p.ShowStats();
            }
        }
    }
}
