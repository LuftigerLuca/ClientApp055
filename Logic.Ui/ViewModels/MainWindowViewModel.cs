using System;
using System.Linq;
using System.Windows.Input;
using De.HsFlensburg.ClientApp055.Logic.Ui.MessageBusMessages;
using De.HsFlensburg.ClientApp055.Logic.Ui.Wrapper;
using De.HsFlensburg.ClientApp055.Services.SerializationService;

namespace De.HsFlensburg.ClientApp055.Logic.Ui.ViewModels
{
    public class MainWindowViewModel
    {
        private ModelFileHandler modelFileHandler;
        private string pathForSerialization;

        public ICommand RenameValueInModelCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand OpenNewClientWindowCommand { get; }

        private void OpenNewClientWindowMethod()
        {
            ServiceBus.Instance.Send(new OpenNewClientWindowMessage());
        }

        public ClientCollectionViewModel MyList { get; set; }

        public MainWindowViewModel(ClientCollectionViewModel viewModelCollection)
        {
            modelFileHandler = new ModelFileHandler();
            pathForSerialization =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\ClientCollectionSerialization\\MyClients.cc";
            RenameValueInModelCommand = new RelayCommand(RenameValueInModel);
            SaveCommand = new RelayCommand(SaveModel);
            LoadCommand = new RelayCommand(LoadModel);
            OpenNewClientWindowCommand = new RelayCommand(OpenNewClientWindowMethod);
            MyList = viewModelCollection;
        }

        private void RenameValueInModel()
        {
            var first = MyList.FirstOrDefault();
            first.Model.Name = "Rename in the model";
        }

        private void SaveModel()
        {
            modelFileHandler.WriteModelToFile(pathForSerialization, MyList.Model);
        }

        private void LoadModel()
        {
            MyList.Model = modelFileHandler.ReadModelFromFile(pathForSerialization);
        }
    }
}