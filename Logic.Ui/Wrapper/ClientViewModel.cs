using De.HsFlensburg.ClientApp055.Business.Model.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp055.Logic.Ui.Wrapper
{
    public class ClientViewModel
    {
        private Client myClient = new Client();

        public ClientViewModel(Client client)
        {
            this.myClient = client;
        }

        ClientViewModel()
        {
        }

        public int Id
        {
            get
            {
                return myClient.Id;
            }
            set
            {
                myClient.Id = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return myClient.Name;
            }
            set
            {
                myClient.Name = value;
            }
        }
    }
}
