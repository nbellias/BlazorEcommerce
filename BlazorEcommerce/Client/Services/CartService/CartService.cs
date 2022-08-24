using BlazorEcommerce.Shared.Entities;
using Blazored.LocalStorage;

namespace BlazorEcommerce.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;
        //private readonly IAuthService _authService;

        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                cart = new List<CartItem>();
            }
            var sameItem = cart.Find(x => x.ProductId == cartItem.ProductId &&
                x.ProductTypeId == cartItem.ProductTypeId);
            if(sameItem == null)
            {
                cart.Add(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
            }
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;
        }

        public async Task<List<CartProductResultDTO>> GetCartProducts()
        {
            //if (await _authService.IsUserAuthenticated())
            //{
            //    var response = await _http.GetFromJsonAsync<ServiceResponse<List<CartProductResultDTO>>>("api/cart");
            //    return response.Data;
            //}
            //else
            //{
                var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                if (cartItems == null)
                    return new List<CartProductResultDTO>();
                var response = await _http.PostAsJsonAsync("api/cart/products", cartItems);
                var cartProducts =
                    await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResultDTO>>>();
                return cartProducts.Data;
            //}

        }

        public async Task RemoveProductFromCart(Guid productId, Guid productTypeId)
        {
            //if (await _authService.IsUserAuthenticated())
            //{
            //    await _http.DeleteAsync($"api/cart/{productId}/{productTypeId}");
            //}
            //else
            //{
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                if (cart == null)
                {
                    return;
                }

                var cartItem = cart.Find(x => x.ProductId == productId
                    && x.ProductTypeId == productTypeId);
                if (cartItem != null)
                {
                    cart.Remove(cartItem);
                    await _localStorage.SetItemAsync("cart", cart);
                OnChange.Invoke();
                }
            //}
        }

        public async Task UpdateQuantity(CartProductResultDTO product)
        {
            //if (await _authService.IsUserAuthenticated())
            //{
            //    var request = new CartItem
            //    {
            //        ProductId = product.ProductId,
            //        Quantity = product.Quantity,
            //        ProductTypeId = product.ProductTypeId
            //    };
            //    await _http.PutAsJsonAsync("api/cart/update-quantity", request);
            //}
            //else
            //{
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                if (cart == null)
                {
                    return;
                }

                var cartItem = cart.Find(x => x.ProductId == product.ProductId
                    && x.ProductTypeId == product.ProductTypeId);
                if (cartItem != null)
                {
                    cartItem.Quantity = product.Quantity;
                    await _localStorage.SetItemAsync("cart", cart);
                }
            //}
        }
    }
}
