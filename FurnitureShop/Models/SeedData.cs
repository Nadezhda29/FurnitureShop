using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Drawing;

namespace FurnitureShop.Models
{
    public class SeedData
    {
        public static void Fill(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();


            context.Furniture.AddRange(
                new Furniture
                {
                    Name = "BILLY/OXBERG",
                    CategoryID = 1,
                    TypeID = 5,
                    Price = 12990,
                    Description = "Стеллаж, черно-коричневый 80x30x202 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\bookcase\1.jpg")
                },

                new Furniture
                {
                    Name = "BILLY",
                    CategoryID = 1,
                    TypeID = 5,
                    Price = 6590,
                    Description = "Стеллаж, дубовый шпон, беленый 80x28x202 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\bookcase\2.jpg")
                },

                new Furniture
                {
                    Name = "BAGGEBO",
                    CategoryID = 1,
                    TypeID = 5,
                    Price = 1700,
                    Description = "Стеллаж, белый 50x25x160 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\bookcase\3.jpg")
                },

                new Furniture
                {
                    Name = "SKRUVSTA",
                    CategoryID = 1,
                    TypeID = 4,
                    Price = 7999,
                    Description = "Рабочий стул, серый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\chair\1.jpg")
                },

                new Furniture
                {
                    Name = "LEIFARNE",
                    CategoryID = 1,
                    TypeID = 4,
                    Price = 3099,
                    Description = "Рабочий стул, белый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\chair\2.jpg")
                },

                new Furniture
                {
                    Name = "HATTEFJÄLL",
                    CategoryID = 1,
                    TypeID = 4,
                    Price = 13999,
                    Description = "Рабочий стул, Гуннаред бежевый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\chair\3.jpg")
                },

                new Furniture
                {
                    Name = "LACK",
                    CategoryID = 1,
                    TypeID = 6,
                    Price = 2999,
                    Description = "Журнальный стол, черно-коричневый 118x78 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\coffee_table\1.jpg")
                },

                new Furniture
                {
                    Name = "VITTSJÖ",
                    CategoryID = 1,
                    TypeID = 6,
                    Price = 3999,
                    Description = "Журнальный стол, черно-коричневый/стекло 75 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\coffee_table\2.jpg")
                },

                new Furniture
                {
                    Name = "VITTSJÖ",
                    CategoryID = 1,
                    TypeID = 6,
                    Price = 4999,
                    Description = "Комплект столов, 2 шт, черно-коричневый/стекло 90x50 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\desk\3.jpg")
                },

                new Furniture
                {
                    Name = "VEBJÖRN",
                    CategoryID = 1,
                    TypeID = 3,
                    Price = 14999,
                    Description = "Письменный стол, бежевый 140x60 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\desk\1.jpg")
                },

                new Furniture
                {
                    Name = "MALM",
                    CategoryID = 1,
                    TypeID = 3,
                    Price = 9999,
                    Description = "Письменный стол, белый 140x65 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\desk\2.jpg")
                },

                new Furniture
                {
                    Name = "BRIMNES",
                    CategoryID = 1,
                    TypeID = 3,
                    Price = 4799,
                    Description = "Письменный стол, черный, 120x65 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\desk\3.jpg")
                },

                new Furniture
                {
                    Name = "GRIMHULT",
                    CategoryID = 1,
                    TypeID = 1,
                    Price = 27000,
                    Description = "2-местный диван, темно-бежевый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\sofa\1.jpg")
                },

                new Furniture
                {
                    Name = "VIMLE",
                    CategoryID = 1,
                    TypeID = 1,
                    Price = 69999,
                    Description = "3-местный диван, золотисто-коричневый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\sofa\2.jpg")
                },

                new Furniture
                {
                    Name = "HOLMSUND",
                    CategoryID = 1,
                    TypeID = 1,
                    Price = 39000,
                    Description = "3-местный диван-кровать, светло-зеленый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\living_room\sofa\3.jpg")
                },

                new Furniture
                {
                    Name = "MALM",
                    CategoryID = 2,
                    TypeID = 7,
                    Price = 18799,
                    Description = "Каркас кровати + 2 кроватных ящика, белый 160x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bed\1.jpg")
                },

                new Furniture
                {
                    Name = "IDANÄS",
                    CategoryID = 2,
                    TypeID = 7,
                    Price = 19799,
                    Description = "Каркас кровати, белый 160x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bed\2.jpg")
                },

                new Furniture
                {
                    Name = "SAGSTUA",
                    CategoryID = 2,
                    TypeID = 7,
                    Price = 13799,
                    Description = "Каркас кровати, черный/Лурой, 160x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bed\3.jpg")
                },

                new Furniture
                {
                    Name = "KNARREVIK",
                    CategoryID = 2,
                    TypeID = 8,
                    Price = 900,
                    Description = "Тумба прикроватная, черный 37x28 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bedside_table\1.jpg")
                },

                new Furniture
                {
                    Name = "HEMNES",
                    CategoryID = 2,
                    TypeID = 8,
                    Price = 5299,
                    Description = "Комод с 2 ящиками, белый 54x66 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bedside_table\2.jpg")
                },

                new Furniture
                {
                    Name = "NORDKISA",
                    CategoryID = 2,
                    TypeID = 8,
                    Price = 5499,
                    Description = "Тумба прикроватная, бамбук, 40x40 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\bedside_table\3.jpg")
                },

                new Furniture
                {
                    Name = "SONGESAND",
                    CategoryID = 2,
                    TypeID = 10,
                    Price = 15999,
                    Description = "Комод с 6 ящиками, белый 161x81 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\chest\1.jpg")
                },

                new Furniture
                {
                    Name = "SKÅNEVIK",
                    CategoryID = 2,
                    TypeID = 10,
                    Price = 4999,
                    Description = "Комод с 3 ящиками, глянцевый белый 70x72x40 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\chest\2.jpg")
                },

                new Furniture
                {
                    Name = "NORDMELA",
                    CategoryID = 2,
                    TypeID = 10,
                    Price = 16999,
                    Description = "Комод с 4 ящиками, черно-синий, 159x50 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\chest\3.jpg")
                },

                new Furniture
                {
                    Name = "SYVDE",
                    CategoryID = 2,
                    TypeID = 11,
                    Price = 10000,
                    Description = "Туалетный столик, белый 100x48 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\dressing_table\1.jpg")
                },

                new Furniture
                {
                    Name = "NORDKISA",
                    CategoryID = 2,
                    TypeID = 11,
                    Price = 8999,
                    Description = "Туалетный столик, бамбук 76x47 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\dressing_table\2.jpg")
                },

                new Furniture
                {
                    Name = "HEMNES",
                    CategoryID = 2,
                    TypeID = 11,
                    Price = 14999,
                    Description = "Туалетный столик с зркл, белый, 100x50 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\dressing_table\3.jpg")
                },

                new Furniture
                {
                    Name = "PAX/HASVIK",
                    CategoryID = 2,
                    TypeID = 9,
                    Price = 24800,
                    Description = "Гардероб, комбинация, белый 150x44x236 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\wardrobe\1.jpg")
                },

                new Furniture
                {
                    Name = "PAX/HOKKSUND",
                    CategoryID = 2,
                    TypeID = 9,
                    Price = 63100,
                    Description = "Гардероб, комбинация, черно-коричневый/глянцевый светло-бежевый 150x66x236 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\wardrobe\2.jpg")
                },

                new Furniture
                {
                    Name = "VISTHUS",
                    CategoryID = 2,
                    TypeID = 9,
                    Price = 25999,
                    Description = "Гардероб, серый/белый, 122x59x216 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bedroom\wardrobe\3.jpg")
                },

                new Furniture
                {
                    Name = "NYSJÖN",
                    CategoryID = 3,
                    TypeID = 15,
                    Price = 4299,
                    Description = "Шкаф высокий, белый 30x190 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\bathroom_cabinet\1.jpg")
                },

                new Furniture
                {
                    Name = "HEMNES",
                    CategoryID = 3,
                    TypeID = 15,
                    Price = 8999,
                    Description = "Зеркальный шкаф с 2 дверцами, белый 83x16x98 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\bathroom_cabinet\2.jpg")
                },

                 new Furniture
                 {
                     Name = "FRIHULT",
                     CategoryID = 3,
                     TypeID = 12,
                     Price = 1299,
                     Description = "Бра, черный",
                     Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\bathroom_lamp\1.jpg")
                 },

                new Furniture
                {
                    Name = "SVALLIS",
                    CategoryID = 3,
                    TypeID = 12,
                    Price = 2499,
                    Description = "Светодиодный потолочный светильник, белый 27 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\bathroom_lamp\2.jpg")
                },

                 new Furniture
                 {
                     Name = "NISSEDAL",
                     CategoryID = 3,
                     TypeID = 14,
                     Price = 2299,
                     Description = "Зеркало, белый 65x65 см",
                     Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\mirror\1.jpg")
                 },

                new Furniture
                {
                    Name = "STORJORM",
                    CategoryID = 3,
                    TypeID = 14,
                    Price = 6499,
                    Description = "Зеркало с подсветкой, белый 80x60 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\mirror\2.jpg")
                },


                 new Furniture
                 {
                     Name = "BRÅVIKEN",
                     CategoryID = 3,
                     TypeID = 13,
                     Price = 9000,
                     Description = "Одинарная раковина, белый 80x48x10 см",
                     Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\sink\1.jpg")
                 },

                new Furniture
                {
                    Name = "ODENSVIK",
                    CategoryID = 3,
                    TypeID = 13,
                    Price = 4000,
                    Description = "Одинарная раковина 63x49x6 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\bathroom\sink\2.jpg")
                },

                new Furniture
                {
                    Name = "LEIFARNE",
                    CategoryID = 4,
                    TypeID = 17,
                    Price = 2699,
                    Description = "Стул, белый/Брур-Инге",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_chair\1.jpg")
                },

                new Furniture
                {
                    Name = "TEODORES",
                    CategoryID = 4,
                    TypeID = 17,
                    Price = 2199,
                    Description = "Стул, белый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_chair\2.jpg")
                },

                new Furniture
                {
                    Name = "EKEDALEN",
                    CategoryID = 4,
                    TypeID = 17,
                    Price = 5299,
                    Description = "Стул, коричневый/Идекулла синий",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_chair\3.jpg")
                },

                new Furniture
                {
                    Name = "METOD",
                    CategoryID = 4,
                    TypeID = 18,
                    Price = 74628,
                    Description = "Кухня, белый/Будбин серый 240x60x228 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_set\1.jpg")
                },

                new Furniture
                {
                    Name = "KNOXHULT",
                    CategoryID = 4,
                    TypeID = 18,
                    Price = 26189,
                    Description = "Кухня, серо-зеленый 220x61x220 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_set\2.jpg")
                },

                new Furniture
                {
                    Name = "METOD",
                    CategoryID = 4,
                    TypeID = 18,
                    Price = 64728,
                    Description = "Кухня, белый/Воксторп под грецкий орех 240x60x228 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_set\3.jpg")
                },

                new Furniture
                {
                    Name = "LÅNGUDDEN",
                    CategoryID = 4,
                    TypeID = 19,
                    Price = 4090,
                    Description = "Одинарная врезная мойка, нержавеющ. сталь 46x46 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_sink\1.jpg")
                },

                new Furniture
                {
                    Name = "HAVSEN",
                    CategoryID = 4,
                    TypeID = 19,
                    Price = 6090,
                    Description = "Одинарная врезная мойка, белый 53x47 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_sink\2.jpg")
                },

                new Furniture
                {
                    Name = "VATTUDALEN",
                    CategoryID = 4,
                    TypeID = 19,
                    Price = 5090,
                    Description = "Одинарная врезная мойка с крылом, нержавеющ. сталь 69x47 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_sink\3.jpg")
                },

                new Furniture
                {
                    Name = "EKEDALEN",
                    CategoryID = 4,
                    TypeID = 16,
                    Price = 13499,
                    Description = "Раздвижной стол, дуб 120/180x80 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_table\1.jpg")
                },

                new Furniture
                {
                    Name = "TÄRENDÖ",
                    CategoryID = 4,
                    TypeID = 16,
                    Price = 2999,
                    Description = "Стол, черный 110x67 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_table\2.jpg")
                },

                new Furniture
                {
                    Name = "STRANDTORP",
                    CategoryID = 4,
                    TypeID = 16,
                    Price = 29999,
                    Description = "Раздвижной стол, белый 150/205/260x95 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\kitchen\kitchen_table\3.jpg")
                },

                new Furniture
                {
                    Name = "ELDBERGET/MALSKÄR",
                    CategoryID = 5,
                    TypeID = 21,
                    Price = 3599,
                    Description = "Рабочее кресло c подушкой, темно-серый/черный",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\computer_chair\1.jpg")
                },

                new Furniture
                {
                    Name = "HATTEFJÄLL",
                    CategoryID = 5,
                    TypeID = 21,
                    Price = 13999,
                    Description = "Рабочий стул, бежевый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\computer_chair\2.jpg")
                },

                new Furniture
                {
                    Name = "PÅHL",
                    CategoryID = 5,
                    TypeID = 20,
                    Price = 5799,
                    Description = "Письменный стол с полками, белый 96x58 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\computer_desk\1.jpg")
                },

                new Furniture
                {
                    Name = "HEMNES",
                    CategoryID = 5,
                    TypeID = 20,
                    Price = 28000,
                    Description = "Стол с дополнительным модулем, черно-коричневый 155x137 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\computer_desk\2.jpg")
                },

                new Furniture
                {
                    Name = "TERTIAL",
                    CategoryID = 5,
                    TypeID = 22,
                    Price = 999,
                    Description = "Лампа рабочая, темно-серый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\lamp\1.jpg")
                },

                new Furniture
                {
                    Name = "NYFORS",
                    CategoryID = 5,
                    TypeID = 22,
                    Price = 4900,
                    Description = "Лампа рабочая, никелированный белый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\lamp\2.jpg")
                },

                 new Furniture
                 {
                     Name = "FRIDLEV",
                     CategoryID = 5,
                     TypeID = 23,
                     Price = 2199,
                     Description = "Стеллаж, белый 66x129 см",
                     Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\shelving\1.jpg")
                 },

                new Furniture
                {
                    Name = "FJÄLLBO",
                    CategoryID = 5,
                    TypeID = 23,
                    Price = 4999,
                    Description = "Стеллаж, черный 51x136 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\study_room\shelving\2.jpg")
                },


                new Furniture
                {
                    Name = "BUSUNGE",
                    CategoryID = 6,
                    TypeID = 24,
                    Price = 15999,
                    Description = "Раздвижная кровать, белый 80x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_bed\1.jpg")
                },

                new Furniture
                {
                    Name = "VITVAL",
                    CategoryID = 6,
                    TypeID = 24,
                    Price = 19999,
                    Description = "Каркас 2-ярусной кровати, белый/светло-серый 90x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_bed\2.jpg")
                },

                new Furniture
                {
                    Name = "MINNEN",
                    CategoryID = 6,
                    TypeID = 24,
                    Price = 7899,
                    Description = "Раздвижная кровать с реечным дном, белый, 80x200 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_bed\3.jpg")
                },

                new Furniture
                {
                    Name = "BUSUNGE",
                    CategoryID = 6,
                    TypeID = 27,
                    Price = 6999,
                    Description = "Комод с 2 ящиками, светло-розовый 80x75 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_chest\1.jpg")
                },

                new Furniture
                {
                    Name = "SMÅSTAD/OPPHUS",
                    CategoryID = 6,
                    TypeID = 27,
                    Price = 6300,
                    Description = "Комод с 3 ящиками, белый/береза 60x42x63 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_chest\2.jpg")
                },

                new Furniture
                {
                    Name = "SMÅSTAD/OPPHUS",
                    CategoryID = 6,
                    TypeID = 27,
                    Price = 11500,
                    Description = "Комод с 6 ящиками, белый/бледно-бирюзовый, 60x57x123 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_chest\3.jpg")
                },

                new Furniture
                {
                    Name = "SUNDVIK",
                    CategoryID = 6,
                    TypeID = 26,
                    Price = 14999,
                    Description = "Шкаф платяной, белый 80x50x171 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_wardrobe\1.jpg")
                },

                new Furniture
                {
                    Name = "SMÅSTAD/OPPHUS",
                    CategoryID = 6,
                    TypeID = 26,
                    Price = 8000,
                    Description = "Гардероб, белый/бледно-бирюзовый 60x57x123 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_wardrobe\2.jpg")
                },

                new Furniture
                {
                    Name = "BUSUNGE",
                    CategoryID = 6,
                    TypeID = 26,
                    Price = 11999,
                    Description = "Шкаф платяной, светло-розовый, 80x139 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\children's_wardrobe\3.jpg")
                },

                new Furniture
                {
                    Name = "SMÅGÖRA",
                    CategoryID = 6,
                    TypeID = 25,
                    Price = 3999,
                    Description = "Письменный стол, белый 93x51 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\desk_for_school\1.jpg")
                },

                new Furniture
                {
                    Name = "PÅHL",
                    CategoryID = 6,
                    TypeID = 25,
                    Price = 6599,
                    Description = "Стол с дополнительным модулем, белый/розовый 128x58 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\desk_for_school\2.jpg")
                },

                new Furniture
                {
                    Name = "PÅHL",
                    CategoryID = 6,
                    TypeID = 25,
                    Price = 6599,
                    Description = "Письменн стол с полками, белый, 128x58 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\children's_room\desk_for_school\3.jpg")
                },

                new Furniture
                {
                    Name = "RIGGA",
                    CategoryID = 7,
                    TypeID = 29,
                    Price = 1499,
                    Description = "Напольная вешалка, белый",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\floor_hanger\1.jpg")
                },

                new Furniture
                {
                    Name = "MULIG",
                    CategoryID = 7,
                    TypeID = 29,
                    Price = 799,
                    Description = "Напольная вешалка, белый 99x152 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\floor_hanger\2.jpg")
                },

                 new Furniture
                 {
                     Name = "LINDBYN",
                     CategoryID = 7,
                     TypeID = 28,
                     Price = 4299,
                     Description = "Зеркало, черный 60x120 см",
                     Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\hallway_mirror\1.jpg")
                 },

                new Furniture
                {
                    Name = "TOFTBYN",
                    CategoryID = 7,
                    TypeID = 28,
                    Price = 4999,
                    Description = "Зеркало, черный 75x165 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\hallway_mirror\2.jpg")
                },

                new Furniture
                {
                    Name = "BRIMNES",
                    CategoryID = 7,
                    TypeID = 31,
                    Price = 9999,
                    Description = "Шкаф платяной 3-дверный, белый 117x190 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\hallway_wardrobe\1.jpg")
                },

                new Furniture
                {
                    Name = "IDANÄS",
                    CategoryID = 7,
                    TypeID = 31,
                    Price = 27999,
                    Description = "Гардероб, белый 121x211 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\hallway_wardrobe\2.jpg")
                },

                new Furniture
                {
                    Name = "TJUSIG",
                    CategoryID = 7,
                    TypeID = 30,
                    Price = 3999,
                    Description = "Скамья с полкой для обуви, белый 81x34x50 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\shoe_shelf\1.jpg")
                },

                new Furniture
                {
                    Name = "MACKAPÄR",
                    CategoryID = 7,
                    TypeID = 30,
                    Price = 5999,
                    Description = "Скамья с отделениями д/хранения, белый 100x51 см",
                    Image = ConvertImageToBytes(@"D:\ASP.NET\FurnitureRepository\hallway\shoe_shelf\2.jpg")
                }
            );

            context.SaveChanges();
        }

        private static byte[] ConvertImageToBytes(string path)
        {
            byte[] bytes = null;
            FileInfo fileInfo = new FileInfo(path);
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            bytes = reader.ReadBytes((int)fileInfo.Length);

            return bytes;
        }

    }
}
