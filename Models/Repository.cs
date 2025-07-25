namespace FormsApp.Models
{
    public static class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, Name = "IPhone 14", Price = 45000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "IPhone 15", Price = 50000, IsActive = true, Image = "4.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "IPhone 16", Price = 60000, IsActive = true, Image = "5.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "IPhone 12", Price = 40000, IsActive = true, Image = "7.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 5, Name = "Macbook Air", Price = 80000, IsActive = true, Image = "11.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "Macbook Pro", Price = 85000, IsActive = true, Image = "13.jpg", CategoryId = 2 });
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void EditIsActiveAndPrice(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.IsActive = updatedProduct.IsActive;
                entity.Price = updatedProduct.Price;
            }
        }

        public static void DeleteProduct(Product? entity)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == entity?.ProductId);

            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}