namespace ConfigDemo.Models;

public interface IRootSetting
{
	public IUserSetting UserSetting { get; set; }

	public IAppSetting AppSetting { get; set; }
}
