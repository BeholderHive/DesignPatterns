using System;

namespace C_
{
    public interface Pedido 
    {  
        void SetTamanho();  
        void SetHamburguer();  
        void SetBatata();  
        void SetRefrigerante();  
        void SetPreco();  
        Combo RetornaCombo();  
    } 
}
