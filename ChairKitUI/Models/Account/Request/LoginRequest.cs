using System.ComponentModel.DataAnnotations;

namespace ChairKitUI.Models.Account.Request;

public class LoginRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập email")]
    public string Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập mật khẩu")]
    [StringLength(maximumLength: 16, MinimumLength = 3, ErrorMessage = "Mật khẩu từ 3 đến 16 ký tự")]
    public string Password { get; set; }
    public bool RememberLogin { get; set; } = true;
}
