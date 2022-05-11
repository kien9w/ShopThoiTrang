using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass.Models;

namespace MyClass.DAO
{
    public class CategoryDAO
    {
        private ThoiTrangDBContext db = new ThoiTrangDBContext();

        public List<Category> getlist(string status = "ALL")
        {
            List<Category> list = null;

            switch (status)
            {
                case  "Index":
                    {
                        list = db.Categorys.Where(m => m.status != 0).ToList();
                        break;
                    }

                case "Trash":
                    {
                        list = db.Categorys.Where(m => m.status == 0).ToList();
                        break;
                    }
                default:
                    return db.Categorys.ToList();
                    break;

            }

            return list;
        }
        public Category getRow(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return db.Categorys.Find(id);
            }
        }

        public int Insert(Category row)
        {
            db.Categorys.Add(row);
            return db.SaveChanges();
        }

        public int Update (Category row)
        {
            db.Entry(row).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete (int id)
        {
            Category category = db.Categorys.Find(id);
            db.Categorys.Remove(category);
            db.SaveChanges();
            return db.SaveChanges();
        }

        public Category Find (int? id)
        {
            Category category = db.Categorys.Find(id);   
            return category;
        }
    }
}
