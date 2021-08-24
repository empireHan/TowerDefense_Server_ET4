using System;
using System.Net;
using ETModel;
using MongoDB.Bson;

namespace ETHotfix
{
	[MessageHandler(AppType.Realm)]
	public class C2R_LoginHandler : AMRpcHandler<C2R_Login, R2C_Login>
	{
		protected override async void Run(Session session, C2R_Login message, Action<R2C_Login> reply)
		{
			string account = message.Account;
			string password = message.Password;
			R2C_Login response = new R2C_Login();

			if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
			{
				response.Error = ErrorCode.ERR_AccountOrPasswordError;
				response.Message = "用户名密码不能为空!";
				reply(response);
				return;
			}

			try
			{
				var accountList = await Game.Scene.GetComponent<DBProxyComponent>().Query<AccountInfo>(d => message.Account == d.AccountName && message.Password == d.Password);
				if(accountList.Count == 0)
                {
					response.Error = ErrorCode.ERR_AccountOrPasswordError;
					response.Message = "该账号不存在!";
					reply(response);
					return;
				}

                // 随机分配一个Gate
                StartConfig config = Game.Scene.GetComponent<RealmGateAddressComponent>().GetAddress();
				//Log.Debug($"gate address: {MongoHelper.ToJson(config)}");
				IPEndPoint innerAddress = config.GetComponent<InnerConfig>().IPEndPoint;
				Session gateSession = Game.Scene.GetComponent<NetInnerComponent>().Get(innerAddress);

				// 向gate请求一个key,客户端可以拿着这个key连接gate
				G2R_GetLoginKey g2RGetLoginKey = (G2R_GetLoginKey)await gateSession.Call(new R2G_GetLoginKey() {Account = message.Account});

				string outerAddress = config.GetComponent<OuterConfig>().Address2;

				response.Address = outerAddress;
				response.Key = g2RGetLoginKey.Key;
				reply(response);
			}
			catch (Exception e)
			{
				ReplyError(response, e, reply);
			}
		}
	}
}