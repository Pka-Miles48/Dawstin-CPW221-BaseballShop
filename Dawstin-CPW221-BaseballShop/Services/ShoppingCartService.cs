using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Dawstin_CPW221_BaseballShop.Services
{
    public class ShoppingCartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string CartSessionKey = "ShoppingCart";

        public ShoppingCartService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private List<CartItem> GetCartItems()
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var cartJson = session.GetString(CartSessionKey);

            return !string.IsNullOrEmpty(cartJson)
                ? JsonSerializer.Deserialize<List<CartItem>>(cartJson)
                : new List<CartItem>();
        }

        private void SaveCartItems(List<CartItem> items)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString(CartSessionKey, JsonSerializer.Serialize(items));
        }

        public void AddToCart(Product product, int quantity)
        {
            var cartItems = GetCartItems();
            var existingItem = cartItems.FirstOrDefault(c => c.Product.ProductID == product.ProductID);

            if (existingItem != null)
                existingItem.Quantity += quantity;
            else
                cartItems.Add(new CartItem { Product = product, Quantity = quantity });

            SaveCartItems(cartItems);
        }

        public void RemoveFromCart(int productId)
        {
            var cartItems = GetCartItems();
            cartItems.RemoveAll(c => c.Product.ProductID == productId);
            SaveCartItems(cartItems);
        }

        public List<CartItem> GetCart() => GetCartItems();
    }
}
