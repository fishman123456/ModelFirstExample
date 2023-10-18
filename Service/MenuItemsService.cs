using ModelFirstExample.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstExample.Model
{
    public class MenuItemsService
    {
        // Класс, реализующий операции с таблицей MenuItem
        internal class MenuItemService
        {
            // 1. получить все записи
            public List<MenuItem> SelectAll()
            {
                ApplicationDbContext dbContext = new ApplicationDbContext();
                return dbContext.menuitems.ToList();
                throw new NotImplementedException();
            }

            // 2. добавить новую запись
            public MenuItem Insert(MenuItem menuItem)
            {
                ApplicationDbContext dbContext = new ApplicationDbContext();
                dbContext.Add(menuItem);
                dbContext.SaveChanges();
                return menuItem;
            }

            // 3. удалить запись по id
            public bool DeleteById(int id)
            {
                throw new NotImplementedException();
            }

            // 4. получить запись по id
            public MenuItem? SelectById(int id)
            {
                ApplicationDbContext dbContext = new ApplicationDbContext();
                return dbContext.menuitems.FirstOrDefault(menuitem => menuitem.Id == id);
            }

            // 5. получить все записи, title которых включает в себя переданную строчку (без учета регистра)
            public List<MenuItem> SelectByTitlePattern(string titlePattern)
            {
                throw new NotImplementedException();
            }

            // 6. посчитать среднюю калойриность всего меню
            public double SelectAverageEnergy()
            {
                throw new NotImplementedException();
            }

            // 7. получить все записи в отсортированном порядке по возрастанию веса
            public List<MenuItem> SelectAllOrderByWeight()
            {
                throw new NotImplementedException();
            }
        }
    }
}
