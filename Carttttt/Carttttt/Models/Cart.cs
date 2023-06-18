﻿namespace Carttttt.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine Line = Lines.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();
            if (Line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                Line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product) =>
            Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);

        public decimal ComputeTotalValue() => (decimal)Lines.Sum(e =>e.Product.ProductPrice*(1-e.Product?.ProductDiscount) * e.Quantity);
        public void Clear() => Lines.Clear();


    }

        public class CartLine
        {
            public int CartLineID { get; set; }

            public Product Product { get; set; } = new();

            public int Quantity { get; set; }
        
    }
}
