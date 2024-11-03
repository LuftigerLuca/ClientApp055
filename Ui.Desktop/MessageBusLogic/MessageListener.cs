using De.HsFlensburg.ClientApp055.Logic.Ui.MessageBusMessages;

namespace De.HsFlensburg.ClientApp055.Ui.Desktop.MessageBusLogic
{
    class MessageListener
    {
        public bool BindableProperty => true;

        public MessageListener()
        {
            InitMessenger();
        }

        private void InitMessenger()
        {
            ServiceBus.Instance.Register<OpenNewClientWindowMessage>
            (this, OpenNewClientWindow
            );
        }

        private void OpenNewClientWindow()
        {
            NewClientWindow myWindow = new NewClientWindow();
            myWindow.ShowDialog();
        }
    }
}