﻿//using BookStore.Domain.Abstract;
//using BookStore.Domain.Entities;
//using Microsoft.AspNetCore.Identity;
//using System.Text.Json;

//namespace BookStore.Domain.Concrete
//{

//    public class EFCartRepository : ICartRepository
//    {
//        private readonly EFDbContext _context;
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;
//        //private ApplicationUser User { get; set; }

//        public EFCartRepository(EFDbContext context, UserManager<ApplicationUser> userManager)
//        {
//            _context = context;
//            _userManager = userManager;
//        }

        

//        public async Task<Cart> GetCart(Guid userId)
//        {
//            //User = await _userManager.FindByIdAsync(userId.ToString());
//            var user = await _userManager.GetUserAsync(User);
//            Cart cart = new Cart();

//            if(User != null)
//               cart = JsonSerializer.Deserialize<Cart>(User.Cart) ?? new Cart();
                
//            return cart; 
//        }

//        public void SaveProduct(Cart cart)
//        {
//            string userCart = JsonSerializer.Serialize(cart);

//            User.Cart = userCart;
//            _userManager.
//            if (product.Id == 0)
//            {
//                _context.Products.Add(product);
//            }
//            else
//            {
//                Product dbEntry = _context.Products.Find(product.Id);
//                if (dbEntry != null)
//                {
//                    dbEntry.Name = product.Name;
//                    dbEntry.Author = product.Author;
//                    dbEntry.Description = product.Description;
//                    dbEntry.Price = product.Price;
//                    dbEntry.Category = product.Category;
//                    //dbEntry.ImageData = product.ImageData;
//                    //dbEntry.ImageMimeType = product.ImageMimeType;
//                }
//            }
//            _context.SaveChanges();
//        }

//        public Cart DeleteProduct(int productID)
//        {
//            Product dbEntry = _context.Products.Find(productID);
//            if (dbEntry != null)
//            {
//                _context.Products.Remove(dbEntry);
//                _context.SaveChanges();
//            }
//            return dbEntry;
//        }
//    }
//}
