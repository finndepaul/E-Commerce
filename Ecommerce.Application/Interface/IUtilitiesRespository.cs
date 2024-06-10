using Ecommerce.Application.DataTransferObj.User.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IUtilitiesRespository
    {
        //Đổi mật khẩu
        Task<bool> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken);
        //Quên mật khẩu
        Task<bool> ForgotPassword(ForgotPasswordRequest request, CancellationToken cancellationToken);
        //Đăng nhập
        Task<bool> Login(LoginRequest request, CancellationToken cancellationToken);
        Task<bool> ConfirmCode(ConfirmCodeRequest request, CancellationToken cancellationToken);
        //Ban Acc
        Task<bool> BanAcc(Guid id, CancellationToken cancellationToken);
        Task<bool> LogOut(CancellationToken cancellationToken);
        Task<bool> SeedGmail(SeedMailRequest request);
    }
}
