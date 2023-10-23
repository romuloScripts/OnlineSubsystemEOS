using UnrealBuildTool;
using System.Collections.Generic;

public class EOS_OSS_TutorialServerTarget : TargetRules
{
	public EOS_OSS_TutorialServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("EOS_OSS_Tutorial");
	}
}