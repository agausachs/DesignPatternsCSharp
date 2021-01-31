using System;
namespace DesignPatterns.SolidPrinciples.DependencyInversion
{
    public class GoodJeep : IGoodAutomobile
    {
        public string Ignition()
        {
            return "Jeep arranca";
        }

        public string Stop()
        {
            return "Jeep parado";
        }
    }
}
