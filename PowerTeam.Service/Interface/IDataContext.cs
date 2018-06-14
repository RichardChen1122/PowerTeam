using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.DAL.Interface;

namespace PowerTeam.Service.Interface
{
    public interface IDataContext : IDisposable
    {
        IDeliveryRepository Delivery { get; }
        IDeliveryShareditemRepository DeliveryShareditem { get; }
        IDeliveryTagRepository DeliveryTag { get; }
        IItemRepository Item { get; }
        IRoleRepository Role { get; }
        ISharedItemRepository SharedItem { get; }
        ITagRepository Tag { get; }
        IUserRepository User { get; }
        IUserRoleRepository UserRole { get; }
        IWorkHourRepository WorkHour { get; }
    }
}
