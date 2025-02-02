﻿using MediatR;

namespace Boilerplate.Application.Features.Users.CreateUser;

public record CreateUserRequest : IRequest<GetUserResponse>
{
    public string Email { get; init; } = null!;

    public string Password { get; init; } = null!;

    public bool IsAdmin { get; init; }
}