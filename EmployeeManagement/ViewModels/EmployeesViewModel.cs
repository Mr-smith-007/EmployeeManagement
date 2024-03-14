using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class EmployeesViewModel
    {
        private EmployeeRepository _repos { get; }
        public EmployeesViewModel() 
        {
            _repos = new EmployeeRepository();
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return new ObservableCollection<Employee>
                    (this._repos.GetAll());
            }
        }
    }
}
