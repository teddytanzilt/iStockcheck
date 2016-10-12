using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using com.andrewbennet.istockcheck.Properties;

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

		private IEnumerable<CheckBox> _checkboxes {
			get {
				foreach(CheckBox item in LeftCheckboxList.Items) {
					yield return item;
				}
				foreach(CheckBox item in MiddleCheckboxList.Items) {
					yield return item;
				}
				foreach(CheckBox item in RightCheckboxList.Items) {
					yield return item;
				}
			}
		}

		void LoadCheckedStates() {
			foreach(CheckBox checkbox in _checkboxes) {
				checkbox.IsChecked = Settings.Default[checkbox.Uid] as bool? ?? false;
			}
		}

		void CheckedChanged(object sender, RoutedEventArgs routedEventArgs) {
			foreach (CheckBox checkbox in _checkboxes) {
				Settings.Default[checkbox.Uid] = checkbox.IsChecked ?? false;
			}
			Settings.Default.Save();
		}
	}
}
