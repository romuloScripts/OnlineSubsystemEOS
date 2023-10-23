using UnrealBuildTool;
using System.Collections.Generic;

public class EOS_OSS_TutorialClientTarget : TargetRules
{
	public EOS_OSS_TutorialClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("EOS_OSS_Tutorial");
	}
}