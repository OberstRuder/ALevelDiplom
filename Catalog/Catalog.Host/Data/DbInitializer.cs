using Catalog.Data.Entities;

namespace Catalog.Data;
public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (!context.Products.Any())
        {
            await context.Products.AddRangeAsync(GetPreconfiguredProducts());

            await context.SaveChangesAsync();
        }
    }

    private static IEnumerable<ProductEntity> GetPreconfiguredProducts()
    {
        return new List<ProductEntity>()
        {
            new ProductEntity()
            {
                Name = "Samsung Galaxy S23 8/128GB Phantom Black",
                Description = "Samsung Galaxy S23 8/128GB Phantom Black",
                Price = 999.99m,
                AvailableStock = 200,
                PictureFileName = "1.png",
                Type = "Phone",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "Samsung Galaxy Fold 4 12/512GB Phantom Black",
                Description = "Samsung Galaxy Fold 4 12/512GB Phantom Black",
                Price = 1800.00m,
                AvailableStock = 50,
                PictureFileName = "2.png",
                Type = "Phone",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "Apple iPhone 14 128GB Midnight",
                Description = "Apple iPhone 14 128GB Midnight",
                Price = 1000.00m,
                AvailableStock = 40,
                PictureFileName = "3.png",
                Type = "Phone",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "Apple iPhone 13 128GB Midnight",
                Description = "Apple iPhone 13 128GB Midnight",
                Price = 1000.00m,
                AvailableStock = 40,
                PictureFileName = "4.png",
                Type = "Phone",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "LG Wing 8/128GB F100N Gray",
                Description = "LG Wing 8/128GB F100N Gray",
                Price = 299.00m,
                AvailableStock = 200,
                PictureFileName = "5.png",
                Type = "Phone",
                Brand = "LG"
            },
            new ProductEntity()
            {
                Name = "LG V60 ThinQ 5G 8/128GB Classy Blue",
                Description = "LG V60 ThinQ 5G 8/128GB Classy Blue",
                Price = 279.00m,
                AvailableStock = 80,
                PictureFileName = "6.png",
                Type = "Phone",
                Brand = "LG"
            },
            new ProductEntity()
            {
                Name = "Xiaomi Redmi Note 10 Pro 6/128GB Onyx Gray",
                Description = "Xiaomi Redmi Note 10 Pro 6/128GB Onyx Gray",
                Price = 249.00m,
                AvailableStock = 20,
                PictureFileName = "7.png",
                Type = "Phone",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Xiaomi Redmi Note 12 4/128GB Ice Blue",
                Description = "Xiaomi Redmi Note 12 4/128GB Ice Blue",
                Price = 199.99m,
                AvailableStock = 20,
                PictureFileName = "8.png",
                Type = "Phone",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Sony Xperia XZ Premium G8142 Black",
                Description = "Sony Xperia XZ Premium G8142 Black",
                Price = 149.99m,
                AvailableStock = 200,
                PictureFileName = "9.png",
                Type = "Phone",
                Brand = "Sony"
            },
            new ProductEntity()
            {
                Name = "Sony Xperia 1 IV 12/256GB White",
                Description = "Sony Xperia 1 IV 12/256GB White",
                Price = 850.00m,
                AvailableStock = 100,
                PictureFileName = "10.png",
                Type = "Phone",
                Brand = "Sony"
            },
            new ProductEntity()
            {
                Name = "Samsung UE50AU7100UXUA",
                Description = "Samsung UE50AU7100UXUA",
                Price = 520.00m,
                AvailableStock = 10,
                PictureFileName = "11.png",
                Type = "TV",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "Samsung QE55Q60BAUXUA",
                Description = "Samsung QE55Q60BAUXUA",
                Price = 799.99m,
                AvailableStock = 5,
                PictureFileName = "12.png",
                Type = "TV",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "LG 43UQ81006LB",
                Description = "LG 43UQ81006LB",
                Price = 479.99m,
                AvailableStock = 30,
                PictureFileName = "13.png",
                Type = "TV",
                Brand = "LG"
            },
            new ProductEntity()
            {
                Name = "LG 32LQ63006LA",
                Description = "LG 32LQ63006LA",
                Price = 299.99m,
                AvailableStock = 45,
                PictureFileName = "14.png",
                Type = "TV",
                Brand = "LG"
            },
            new ProductEntity()
            {
                Name = "Xiaomi Mi TV Q1E",
                Description = "Xiaomi Mi TV Q1E",
                Price = 530.00m,
                AvailableStock = 35,
                PictureFileName = "15.png",
                Type = "TV",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Xiaomi TV A2",
                Description = "Xiaomi TV A2",
                Price = 229.99m,
                AvailableStock = 35,
                PictureFileName = "16.png",
                Type = "TV",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Sony KD43X81KR",
                Description = "Sony KD43X81KR",
                Price = 699.99m,
                AvailableStock = 40,
                PictureFileName = "17.png",
                Type = "TV",
                Brand = "Sony"
            },
            new ProductEntity()
            {
                Name = "Sony XR55X90KR",
                Description = "Sony XR55X90KR",
                Price = 1499.99m,
                AvailableStock = 85,
                PictureFileName = "18.png",
                Type = "TV",
                Brand = "Sony"
            },
            new ProductEntity()
            {
                Name = "Samsung Galaxy Tab A8",
                Description = "Samsung Galaxy Tab A8",
                Price = 250.00m,
                AvailableStock = 30,
                PictureFileName = "19.png",
                Type = "Tablet",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "Samsung Galaxy Tab A7 Lite",
                Description = "Samsung Galaxy Tab A7 Lite",
                Price = 150.00m,
                AvailableStock = 120,
                PictureFileName = "20.png",
                Type = "Tablet",
                Brand = "Samsung"
            },
            new ProductEntity()
            {
                Name = "Apple iPad 2021",
                Description = "Apple iPad 2021",
                Price = 480.00m,
                AvailableStock = 130,
                PictureFileName = "21.png",
                Type = "Tablet",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "Apple iPad 2021 mini",
                Description = "Apple iPad 2021 mini",
                Price = 630.00m,
                AvailableStock = 100,
                PictureFileName = "22.png",
                Type = "Tablet",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "Xiaomi Mi Pad 5 Wi-Fi 6/128GB",
                Description = "Xiaomi Mi Pad 5 Wi-Fi 6/128GB",
                Price = 380.00m,
                AvailableStock = 100,
                PictureFileName = "23.png",
                Type = "Tablet",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Apple MacBook Air 13 M1 256GB 2020",
                Description = "Apple MacBook Air 13 M1 256GB 2020",
                Price = 1099.00m,
                AvailableStock = 20,
                PictureFileName = "25.png",
                Type = "Laptop",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "Apple MacBook Pro 14 M2 Pro 512GB 2023",
                Description = "Apple MacBook Pro 14 M2 Pro 512GB 2023",
                Price = 2449.00m,
                AvailableStock = 30,
                PictureFileName = "26.png",
                Type = "Laptop",
                Brand = "Apple"
            },
            new ProductEntity()
            {
                Name = "Xiaomi Mi RedmiBook 15",
                Description = "Xiaomi Mi RedmiBook 15",
                Price = 430.00m,
                AvailableStock = 55,
                PictureFileName = "27.png",
                Type = "Laptop",
                Brand = "Xiaomi"
            },
            new ProductEntity()
            {
                Name = "Xiaomi RedmiBook Air 13 i7",
                Description = "Xiaomi RedmiBook Air 13 i7",
                Price = 899.00m,
                AvailableStock = 60,
                PictureFileName = "28.png",
                Type = "Laptop",
                Brand = "Xiaomi"
            },
        };
    }
}