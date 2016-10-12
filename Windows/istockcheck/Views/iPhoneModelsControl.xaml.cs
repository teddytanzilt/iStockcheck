using System.Collections.Generic;

namespace com.andrewbennet.istockcheck.Views {
	/// <summary>
	/// Interaction logic for iPhoneModelsControl.xaml
	/// </summary>
	public partial class iPhoneModelsControl {
		
		public iPhoneModelsControl() {
			InitializeComponent();
			
			List<IphoneModel> iPhone7 = new List<IphoneModel>();
			List<IphoneModel> iPhone7Plus = new List<IphoneModel>();

			foreach(Colour colour in EnumExtensions.GetValues<Colour>()) {
				foreach(StorageSize size in EnumExtensions.GetValues<StorageSize>()) {
					if(colour != Colour.JetBlack || size != StorageSize.Small) {
						iPhone7.Add(new IphoneModel(PhoneSize.iPhone7, size, colour));
						iPhone7Plus.Add(new IphoneModel(PhoneSize.iPhone7Plus, size, colour));
					}
				}
			}

			LeftCheckboxList.ItemsSource = iPhone7;
			RightCheckboxList.ItemsSource = iPhone7Plus;
		}
	}
}
