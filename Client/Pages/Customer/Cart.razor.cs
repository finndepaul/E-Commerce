using Blazored.LocalStorage;
using Client.IServices;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.ValueObj.Pagination;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Client.Pages.Customer
{
    public partial class Cart
    {
        [Inject] ICustomerServices _ser { get; set; }
        [Inject] ILocalStorageService _local { get; set; }

        [Inject] ILocalStorageService localStorage { get; set; }
        public NavigationManager naviga { get; set; }

        public PaginationResponse<CartDetailDTO> list;
        public OrderDetailCreateRequest Request = new OrderDetailCreateRequest();
        public string UserID { get; set; }
        

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

        public async Task Checkout(Guid PrID, Guid cartdetail, decimal price, decimal quantity)
        {
            UserID = await localStorage.GetItemAsync<string>("userId");

            Request.ProductID = PrID;
            Request.NumberOfProduct = (int)Math.Floor(quantity);
            Request.CreatedBy = Guid.Parse(UserID);
            Request.Shipfee = 20000;
            Request.Price = price*Request.NumberOfProduct;

            var rs = await _ser.CreateBill(Request);
        }

        private void PageChanged(int i)
        {
            _table.NavigateTo(i - 1);
        }
    }
}
