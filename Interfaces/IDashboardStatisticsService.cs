namespace Interfaces
{
    public interface IDashboardStatisticsService
    {
        int GetClientsCount();
        int GetTenantsCount();
        int GetOwnersCount();
    }
}
