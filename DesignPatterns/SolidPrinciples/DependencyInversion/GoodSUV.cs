using System;
namespace DesignPatterns.SolidPrinciples.DependencyInversion
{
    public class GoodSUV : IGoodAutomobile
    {
        public string Ignition()
        {
            return "SUV arranca";
        }

        public string Stop()
        {
            return "SUV parado";
        }
    }
}
