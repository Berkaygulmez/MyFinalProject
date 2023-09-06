using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ğrğn olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CheckIfCategoryLimitExceded="Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
