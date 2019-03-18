using UnityEngine;
using UnityEditor.ShaderGraph;
using System.Reflection;

[Title("UV", "CG Panner")]
public class CGPannerNode : CodeFunctionNode, IMayRequireTime
{
    public CGPannerNode()
    {
        name = "CG Panner";
    }

    protected override MethodInfo GetFunctionToConvert()
    {
        return GetType().GetMethod("CG_Panner", BindingFlags.Static | BindingFlags.NonPublic);
    }

    static string CG_Panner(
        [Slot(0, Binding.MeshUV0)] Vector2Node UV,
        [Slot(1, Binding.None, 1f, 1f, 1f, 1f)] Vector2 Tiling,
        [Slot(2, Binding.None, 1f, 1f, 1f, 1f)] Vector2 Speed,
        [Slot(3, Binding.None)] out Vector2 Out)
    {
        Out = Vector2.zero;

        return
            @"
{
    Out = (UV * Tiling) + (_Time.y * Speed);
}
";
    }

    public bool RequiresTime()
    {
        return true;
    }
}