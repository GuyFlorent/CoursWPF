using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirWpf
{
    public class Employee : INotifyPropertyChanged
    {

        /* public int Age {get; set; }
           public string Name { get; set; }

           public string FirstName { get; set; }*/
        private string _Name;
        private int _Age;
        private string _FirstName;
       public Employee(string name, string firstName, int age)
        {
            this._Age = age;
            this._Name = name;
            this._FirstName = firstName;
        }

       
          public int Age
          {
              get { return _Age; }
              set
              {
                  if (_Age != 0)
                      _Age = value;
                  onPropertyChanged(nameof(Age));
              }
          }


          
          public string Name
          {
              get { return _Name; }
              set
              {
                  if (_Name != null)
                      _Name = value;
                  onPropertyChanged(nameof(Name));
              }
          }

         

        
        public string FirstName
          {
              get { return _FirstName; }
              set
              {
                  if (_FirstName != null)
                      _FirstName = value;
                  onPropertyChanged(nameof(FirstName));
              }
          }
          public event PropertyChangedEventHandler PropertyChanged;

          private void onPropertyChanged(string v)
          {
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
          }
    }
}
