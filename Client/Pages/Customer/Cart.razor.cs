using Blazored.LocalStorage;
using Client.IServices;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.ValueObj.Pagination;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Client.Pages.Customer
{
    public partial class Cart
    {
        [Inject] ICustomerServices _ser { get; set; }
        [Inject] ILocalStorageService _local { get; set; }

        public PaginationResponse<CartDetailDTO> list;

        private MudTable<CartDetailDTO> _table;
        private string cartId;

        protected override async Task OnInitializedAsync()
        {
            cartId = await _local.GetItemAsync<string>("userId");
            list = await _ser.GetCart(Guid.Parse(cartId));
        }
        private async Task LoadTableData()
        {
            var newData = await _ser.GetCart(Guid.Parse(cartId));
            list = newData;
        }
        private void PageChanged(int i)
        {
            _table.NavigateTo(i - 1);
        }
    }
}
