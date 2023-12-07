// See https://aka.ms/new-console-template for more information

using Config.Net;

Console.WriteLine("Hello, World!");

var settings = new ConfigurationBuilder<IRootSetting>()
	.UseIniFile("config.ini")
	.UseJsonFile("config.json")
	.Build();

Console.WriteLine("Last App run: " + settings.AppSetting.LastRun);

settings.UserSetting.FirstName = "Fulan";
settings.UserSetting.LastName = "Salim";
settings.UserSetting.Age = 19;

settings.AppSetting.LastRun = DateTime.Now;

Console.WriteLine("Finish!");
