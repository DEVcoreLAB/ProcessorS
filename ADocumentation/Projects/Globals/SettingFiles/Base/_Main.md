IConfigureFile.cs - An interface for a method that operates on settings files.   
<br>
SaveSettings.cs - Contain generic Configure method.   
	This method is based on the IConfigureFile interface and inherits from ApplicationSettingsBase to ensure the provided type T, where T is a settings-type object.   
	```csharp
	public void Configure<T>(T settingFile, string nameOfSetting, object value) where T : ApplicationSettingsBase
	```
	<br>
	Example of usage with using SettingFileConfigurator:   
	```csharp
	SettingFileConfigurator settingFileConfigurator = new SettingFileConfigurator(new SaveSettings());
            settingFileConfigurator.ConfigureFile.Configure(SettingFilePath.Default, 
            nameof(SettingFilePath.Default.SystemPath), 
            $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS");
	```
	<br>
	SettingFilePath.Default - instance of settings file.   
	nameof(SettingFilePath.Default.SystemPath) - name of setting to save new value.   
	$@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS") - value to save. String in this case.
