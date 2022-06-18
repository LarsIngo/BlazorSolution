namespace BlazorApp.Data
{
    public class NotificationService
    {
        public Task<Notification[]> GetAsync(int count)
        {
            return Task.FromResult(Enumerable.Range(1, count).Select(index => new Notification
            {
                Message = $"{index}",
            }).ToArray());
        }
    }
}