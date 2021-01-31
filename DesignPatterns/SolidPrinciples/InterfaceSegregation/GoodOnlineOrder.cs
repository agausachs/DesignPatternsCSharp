using System;
namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    public class GoodOnlineOrder : IGoodOrder, IGoodOnlineOrder
    {
        public string AddToCart()
        {
            // Añadir a Carrito
            return "Good Online Order Añadir a Carrito";
        }

        public string CCProcess()
        {
            // Procesar con Tarjeta de Crédito
            return "Good Online Order Procesar con Tarjeta de crédito";
        }
    }
}
