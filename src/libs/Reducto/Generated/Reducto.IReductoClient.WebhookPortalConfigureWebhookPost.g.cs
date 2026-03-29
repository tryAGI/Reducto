#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Webhook Portal
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WebhookPortalConfigureWebhookPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}