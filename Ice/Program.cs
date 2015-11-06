using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooler CoolerLG = new Cooler(true, 10, FrostLevel.Normal); 
            while (true)
            {
                Console.Clear();
                Console.WriteLine(CoolerLG.Info() + "\n");
                Console.WriteLine("Нажмите клавишу для выполнения действия:");
                Console.WriteLine("1 - Положить пару пива");
                Console.WriteLine("2 - Достать пару пива");
                Console.WriteLine("3 - Установить норм заморозку");
                Console.WriteLine("4 - Установить режим Украинская зима");
                Console.WriteLine("5 - Установить режим Арктика");
                Console.WriteLine("6 - Включить холодильник");
                Console.WriteLine("7 - Выключить холодильник");
                Console.WriteLine("e - Выйти");

                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        CoolerLG.PutBeers(2);
                        break;
                    case '2':
                        CoolerLG.GetBeers(2);
                        break;
                    case '3':
                        CoolerLG.SetNormalFrost();
                        break;
                    case '4':
                        CoolerLG.SetUkrainianWinterFrost();
                        break;
                    case '5':
                        CoolerLG.SetArcticIceFrost();
                        break;
                    case '6':
                        CoolerLG.On();
                        break;
                    case '7':
                        CoolerLG.Off();
                        break;
                    case 'e':                                             
                        return;
                }
            }
        }
    }
}
