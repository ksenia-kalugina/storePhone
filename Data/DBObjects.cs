using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContext content)
        {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Phone.Any())
            {
                
                content.AddRange(
                    new Phone
                    {
                        name = "СМАРТФОН HUAWEI P30 PRO VOG-L29 DUAL SIM 8GB/256GB (СЕВЕРНОЕ СИЯНИЕ) ",
                        shortDescription = "Производитель: Huawei",
                        longDescription = "Тип смартфон, Операционная система Android, Сенсорный экран, Разрешение экрана 1080x2340, Размер экрана 6.47, Флэш-память 256 ГБ, Оперативная память 8 ГБ, Количество SIM-карт 2, Количество точек матрицы 40 Мп, Емкость аккумулятора 4 200 мА·ч, Фронтальная камера 32 Мп, NFC, Быстрая зарядка SuperCharge, Беспроводная зарядка, Количество ядер 8 (2+2+4), Тактовая частота процессора 2 600 МГц, Сканер отпечатка пальца, Оптический зум 5 Х",
                        img = "https://i-on.by/image/tovar/53/mobile/e3331a177d37142043bde0d0d3867886_WM.jpg",
                        price = 1910,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    
                    new Phone
                    {
                        name = "СМАРТФОН APPLE IPHONE XR (PRODUCT)RED™ 256GB DUAL SIM",
                        shortDescription = "Производитель: Apple",
                        longDescription = "Тип смартфон, Операционная система Apple iOS, Сенсорный экран, Разрешение экрана 828x1792, Размер экрана 6.1, Флэш-память 256 ГБ, Оперативная память 3 ГБ, Количество SIM-карт 2, Количество точек матрицы 12 Мп, Емкость аккумулятора 2 942 мА·ч, Фронтальная камера 7 Мп, NFC, Быстрая зарядка, Беспроводная зарядка, Количество ядер 6 (2+4)",
                        img = "https://i-on.by/image/tovar/50/mobile/8ed93a5d7edd5e6f62081dcdfb0c09a4_WM.jpg",
                        price = 2374,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН SAMSUNG GALAXY NOTE9 SM-N9600 DUAL SIM 512GB SDM 845 (ЧЕРНЫЙ)",
                        shortDescription = "Производитель: Samsung",
                        longDescription = "Тип смартфон, Операционная система Android, Сенсорный экран, Разрешение экрана 1440x2960, Размер экрана 6.4, Флэш-память 512 ГБ, Оперативная память 8 ГБ, Количество SIM-карт 2, Количество точек матрицы 12 Мп, Емкость аккумулятора 4 000 мА·ч, Фронтальная камера 8 Мп, NFC, Быстрая зарядка Adaptive Fast Charging, Беспроводная зарядка, Количество ядер 8 (4+4), Тактовая частота процессора 2 800 МГц, Сканер отпечатка пальца, Оптический зум 2 Х",
                        img = "https://i-on.by/image/tovar/50/mobile/f5e23259a25b69d128092000899d1d80_WM.jpg",
                        price = 2572,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН SAMSUNG GALAXY S10+ G975 12GB/1TB DUAL SIM EXYNOS 9820 (ЧЕРНАЯ КЕРАМИКА)",
                        shortDescription = "Производитель: Samsung",
                        longDescription = "Тип смартфон, Операционная система Android, Сенсорный экран, Разрешение экрана 1440x3040, Размер экрана 6.4, Флэш-память 1 ТБ, Оперативная память 12 ГБ, Количество SIM-карт 2, Количество точек матрицы 12 Мп, Емкость аккумулятора 4 100 мА·ч, Фронтальная камера 10 Мп, NFC, Быстрая зарядка, Беспроводная зарядка, Количество ядер 8 (2+2+4), Тактовая частота процессора 2 700 МГц, Сканер отпечатка пальца, Оптический зум 2 Х",
                        img = "https://i-on.by/image/tovar/52/mobile/497eed9c38754205a6dbb7d61bd07580_WM.jpg",
                        price = 3217,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН APPLE IPHONE XS MAX 512GB (СЕРЫЙ КОСМОС)",
                        shortDescription = "Производитель: Apple",
                        longDescription = "Тип смартфон, Операционная система Apple iOS, Сенсорный экран, Разрешение экрана 1242x2688, Размер экрана 6.5, Флэш-память 512 ГБ, Оперативная память 4 ГБ, Количество SIM-карт 1, Количество точек матрицы 12 Мп, Емкость аккумулятора 3 174 мА·ч, Фронтальная камера 7 Мп, NFC, Быстрая зарядка, Беспроводная зарядка, Количество ядер 6 (2+4), Оптический зум 2 Х",
                        img = "https://i-on.by/image/tovar/50/mobile/c12f38da55a4fe33663b039507477dd8_WM.jpg",
                        price = 3373,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН SAMSUNG GALAXY S10+ G975 12GB/1TB DUAL SIM EXYNOS 9820 (БЕЛАЯ КЕРАМИКА)",
                        shortDescription = "Производитель: Samsung",
                        longDescription = "Тип смартфон, Операционная система Android, Сенсорный экран, Разрешение экрана 1440x3040, Размер экрана 6.4, Флэш-память 1 ТБ, Оперативная память 12 ГБ, Количество SIM-карт 2, Количество точек матрицы 12 Мп, Емкость аккумулятора 4 100 мА·ч, Фронтальная камера 10 Мп, NFC, Быстрая зарядка, Беспроводная зарядка, Количество ядер 8 (2+2+4), Тактовая частота процессора 2 700 МГц, Сканер отпечатка пальца, Оптический зум 2 Х",
                        img = "https://i-on.by/image/tovar/52/mobile/862fffd332f24db6475408dab1110a8a_WM.jpg",
                        price = 3452,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН APPLE IPHONE 7 32GB BLACK",
                        shortDescription = "Производитель: Apple",
                        longDescription = "Тип смартфон, Операционная система Apple iOS, Сенсорный экран емкостный, мультитач, Размер экрана 4.7, Разрешение экрана 750x1334, Флэш-память 32 ГБ, Оперативная память 2 ГБ, Количество SIM-карт 1, Количество точек матрицы 12 Мп, Фронтальная камера 7 Мп, Ёмкость аккумулятора 1 960 мА·ч, Количество ядер 4 (2+2), NFC, Тактовая частота процессора 2 340 МГц, Сканер отпечатка пальца",
                        img = "https://i-on.by/image/tovar/25/mobile/f8d7fac0fe59ead77f5199454a6e8c4a_WM.jpg",
                        price = 1178,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "СМАРТФОН SONY XPERIA T2 ULTRA",
                        shortDescription = "Производитель: Sony",
                        longDescription = "Тип смартфон, Операционная система Android, Сенсорный экран емкостный, мультитач, Размер экрана 6, Разрешение экрана 720x1280, Флэш-память 8 ГБ, Оперативная память 1 ГБ, Количество точек матрицы 13 Мп, Фронтальная камера 1.1 Мп, Ёмкость аккумулятора 3 000 мА·ч, Количество ядер 4, NFC, Тактовая частота процессора 1 400 МГц",
                        img = "https://i-on.by/image/tovar/7/mobile/45065306c37efb535c1cd5786c82222c_WM.jpg",
                        price = 419,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН NOKIA 105 BLUE ",
                        shortDescription = "Производитель: Nokia",
                        longDescription = "Тип телефон, Размер экрана 1.4, Разрешение экрана 128x128, Флэш-память 8 МБ, Оперативная память 384 КБ, Ёмкость аккумулятора 800 мА·ч, Фонарик",
                        img = "https://i-on.by/image/tovar/2/mobile/91b5d317dd831280cb268a4de96723c2_WM.jpg",
                        price = 48,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН TEXET TM-513R BLACK/ORANGE",
                        shortDescription = "Производитель: TeXet",
                        longDescription = "Тип телефон, Размер экрана 2, Разрешение экрана 176x220, Количество SIM-карт 2, Количество точек матрицы 2 Мп, Ёмкость аккумулятора 2 570 мА·ч, Фонарик",
                        img = "https://i-on.by/image/tovar/14/mobile/6765a92938529f293dbfb2b65b8a72f8_WM.jpg",
                        price = 97,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]

                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН NOKIA 130 DUAL SIM RED",
                        shortDescription = "Производитель: Nokia",
                        longDescription = "Тип телефон, Размер экрана 1.8, Разрешение экрана 128x160, Количество SIM-карт 2, Ёмкость аккумулятора 1 020 мА·ч, Фонарик",
                        img = "https://i-on.by/image/tovar/10/mobile/e00be16f37239fc7b5447b66dbb11527_WM.jpg",
                        price = 64,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН MAXVI X850 GOLD",
                        shortDescription = "Производитель: Maxvi",
                        longDescription = "Тип телефон, Размер экрана 2.8, Разрешение экрана 240x320, Флэш-память 32 МБ, Оперативная память 32 МБ, Количество SIM-карт 2, Количество точек матрицы 1.3 Мп, Ёмкость аккумулятора 1 600 мА·ч",
                        img = "https://i-on.by/image/tovar/13/mobile/9fb0e0157d5cf1a6d0510165a6e813b6_WM.jpg",
                        price = 68,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН CATERPILLAR B25",
                        shortDescription = "Производитель: Caterpillar",
                        longDescription = "Тип телефон, Размер экрана 2, Разрешение экрана 240x320, Количество SIM-карт 2, Количество точек матрицы 2 Мп, Ёмкость аккумулятора 1 300 мА·ч, Количество ядер 1, Тактовая частота процессора 208 МГц, Фонарик",
                        img = "https://i-on.by/image/tovar/10/mobile/dd7bdbaaeaba93c4ef7a809111e3321f_WM.jpg",
                        price = 121,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН MAXVI X800 BLACK/RED",
                        shortDescription = "Производитель: Maxvi",
                        longDescription = "Тип телефон, Размер экрана 2.8, Количество SIM-карт 2, Количество точек матрицы 1.3 Мп, Ёмкость аккумулятора 1 600 мА·ч, Фонарик",
                        img = "https://content2.onliner.by/catalog/device/header/4bb886b4358b2eaf5b5b2e684fcd48ae.jpg",
                        price = 60,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    },
                    new Phone
                    {
                        name = "МОБИЛЬНЫЙ ТЕЛЕФОН NOKIA 230 DUAL SIM BLACK",
                        shortDescription = "Производитель: Nokia",
                        longDescription = "Тип телефон, Размер экрана 2.8, Разрешение экрана 240x320, Оперативная память 16 МБ, Количество SIM-карт 2, Количество точек матрицы 2 Мп, Фронтальная камера 2.0 Мп, Ёмкость аккумулятора 1 200 мА·ч",
                        img = "https://i-on.by/image/tovar/20/mobile/24cb01c92da8d1cba9d351d4450818b4_WM.jpg",
                        price = 139,
                        isFovorite = true,
                        available = true,
                        Category = Categories["Не смартфон"]
                    }

                    );
                content.SaveChanges();
            }

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]{
                        new Category { categoryName = "Смартфон", description = "" },
                        new Category { categoryName = "Не смартфон", description = "" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                    
                }
                return category;
            }
        }
    }
}
