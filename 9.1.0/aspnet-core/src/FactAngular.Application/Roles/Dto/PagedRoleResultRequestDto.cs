﻿using Abp.Application.Services.Dto;

namespace FactAngular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

