using GymManagement.Contracts.api.requests.Subscriptions;

namespace GymManagement.Contracts.Api.Requests.Subscriptions
{
    public record SubscriptionResponse(Guid id, SubscriptionTypes subscriptionRequestType);
}