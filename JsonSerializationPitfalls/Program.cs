using JsonSerializationPitfalls;
using Newtonsoft.Json;
const string validJson = """{ "value": true, "errorReason": "TwoWrongs" } """;
const string slightlyValidJson = """{ "value": true, "errorReason": "TwoWrongs", "unexpectedProperty": "unexpectedValue" }""";
const string invalidJson = """{ "unexpectedProperty": "unexpectedValue" }""";

var validJsonPoco = JsonConvert.DeserializeObject<Poco>(validJson);
var slightlyValidJsonPoco = JsonConvert.DeserializeObject<Poco>(slightlyValidJson);
var invalidJsonPoco = JsonConvert.DeserializeObject<Poco>(invalidJson);

Console.WriteLine(JsonConvert.SerializeObject(validJsonPoco));
Console.WriteLine(JsonConvert.SerializeObject(slightlyValidJsonPoco));
Console.WriteLine(JsonConvert.SerializeObject(invalidJsonPoco));

// Output:
// {"value":true,"errorReason":"TwoWrongs"}
// {"value":true,"errorReason":"TwoWrongs"}
// {"value":false,"errorReason":"TwoWrongs"}
