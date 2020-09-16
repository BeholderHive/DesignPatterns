using System;

namespace C_
{
    public class ComboBuilder
    {
        private Pedido pedido;  
        public ComboBuilder(Pedido itemPedido) {  
            pedido = itemPedido;  
        }  
        public void CriarCombo() {  
            pedido.SetTamanho();  
            pedido.SetHamburguer();  
            pedido.SetBatata();  
            pedido.SetRefrigerante();  
            pedido.SetPreco();  
        }  
        public Combo RetornaCombo() {  
            return pedido.RetornaCombo();  
        }  
    }
}
