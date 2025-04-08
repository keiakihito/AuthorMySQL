using System;
using System.Linq;
using AuthorMySQL.Data; // ← 名前空間を変更
using Microsoft.EntityFrameworkCore;

namespace AuthorMySQL
{
    public static class TestQueries
    {
        public static void Run(PubsDbContext db)
        {
            Console.WriteLine("\n~~ Test Queries on console ~~\n");
            Console.WriteLine("== 著者一覧（TKのみ） ==");

            var caAuthors = db.Authors.Where(a => a.State == "TK").ToList();
            foreach (var a in caAuthors)
            {
                Console.WriteLine($"{a.AuthorId}: {a.AuthorFirstName} {a.AuthorLastName}");
            }

            var author = db.Authors.FirstOrDefault(a => a.AuthorId == "100-00-0002");
            if (author != null)
            {
                Console.WriteLine("\n== 指定IDの著者 ==\n");
                Console.WriteLine($"{author.AuthorId}: {author.AuthorFirstName} {author.AuthorLastName}");
                Console.WriteLine("\n");
            }

            // ✅ ここに Create / Update / Delete をコメントインしながら試せます
            author = db.Authors.FirstOrDefault(a => a.AuthorId == "999-99-9999");
            if (author != null)
            {
                db.Authors.Remove(author);
                db.SaveChanges();
                Console.WriteLine("🗑️ 著者削除完了！");
            }
        } // end of Run
    } // end of TestQueries
}　// end of AuthorMySQL


/* Create
 var newAuthor = new Author
   {
       AuthorId = "999-99-9999",
       AuthorFirstName = "Testy",
       AuthorLastName = "McTestFace",
       Phone = "000-000-0000",
       Address = "Test Street",
       City = "Testville",
       State = "CA",
       Zip = "99999",
       Contract = true
   };

   db.Authors.Add(newAuthor);
   db.SaveChanges();

   Console.WriteLine("✅ 著者追加完了！");
   Console.WriteLine("\n");
 */

/* Update
   author = db.Authors.FirstOrDefault(a => a.AuthorId == "999-99-9999");
   if (author != null)
   {
       author.City = "UpdatedCity";
       db.SaveChanges();
       Console.WriteLine("✅ 著者更新完了！");
       Console.WriteLine("\n");
   }
 */

/*
Delete

   author = db.Authors.FirstOrDefault(a => a.AuthorId == "999-99-9999");
   if (author != null)
   {
       db.Authors.Remove(author);
       db.SaveChanges();
       Console.WriteLine("🗑️ 著者削除完了！");
       Console.WriteLine("\n");
   }

 */