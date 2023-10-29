using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Data.Seeds;

public static class CategorySeed
{
    private const string AdminId = "46dadb72-f4b7-400e-be4b-d58d36dc22dd";

    public static List<Category> Data
    {
        get
        {
            return new List<Category>
            {
                new()
                {
                    CategoryId = 1,
                    Name = "Electronica",
                    Description = "Todo lo relacionado con la electrónica, desde televisores hasta teléfonos inteligentes.",
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    CategoryId = 2,
                    Name = "Hogar y Jardin",
                    Description = "Todo lo que necesitas para que tu hogar y jardín se vean y se sientan geniales.",
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    CategoryId = 3,
                    Name = "Moda",
                    Description = "Las últimas tendencias de moda para hombres, mujeres y niños.",
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    CategoryId = 4,
                    Name = "Salud y Belleza",
                    Description = "Productos para ayudarte a verte y sentirte mejor.",
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    CategoryId = 5,
                    Name = "Deportes y Aire Libre",
                    Description = "Equipo y ropa para todas tus actividades favoritas.",
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now
                }
            };
        }
    }
}
