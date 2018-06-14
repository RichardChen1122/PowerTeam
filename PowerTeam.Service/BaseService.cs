using PowerTeam.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Service
{
    public class BaseService : IBaseService
    {
        private IDataContext _context = null;
        public BaseService(IDataContext dataContext)
        {
            _context = dataContext;
        }

        public IDataContext PTDataContext
        {
            get
            {
                return _context;
            }
        }
    }
}
