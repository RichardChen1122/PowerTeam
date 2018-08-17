using System;
using PowerTeam.DAL;
using PowerTeam.DAL.Interface;
using PowerTeam.DAL.Reponsitory;
using PowerTeam.Service.Interface;

namespace PowerTeam.Service
{
    public class DataContext : IDataContext
    {
        private PTDBContext _ptDbContext;
        private IDeliveryRepository _delivery;
        private IDeliveryShareditemRepository _deliveryShareditem;
        private IDeliveryTagRepository _deliveryTag;
        private IItemRepository _item;
        private IRoleRepository _role;
        private ISharedItemRepository _sharedItem;
        private ITagRepository _tag;
        private IUserRepository _user;
        private IUserRoleRepository _userRole;
        private IWorkHourRepository _workHour;

        public DataContext()
        {
            var facotry = new PTDBContextFactory();
            _ptDbContext = facotry.CreateDbContext(new string[1]);
        }
        public IDeliveryRepository Delivery
        {
            get
            {
                if (_delivery == null)
                {
                    _delivery = new DeliveryRepository(_ptDbContext);
                }

                return _delivery;
            }
        }

        public IDeliveryShareditemRepository DeliveryShareditem
        {
            get
            {
                if (_deliveryShareditem == null)
                {
                    _deliveryShareditem = new DeliveryShareditemRepository(_ptDbContext);
                }

                return _deliveryShareditem;
            }
        }

        public IDeliveryTagRepository DeliveryTag
        {
            get
            {
                if (_deliveryTag == null)
                {
                    _deliveryTag = new DeliveryTagRepository(_ptDbContext);
                }

                return _deliveryTag;
            }
        }

        public IItemRepository Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new ItemRepository(_ptDbContext);
                }

                return _item;
            }
        }

        public IRoleRepository Role
        {
            get
            {
                if (_role == null)
                {
                    _role = new RoleRepository(_ptDbContext);
                }

                return _role;
            }
        }

        public ISharedItemRepository SharedItem
        {
            get
            {
                if (_sharedItem == null)
                {
                    _sharedItem = new SharedItemRepository(_ptDbContext);
                }

                return _sharedItem;
            }
        }

        public ITagRepository Tag
        {
            get
            {
                if (_tag == null)
                {
                    _tag = new TagRepository(_ptDbContext);
                }

                return _tag;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_ptDbContext);
                }

                return _user;
            }
        }

        public IUserRoleRepository UserRole
        {
            get
            {
                if (_userRole == null)
                {
                    _userRole = new UserRoleRepository(_ptDbContext);
                }

                return _userRole;
            }
        }

        public IWorkHourRepository WorkHour
        {
            get
            {
                if (_workHour == null)
                {
                    _workHour = new WorkHourRepository(_ptDbContext);
                }

                return _workHour;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
