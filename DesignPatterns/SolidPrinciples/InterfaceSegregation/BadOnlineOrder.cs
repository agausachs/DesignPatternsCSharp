using System;
namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    public class BadOnlineOrder : IBadOrder
    {
        public string AddToCart()
        {
            // Añadir a carrito
            return "Bad Online Order Añadir a Carrito";
        }

        public string CCProcess()
        {
            // procesar con tarjeta de crédito
            return "Bad Online Order Procesar Tarjeta de crédito"
        }
    }
}
