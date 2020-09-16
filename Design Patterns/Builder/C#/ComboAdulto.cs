using System;

namespace C_
{
    public class ComboAdulto: Pedido
    {
        Combo combo = new Combo();  
        public void SetTamanho() 
        {  
            combo.Tamanho = "COMBO ADULTO";  
        }  
        public void SetHamburguer() 
        {  
            combo.Hamburguer = "Big Bacon Classic Triple";  
        }  
        public void SetBatata() 
        {  
            combo.Batata = "Batata Grande";  
        }  
        public void SetRefrigerante() 
        {  
            combo.Refrigerante = "600 ml";  
        }  
        public void SetPreco() 
        {  
            combo.Preco = "R$ 50,00";  
        }  
        public Combo RetornaCombo() 
        {  
            return combo;  
        }  
    }
}
