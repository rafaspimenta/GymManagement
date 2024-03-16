using System.Text.Json.Serialization;

namespace GymManagement.Contracts.api.requests.Subscriptions
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubscriptionTypes
    {
        Free,
        Standard,
        Pro
    }
}