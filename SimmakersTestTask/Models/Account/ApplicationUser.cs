using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string? AvatarName { get; set; }
    public byte[]? Avatar { get; set; }

}