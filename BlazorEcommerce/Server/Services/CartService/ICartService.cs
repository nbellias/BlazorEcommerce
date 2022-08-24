using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResultDTO>>> GetCartProducts(List<CartItem> cartItems);
        //Task<ServiceResponse<List<CartProductResultDTO>>> StoreCartItems(List<CartItem> cartItems);
        //Task<ServiceResponse<Guid>> GetCartItemsCount();
        //Task<ServiceResponse<List<CartProductResultDTO>>> GetDbCartProducts(int? userId = null);
        //Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);
        //Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);
        //Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
}
