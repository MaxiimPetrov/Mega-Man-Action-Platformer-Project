using UnrealBuildTool;

public class MegaManProjectTarget : TargetRules
{
	public MegaManProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MegaManProject");
	}
}
