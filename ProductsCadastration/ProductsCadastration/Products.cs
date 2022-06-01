using System;
using System.Collections.Generic;

namespace ProductsCadastration
{
    public class Products
    {
        public string Name;
        public float Price;
        public int Quantity;

        public float TotalValue()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }
    }
}
