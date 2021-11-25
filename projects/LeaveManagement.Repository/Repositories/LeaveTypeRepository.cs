using LeaveManagement.Repository.Contracts;
using LeaveManagement.Data.Data;

namespace LeaveManagement.Repository.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
