using System.Linq;
using UnityEditor;

public class BuildScript
{
    [MenuItem("CI/Build")]
    public static void Build()
    {
        BuildPipeline.BuildPlayer(ScenePaths, "Build/TestProject.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    static string[] ScenePaths => EditorBuildSettings.scenes.Select(scene => scene.path).ToArray();
}