using pr7.Models;
using pr7.LogIn;
using pr7.CheckEntry;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace pr7.Products
{
    internal class AddProductToCart
    {
        private readonly DickieYagodkiContext _db;
        public AddProductToCart(DickieYagodkiContext db)
        {
            _db = db;
        }
        public async Task AddProduct()
        {
            while (true)
            {
                int input = CheckType.CheckInt("Введите ID товара для добавления в корзину: ");

                var be = _db.Products.FirstOrDefaultAsync(u => u.ProductId == input);
                if (be != null && CurrentUser.CurrUsr != null)
                {
                    var cart = await _db.Carts.FirstOrDefaultAsync(u => u.UserId == CurrentUser.CurrUsr.UserId);

                    if (cart == null)
                    {
                        cart = new()
                        {
                            UserId = CurrentUser.CurrUsr.UserId

                        };
                    }

                    await _db.Carts.AddAsync(cart);
                    await _db.SaveChangesAsync();

                    ProductInCart productInCart = new()
                    {
                        CartId = cart.CartId,
                        ProductId = input,
                        Quantity = 1
                    };

                    await _db.ProductInCarts.AddAsync(productInCart);
                    await _db.SaveChangesAsync();

                    
                }
                return;
            }
        }
    }
}
