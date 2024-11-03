using System.ComponentModel;

namespace De.HsFlensburg.ClientApp055.Logic.Ui.Base
{
    public interface IViewModel<TypeOfModel> : INotifyPropertyChanged
    {
        TypeOfModel Model { get; set; }

        void NewModelAssigned();
    }
}