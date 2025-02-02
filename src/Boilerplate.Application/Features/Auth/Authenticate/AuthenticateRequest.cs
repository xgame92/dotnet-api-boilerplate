﻿using Boilerplate.Application.Common.Responses;
using MediatR;

namespace Boilerplate.Application.Features.Auth.Authenticate;

public record AuthenticateRequest : IRequest<Jwt?>
{
    public string Email { get; init; } = null!;

    public string Password { get; init; }  = null!;
}