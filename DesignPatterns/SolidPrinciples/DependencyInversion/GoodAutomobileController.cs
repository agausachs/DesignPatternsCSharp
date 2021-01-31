using System;
namespace DesignPatterns.SolidPrinciples.DependencyInversion
{
    public class GoodAutomobileController
    {
        IGoodAutomobile _mAutomobile;

        public GoodAutomobileController(IGoodAutomobile goodAutomobile)
        {
            _mAutomobile = goodAutomobile;
        }

        public void Ignition()
        {
            Console.WriteLine(_mAutomobile.Ignition());
        }

        public void Stop()
        {
            Console.WriteLine(_mAutomobile.Stop());
        }
    }
}
