using restaurant_domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.Menu
{
    public class RemoveItemFromMenuService
    {

        public RemoveItemFromMenuService()
        {
            var prato1 = new Plate("lasanha");
            var prato2 = prato1;


            prato2.TiraIngrediente();
        }

        //Recebe o ID do prato e remove ele do menu
    }
}
