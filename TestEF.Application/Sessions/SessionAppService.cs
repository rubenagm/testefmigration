﻿using System.Threading.Tasks;
using Abp.Auditing;
using Abp.AutoMapper;
using Abp.ObjectMapping;
using TestEF.Sessions.Dto;

namespace TestEF.Sessions
{
    public class SessionAppService : TestEFAppServiceBase, ISessionAppService
    {
        private readonly IObjectMapper _objectMapper;

        public SessionAppService(IObjectMapper objectMapper)
        {
            _objectMapper = objectMapper;
        }

        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput();

            if (AbpSession.UserId.HasValue)
            {
                output.User = _objectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = _objectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            return output;
        }
    }
}