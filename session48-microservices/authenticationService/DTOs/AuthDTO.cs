﻿namespace authenticationService.DTOs;

public class RegisterDTO 
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

public class AuthResponseDTO
{
    public string Token { get; set; }
    public string Username { get; set; }
}