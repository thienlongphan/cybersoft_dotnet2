using Microsoft.AspNetCore.Mvc;
using session38_50.Data;
using session38_50.Interfaces;
using session38_50.Models;
using session38_50.Models.DTOs;

namespace session38_50.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    public async Task<ActionResult> Register([FromBody] UserDTO user)
    {
        try
        {
           var result= await _userService.CreateUserAsync(user);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        
    }

    [HttpGet("verify-email")]
    public async Task<ActionResult> VerifyEmail([FromQuery] string token)
    {
        try
        {
            var result = await _userService.VerifyEmailAsync(token);
            if (result != null)
            {
                return Ok("Email verified Successfully");
            }
            else
            {
                return BadRequest("Email verified Failed");
            }
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login([FromBody] LoginDTO user)
    {
        try
        {
            var result = await _userService.LoginAsync(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Login failed");
        }
        catch (Exception e)
        {
            return BadRequest($"Login failed {e.Message}");
        }
    }
    
    [HttpPost("forgot-password")]
    public async Task<ActionResult> ForgotPassword([FromBody] ForgotPassDTO forgotPassDTO){
        try {
            var result = await _userService.ForgotPasswordAsync(forgotPassDTO.Email);
            if(result == null) {
                return BadRequest("Invalid email");
            }
            return Ok("Password reset link sent to your email");
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("reset-password")]
    public async Task<ActionResult> ResetPassword([FromBody] ResetPasswordDTO resetPasswordDto)
    {
        try
        {
            var result = await _userService.ResetPasswordAsync(resetPasswordDto);
            if (result == null)
            {
                return BadRequest("Invalid token and new password is not provided");
            }
            
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}