using System.ComponentModel.DataAnnotations;

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Models.DTO
{
    public class AddWalkRequestDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        [Required]
        [Range(0, 50)]
        public double LengtInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        [Required]
        public Guid DifficultyId { get; set; }
        [Required]
        public Guid RegionId { get; set; }
    }
}
