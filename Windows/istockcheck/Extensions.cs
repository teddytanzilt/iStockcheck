using System;
using System.Collections.Generic;
using System.Linq;

namespace com.andrewbennet.istockcheck {
	public static class EnumExtensions {
		public static IEnumerable<TEnum> GetValues<TEnum>() {
			return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
		}
	}
}
