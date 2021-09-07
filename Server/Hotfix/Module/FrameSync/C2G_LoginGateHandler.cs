using System;
using ETModel;

namespace ETHotfix
{
	[MessageHandler(AppType.Gate)]
	public class C2G_LoginGateHandler : AMRpcHandler<C2G_LoginGate, G2C_LoginGate>
	{
		protected override async void Run(Session session, C2G_LoginGate message, Action<G2C_LoginGate> reply)
		{
			G2C_LoginGate response = new G2C_LoginGate();
			try
			{
				string account = Game.Scene.GetComponent<GateSessionKeyComponent>().Get(message.Key);
				if (account == null)
				{
					response.Error = ErrorCode.ERR_ConnectGateKeyError;
					response.Message = "Gate key验证失败!";
					reply(response);
					return;
				}
				Player player = ComponentFactory.Create<Player, string>(account);
				Game.Scene.GetComponent<PlayerComponent>().Add(player);
				session.AddComponent<SessionPlayerComponent>().Player = player;
				session.AddComponent<MailBoxComponent, string>(ActorInterceptType.GateSession);

				response.PlayerId = player.Id;
				reply(response);

				//读取配置信息，并回传客户端				
				var levelConfigList = await Game.Scene.GetComponent<DBProxyComponent>().Query<LevelConfigDB>(d=> d.Id > 0);
				if (levelConfigList.Count > 0)
                {
					//组装参数发给客户端
					R2C_LevelConfig levelConfigs = new R2C_LevelConfig(); 
					foreach(LevelConfigDB lc in levelConfigList)
                    {
						LevelConfig levelConfig = new LevelConfig();
						levelConfig.LevelIndex = lc.levelIndex;
						levelConfig.Config = lc.strConfig;
						levelConfigs.LevelConfigs.Add(levelConfig);
					}
					session.Send(levelConfigs);					
				}
                else
                {
					//send config error message and stop client logic
					session.Send(new G2C_TestHotfixMessage() { Info = "stop client logic,get config error" });
				}
				//
				session.Send(new G2C_TestHotfixMessage() { Info = "recv hotfix message success" });
			}
			catch (Exception e)
			{
				ReplyError(response, e, reply);
			}
		}
	}
}