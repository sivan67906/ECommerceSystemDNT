using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Domain.Entities;
public class Client
{
    public string ClientId { get; set; } = null!;
    public string ClientName { get; set; } = null!; // e.g., "Web", "Android", "iOS"
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
}