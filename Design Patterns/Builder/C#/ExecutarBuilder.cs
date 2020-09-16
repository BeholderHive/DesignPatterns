using System;

namespace C_
{
    class ExecutarBuilder
    {
        static void Main(string[] args)
        {
            var comboAdulto = new ComboBuilder(new ComboAdulto());  
            comboAdulto.CriarCombo();  
            Console.WriteLine("\n"+comboAdulto.RetornaCombo().Tamanho+": ");
            Console.WriteLine(comboAdulto.RetornaCombo().Hamburguer);
            Console.WriteLine(comboAdulto.RetornaCombo().Batata);
            Console.WriteLine(comboAdulto.RetornaCombo().Refrigerante);
            Console.WriteLine(comboAdulto.RetornaCombo().Preco);
            var comboInfantil = new ComboBuilder(new ComboInfantil());  
            comboInfantil.CriarCombo();
            Console.WriteLine("\n"+comboInfantil.RetornaCombo().Tamanho+": ");
            Console.WriteLine(comboInfantil.RetornaCombo().Hamburguer);
            Console.WriteLine(comboInfantil.RetornaCombo().Batata);
            Console.WriteLine(comboInfantil.RetornaCombo().Refrigerante);
            Console.WriteLine(comboInfantil.RetornaCombo().Preco);  
        }
    }
}
