namespace _8_Delegate
{
    public delegate int OperationDelegate(int x, int y);

    class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) { return x - y; }
    }

    class Program
    {
        public static void ShowMessagePanel(string msg)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("---Panel---"+ msg);
            Console.ForegroundColor= defaultColor;
        }

        public static void ShowMessageDisplay(string msg)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Display---" + msg);
            Console.ForegroundColor = defaultColor;
        }


        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Hello, World!");
            //OperationDelegate operation = new OperationDelegate(SimpleMath.Add);

            //int result = operation(1, 2);//.Invoke(1, 2);
            //Console.WriteLine("Result = {0}", result);

            Car bmw = new Car("i3",100, 10);
            //bmw.errorMessageEvent += ShowMessagePanel;
            //анонімний метод
            //bmw.errorMessageEvent += delegate(string msg)
            //{
            //    ConsoleColor defaultColor = Console.ForegroundColor;
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("---Не відомий пристрій---" + msg);
            //    Console.ForegroundColor = defaultColor;
            //};
            //Лямда вираз
            bmw.errorMessageEvent += msg => 
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("---Якась китайська заглушка---" + msg);
                Console.ForegroundColor = defaultColor;
            };
            bmw.errorMessageEvent += ShowMessageDisplay;
            //var panelEvent = new Car.CarEngineHandler(ShowMessagePanel);
            //var didplayEvent = new Car.CarEngineHandler(ShowMessageDisplay);

            //bmw.RegisterWithCarEngine(panelEvent);
            //bmw.RegisterWithCarEngine(didplayEvent);

            for (int i = 0; i < 6; i++)
            {
                bmw.Accelerate(20);
            }
            bmw.errorMessageEvent -= ShowMessageDisplay;
            //bmw.UnRegisterWithCarEngine(didplayEvent);
            for (int i = 0; i < 6; i++)
            {
                bmw.Accelerate(20);
            }

        }
    }
}
