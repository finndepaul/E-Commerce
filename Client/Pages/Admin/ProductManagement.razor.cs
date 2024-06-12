using Client.Dialog;
using Client.IServices;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Client.Pages.Admin
{
    public partial class ProductManagement
    {
        [Inject] IAdminService _ser { get; set; }

        public PaginationResponse<ProductDTO> list;

        private MudTable<ProductDTO> _table; // để pagination
        protected override async Task OnInitializedAsync()
        {
            list = await _ser.GetAll();
            
        }
        public async Task DuyetSP(Guid id)
        {
            await _ser.AcceptionProduct(id);
            await LoadTableData();
        }
        private async Task LoadTableData()
        {
            var newData = await _ser.GetAll();
            list = newData;
        }
        private void PageChanged(int i)
        {
            _table.NavigateTo(i - 1);
        }

        
    }
}
