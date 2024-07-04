using UnrealBuildTool;

public class MegaManProjectEditorTarget : TargetRules
{
	public MegaManProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MegaManProject");
	}
}
