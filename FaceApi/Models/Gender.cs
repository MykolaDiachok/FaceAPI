using System.Runtime.Serialization;

namespace FaceApi.Models;

public enum Gender
{
    [EnumMember(Value = "Male")]
    Male = 1,
    [EnumMember(Value = "Female")]
    Female = 2,
    [EnumMember(Value = "Non-Binary")]
    NonBinary = 3,
    [EnumMember(Value = "Other")]
    Other = 4
}