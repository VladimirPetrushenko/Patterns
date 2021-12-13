﻿using ApplicationWithAllPatterns.BehaviorPatterns;
using ApplicationWithAllPatterns.CreationalDesignPatterns;

namespace ApplicationWithAllPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyPattern.Make();
            //TemplateMethodPattern.Make();
            //MediatorPattern.MakeWithTemplateMethod();
            //IteratorPattern.MakeWithTemplateMethod();
            //ObserverPattern.MakeWithTemplateMethod();
            //VisiterPatterns.MakeWithTemplateMethod();
            //StatePattern.MakeWithTemplateMethod();
            //ChainOfResponsibilityPattern.MakeWithTemplateMethod();

            SingletonPattern.MakeWithTemplateMethod();
        }

    }
}
