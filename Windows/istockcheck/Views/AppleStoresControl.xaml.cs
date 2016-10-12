using System.Linq;

namespace com.andrewbennet.istockcheck.Views {
	/// <summary>
	/// Interaction logic for AppleStoresControl.xaml
	/// </summary>
	public partial class AppleStoresControl {
		
		public AppleStoresControl() {
			InitializeComponent();

			int numberOfStores = AppleStore.StoresById.Count;
			LeftCheckboxList.ItemsSource = AppleStore.StoresById.Take(numberOfStores/3);
			MiddleCheckboxList.ItemsSource = AppleStore.StoresById.Skip(numberOfStores/3).Take(numberOfStores/3);
			RightCheckboxList.ItemsSource = AppleStore.StoresById.Skip(2*numberOfStores/3);
		}
	}
}
