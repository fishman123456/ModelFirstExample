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
                throw new NotImplementedException();
            }
        }

        // 6. посчитать среднюю калойриность всего меню
        public double SelectAverageEnergy()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                throw new NotImplementedException();
            }
        }

        // 7. получить все записи в отсортированном порядке по возрастанию веса
        public List<MenuItem> SelectAllOrderByWeight()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                throw new NotImplementedException();
            }
        }
    }
}

