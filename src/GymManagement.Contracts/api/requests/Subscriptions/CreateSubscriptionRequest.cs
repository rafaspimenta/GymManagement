namespace GymManagement.Contracts.api.requests.Subscriptions
{
    public record CreateSubscriptionRequest(SubscriptionTypes subscriptionType, Guid adminId);
}