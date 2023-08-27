using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Services
{
    public class ContextService : IContextService
    {
        private readonly IContextService _contextService;

        public ContextService(IContextService contextService)
        {
            _contextService = contextService;
        }

        public string GetUserContextData(int userId)
        {
            return _contextService.GetUserContextData(userId);
        }
    }
}
