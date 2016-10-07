using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace com.andrewbennet.istockcheck.Views {
	/// <summary>
	/// Interaction logic for iPhoneModelsControl.xaml
	/// </summary>
	public partial class iPhoneModelsControl {
		private StackPanel mStackPanel = new StackPanel();

		public ObservableCollection<IphoneModel> AllModels { get; set; }

		public iPhoneModelsControl() {
			InitializeComponent();
			CheckboxList.ItemsSource = IphoneModel.GetAll();
		}
	}
}
