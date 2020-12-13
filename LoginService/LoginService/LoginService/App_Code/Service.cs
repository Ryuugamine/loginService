using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class Service : IService
{
	public LoginResponseModel Login(UserModel user)
	{
		LoginResponseModel response = new LoginResponseModel();
        using (LoginContext context = new LoginContext())
        {
            var users = from u in context.Users where u.Login.Equals(user.Login) select u;
            if (users != null && users.Count() > 0)
            {
                UserModel currentUser = users.First();
                if (currentUser.Password.Equals(user.Password))
                {
                    response.Status = (int)Constants.STATUSES.OK;
                    response.Message = Constants.SUCCESS;
                }
                else
                {
                    response.Status = (int)Constants.STATUSES.ERROR;
                    response.Message = Constants.WRONG_USER_DATA;
                }
            }
            else
            {
                response.Status = (int)Constants.STATUSES.ERROR;
                response.Message = Constants.WRONG_USER_DATA;
            }

        }
        return response;
    }
}
