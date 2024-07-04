using UnrealBuildTool;

public class MegaManProjectClientTarget : TargetRules
{
	public MegaManProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MegaManProject");
	}
}
