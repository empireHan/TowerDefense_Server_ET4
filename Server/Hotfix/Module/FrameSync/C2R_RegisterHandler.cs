using System;
using System.Net;
using ETModel;
using MongoDB.Bson;

namespace ETHotfix
{
	[MessageHandler(AppType.Realm)]
	public class C2R_RegisterHandler : AMRpcHandler<C2R_Register, R2C_Register>
	{
		protected override async void Run(Session session, C2R_Register message, Action<R2C_Register> reply)
		{
			string account = message.Account;
			string password = message.Password;
			R2C_Register response = new R2C_Register();

			if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
				response.Error = ErrorCode.ERR_AccountOrPasswordError;
				response.Message = "用户名密码不能为空!";
				reply(response);
				return;
            }
			
			try
			{
				var accountList = await Game.Scene.GetComponent<DBProxyComponent>().Query<AccountInfo>(d => message.Account == d.AccountName);
				if(accountList.Count > 0)
                {
					response.Error = ErrorCode.ERR_AccountOrPasswordError;
					response.Message = "该账号已存在!";
					reply(response);
					return;
                }

				AccountInfo accountInfo = ComponentFactory.CreateWithId<AccountInfo>(IdGenerater.GenerateId());
				accountInfo.AccountName = account;
				accountInfo.Password = password;
				await Game.Scene.GetComponent<DBProxyComponent>().Save(accountInfo);

				response.Message = "注册成功!";
				reply(response);
			}
			catch (Exception e)
			{
				ReplyError(response, e, reply);
			}

			response.Error = ErrorCode.ERR_Success;
			reply(response);
		}
	}
}