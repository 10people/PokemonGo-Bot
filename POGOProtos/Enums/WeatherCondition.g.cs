// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/WeatherCondition.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/WeatherCondition.proto</summary>
  public static partial class WeatherConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/WeatherCondition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0VudW1zL1dlYXRoZXJDb25kaXRpb24ucHJvdG8SEFBP",
            "R09Qcm90b3MuRW51bXMqcQoQV2VhdGhlckNvbmRpdGlvbhIICgROT05FEAAS",
            "CQoFQ0xFQVIQARIJCgVSQUlOWRACEhEKDVBBUlRMWV9DTE9VRFkQAxIMCghP",
            "VkVSQ0FTVBAEEgkKBVdJTkRZEAUSCAoEU05PVxAGEgcKA0ZPRxAHYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.WeatherCondition), }, null));
    }
    #endregion

  }
  #region Enums
  public enum WeatherCondition {
    [pbr::OriginalName("NONE")] None = 0,
    [pbr::OriginalName("CLEAR")] Clear = 1,
    [pbr::OriginalName("RAINY")] Rainy = 2,
    [pbr::OriginalName("PARTLY_CLOUDY")] PartlyCloudy = 3,
    [pbr::OriginalName("OVERCAST")] Overcast = 4,
    [pbr::OriginalName("WINDY")] Windy = 5,
    [pbr::OriginalName("SNOW")] Snow = 6,
    [pbr::OriginalName("FOG")] Fog = 7,
  }

  #endregion

}

#endregion Designer generated code
