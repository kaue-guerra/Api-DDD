using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        
        [NotMapped]
        public string PropertyName { get; set; }
        public string Message { get; set; }
        public List<Notifies> Notifications { get; set; }

        public bool ValidatePropertyString(string valor, string propertyName)
        {
            if(string.IsNullOrWhiteSpace(propertyName) || string.IsNullOrWhiteSpace(valor))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName,
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int valor, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName) || valor < 1)
            {
                Notifications.Add(new Notifies
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName,
                });

                return false;
            }

            return true;
        }
    }
}
