using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public Pessoa(string nomes){
            Nome = nomes;
            
        }
        private string _nome;
        public string Nome 
        { 
            get =>_nomes.ToUpper();
            

            set{
                if(value== ""){
                    throw new ArgumentException("O nome não pode ficar vazio");
                }
                _nome = value;
            } 
        }

        public void Deconstruct(out string nomes){
            nomes = Nome;
            
        }
        
    }
}
