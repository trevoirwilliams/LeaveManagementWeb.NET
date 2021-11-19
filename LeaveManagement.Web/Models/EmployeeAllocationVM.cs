namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }

}
