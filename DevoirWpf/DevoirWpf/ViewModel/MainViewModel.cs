using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirWpf.ViewModel
{
    public class MainViewModel
    {
        private ObservableCollection<Employee> m_Liste_employee;

        /*init permet a notre appli de renitialiser au départ car 
        si il ya pas d'objet deja créer on ne pouvait pas en ajouter*/
        public void init()
        {
            if (m_Liste_employee == null)
            {
                m_Liste_employee = new ObservableCollection<Employee>();
            }
        }
        public void Add_Content(string _name, string _firstname, int _age)
        {

            m_Liste_employee.Add(new Employee(_name, _firstname, _age));
        }

        public void Remove_Content(Employee employee)
        {
            m_Liste_employee.Remove(employee);
        }

        public ObservableCollection<Employee> Liste_Employee
        {
            get { return m_Liste_employee; }
            set
            {
                m_Liste_employee = value;
            }

        }
    }
}
