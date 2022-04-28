using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriagemHospitalar
{
    internal class Pacient
    {

        public Pacient()
        {
            this.namePatient = "_";
            this.description = "_";
            this.priority = 0;
            this.dayOfBirth = 0;
            this.monthOfBirth = 0;
            this.yearOfBirth = 0;     
        }



        // Nome do paciente

        private String namePatient;

        public String NamePatient
        {
            get { return this.namePatient; }
            set
            {
                String texto = value.ToUpper();
                this.namePatient = texto;
            }
        }

        // Data de Nascimento

        public int dayOfBirth { get; set; }
        public int monthOfBirth { get; set; }
        public int yearOfBirth { get; set; }

        // Descrição do paciente

        private String description;

        public String Description
        {
            get { return description; }
            set
            { 
                String texto = value.ToLower();
                this.description = texto;
            }
        }

        // Prioridade     

        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Métodos

        // Idade do Paciente

        private int Age() 
        {
            // Data atual
            int age;

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            // Calcular idade

            age = year - this.yearOfBirth;

            if (month < this.monthOfBirth) 
            {
                age--;
            }
            else if (month == this.monthOfBirth)
            {
                if (day < this.dayOfBirth)
                {
                    age--;
                }  
            }
            return age;
        }

        // Exibir Resultados 
        public void ShowStats()
        {
            Console.WriteLine("O nome do paciente é: {0}\n A descrição dele: {1}", this.NamePatient, this.Description);
            if (this.priority == 1) { Console.WriteLine("Seu nível de prioridade é baixo");}
            else if (this.priority == 2) { Console.WriteLine("Seu nível de prioridade é médio"); }
            else if (this.priority == 3) { Console.WriteLine("Seu nível de prioridade é alto"); }
        }


    }
}
