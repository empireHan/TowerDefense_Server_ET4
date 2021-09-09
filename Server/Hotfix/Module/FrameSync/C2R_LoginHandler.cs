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

			if (false)
			{
				LevelConfigDB levelConfig = ComponentFactory.CreateWithId<LevelConfigDB>(IdGenerater.GenerateId());
				levelConfig.levelIndex = 1;
				levelConfig.strConfig = "|1|第一关|Level1|Level 1 Des|3|1|10|-6.05,0.2,-20.02|0,27.347,0|1001,1002,1003,1004,1005,1006,1007,1008,1009,1010|101,102,103";
				await Game.Scene.GetComponent<DBProxyComponent>().Save(levelConfig);
				levelConfig = ComponentFactory.CreateWithId<LevelConfigDB>(IdGenerater.GenerateId());
				levelConfig.levelIndex = 2;
				levelConfig.strConfig = "|2|第二关|Level2|Level 2 Des|4|2|15|9.17,0.55,-1.14|0,-90,0|1011,1012,1013,1014,1015,1016,1017,1018,1019,1020|101,102,103,105";
				await Game.Scene.GetComponent<DBProxyComponent>().Save(levelConfig);
				levelConfig = ComponentFactory.CreateWithId<LevelConfigDB>(IdGenerater.GenerateId());
				levelConfig.levelIndex = 3;
				levelConfig.strConfig = "|3|第三关|Level3|Level 3 Des|5|3|20|-6.59,0.07,-15|0,90,0|1021,1022,1023,1024,1025,1026,1027,1028,1029,1030|101,102,103,105,106";
				await Game.Scene.GetComponent<DBProxyComponent>().Save(levelConfig);
				levelConfig = ComponentFactory.CreateWithId<LevelConfigDB>(IdGenerater.GenerateId());
				levelConfig.levelIndex = 4;
				levelConfig.strConfig = "|4|第四关|Level4|Level 4 Des|6|4|15|-6.74,-0.49,4.04|0,-120,0|1031,1032,1033,1034,1035,1036,1037,1038,1039,1040|101,102,103,106";
				await Game.Scene.GetComponent<DBProxyComponent>().Save(levelConfig);
				levelConfig = ComponentFactory.CreateWithId<LevelConfigDB>(IdGenerater.GenerateId());
				levelConfig.levelIndex = 5;
				levelConfig.strConfig = "|5|第五关|Level5|Level 5 Des|7|5|20|0,-2,-1.47|0,90,0|1041,1042,1043,1044,1045,1046,1047,1048,1049,1050|101,102,103,104,105,106";
				await Game.Scene.GetComponent<DBProxyComponent>().Save(levelConfig);
				Console.WriteLine("已经写入数据库");
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