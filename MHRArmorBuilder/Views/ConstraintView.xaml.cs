using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MHRArmorBuilder.Views
{
    /// <summary>
    /// Interaction logic for ConstraintView.xaml
    /// </summary>
    public partial class ConstraintView : UserControl
    {
        public ConstraintView()
        {
            InitializeComponent();
            ComboBox.Loaded += comboBox1_Loaded;
        }

        private void comboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            var textBox = ComboBox.Template.FindName("PART_EditableTextBox", ComboBox) as TextBox;
            textBox?.AddHandler(TextBox.PreviewMouseDownEvent, new MouseButtonEventHandler(ComboBoxPreviewMouseDown),
                true);

            ComboBox.Loaded -= comboBox1_Loaded;
        }

        private void ComboBoxPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ComboBox.IsDropDownOpen = true;
        }
        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(((TextBox)sender).Text + e.Text);
        }
        
        private bool IsTextAllowed(string eText) => int.TryParse(eText, out int intValue) && intValue is < 10 and >= 0;
    }
}