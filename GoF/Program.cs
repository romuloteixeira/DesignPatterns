using System;

namespace GoF
{
    class Program
    {
        static void Main()
        {
            MainMenuWriter();
            OptionsRun();

            Console.ReadKey();
            Console.Clear();

            Main();
        }

        private static void MainMenuWriter()
        {
            Console.WriteLine("Pick a option:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");
        }

        private static void OptionsRun()
        {
            var option = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            switch (option.KeyChar)
            {
                case '1':
                    AbstractFactory();
                    break;
                case '2':
                    //ExecucaoFactoryMethod.Executar();
                    break;
                case '3':
                    //ExecucaoSingleton.Executar();
                    break;
                case '4':
                    //ExecucaoAdapter.Executar();
                    break;
                case '5':
                    //ExecucaoFacade.Executar();
                    break;
                case '6':
                    //ExecucaoComposite.Executar();
                    break;
                case '7':
                    //ExecucaoCommand.Executar();
                    break;
                case '8':
                    //ExecucaoStrategy.Executar();
                    break;
                case '9':
                    //ExecucaoObserver.Executar();
                    break;
                default:
                    Console.WriteLine("Wrong option, please try again.");
                    break;
            }
        }

        private static void AbstractFactory()
        {
            Console.WriteLine("A - Abstract Factory");
            Console.WriteLine("B - Abstract Factory");

            var subOption = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            switch (subOption.KeyChar)
            {
                case 'a':
                    //ExecucaoAbstractFactory.Executar();
                    break;
                case 'b':
                    //ExecucaoAbstractAFactory.Executar();
                    break;
                default:
                    Console.WriteLine("Wrong option, please try again.");
                    break;
            }
        }
    }
}
