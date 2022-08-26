using BlazorEcommerce.Shared.Entities;
using BlazorEcommerce.Shared.Responses;

namespace BlazorEcommerce.Server.Repositories.CartRepository
{
    public interface ICartRepository
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
        //Task<ServiceResponse<List<CartProductResultDTO>>> StoreCartItems(List<CartItem> cartItems);
        //Task<ServiceResponse<Guid>> GetCartItemsCount();
        //Task<ServiceResponse<List<CartProductResultDTO>>> GetDbCartProducts(int? userId = null);
        //Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);
        //Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);
        //Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
}
