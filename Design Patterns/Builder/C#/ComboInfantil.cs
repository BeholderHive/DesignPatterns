using System;

namespace C_
{
    public class ComboInfantil: Pedido
    {
        Combo combo = new Combo();  
        public void SetTamanho() 
        {  
            combo.Tamanho = "COMBO INFANTIL";  
        }  
        public void SetHamburguer() 
        {  
            combo.Hamburguer = "Jr. Cheeseburger Deluxe";  
        }  
        public void SetBatata() 
        {  
            combo.Batata = "Batata Pequena";  
        }  
        public void SetRefrigerante() 
        {  
            combo.Refrigerante = "150 ml";  
        }  
        public void SetPreco() 
        {  
            combo.Preco = "R$ 25,00";  
        }  
        public Combo RetornaCombo() 
        {  
            return combo;  
        }  
    }
}
