using ModelFirstExample.Model;

using System.Reflection;
namespace ModelFirstExample
{
    // id int . title string . calories double. proteins double. fats double. carbohydrates double. weght double
    //public int Id { get; set; }
    //public string Title { get; set; }
    //public int Calories { get; set; }
    //public int Proteins { get; set; }
    //public int Fats { get; set; }
    //public int Carbohydrates { get; set; }
    //public int Weight { get; set; }
    // для запуска миграции ввести в Консоли диспечеров пакетов  Add-migration Menu 19-10-2023
    // для обновления на сервере ввести в Консоли диспечеров пакетов Update-Database
    internal class Program
    {
        public static void TestSelectALL()
        {
            Console.WriteLine("Hello, Doy!");
            MenuItemService menuItemsService = new MenuItemService();
            menuItemsService.SelectAll();
        }
        // метод тест добавить записи
        public void TestAdd()
        {
            Console.WriteLine("Hello, Doy!");
            MenuItemService menuItemsService = new MenuItemService();
            var grush = menuItemsService.Insert(new MenuItem
            {
                Title = "груша",
                Calories = 157,
                Proteins = 50,
                Carbohydrates = 879,
                Weight = 8,
                Fats = 11
            });
            Console.WriteLine(grush);
            var yablok = menuItemsService.Insert(new MenuItem
            {
                Title = "яблоко",
                Calories = 154,
                Proteins = 40,
                Carbohydrates = 579,
                Weight = 9,
                Fats = 3
            });
            Console.WriteLine(yablok);
            var vatermelon = menuItemsService.Insert(new MenuItem
            {
                Title = "арбуз",
                Calories = 149,
                Proteins = 60,
                Carbohydrates = 673,
                Weight = 12,
                Fats = 25
            });
            Console.WriteLine(vatermelon);
        }
        public static void Main(string[] args)
        {
            MenuItemService menuItemsService = new MenuItemService();
           TestSelectALL();
        }
    }
}