using Ecommerce.Application.DataTransferObj.User.Ultilities;
using Ecommerce.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement
{
	public class LoginRepository 
	{
		public Task<bool> BanAcc(Guid id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ForgotPassword(ForgotPasswordRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Login(LoginRequest request, CancellationToken cancellationToken)
		{
            throw new NotImplementedException();
        }

		public Task<bool> LogOut(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> SeedGmail(SeedMailRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
