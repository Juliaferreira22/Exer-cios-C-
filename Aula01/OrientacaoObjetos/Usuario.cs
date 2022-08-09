using System;

namespace OrientacaoObjetos
{
    class Usuario
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public int Idade { get; set; }

        public string Email { get; set; }

        public override string ToString() // ToString deve ser feito na classe pai
        {
            return $"Login: { Login }  |  Senha: { Senha } \n | Idade: {Idade} \n Email: {Email} ";   
            

        }

        
        
              
        
    }
}