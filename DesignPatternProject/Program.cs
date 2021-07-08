using DesignPatterns.Dinosaur;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyExample();
            Console.WriteLine("\n*********************************************************************\n");
            FactoryMethodExamples();
        }

        public static void ProxyExample()
        {
            var secureNestProxy = new SecureNestProxy(new RealNest());

            secureNestProxy.Access("Stegosaurus");
            secureNestProxy.Access("Cioara");
        }                
        
        public static void FactoryMethodExamples()
        {
            IDinosaurNoiseProducer fm1 = new TRexNoiseProducer();
            fm1.MakeADinosaurNoise();

            IDinosaurNoiseProducer fm2 = new StegosaurusNoiseProducer();
            fm2.MakeADinosaurNoise();
        }            
    }
}
