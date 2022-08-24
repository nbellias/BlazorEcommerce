using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Task<ServiceResponse<List<CartProductResultDTO>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = _cartRepository.GetCartProducts(cartItems);

            return result;
        }
    }
}
