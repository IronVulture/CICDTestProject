using System.Linq;
using UnityEditor;

public class CI
{
    [MenuItem("CI/Win64Build")]
    public static void Win64Build()
    {
#if UNITY_EDITOR
        BuildPipeline.BuildPlayer(ScenePaths, "Build/TestProject.exe", BuildTarget.StandaloneWindows64,
            BuildOptions.None);
#endif
    }
    [MenuItem("CI/SwitchBuild")]
    static void SwitchBuild()
    {

#if UNITY_EDITOR
        // Build player.
        BuildPipeline.BuildPlayer(ScenePaths, "NSbuilds/TestProject", BuildTarget.Switch, BuildOptions.Development);
#endif
    }

    static string[] ScenePaths => EditorBuildSettings.scenes.Select(scene => scene.path).ToArray();
}
