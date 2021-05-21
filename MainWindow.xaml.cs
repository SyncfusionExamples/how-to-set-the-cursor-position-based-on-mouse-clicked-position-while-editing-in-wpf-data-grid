using Syncfusion.UI.Xaml.Grid.Cells;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //customize the TextBoxCellRenderer 
            this.sfDataGrid.CellRenderers.Remove("TextBox");
            this.sfDataGrid.CellRenderers.Add("TextBox", new GridCellTextBoxRendererExt());
        }      
    }

    public class GridCellTextBoxRendererExt : GridCellTextBoxRenderer
    {  
        protected override void OnEditElementLoaded(object sender, RoutedEventArgs e)
        {
            base.OnEditElementLoaded(sender, e);
            var uiElement = sender as TextBox;
            //set the CaretIndex based on clicked text position
            uiElement.CaretIndex = uiElement.GetCharacterIndexFromPoint(Mouse.GetPosition(uiElement), true);
        }
    }
}
         
   

