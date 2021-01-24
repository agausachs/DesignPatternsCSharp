﻿using System;
namespace DesignPatterns.Patterns.FactoryMethodPattern
{
    public class ConcreteCreator2: Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
