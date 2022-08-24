using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResultDTO>> GetCartProducts();
        Task RemoveProductFromCart(Guid productId, Guid productTypeId);
        Task UpdateQuantity(CartProductResultDTO product);
        //Task StoreCartItems(bool emptyLocalCart);
        //Task GetCartItemsCount();
    }
}
