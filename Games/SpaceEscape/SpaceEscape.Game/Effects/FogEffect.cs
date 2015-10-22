// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Rendering;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace SiliconStudio.Xenko.Rendering
{
    public static partial class FogEffectKeys
    {
        public static readonly ParameterKey<Color4> FogColor = ParameterKeys.New<Color4>(new Color4(1,1,1,1));
        public static readonly ParameterKey<float> fogNearPlaneZ = ParameterKeys.New<float>(80.0f);
        public static readonly ParameterKey<float> fogFarPlaneZ = ParameterKeys.New<float>(250.0f);
        public static readonly ParameterKey<float> fogNearPlaneY = ParameterKeys.New<float>(0.0f);
        public static readonly ParameterKey<float> fogFarPlaneY = ParameterKeys.New<float>(120.0f);
    }
}
