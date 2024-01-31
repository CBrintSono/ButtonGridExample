using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfSandbox
{
    public class ButtonsViewModel
    {
        public ICommand ButtonCommand { get; }
        public ObservableCollection<ButtonData> ButtonCollection { get; set; }


        public ButtonsViewModel()
        {
            ButtonCommand = new RelayCommand(ButtonClick);
            ButtonCollection = new ObservableCollection<ButtonData>();
            LoadData();
        }

        private void LoadData()
        {
            // Initialize the ButtonCollection property with data
            ButtonCollection.Add(new ButtonData { X = 2, Y = 0, Text = "Button 7" });
            ButtonCollection.Add(new ButtonData { X = 0, Y = 0, Text = "Button 1" });
            ButtonCollection.Add(new ButtonData { X = 0, Y = 1, Text = "Button 2" });
            ButtonCollection.Add(new ButtonData { X = 0, Y = 2, Text = "Button 3" });
            ButtonCollection.Add(new ButtonData { X = 1, Y = 0, Text = "Button 4" });
            ButtonCollection.Add(new ButtonData { X = 1, Y = 1, Text = "Button 5" });
            ButtonCollection.Add(new ButtonData { X = 1, Y = 2, Text = "Button 6" });
            ButtonCollection.Add(new ButtonData { X = 2, Y = 1, Text = "Button 8" });
            ButtonCollection.Add(new ButtonData { X = 2, Y = 2, Text = "Button 9" });
            ButtonCollection.Add(new ButtonData { X = 3, Y = 0, Text = "Button 10" });
            ButtonCollection.Add(new ButtonData { X = 3, Y = 1, Text = "Button 11" });
            ButtonCollection.Add(new ButtonData { X = 3, Y = 2, Text = "Button 12" });

        }

        private void ButtonClick(object parameter)
        {
            var buttonData = parameter as ButtonData;
            // Handle the button click here
            if (buttonData != null) 
            {
                buttonData.Text = "Clicked!";
            }
        }
    }
}
