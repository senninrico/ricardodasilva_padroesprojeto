using System;
using DesignPatterns.Composite;
using DesignPatterns.Builder;
using DesignPatterns.Facades;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Flyweight;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.ChainResponsability;
using DesignPatterns.Strategy;
using DesignPatterns.Decorator;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Singleton;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            Console.WriteLine("Singleton");
            Console.WriteLine("");
            DBConnectClassic serviceInstance1 = DBConnectClassic.GetInstance();
            Console.WriteLine(serviceInstance1.GetCreationCount());

            DBConnectClassic serviceInstance2 = DBConnectClassic.GetInstance();
            Console.WriteLine(serviceInstance2.GetCreationCount());

            DBConnectClassic1 serviceInstance3 = DBConnectClassic1.Instance;
            Console.WriteLine(serviceInstance3.GetCreationCount());

            DBConnectClassic1 serviceInstance4 = DBConnectClassic1.Instance;
            Console.WriteLine(serviceInstance4.GetCreationCount());

            DBConnectClassic2 serviceInstance5 = DBConnectClassic2.Instance2;
            Console.WriteLine(serviceInstance5.GetCreationCount());

            DBConnectClassic2 serviceInstance6 = DBConnectClassic2.Instance2;
            Console.WriteLine(serviceInstance6.GetCreationCount());

            Console.WriteLine(serviceInstance1 == serviceInstance2);
            Console.WriteLine(serviceInstance3 == serviceInstance4);
            Console.WriteLine(serviceInstance5 == serviceInstance6);

            Console.WriteLine("");
            #endregion

            #region Factory
            Console.WriteLine("Factory");
            Console.WriteLine("");
            var a = AnimalFactory.Create(Animal.Dog);
            Console.WriteLine("Classe:" + a.GetType().Name);
            Console.WriteLine("");
            #endregion

            #region AbstractFactory
            Console.WriteLine("DesignPatterns");
            Console.WriteLine("");
            Console.WriteLine("AbstractFactory");

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.Animais();
            Console.WriteLine("");
            ContinentFactory america = new AmericaFactory(); //BRAZIL
            world = new AnimalWorld(america);
            world.Animais();
            Console.WriteLine("");
            #endregion

            #region Builder 
            Console.WriteLine("Builder");
            Console.WriteLine("");
            BuildingsBuilder builders;
            Build builder = new Build();

            builders = new ComercialBuilder();
            builder.Construct(builders);
            builders.Building.Show();
            Console.WriteLine("");

            builders = new SchoolBuilder();
            builder.Construct(builders);
            builders.Building.Show();
            Console.WriteLine("");
            #endregion

            #region Prototype
            Console.WriteLine("Prototype");
            Console.WriteLine("");
            Document d1 = new Document("test.doc");
            Document c1 = (Document)d1.Clone();
            Console.WriteLine($"d1 - original { d1.ShowName()}");
            Console.WriteLine($"c1 - clone { c1.ShowName()}");
            Console.WriteLine("");
            #endregion

            #region Adapter
            Console.WriteLine("Adapter");
            Console.WriteLine("");
            Sockets s1pin = new Sockets("1Pin");
            s1pin.Display();
            Console.WriteLine("");
            SocketType s2pin = new SocketType("2Pin");
            s2pin.Display();
            Console.WriteLine("");
            SocketType s3pin = new SocketType("3Pin");
            s3pin.Display();
            Console.WriteLine("");
            SocketType s3pinY = new SocketType("3PinY");
            s3pinY.Display();
            Console.WriteLine("");
            #endregion

            #region Bridge
            Console.WriteLine("Bridge");
            Console.WriteLine("");
            string url = "www.facebook.com";
            Sites site = new Sites("Firefox", url);
            site.Navegate();
            Console.WriteLine("");
            site = new Sites("Edge", url);
            site.Navegate();
            Console.WriteLine("");
            site = new Sites("Chrome", url);
            site.Navegate();
            Console.WriteLine("");
            #endregion

            #region Composite
            Console.WriteLine("Composite");
            Console.WriteLine("");

            Woman mother = new Woman();
            var father = new Man();
            var kid1 = new Man();
            var kid2 = new Woman();

            mother.AddFiliation(kid1);
            mother.AddFiliation(kid2);
            mother.Display();
            Console.WriteLine("");
            father.Display();
            Console.WriteLine("");

            #endregion

            #region  Decorator
            Console.WriteLine("Decorator");
            Console.WriteLine("");
            Burguer burger = new Burguer("BBQ simples");
            Bread bread = new Bread("Frances", 1, 1);
            Cheese cheese = new Cheese("Prato", 0.400, 2);
            Salada salada = new Salada("Alface", 1, 2);
            Steak hamburguer = new Steak("160g", 1, 2);
            Sauce sauce = new Sauce("BBQ", 1, 2);
            burger.SetIngredients(bread);
            burger.SetIngredients(cheese);
            burger.SetIngredients(salada);
            burger.SetIngredients(hamburguer);
            burger.SetIngredients(sauce);
            burger.MakeFood();
            Console.WriteLine("");

            Pizza pizza = new Pizza("Calabreza");
            Batter batter = new Batter("Media", 1, 2);
            cheese = new Cheese("Mussarela", 0.500, 2);
            sauce = new Sauce("Tomatoe", 0.500, 2);
            Specialities specialities = new Specialities("Calabreza", 1, 3);
            pizza.SetIngredients(batter);
            pizza.SetIngredients(cheese);
            pizza.SetIngredients(sauce);
            pizza.SetIngredients(specialities);
            pizza.MakeFood();
            Console.WriteLine("");

            Massa massa = new Massa("Bolonhesa");
            Pasta pasta = new Pasta("Spaguetti", 1, 3);
            cheese = new Cheese("Parmesão", 0.500, 2);
            sauce = new Sauce("Tomatoe", 0.500, 2);
            specialities = new Specialities("Carne Moida", 1, 3);
            massa.SetIngredients(pasta);
            massa.SetIngredients(cheese);
            massa.SetIngredients(sauce);
            massa.SetIngredients(specialities);
            massa.MakeFood();
            Console.WriteLine("");
            #endregion

            #region Facade
            Console.WriteLine("Facade");
            Console.WriteLine("");
            Facade facade = new Facade();
            facade.Buy();
            Console.WriteLine("");
            #endregion

            #region FlyWeight
            Console.WriteLine("FlyWeight");
            Console.WriteLine("");
            Mover move = new Mover();
            move.MoveTo("A.pdf", @"\\Vp1\c\Docs\");
            Console.WriteLine("");
            #endregion

            #region Proxy
            Console.WriteLine("Proxy");
            Console.WriteLine("");
            FinancialRFBR financialRFBR = new FinancialRFBR();
            financialRFBR.PayLegal(19333.88, 15, "10000-1101010-1010201010");
            Console.WriteLine("");
            financialRFBR.PayPhysical(150.55, 10, "10000-1101010");
            Console.WriteLine("");
            #endregion        

            #region ChainResponsability
            Console.WriteLine("ChainResponsability");
            Console.WriteLine("");
            GameTable gt = new GameTable();
            Players p1 = new Players("Andre");
            Players p2 = new Players("Bruna");
            Players p3 = new Players("Cesar");
            Players p4 = new Players("Danilo");
            Players p5 = new Players("Ester");
            Players p6 = new Players("Fabiana");
            gt.AddPlayer(p1);
            gt.AddPlayer(p5);
            gt.AddPlayer(p3);
            gt.AddPlayer(p6);
            gt.AddPlayer(p4);
            gt.AddPlayer(p2);
            int NumberOfPlays = 5;
            gt.PlayGame(NumberOfPlays);
            Console.WriteLine("");
            #endregion

            #region Strategy
            Console.WriteLine("Strategy");
            Console.WriteLine("");
            OrdenedArray vector = new OrdenedArray();

            vector.Add("1");
            vector.Add("3");
            vector.Add("4");
            vector.Add("7");
            vector.Add("9");

            vector.SetOrderStrategy(new NormalOrder());
            vector.Order();
            Console.WriteLine("");
            vector.SetOrderStrategy(new ReverseOrder());
            vector.Order();
            Console.WriteLine("");
            #endregion

            Console.WriteLine("Oh Glória!!");
            Console.ReadLine();
        }
    }


}
