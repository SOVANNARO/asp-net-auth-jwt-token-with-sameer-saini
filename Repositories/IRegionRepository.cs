using auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain;

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetByIdAsync(Guid id);
        Task<Region> CreateAsync(Region region);
        Task<Region?> updateAsync(Guid id, Region region);
        Task<Region?> DeleteAsync(Guid id);
    }
}