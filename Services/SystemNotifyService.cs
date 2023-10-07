using Radzen;

namespace BookMyLunchClient.Services
{
    // notification service for system
    public class SystemNotifyService
    {
        private readonly NotificationService _notificationService;

        public SystemNotifyService(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // error notification
        public void ShowErrorNotification(string summary, string detail)
        {
            var severity = NotificationSeverity.Error;
            var duration = 4000;
            var message = new NotificationMessage { Severity = severity, Summary = summary, Detail = detail, Duration = duration };
            _notificationService.Notify(message);
        }

        // You can add other methods for different types of notifications if needed
    }
}
