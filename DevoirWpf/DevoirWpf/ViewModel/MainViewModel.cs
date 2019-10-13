using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void PopulateEmployee()
        {
            //méthode pour lire un fichier xml aves C#
            var doc = new XmlDocument();
            doc.Load("../../Resources/employee.xml");
            var xmlNodeList = doc.DocumentElement?.SelectNodes("/employees/employee");
            if (xmlNodeList == null) return;

            foreach(XmlNode employee in xmlNodeList)
            {
                Add_Content(employee.Attributes["name"].Value, employee.Attributes["firstname"].Value, Int32.Parse(employee.Attributes["age"].Value));
            }
        }
    }
}
