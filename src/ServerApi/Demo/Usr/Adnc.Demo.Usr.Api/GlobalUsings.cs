﻿global using Adnc.Infra.Core.Configuration;
global using Adnc.Shared;
global using Adnc.Shared.Application.Contracts.Dtos;
global using Adnc.Demo.Shared.Const.Permissions.Usr;
global using Adnc.Shared.WebApi;
global using Adnc.Shared.WebApi.Authentication;
global using Adnc.Shared.WebApi.Authentication.JwtBearer;
global using Adnc.Shared.WebApi.Authorization;
global using Adnc.Demo.Usr.Application.Contracts.Dtos;
global using Adnc.Demo.Usr.Application.Contracts.Services;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Options;
global using System.IdentityModel.Tokens.Jwt;