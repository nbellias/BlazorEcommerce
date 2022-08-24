﻿using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Repositories.CartRepository
{
    public class CartRepository : ICartRepository
    {
        private readonly DataContext _context;
        private readonly IAuthService _authService;

        public CartRepository(DataContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<ServiceResponse<List<CartProductResultDTO>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = new ServiceResponse<List<CartProductResultDTO>>
            {
                Data = new List<CartProductResultDTO>()
            };

            foreach (var item in cartItems)
            {
                var product = await _context.Products
                    .Where(p => p.Id == item.ProductId)
                    .FirstOrDefaultAsync();

                if (product == null)
                {
                    continue;
                }

                var productVariant = await _context.ProductVariants
                    .Where(v => v.ProductId == item.ProductId
                        && v.ProductTypeId == item.ProductTypeId)
                    .Include(v => v.ProductType)
                    .FirstOrDefaultAsync();

                if (productVariant == null)
                {
                    continue;
                }

                var cartProduct = new CartProductResultDTO
                {
                    ProductId = product.Id,
                    Title = product.Title,
                    ImageUrl = product.ImageUrl,
                    Price = productVariant.Price,
                    ProductType = productVariant.ProductType.Name,
                    ProductTypeId = productVariant.ProductTypeId,
                    Quantity = item.Quantity
                };

                result.Data.Add(cartProduct);
            }

            return result;
        }

        //public async Task<ServiceResponse<List<CartProductResultDTO>>> StoreCartItems(List<CartItem> cartItems)
        //{
        //    cartItems.ForEach(cartItem => cartItem.UserId = _authService.GetUserId());
        //    _context.CartItems.AddRange(cartItems);
        //    await _context.SaveChangesAsync();

        //    return await GetDbCartProducts();
        //}

        //public async Task<ServiceResponse<Guid>> GetCartItemsCount()
        //{
        //    var count = (await _context.CartItems.Where(ci => ci.UserId == _authService.GetUserId()).ToListAsync()).Count;
        //    return new ServiceResponse<Guid> { Data = count };
        //}

        //public async Task<ServiceResponse<List<CartProductResultDTO>>> GetDbCartProducts(int? userId = null)
        //{
        //    if (userId == null)
        //        userId = _authService.GetUserId();

        //    return await GetCartProducts(await _context.CartItems
        //        .Where(ci => ci.UserId == userId).ToListAsync());
        //}

        //public async Task<ServiceResponse<bool>> AddToCart(CartItem cartItem)
        //{
        //    cartItem.UserId = _authService.GetUserId();

        //    var sameItem = await _context.CartItems
        //        .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId &&
        //        ci.ProductTypeId == cartItem.ProductTypeId && ci.UserId == cartItem.UserId);
        //    if (sameItem == null)
        //    {
        //        _context.CartItems.Add(cartItem);
        //    }
        //    else
        //    {
        //        sameItem.Quantity += cartItem.Quantity;
        //    }

        //    await _context.SaveChangesAsync();

        //    return new ServiceResponse<bool> { Data = true };
        //}

        //public async Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem)
        //{
        //    var dbCartItem = await _context.CartItems
        //        .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId &&
        //        ci.ProductTypeId == cartItem.ProductTypeId && ci.UserId == _authService.GetUserId());
        //    if (dbCartItem == null)
        //    {
        //        return new ServiceResponse<bool>
        //        {
        //            Data = false,
        //            Success = false,
        //            Message = "Cart item does not exist."
        //        };
        //    }

        //    dbCartItem.Quantity = cartItem.Quantity;
        //    await _context.SaveChangesAsync();

        //    return new ServiceResponse<bool> { Data = true };
        //}

        //public async Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId)
        //{
        //    var dbCartItem = await _context.CartItems
        //        .FirstOrDefaultAsync(ci => ci.ProductId == productId &&
        //        ci.ProductTypeId == productTypeId && ci.UserId == _authService.GetUserId());
        //    if (dbCartItem == null)
        //    {
        //        return new ServiceResponse<bool>
        //        {
        //            Data = false,
        //            Success = false,
        //            Message = "Cart item does not exist."
        //        };
        //    }

        //    _context.CartItems.Remove(dbCartItem);
        //    await _context.SaveChangesAsync();

        //    return new ServiceResponse<bool> { Data = true };
        //}
    }
}
