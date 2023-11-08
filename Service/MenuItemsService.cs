using ModelFirstExample.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstExample.Model
{
    // Класс, реализующий операции с таблицей MenuItem
    public class MenuItemService
    {
        // 1. получить все записи
        public List<MenuItem> SelectAll()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
               
                foreach (MenuItem item in dbContext.menuitems)
                {
                    Console.WriteLine(item);
                }
                return dbContext.menuitems.ToList();
            }
        }
        // 2. добавить новую запись
        public MenuItem Insert(MenuItem menuItem)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                dbContext.Add(menuItem);
                dbContext.SaveChanges();
                return menuItem;
            }
        }
        // 3. удалить запись по id
        public bool DeleteById(int id)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
               var menuItem = SelectById(id);
                if (menuItem != null)
                {
                    dbContext.menuitems.Remove(menuItem);
                    dbContext.SaveChanges();
                }
                return menuItem!=null;
            }
        }
        // 4. получить запись по id
        public MenuItem? SelectById(int id)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return dbContext.menuitems.FirstOrDefault(menuitem => menuitem.Id == id);
            }
        }
        // 5. получить все записи, title которых включает в себя переданную строчку (без учета регистра)
        public List<MenuItem> SelectByTitlePattern(string titlePattern)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                string pattern = titlePattern.ToLower();
               return dbContext.menuitems
                    .Where(m=>m.Title.ToLower().Contains(pattern))
                    .ToList();
            }
        }
        // 6. посчитать среднюю калойриность всего меню
        public double SelectAverageEnergy()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return dbContext.menuitems
                    .Where(u => ((short)u.Calories)>0)
                        .Average(p => p.Calories);
               
                   
            }
        }
        // 7. получить все записи в отсортированном порядке по возрастанию веса
        public List<MenuItem> SelectAllOrderByWeight()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Console.WriteLine("Сортировка по весу");
                foreach (MenuItem item in dbContext.menuitems.OrderBy(m => m.Weight).ToList())
                {
                    Console.WriteLine(item);
                }
                return dbContext.menuitems.OrderBy(m => m.Weight).ToList();          
            }
        }
    }
}

