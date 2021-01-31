using System;
namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    public class BadOfflineOrder : IBadOrder
    {
        public string AddToCart()
        {
            // añadir a carrito
            return "Bad Offline Order Añadir a Carrito";
        }

        public string CCProcess()
        {
            // No necesario para efectivo / offline
            return "Bad Offline Order, Procesar Tarjeta Crédito. No debería poder";
        }
    }
}
