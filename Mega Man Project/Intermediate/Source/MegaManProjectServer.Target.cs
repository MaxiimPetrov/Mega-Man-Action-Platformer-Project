using UnrealBuildTool;

public class MegaManProjectServerTarget : TargetRules
{
	public MegaManProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MegaManProject");
	}
}
