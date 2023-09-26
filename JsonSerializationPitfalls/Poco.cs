namespace JsonSerializationPitfalls;

public class Poco
{
    [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Value { get; set; } = false;
    [Newtonsoft.Json.JsonProperty("errorReason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public AccessEntitlementErrorReason ErrorReason { get; set; }
}

public enum AccessEntitlementErrorReason
{
    TwoWrongs = 0,
    DontMakeItRight = 1
}