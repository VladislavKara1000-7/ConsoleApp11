

namespace ConsoleApp11
{
    internal class Player
    {
      public int hp;
      public int intelect;
      public int defencive;
      public int damage;
      public int speed;
      public int mana;
     
      void P_Input()
      {
            var name = "";
            do
            {
                Console.Write("Name:");
                name = Console.ReadLine();
            } while (name == null);
            var type = "";
            do
            {
                Console.Write("Magician\nKnight\nHunter\nClass:");
                type = Console.ReadLine();
                switch (type)
                {
                    case "Magician":
                        hp = 60;
                        intelect = 50;
                        defencive = 30;
                        damage = 70;
                        speed = 10;
                        mana = 80;
                        break;
                    case "Knight":
                        hp = 80;
                        intelect = 25;
                        defencive = 100;
                        damage = 50;
                        speed = 20;
                        mana = 10;
                        break;
                    case "Hunter":
                        hp = 25;
                        intelect = 100;
                        defencive = 10;
                        damage = 30;
                        speed = 80;
                        mana = 25;
                        break;
                    default:
                        Console.WriteLine("Wrong type");
                        type = null;
                        break;
                }
            } while (type == null);
        
      }
        void Inventory()
        {
            int inv_size = Random.Shared.Next(10, 21);
            string[] inv = new string[inv_size];
            string[] chess = new string[10];
            string[] items = new string[4];
            items[0] = "Candy";
            items[1] = "Knife";
            items[2] = "Costume";
            for(int i = Random.Shared.Next(0, 9); i < 10; i++)
            {
                chess[9 - i] = items[Random.Shared.Next(0, 3)];
            }
            bool error = false;
            do
            {
                Console.WriteLine("Inventory:");
                for (int i = 0; i < inv_size; i++)
                {
                    Console.WriteLine($"{i + 1}.{inv[i]}");
                }
                Console.WriteLine("Chess:");
                for (int i = 0; i < 10; i++)
                {
                     Console.WriteLine(($"{i + 1}.{chess[i]}"));
                }
                Console.WriteLine("Put items from chess to inventory?\nY/N");
                if (char.TryParse(Console.ReadLine(), out char choise))
                {
                    switch (choise)
                    {
                        case 'Y':
                            error = false;
                            for (int i = 0; i < 10; i++)
                            {
                                inv[i] = chess[i];
                            }
                            Array.Resize(ref chess, 0);
                            Array.Resize(ref chess, 10);
                            Console.WriteLine("Inventory:");
                            for (int i = 0; i < inv_size; i++)
                            {
                                Console.WriteLine($"{i + 1}.{inv[i]}");
                            }
                            Console.WriteLine("Chess:");
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine(($"{i + 1}.{chess[i]}"));
                            }
                            break;
                        case 'N':
                            error = false;
                            break;
                        default:
                            error = true;
                            break;
                    }
                }
            } while (error);
        }
        public Player()
        {
            P_Input();
            Inventory();
        }
    }
}
