using System;
namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    public class GoodOfflineOrder : IGoodOrder
    {
        public string AddToCart()
        {
            // Añadir al carrito
            return "Good Offline Order Añadir a Carrito";
        }
    }
}
