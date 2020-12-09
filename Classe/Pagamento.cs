using System;

namespace Abstração.Classe
{
    public abstract class Pagamento
    {
       
        private DateTime data;
       
           
        protected float valor;
        
        
        public string Cancelar(){
            return ""; 
        
        
        }


        //OBRIGATORIO
        public abstract string Desconto(int valor);


        public abstract string Juros (int parcelas);
    }
}