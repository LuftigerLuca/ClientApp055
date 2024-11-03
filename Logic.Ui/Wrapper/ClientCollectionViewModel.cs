using De.HsFlensburg.ClientApp055.Business.Model.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using De.HsFlensburg.ClientApp055.Logic.Ui.Base;

namespace De.HsFlensburg.ClientApp055.Logic.Ui.Wrapper
{
    public class ClientCollectionViewModel : ViewModelSyncCollection<ClientViewModel, Client, ClientCollection>
    {
        public override void NewModelAssigned()
        {
            foreach (var cvm in this)
            {
                var modelPropChanged = cvm.Model as INotifyPropertyChanged;
                if (modelPropChanged != null)
                {
                    modelPropChanged.PropertyChanged += cvm.OnPropertyChangedInModel;
                }
            }
        }
    }
}